using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;

namespace Sistema_Gestion_de_Citas_Medicas.CapaDatos
{
    public class CitaDAL
    {
        // 1. Validar horarios para evitar duplicidad tanto para el médico como para el paciente
        public bool ExisteChoqueHorario(int idMedico, int idPaciente, DateTime fechaHora)
        {
			// Usar "using" para asegurar que la conexión se cierre automáticamente
			using (SqlConnection con = Conexion.ObtenerConexion())
            {
                // Validamos si el médico ya está ocupado O si el paciente ya tiene otra cita a esa misma hora
                string query = @"SELECT COUNT(*) FROM Cita 
                         WHERE (ID_Medico = @ID_Medico OR ID_Paciente = @ID_Paciente)
                           AND FechaHora = @FechaHora 
                           AND Estado <> 'Cancelada'";
				// El estado 'Cancelada' no se considera para el choque de horarios
				using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Medico", idMedico);
                    cmd.Parameters.AddWithValue("@ID_Paciente", idPaciente);
                    cmd.Parameters.AddWithValue("@FechaHora", fechaHora);
					// Abrimos la conexión y ejecutamos la consulta
					con.Open();
                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                    return cantidad > 0;
                }
            }
        }

        // 2. Agendar nueva Cita
        public bool AgendarCita(Cita cita)
        {
            // Validar que la fecha y hora de la cita no sean menores al momento actual (evita fechas pasadas)
            if (cita.FechaHora < DateTime.Now)
            {
                throw new Exception("No puedes agendar citas con fecha u hora pasada. Selecciona una fecha y hora vigente.");
            }

            // Validar el cruce de horarios (médico ocupado o paciente con otra cita a la misma hora)
            if (ExisteChoqueHorario(cita.IdMedico, cita.IdPaciente, cita.FechaHora))
            {
                throw new Exception("No puedes agendar esta cita: Ya tienes otra cita programada a esta misma hora (o el médico ya está ocupado).");
            }
			// Insertar la cita en la base de datos
			using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Cita (FechaHora, Estado, ID_Paciente, ID_Medico) 
                         VALUES (@FechaHora, 'Pendiente', @ID_Paciente, @ID_Medico);";
				// El estado inicial de la cita será 'Pendiente'
				using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FechaHora", cita.FechaHora);
                    cmd.Parameters.AddWithValue("@ID_Paciente", cita.IdPaciente);
                    cmd.Parameters.AddWithValue("@ID_Medico", cita.IdMedico);
					// Abrimos la conexión y ejecutamos la inserción
					try
					{
                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception($"Error de base de datos al agendar cita: {ex.Message}");
                    }
                }
            }
        }

        // 3. Listar Citas con nombres completos de Paciente y Médico
        public List<Cita> ListarCitas(int? idPaciente = null, int? idMedico = null)
        {
            List<Cita> lista = new List<Cita>();
			// Consulta SQL con JOIN para obtener nombres completos y especialidad
			using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = @"SELECT c.ID_Cita, c.FechaHora, c.Estado, c.ID_Paciente, c.ID_Medico,
                                        p.Nombre + ' ' + p.Apellido AS PacienteNombre,
                                        m.Nombre + ' ' + m.Apellido AS MedicoNombre,
                                        e.NombreEspecialidad
                                 FROM Cita c
                                 INNER JOIN Paciente p ON c.ID_Paciente = p.ID_Paciente
                                 INNER JOIN Medico m ON c.ID_Medico = m.ID_Medico
                                 INNER JOIN Especialidad e ON m.ID_Especialidad = e.ID_Especialidad
                                 WHERE (@ID_Paciente IS NULL OR c.ID_Paciente = @ID_Paciente)
                                   AND (@ID_Medico IS NULL OR c.ID_Medico = @ID_Medico)
                                 ORDER BY c.FechaHora DESC";
				// Si se pasan parámetros nulos, se listarán todas las citas; de lo contrario, se filtrará por paciente o médico.
				using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Paciente", (object)idPaciente ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Medico", (object)idMedico ?? DBNull.Value);
					// Abrimos la conexión y ejecutamos la consulta
					try
					{
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cita c = new Cita
                                {
                                    IdCita = Convert.ToInt32(reader["ID_Cita"]),
                                    FechaHora = Convert.ToDateTime(reader["FechaHora"]),
                                    Estado = reader["Estado"].ToString(),
                                    IdPaciente = Convert.ToInt32(reader["ID_Paciente"]),
                                    IdMedico = Convert.ToInt32(reader["ID_Medico"]),
                                    NombrePaciente = reader["PacienteNombre"].ToString(),
                                    NombreMedico = reader["MedicoNombre"].ToString(),
                                    NombreEspecialidad = reader["NombreEspecialidad"].ToString()
                                };
                                lista.Add(c);
                            }
                        }
                    }
					// Manejo de excepciones para capturar errores de SQL y lanzar una excepción más descriptiva
					catch (SqlException ex)
                    {
                        throw new Exception($"Error al consultar citas: {ex.Message}");
                    }
                }
            }
			// Retornamos la lista de citas obtenida de la base de datos
			return lista;
        }

        // 4. Cambiar estado de Cita (Atendida / Cancelada)
        public bool CambiarEstadoCita(int idCita, string nuevoEstado)
        {
			using (SqlConnection con = Conexion.ObtenerConexion())
            {
				// Validar que el nuevo estado sea uno de los permitidos
				string query = "UPDATE Cita SET Estado = @Estado WHERE ID_Cita = @ID_Cita";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@ID_Cita", idCita);
					// Abrimos la conexión y ejecutamos la actualización
					con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // 5. Métodos para obtener las estadísticas reales del Dashboard / Resumen
        public int ObtenerConteoPacientes()
        {
			using (SqlConnection con = Conexion.ObtenerConexion())
            {
				// Consulta SQL para contar todos los pacientes en la base de datos
				string query = "SELECT COUNT(*) FROM Paciente";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

		// 6. Obtener conteo total de citas
		public int ObtenerConteoCitasTotales()
        {
			using (SqlConnection con = Conexion.ObtenerConexion())
            {
				// Consulta SQL para contar todas las citas en la base de datos
				string query = "SELECT COUNT(*) FROM Cita";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

		// 7. Obtener conteo total de médicos
		public int ObtenerConteoMedicos()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
				// Consulta SQL para contar todos los médicos en la base de datos
				string query = "SELECT COUNT(*) FROM Medico";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

		// 8. Obtener conteo total de recetas
		public int ObtenerConteoRecetas()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Receta";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}
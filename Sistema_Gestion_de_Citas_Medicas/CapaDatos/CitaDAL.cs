using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;

namespace Sistema_Gestion_de_Citas_Medicas.CapaDatos
{
    public class CitaDAL
    {
        // 1. Validar horarios para evitar duplicidad de citas
        public bool ExisteChoqueHorario(int idMedico, DateTime fechaHora)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = @"SELECT COUNT(*) FROM Cita 
                                 WHERE ID_Medico = @ID_Medico 
                                   AND FechaHora = @FechaHora 
                                   AND Estado <> 'Cancelada'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Medico", idMedico);
                    cmd.Parameters.AddWithValue("@FechaHora", fechaHora);

                    con.Open();
                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                    return cantidad > 0;
                }
            }
        }

        // 2. Agendar nueva Cita
        public bool AgendarCita(Cita cita)
        {
            if (ExisteChoqueHorario(cita.IdMedico, cita.FechaHora))
            {
                throw new Exception("El médico seleccionado ya tiene una cita agendada en la misma fecha y hora.");
            }

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Cita (FechaHora, Estado, ID_Paciente, ID_Medico) 
                                 VALUES (@FechaHora, 'Pendiente', @ID_Paciente, @ID_Medico);";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FechaHora", cita.FechaHora);
                    cmd.Parameters.AddWithValue("@ID_Paciente", cita.IdPaciente);
                    cmd.Parameters.AddWithValue("@ID_Medico", cita.IdMedico);

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

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Paciente", (object)idPaciente ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Medico", (object)idMedico ?? DBNull.Value);

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
                    catch (SqlException ex)
                    {
                        throw new Exception($"Error al consultar citas: {ex.Message}");
                    }
                }
            }
            return lista;
        }

        // 4. Cambiar estado de Cita (Atendida / Cancelada)
        public bool CambiarEstadoCita(int idCita, string nuevoEstado)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Cita SET Estado = @Estado WHERE ID_Cita = @ID_Cita";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@ID_Cita", idCita);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
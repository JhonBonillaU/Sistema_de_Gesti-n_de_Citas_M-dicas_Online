using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;

namespace Sistema_Gestion_de_Citas_Medicas.CapaDatos
{
	public class RecetaDAL
	{
		// 1. Listar citas trayendo la receta si ya existe
		public List<Cita> ListarCitasPendientesParaReceta()
		{
			List<Cita> lista = new List<Cita>();
			// Usamos la conexión a la base de datos para obtener las citas pendientes
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				// Consulta SQL para obtener las citas pendientes junto con la información del paciente, médico, especialidad y receta (si existe)
				string query = @"SELECT c.ID_Cita, c.FechaHora, c.Estado, c.ID_Paciente, c.ID_Medico,
                                        p.Nombre + ' ' + p.Apellido AS PacienteNombre,
                                        m.Nombre + ' ' + m.Apellido AS MedicoNombre,
                                        e.NombreEspecialidad,
                                        r.Descripcion AS DescripcionReceta
                                 FROM Cita c
                                 INNER JOIN Paciente p ON c.ID_Paciente = p.ID_Paciente
                                 INNER JOIN Medico m ON c.ID_Medico = m.ID_Medico
                                 INNER JOIN Especialidad e ON m.ID_Especialidad = e.ID_Especialidad
                                 LEFT JOIN Receta r ON c.ID_Cita = r.ID_Cita
                                 WHERE c.Estado <> 'Cancelada'
                                 ORDER BY c.FechaHora DESC";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					// Abrimos la conexión y ejecutamos la consulta
					con.Open();
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						// Leer cada registro y crear objetos Cita con la información obtenida
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
								NombreEspecialidad = reader["NombreEspecialidad"].ToString(),
								DescripcionReceta = reader["DescripcionReceta"] != DBNull.Value ? reader["DescripcionReceta"].ToString() : string.Empty
							};
							lista.Add(c);
						}
					}
				}
			}
			// Retornamos la lista de citas obtenida de la base de datos, incluyendo la descripción de la receta si ya existe
			return lista;
		}

		// 2. Guardar o Modificar Receta (Inserta si no existe, Actualiza si ya existe)
		public bool EmitirReceta(Receta receta)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				// Abrimos la conexión y comenzamos una transacción para asegurar que todas las operaciones se realicen correctamente
				con.Open();
				SqlTransaction tx = con.BeginTransaction();
				// Intentamos ejecutar la inserción o actualización de la receta dentro de la transacción
				try
				{
					// Verificar si ya existe una receta para esta cita
					string queryCheck = "SELECT COUNT(*) FROM Receta WHERE ID_Cita = @ID_Cita";
					int existe = 0;
					using (SqlCommand cmdCheck = new SqlCommand(queryCheck, con, tx))
					{
						cmdCheck.Parameters.AddWithValue("@ID_Cita", receta.IdCita);
						existe = Convert.ToInt32(cmdCheck.ExecuteScalar());
					}

					if (existe > 0)
					{
						// Si ya existe, ACTUALIZAMOS la receta existente (Modificar)
						string queryUpdate = "UPDATE Receta SET Descripcion = @Descripcion WHERE ID_Cita = @ID_Cita;";
						using (SqlCommand cmdU = new SqlCommand(queryUpdate, con, tx))
						{
							cmdU.Parameters.AddWithValue("@Descripcion", receta.Descripcion);
							cmdU.Parameters.AddWithValue("@ID_Cita", receta.IdCita);
							cmdU.ExecuteNonQuery();
						}
					}
					else
					{
						// Si no existe, INSERTAMOS la nueva receta
						string queryInsert = "INSERT INTO Receta (Descripcion, ID_Cita) VALUES (@Descripcion, @ID_Cita);";
						using (SqlCommand cmdR = new SqlCommand(queryInsert, con, tx))
						{
							cmdR.Parameters.AddWithValue("@Descripcion", receta.Descripcion);
							cmdR.Parameters.AddWithValue("@ID_Cita", receta.IdCita);
							cmdR.ExecuteNonQuery();
						}
					}

					// Asegurar que la cita quede marcada como "Atendida"
					string queryCita = "UPDATE Cita SET Estado = 'Atendida' WHERE ID_Cita = @ID_Cita;";
					using (SqlCommand cmdC = new SqlCommand(queryCita, con, tx))
					{
						cmdC.Parameters.AddWithValue("@ID_Cita", receta.IdCita);
						cmdC.ExecuteNonQuery();
					}
					// Si todo se ejecutó correctamente, confirmamos la transacción
					tx.Commit();
					return true;
				}
				// Manejo de excepciones para capturar errores de SQL y revertir la transacción en caso de fallo
				catch (SqlException ex)
				{
					tx.Rollback();
					throw new Exception($"Error SQL al procesar la receta: {ex.Message}");
				}
			}
		}

		// 3. Obtener la receta específica asociada a una cita
		public Receta ObtenerRecetaPorCita(int idCita)
		{
			// Inicializamos la variable de receta como nula, ya que puede que no exista una receta para la cita dada
			Receta r = null;
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				string query = "SELECT ID_Receta, Descripcion, ID_Cita FROM Receta WHERE ID_Cita = @ID_Cita";
				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					// Agregamos el parámetro de la cita para la consulta
					cmd.Parameters.AddWithValue("@ID_Cita", idCita);
					con.Open();
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						// Si se encuentra una receta para la cita, creamos un objeto Receta con los datos obtenidos
						if (reader.Read())
						{
							r = new Receta
							{
								IdReceta = Convert.ToInt32(reader["ID_Receta"]),
								Descripcion = reader["Descripcion"].ToString(),
								IdCita = Convert.ToInt32(reader["ID_Cita"])
							};
						}
					}
				}
			}
			// Retornamos la receta obtenida de la base de datos, o null si no existe
			return r;
		}
	}
}
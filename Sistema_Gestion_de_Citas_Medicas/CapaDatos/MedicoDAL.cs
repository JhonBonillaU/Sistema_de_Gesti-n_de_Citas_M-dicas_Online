using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;

namespace Sistema_Gestion_de_Citas_Medicas.CapaDatos
{
    public class MedicoDAL
    {
        public List<Medico> ListarMedicos()
        {
            List<Medico> lista = new List<Medico>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = @"SELECT m.ID_Medico, m.Nombre, m.Apellido, m.Telefono, m.Correo, 
                                        m.ID_Especialidad, e.NombreEspecialidad 
                                 FROM Medico m
                                 INNER JOIN Especialidad e ON m.ID_Especialidad = e.ID_Especialidad";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Medico m = new Medico
                        {
                            IdMedico = Convert.ToInt32(reader["ID_Medico"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            Correo = reader["Correo"].ToString(),
                            IdEspecialidad = Convert.ToInt32(reader["ID_Especialidad"]),
                            NombreEspecialidad = reader["NombreEspecialidad"].ToString()
                        };
                        lista.Add(m);
                    }
                }
            }
            return lista;
        }

		// Registrar Médico con Transacción SQL
		public bool RegistrarMedico(Medico medico, string username, string password)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				con.Open();
				SqlTransaction tx = con.BeginTransaction();

				try
				{
					string queryMedico = @"INSERT INTO Medico (Nombre, Apellido, Telefono, Correo, ID_Especialidad) 
                                   VALUES (@Nombre, @Apellido, @Telefono, @Correo, @ID_Especialidad);
                                   SELECT SCOPE_IDENTITY();";

					int idMedicoGenerado = 0;
					using (SqlCommand cmdM = new SqlCommand(queryMedico, con, tx))
					{
						cmdM.Parameters.AddWithValue("@Nombre", medico.Nombre);
						cmdM.Parameters.AddWithValue("@Apellido", medico.Apellido);
						cmdM.Parameters.AddWithValue("@Telefono", medico.Telefono);
						cmdM.Parameters.AddWithValue("@Correo", medico.Correo);
						cmdM.Parameters.AddWithValue("@ID_Especialidad", medico.IdEspecialidad);

						idMedicoGenerado = Convert.ToInt32(cmdM.ExecuteScalar());
					}

					string queryUsuario = @"INSERT INTO Usuario (Username, Password, Rol, ID_Paciente, ID_Medico) 
                                   VALUES (@Username, @Password, 'Medico', NULL, @ID_Medico);";

					using (SqlCommand cmdU = new SqlCommand(queryUsuario, con, tx))
					{
						cmdU.Parameters.AddWithValue("@Username", username);
						cmdU.Parameters.AddWithValue("@Password", password);
						cmdU.Parameters.AddWithValue("@ID_Medico", idMedicoGenerado);

						cmdU.ExecuteNonQuery();
					}

					tx.Commit();
					return true;
				}
				catch (SqlException ex)
				{
					tx.Rollback();
					throw new Exception($"Error en SQL Server al registrar el médico: {ex.Message}");
				}
			}
		}

		// Actualizar Médico
		public bool ActualizarMedico(Medico medico)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				string query = @"UPDATE Medico 
                         SET Nombre = @Nombre, 
                             Apellido = @Apellido, 
                             Telefono = @Telefono, 
                             Correo = @Correo, 
                             ID_Especialidad = @ID_Especialidad 
                         WHERE ID_Medico = @ID_Medico";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@Nombre", medico.Nombre);
					cmd.Parameters.AddWithValue("@Apellido", medico.Apellido);
					cmd.Parameters.AddWithValue("@Telefono", medico.Telefono);
					cmd.Parameters.AddWithValue("@Correo", medico.Correo);
					cmd.Parameters.AddWithValue("@ID_Especialidad", medico.IdEspecialidad);
					cmd.Parameters.AddWithValue("@ID_Medico", medico.IdMedico);

					con.Open();
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

		// Eliminar Médico y su Usuario asociado
		public bool EliminarMedico(int idMedico)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				con.Open();
				SqlTransaction tx = con.BeginTransaction();

				try
				{
					string queryUsuario = "DELETE FROM Usuario WHERE ID_Medico = @ID_Medico";
					using (SqlCommand cmdU = new SqlCommand(queryUsuario, con, tx))
					{
						cmdU.Parameters.AddWithValue("@ID_Medico", idMedico);
						cmdU.ExecuteNonQuery();
					}

					string queryMedico = "DELETE FROM Medico WHERE ID_Medico = @ID_Medico";
					using (SqlCommand cmdM = new SqlCommand(queryMedico, con, tx))
					{
						cmdM.Parameters.AddWithValue("@ID_Medico", idMedico);
						cmdM.ExecuteNonQuery();
					}

					tx.Commit();
					return true;
				}
				catch (SqlException ex)
				{
					tx.Rollback();
					throw new Exception($"Error al eliminar el médico: {ex.Message}");
				}
			}
		}
	}
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;

namespace Sistema_Gestion_de_Citas_Medicas.CapaDatos
{
    public class PacienteDAL
    {
        // 1. Registramos Paciente usando Transacción SQL y Manejo de Excepciones
        public bool RegistrarPaciente(Paciente paciente, string username, string password)
        {
            // Bloque using para liberar conexiones automáticamente con IDisposable
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
				// Abrimos la conexión y comenzamos una transacción para asegurar que ambas inserciones (Paciente y Usuario) se realicen correctamente
				con.Open();
                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    // Insertar Paciente usando @ para evitar inyección SQL
                    string queryPaciente = @"INSERT INTO Paciente (Nombre, Apellido, FechaNacimiento, Telefono, Correo) 
                                            VALUES (@Nombre, @Apellido, @FechaNacimiento, @Telefono, @Correo);
                                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmdP = new SqlCommand(queryPaciente, con, tx))
                    {
                        cmdP.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                        cmdP.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                        cmdP.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);
                        cmdP.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                        cmdP.Parameters.AddWithValue("@Correo", paciente.Correo);

                        int idPacienteGenerado = Convert.ToInt32(cmdP.ExecuteScalar());

                        // Insertar Usuario
                        string queryUsuario = @"INSERT INTO Usuario (Username, Password, Rol, ID_Paciente, ID_Medico) 
                                               VALUES (@Username, @Password, 'Paciente', @ID_Paciente, NULL);";

                        using (SqlCommand cmdU = new SqlCommand(queryUsuario, con, tx))
                        {
                            cmdU.Parameters.AddWithValue("@Username", username);
                            cmdU.Parameters.AddWithValue("@Password", password);
                            cmdU.Parameters.AddWithValue("@ID_Paciente", idPacienteGenerado);

                            cmdU.ExecuteNonQuery();
                        }
                    }

                    tx.Commit(); // Confirmar transacción si todo sale bien
                    return true;
                }
                catch (SqlException ex)
                {
                    tx.Rollback(); // Deshacer cambios en la BD ante error de SQL con Rollback
                    // Manejo de excepción
                    throw new Exception($"Error en SQL Server al registrar el paciente: {ex.Message}");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    // Red de seguridad para excepciones generales
                    throw new Exception($"Error inesperado en la capa de datos: {ex.Message}");
                }
            }
        }

        // 2. Listar Pacientes usando SqlDataReader 
        public List<Paciente> ListarPacientes()
        {
            List<Paciente> lista = new List<Paciente>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
				// Consulta SQL para obtener todos los pacientes
				string query = "SELECT ID_Paciente, Nombre, Apellido, FechaNacimiento, Telefono, Correo FROM Paciente";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
					// Intentamos abrir la conexión y ejecutar la consulta
					try
					{
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
							// Leer cada registro y crear objetos Paciente
							while (reader.Read())
                            {
                                Paciente p = new Paciente
                                {
                                    IdPaciente = Convert.ToInt32(reader["ID_Paciente"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                    Telefono = reader["Telefono"].ToString(),
                                    Correo = reader["Correo"].ToString()
                                };
                                lista.Add(p);
                            }
                        }
                    }
                    // Manejo de excepciones para capturar errores de SQL y lanzar una excepción más descriptiva
                    catch (SqlException ex)
                    {
                        throw new Exception($"Error al consultar la tabla Paciente: {ex.Message}");
                    }
                }
            }
            return lista;
        }

		// 3. Actualizar información del Paciente
		public bool ActualizarPaciente(Paciente paciente)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				// Consulta SQL para actualizar la información del paciente
				string query = @"UPDATE Paciente 
                         SET Nombre = @Nombre, 
                             Apellido = @Apellido, 
                             FechaNacimiento = @FechaNacimiento, 
                             Telefono = @Telefono, 
                             Correo = @Correo 
                         WHERE ID_Paciente = @ID_Paciente";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					// Abrimos la conexión y ejecutamos la actualización
					cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
					cmd.Parameters.AddWithValue("@Apellido", paciente.Apellido);
					cmd.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);
					cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
					cmd.Parameters.AddWithValue("@Correo", paciente.Correo);
					cmd.Parameters.AddWithValue("@ID_Paciente", paciente.IdPaciente);

					con.Open();
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

		// 4. Eliminar Paciente y su cuenta de Usuario asociada
		public bool EliminarPaciente(int idPaciente)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				// Abrimos la conexión y comenzamos una transacción para asegurar que ambas eliminaciones (Paciente y Usuario) se realicen correctamente
				con.Open();
				SqlTransaction tx = con.BeginTransaction();

				try
				{
					// 1. Primero eliminamos el registro dependiente en Usuario por la llave foránea
					string queryUsuario = "DELETE FROM Usuario WHERE ID_Paciente = @ID_Paciente";
					using (SqlCommand cmdU = new SqlCommand(queryUsuario, con, tx))
					{
						cmdU.Parameters.AddWithValue("@ID_Paciente", idPaciente);
						cmdU.ExecuteNonQuery();
					}

					// 2. Luego eliminamos el registro en la tabla Paciente
					string queryPaciente = "DELETE FROM Paciente WHERE ID_Paciente = @ID_Paciente";
					using (SqlCommand cmdP = new SqlCommand(queryPaciente, con, tx))
					{
						cmdP.Parameters.AddWithValue("@ID_Paciente", idPaciente);
						cmdP.ExecuteNonQuery();
					}

					tx.Commit();
					return true;
				}
                // Manejo de excepciones para capturar errores de SQL y revertir la transacción en caso de fallo
				catch (SqlException ex)
				{
					tx.Rollback();
					throw new Exception($"Error al eliminar el paciente: {ex.Message}");
				}
			}
		}
	}
}
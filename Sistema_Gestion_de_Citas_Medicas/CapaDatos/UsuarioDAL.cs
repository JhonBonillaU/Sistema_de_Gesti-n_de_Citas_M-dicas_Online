using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;

namespace Sistema_Gestion_de_Citas_Medicas.CapaDatos
{
    public class UsuarioDAL
    {
		// 1. Método Login existente
		public Usuario ValidarLogin(string username, string password)
		{
			Usuario usuario = null;

			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				string query = @"SELECT ID_Usuario, Username, Password, Rol, ID_Paciente, ID_Medico 
                                 FROM Usuario 
                                 WHERE Username = @Username AND Password = @Password";

				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@Username", username);
				cmd.Parameters.AddWithValue("@Password", password);

				con.Open();

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						string rol = reader["Rol"].ToString();

						if (rol == "Paciente")
						{
							Paciente p = new Paciente
							{
								IdUsuario = Convert.ToInt32(reader["ID_Usuario"]),
								Username = reader["Username"].ToString(),
								Rol = rol,
								ID_Paciente = reader["ID_Paciente"] != DBNull.Value ? Convert.ToInt32(reader["ID_Paciente"]) : 0
							};
							usuario = p;
						}
						else if (rol == "Medico")
						{
							Medico m = new Medico
							{
								IdUsuario = Convert.ToInt32(reader["ID_Usuario"]),
								Username = reader["Username"].ToString(),
								Rol = rol,
								ID_Medico = reader["ID_Medico"] != DBNull.Value ? Convert.ToInt32(reader["ID_Medico"]) : 0
							};
							usuario = m;
						}
						else // Administrador u otros roles
						{
							usuario = new Usuario
							{
								IdUsuario = Convert.ToInt32(reader["ID_Usuario"]),
								Username = reader["Username"].ToString(),
								Rol = rol
							};
						}
					}
				}
			}
			return usuario;
		}

		// 2. Listar Usuarios para el DataGridView
		public List<Usuario> ListarUsuarios()
		{
			List<Usuario> lista = new List<Usuario>();

			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				string query = "SELECT ID_Usuario, Username, Password, Rol FROM Usuario";
				SqlCommand cmd = new SqlCommand(query, con);
				con.Open();

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						Usuario u = new Usuario
						{
							IdUsuario = Convert.ToInt32(reader["ID_Usuario"]),
							Username = reader["Username"].ToString(),
							Password = reader["Password"].ToString(),
							Rol = reader["Rol"].ToString()
						};
						lista.Add(u);
					}
				}
			}
			return lista;
		}

		// 3. Registrar Usuario (ideal para administradores puros o cuentas independientes)
		public bool RegistrarUsuario(Usuario usuario)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				string query = @"INSERT INTO Usuario (Username, Password, Rol, ID_Paciente, ID_Medico) 
                                 VALUES (@Username, @Password, @Rol, NULL, NULL)";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@Username", usuario.Username);
					cmd.Parameters.AddWithValue("@Password", usuario.Password);
					cmd.Parameters.AddWithValue("@Rol", usuario.Rol);

					con.Open();
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

		// 4. Actualizar Usuario
		public bool ActualizarUsuario(Usuario usuario)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				string query = @"UPDATE Usuario 
                                 SET Username = @Username, 
                                     Password = @Password, 
                                     Rol = @Rol 
                                 WHERE ID_Usuario = @ID_Usuario";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@Username", usuario.Username);
					cmd.Parameters.AddWithValue("@Password", usuario.Password);
					cmd.Parameters.AddWithValue("@Rol", usuario.Rol);
					cmd.Parameters.AddWithValue("@ID_Usuario", usuario.IdUsuario);

					con.Open();
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

		// 5. Eliminar Usuario
		public bool EliminarUsuario(int idUsuario)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				string query = "DELETE FROM Usuario WHERE ID_Usuario = @ID_Usuario";
				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);
					con.Open();
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}


	}
}
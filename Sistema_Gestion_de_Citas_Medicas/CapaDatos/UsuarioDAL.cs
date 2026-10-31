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
			// Inicializamos la variable de usuario como nula, ya que puede que no exista un usuario con las credenciales dadas
			Usuario usuario = null;
			
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				// Consulta SQL para validar el login y obtener los datos del usuario
				string query = @"SELECT ID_Usuario, Username, Password, Rol, ID_Paciente, ID_Medico 
                                 FROM Usuario 
                                 WHERE Username = @Username AND Password = @Password";
				// Usamos parámetros para evitar inyección SQL
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@Username", username);
				cmd.Parameters.AddWithValue("@Password", password);

				con.Open();

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					// Si se encuentra un usuario con las credenciales dadas, creamos el objeto Usuario correspondiente según su rol
					if (reader.Read())
					{
						string rol = reader["Rol"].ToString();
						// Dependiendo del rol, creamos un objeto Paciente, Medico o Usuario genérico
						if (rol == "Paciente") // Si el rol es "Paciente", creamos un objeto Paciente con los datos obtenidos
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
						// Si el rol es "Medico", creamos un objeto Medico con los datos obtenidos
						else if (rol == "Medico") // Si el rol es "Medico", creamos un objeto Medico con los datos obtenidos
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
						// Si el rol es otro (por ejemplo, "Administrador"), creamos un objeto Usuario genérico
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
				// Consulta SQL para obtener todos los usuarios
				string query = "SELECT ID_Usuario, Username, Password, Rol FROM Usuario";
				SqlCommand cmd = new SqlCommand(query, con);
				con.Open();

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					// Leemos cada registro y creamos objetos Usuario con los datos obtenidos
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
			// Retornamos la lista de usuarios obtenida de la base de datos
			return lista;
		}

		// 3. Registrar Usuario (ideal para administradores puros o cuentas independientes)
		public bool RegistrarUsuario(Usuario usuario)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				// Consulta SQL para insertar un nuevo usuario en la base de datos
				string query = @"INSERT INTO Usuario (Username, Password, Rol, ID_Paciente, ID_Medico) 
                                 VALUES (@Username, @Password, @Rol, NULL, NULL)";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					// Usamos parámetros para evitar inyección SQL y asignamos los valores del objeto Usuario
					cmd.Parameters.AddWithValue("@Username", usuario.Username);
					cmd.Parameters.AddWithValue("@Password", usuario.Password);
					cmd.Parameters.AddWithValue("@Rol", usuario.Rol);

					con.Open();
					return cmd.ExecuteNonQuery() > 0; // Retornamos true si la inserción fue exitosa, false en caso contrario
				}
			}
		}

		// 4. Actualizar Usuario
		public bool ActualizarUsuario(Usuario usuario)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				// Consulta SQL para actualizar los datos de un usuario existente en la base de datos
				string query = @"UPDATE Usuario 
                                 SET Username = @Username, 
                                     Password = @Password, 
                                     Rol = @Rol 
                                 WHERE ID_Usuario = @ID_Usuario";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					// Usamos parámetros para evitar inyección SQL y asignamos los valores del objeto Usuario
					cmd.Parameters.AddWithValue("@Username", usuario.Username);
					cmd.Parameters.AddWithValue("@Password", usuario.Password);
					cmd.Parameters.AddWithValue("@Rol", usuario.Rol);
					cmd.Parameters.AddWithValue("@ID_Usuario", usuario.IdUsuario);

					con.Open();
					return cmd.ExecuteNonQuery() > 0; // Retornamos true si la actualización fue exitosa, false en caso contrario
				}
			}
		}

		// 5. Eliminar Usuario
		public bool EliminarUsuario(int idUsuario)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				// Consulta SQL para eliminar un usuario de la base de datos por su ID
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
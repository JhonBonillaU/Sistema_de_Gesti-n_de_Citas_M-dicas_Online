using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;

namespace Sistema_Gestion_de_Citas_Medicas.CapaDatos
{
	public class EspecialidadDAL
	{
		// 1. Listar Especialidades
		public List<Especialidad> ListarEspecialidades()
		{
			List<Especialidad> lista = new List<Especialidad>();

			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				// Consulta SQL para obtener todas las especialidades
				string query = "SELECT ID_Especialidad, NombreEspecialidad FROM Especialidad";
				SqlCommand cmd = new SqlCommand(query, con);
				con.Open();
				// Ejecutar el comando y leer los resultados
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					// Leer cada registro y crear objetos Especialidad
					while (reader.Read())
					{
						Especialidad e = new Especialidad
						{
							IdEspecialidad = Convert.ToInt32(reader["ID_Especialidad"]),
							NombreEspecialidad = reader["NombreEspecialidad"].ToString()
						};
						lista.Add(e);
					}
				}
			}
			// Retornamos la lista de especialidades obtenida de la base de datos
			return lista;
		}

		// 2. Registrar Especialidad
		public bool RegistrarEspecialidad(Especialidad especialidad)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				// Consulta SQL para insertar una nueva especialidad
				string query = "INSERT INTO Especialidad (NombreEspecialidad) VALUES (@NombreEspecialidad)";
				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@NombreEspecialidad", especialidad.NombreEspecialidad);
					con.Open();
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

		// 3. Actualizar Especialidad
		public bool ActualizarEspecialidad(Especialidad especialidad)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				// Consulta SQL para actualizar una especialidad existente
				string query = "UPDATE Especialidad SET NombreEspecialidad = @NombreEspecialidad WHERE ID_Especialidad = @ID_Especialidad";
				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@NombreEspecialidad", especialidad.NombreEspecialidad);
					cmd.Parameters.AddWithValue("@ID_Especialidad", especialidad.IdEspecialidad);
					con.Open();
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

		// 4. Eliminar Especialidad
		public bool EliminarEspecialidad(int idEspecialidad)
		{
			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				// Consulta SQL para eliminar una especialidad por su ID
				string query = "DELETE FROM Especialidad WHERE ID_Especialidad = @ID_Especialidad";
				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@ID_Especialidad", idEspecialidad);
					con.Open();
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}
	}
}
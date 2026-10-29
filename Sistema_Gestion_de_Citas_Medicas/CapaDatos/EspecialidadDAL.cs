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
		public List<Especialidad> ListarEspecialidades()
		{
			List<Especialidad> lista = new List<Especialidad>();

			using (SqlConnection con = Conexion.ObtenerConexion())
			{
				string query = "SELECT ID_Especialidad, NombreEspecialidad FROM Especialidad";
				SqlCommand cmd = new SqlCommand(query, con);
				con.Open();

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
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
			return lista;
		}
	}
}

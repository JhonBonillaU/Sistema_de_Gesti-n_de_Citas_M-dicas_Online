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
    }
}
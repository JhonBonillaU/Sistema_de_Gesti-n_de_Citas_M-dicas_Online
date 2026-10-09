using System;
using System.Data.SqlClient;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;

namespace Sistema_Gestion_de_Citas_Medicas.CapaDatos
{
    public class UsuarioDAL
    {
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
                                Rol = rol
                            };

                            if (reader["ID_Paciente"] != DBNull.Value)
                            {
                                p.IdPaciente = Convert.ToInt32(reader["ID_Paciente"]);
                            }

                            usuario = p;
                        }
                        else if (rol == "Medico")
                        {
                            Medico m = new Medico
                            {
                                IdUsuario = Convert.ToInt32(reader["ID_Usuario"]),
                                Username = reader["Username"].ToString(),
                                Rol = rol
                            };

                            if (reader["ID_Medico"] != DBNull.Value)
                            {
                                m.IdMedico = Convert.ToInt32(reader["ID_Medico"]);
                            }

                            usuario = m;
                        }
                        else // Administrador
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
    }
}
using System;
using System.Data.SqlClient;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;

namespace Sistema_Gestion_de_Citas_Medicas.CapaDatos
{
    public class RecetaDAL
    {
        // Emitir receta y marcar la cita como 'Atendida' en una sola transacción SQL
        public bool EmitirReceta(Receta receta)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    // 1. Insertar Receta
                    string queryReceta = @"INSERT INTO Receta (Descripcion, ID_Cita) 
                                           VALUES (@Descripcion, @ID_Cita);";

                    using (SqlCommand cmdR = new SqlCommand(queryReceta, con, tx))
                    {
                        cmdR.Parameters.AddWithValue("@Descripcion", receta.Descripcion);
                        cmdR.Parameters.AddWithValue("@ID_Cita", receta.IdCita);
                        cmdR.ExecuteNonQuery();
                    }

                    // 2. Actualizar estado de la Cita a 'Atendida'
                    string queryCita = "UPDATE Cita SET Estado = 'Atendida' WHERE ID_Cita = @ID_Cita;";
                    using (SqlCommand cmdC = new SqlCommand(queryCita, con, tx))
                    {
                        cmdC.Parameters.AddWithValue("@ID_Cita", receta.IdCita);
                        cmdC.ExecuteNonQuery();
                    }

                    tx.Commit(); // Confirmar cambios en SQL
                    return true;
                }
                catch (SqlException ex)
                {
                    tx.Rollback();
                    throw new Exception($"Error SQL al emitir la receta: {ex.Message}");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new Exception($"Error inesperado al emitir la receta: {ex.Message}");
                }
            }
        }
    }
}
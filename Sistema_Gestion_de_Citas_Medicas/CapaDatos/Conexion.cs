using System.Configuration;
using System.Data.SqlClient;

namespace Sistema_Gestion_de_Citas_Medicas.CapaDatos
{
    public class Conexion
    {
        private static string cadenaConexion = ConfigurationManager.ConnectionStrings["cnSQL"]?.ConnectionString
            ?? "Server=3375898HP;Database=GestionCitasMedicas;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}

//NOTA: Cambiar la cadena de conexión en el archivo App.config si se desea conectar a otra base de datos.

//Solucion de error en libreria configuracion: Referencias/agregar referencia 
//Marca la casilla al lado de System.Configuration, clic en Aceptar.
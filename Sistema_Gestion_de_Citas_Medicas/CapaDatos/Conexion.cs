using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Sistema_Gestion_de_Citas_Medicas.CapaDatos
{
    public class Conexion
    {
        // Obtiene la cadena de conexión definida en App.config
        private static string cadenaConexion = ConfigurationManager.ConnectionStrings["cnSQL"]?.ConnectionString
            ?? "Server=.;Database=GestionCitasMedicas;Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}

//Solucion de error en libreria configuracion: Referencias/agregar referencia 
//Marca la casilla al lado de System.Configuration. Haz clic en Aceptar.


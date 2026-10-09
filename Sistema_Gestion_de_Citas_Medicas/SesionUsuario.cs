using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Citas_Medicas
{
    public static class SesionUsuario
    {

        public static int IdUsuario { get; set; }
        public static string Username { get; set; }
        public static string Rol { get; set; } // roles de "Admin", "Medico", "Paciente"
        public static int? IdPaciente { get; set; }
        public static int? IdMedico { get; set; }

        public static void LimpiarSesion()
        {
            IdUsuario = 0;
            Username = string.Empty;
            Rol = string.Empty;
            IdPaciente = null;
            IdMedico = null;
        }
    }
}

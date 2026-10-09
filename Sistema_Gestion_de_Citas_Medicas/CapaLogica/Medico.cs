using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Citas_Medicas.CapaLogica
{
    public class Medico : Usuario
    {
        private int idMedico;
        private int idEspecialidad;
        private string nombreEspecialidad;

        public int IdMedico { get => idMedico; set => idMedico = value; }
        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string NombreEspecialidad { get => nombreEspecialidad; set => nombreEspecialidad = value; }

        public Medico() : base() { }

        public Medico(int idMedico, int idEspecialidad, string nombreEspecialidad, int idUsuario, string username, string password, string nombre, string apellido, string telefono, string correo)
            : base(idUsuario, username, password, "Medico", nombre, apellido, telefono, correo)
        {
            this.idMedico = idMedico;
            this.idEspecialidad = idEspecialidad;
            this.nombreEspecialidad = nombreEspecialidad;
        }

        // Polimorfismo con 'override'
        public override string ObtenerPerfil()
        {
            return $"MÉDICO: Dr. {nombre} {apellido} | Especialidad: {nombreEspecialidad}";
        }

        public override string ToString()
        {
            return $"Dr. {nombre} {apellido} ({nombreEspecialidad})";
        }
    }
}
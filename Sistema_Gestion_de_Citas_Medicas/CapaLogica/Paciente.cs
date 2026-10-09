using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Citas_Medicas.CapaLogica
{
    // Heredamos
    public class Paciente : Usuario
    {
        //agregamos los atributos de la clase Paciente
        private int idPaciente; 
        private DateTime fechaNacimiento;

        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public Paciente() : base() { }

        // Invocación al constructor padre mediante base
        public Paciente(int idPaciente, DateTime fechaNacimiento, int idUsuario, string username, string password, string nombre, string apellido, string telefono, string correo)
            : base(idUsuario, username, password, "Paciente", nombre, apellido, telefono, correo)
        {
            this.idPaciente = idPaciente;
            this.fechaNacimiento = fechaNacimiento;
        }

        // Polimorfismo con override: Sobrescribe el método virtual de Usuario
        public override string ObtenerPerfil()
        {
            return $"PACIENTE: {nombre} {apellido} | Teléfono: {telefono} | Fecha Nac: {fechaNacimiento.ToShortDateString()}";
        }

        // Sobrescritura de System.Object.ToString()
        public override string ToString()
        {
            return $"[Paciente] {nombre} {apellido}";
        }
    }
}
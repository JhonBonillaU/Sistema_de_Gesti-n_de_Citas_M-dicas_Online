using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Citas_Medicas.CapaLogica
{
    public class Cita
    {
        // Atributos privados y protegidos
        protected int idCita;
        protected DateTime fechaHora;
        protected string estado; // Pendiente, Atendida, Cancelada
        protected int idPaciente;
        protected int idMedico;

        // Propiedades auxiliares para mostrar nombres en la interfaz (UI)
        public string NombrePaciente { get; set; }
        public string NombreMedico { get; set; }
        public string NombreEspecialidad { get; set; }

        // Encapsulamiento
        public int IdCita { get => idCita; set => idCita = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int IdMedico { get => idMedico; set => idMedico = value; }

        public Cita()
        {
            estado = "Pendiente";
        }

        public Cita(int idCita, DateTime fechaHora, string estado, int idPaciente, int idMedico)
        {
            this.idCita = idCita;
            this.fechaHora = fechaHora;
            this.estado = estado;
            this.idPaciente = idPaciente;
            this.idMedico = idMedico;
        }

        // Sobrescritura de System.Object.ToString() 
        public override string ToString()
        {
            return $"Cita #{idCita} - {fechaHora.ToString("dd/MM/yyyy HH:mm")} [{estado}]";
        }
    }
}

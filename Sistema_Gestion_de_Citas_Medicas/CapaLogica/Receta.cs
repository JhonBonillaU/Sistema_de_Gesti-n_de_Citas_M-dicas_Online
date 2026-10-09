using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Citas_Medicas.CapaLogica
{
    public class Receta
    {
        protected int idReceta;
        protected string descripcion;
        protected int idCita;

        // Propiedades públicas encapsuladas
        public int IdReceta { get => idReceta; set => idReceta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdCita { get => idCita; set => idCita = value; }

        public Receta() { }

        public Receta(int idReceta, string descripcion, int idCita)
        {
            this.idReceta = idReceta;
            this.descripcion = descripcion;
            this.idCita = idCita;
        }

        // Sobrescritura de System.Object.ToString() (Semana 10)
        public override string ToString()
        {
            return $"Receta #{idReceta} para Cita #{idCita}";
        }
    }
}

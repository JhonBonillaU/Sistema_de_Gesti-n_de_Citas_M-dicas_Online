using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Citas_Medicas.CapaLogica
{
    namespace Sistema_Gestion_de_Citas_Medicas.CapaLogica
    {
        public class Especialidad
        {
            private int idEspecialidad;
            private string nombreEspecialidad;

            public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
            public string NombreEspecialidad { get => nombreEspecialidad; set => nombreEspecialidad = value; }

            public Especialidad() { }

            public Especialidad(int idEspecialidad, string nombreEspecialidad)
            {
                this.idEspecialidad = idEspecialidad;
                this.nombreEspecialidad = nombreEspecialidad;
            }
        }
    }
}

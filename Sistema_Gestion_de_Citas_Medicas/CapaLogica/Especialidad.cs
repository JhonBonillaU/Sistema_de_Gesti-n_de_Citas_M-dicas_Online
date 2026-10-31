using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Citas_Medicas.CapaLogica
{
	public class Especialidad
	{
		// Atributos privados
		private int idEspecialidad;
		private string nombreEspecialidad;

		// Encapsulamiento
		public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
		public string NombreEspecialidad { get => nombreEspecialidad; set => nombreEspecialidad = value; }

		// Constructor por defecto
		public Especialidad() { }

		// Constructor con parámetros
		public Especialidad(int idEspecialidad, string nombreEspecialidad)
		{
			this.idEspecialidad = idEspecialidad;
			this.nombreEspecialidad = nombreEspecialidad;
		}
	}
}
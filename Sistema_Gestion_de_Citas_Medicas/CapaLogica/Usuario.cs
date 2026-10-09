using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Citas_Medicas.CapaLogica
{
    //Clase Base con miembros protected y propiedades públicas
    public class Usuario
    {
        // Campos 'protected' Visibles para clases derivadas (Paciente/Medico), invisibles afuera
        protected int idUsuario;
        protected string username;
        protected string password;
        protected string rol;
        protected string nombre;
        protected string apellido;
        protected string telefono;
        protected string correo;

        // Encapsulamiento con propiedades
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }

        // Constructores y encadenamiento
        public Usuario() { }

        public Usuario(int idUsuario, string username, string password, string rol, string nombre, string apellido, string telefono, string correo)
        {
            this.idUsuario = idUsuario;
            this.username = username;
            this.password = password;
            this.rol = rol;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.correo = correo;
        }

        // Método 'virtual': Permite que las clases hijas redefinan el comportamiento polimórfico
        public virtual string ObtenerPerfil()
        {
            return $"USUARIO: {username} | Rol: {rol} | Nombre: {nombre} {apellido}";
        }

        // Sobrescritura de ToString() heredado de System.Object
        public override string ToString()
        {
            return $"{nombre} {apellido} ({username})";
        }
    }
}


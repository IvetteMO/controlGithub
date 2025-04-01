using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlGithub
{
    internal class Docente : Persona
    {
        private string cedula;
        private string especialidad;
        public Docente(string cedula, string especialidad, string nombre, string apellido, int edad, string direccion) : base(nombre, apellido, edad, direccion)
        {
            this.cedula = cedula;
            this.especialidad = especialidad;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }

        public void MostrarDocente()
        {
            base.MostrarDatos();
            Console.WriteLine("Cedula: " + cedula);
            Console.WriteLine("Especialidad: " + especialidad);

        }
    }
}

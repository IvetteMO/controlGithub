using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlGithub
{
    internal class Alumno : Persona
    {
        private string matricula;
        private string carrera;
        public Alumno(string matricula, string carrera, string nombre, string apellido, int edad, string direccion) : base(nombre, apellido, edad, direccion)
        {
            this.matricula = matricula;
            this.carrera = carrera;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Carrera { get => carrera; set => carrera = value; }

        public void MostrarEstudiante()
        {
            base.MostrarDatos();
            Console.WriteLine("Matricula: " + matricula);
            Console.WriteLine("Carrera: " + carrera);
            
        }   
    }
}

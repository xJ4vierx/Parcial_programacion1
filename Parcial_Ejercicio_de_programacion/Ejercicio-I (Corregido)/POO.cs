using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I
{
    class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
        }
    }

    class Program
    {
        static void Main()
        {
            Persona persona1 = new Persona("Carlos", 25);
            persona1.MostrarDetalles();
        }
    }
}
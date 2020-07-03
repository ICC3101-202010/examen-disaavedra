using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            string eleccion;

            Central central = new Central();

            Console.WriteLine("Bienvenido!!");
            Console.WriteLine("[1] Crear Equipo" +
                              "[2] Seleccionar equipo existente");

            eleccion = Console.ReadLine();

            switch(eleccion)
            {
                case "1":
                    central.CrearEquipo();
                    break;

                case "2":
                    central.MostrarEquipo();
                    break;
            }
        }
    }
}

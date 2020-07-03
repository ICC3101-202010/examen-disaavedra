using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Examen
{
    [Serializable]
    class Central
    {
        List<Equipo> equipos = new List<Equipo>();

        public void CrearEquipo()
        {
            string nombre, tipo;
            string eleccionTipo;
            Console.WriteLine("Nombre equipo");
            nombre = Console.ReadLine();
            Console.WriteLine("Tipo de Equipo" +
                              "[1] Nacional" +
                              "[2] Liga");
            eleccionTipo = Console.ReadLine();
            switch(eleccionTipo)
            {
                case "1":
                    tipo = "Nacional";
                    break;
                case "2":
                    tipo = "Liga";
                    break;
                default:
                    Console.WriteLine("Como no existe la opcion marcada, se le ha asignado como un equipo de Liga");
                    tipo = "Liga";
                    break;
            }
            CrearJugadores();
            CrearEntrenador();
            CrearMedico();
            Equipo equipo = new Equipo(nombre, tipo, CrearJugadores(), CrearMedico(), CrearEntrenador());
        }

        private Entrenador CrearEntrenador()
        {
            string nombre, apellido, nacionalidad, sueldo;
            string Tipo = "Entrenador";
            Console.WriteLine("Nombre", Tipo);
            nombre = Console.ReadLine();
            Console.WriteLine("Apellido", Tipo);
            apellido = Console.ReadLine();
            Console.WriteLine("Nombre", Tipo);
            nacionalidad = Console.ReadLine();
            Console.WriteLine("Sueldo", Tipo);
            sueldo = Console.ReadLine();
            Entrenador entrenador = new Entrenador(nombre, apellido, nacionalidad, sueldo);
            return entrenador;
        }

        private Medico CrearMedico()
        {
            string nombre, apellido, nacionalidad, sueldo;
            string Tipo = "Medico";
            Console.WriteLine("Nombre", Tipo);
            nombre = Console.ReadLine();
            Console.WriteLine("Apellido", Tipo);
            apellido = Console.ReadLine();
            Console.WriteLine("Nombre", Tipo);
            nacionalidad = Console.ReadLine();
            Console.WriteLine("Sueldo", Tipo);
            sueldo = Console.ReadLine();
            Medico medico = new Medico(nombre, apellido, nacionalidad, sueldo);
            return medico;
        }

        private List<Jugador> CrearJugadores()
        {
            int var;
            List<Jugador> jugadores = new List<Jugador>();
            var = 1;
            while (var > 0)
            {
                jugadores.Add(CrearArquero());
                var -= 1;
            }
            var = 5;
            while(var > 0)
            {
                jugadores.Add(CrearDefensa());
                var -= 1;
            }
            var = 5;
            while (var > 0)
            {
                jugadores.Add(CrearCentroCampista());
                var -= 1;
            }
            var = 4;
            while (var > 0)
            {
                jugadores.Add(CrearDelantero());
                var -= 1;
            }

            return jugadores;
        }

        private Jugador CrearArquero()
        {
            string Tipo = "Arquero";
            Jugador arquero;
            arquero = CrearJugador(Tipo);
            return arquero;
        }

        private Jugador CrearDefensa()
        {
            string Tipo = "Defensa";
            Jugador defensa;
            defensa = CrearJugador(Tipo);
            return defensa;
        }

        private Jugador CrearCentroCampista()
        {
            string Tipo = "CentroCampista";
            Jugador centroCampista;
            centroCampista = CrearJugador(Tipo);
            return centroCampista;
        }

        private Jugador CrearDelantero()
        {
            string Tipo = "Delantero";
            Jugador delantero;
            delantero = CrearJugador(Tipo);
            return delantero;
        }

        private Jugador CrearJugador(string Tipo)
        {
            string nombre, apellido, nacionalidad, numero, sueldo;
            int puntosAtaque, puntosDefensa;
            Console.WriteLine("Nombre", Tipo);
            nombre = Console.ReadLine();
            Console.WriteLine("Apellido", Tipo);
            apellido = Console.ReadLine();
            Console.WriteLine("Nombre", Tipo);
            nacionalidad = Console.ReadLine();
            Console.WriteLine("Sueldo", Tipo);
            sueldo = Console.ReadLine();
            Jugador jugador = new Jugador(nombre, apellido, nacionalidad, sueldo);
            Console.WriteLine("Numero", Tipo);
            numero = Console.ReadLine();
            Console.WriteLine("Puntos de Ataque", Tipo);
            puntosAtaque = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Puntos de Defensa", Tipo);
            puntosDefensa = Int32.Parse(Console.ReadLine());
            jugador.DatosJugador(numero, "Delantero", puntosAtaque, puntosDefensa);
            return jugador;
        }

        public void MostrarEquipo()
        {
            int numero = 1;
            int eleccion;
            Console.WriteLine("Selecciona un Equipo para conocer su informacion");
            foreach (var i in equipos)
            {
                Console.WriteLine(numero + i.NOMBRE);
                numero += 1;
            }
            eleccion = Int32.Parse(Console.ReadLine());
            //Aqui debe ir un Evento
            MostrarInfoEquipo(eleccion);
        }

        private void MostrarInfoEquipo(int eleccion)
        {
            Equipo equipo;
            int numero = 1;
            equipo = equipos.ElementAt(eleccion - 1);
            Console.WriteLine("Nombre de Equipo:" + equipo.NOMBRE);
            Console.WriteLine("Tipo de Equipo:" + equipo.TIPO);
            foreach (var i in equipo.JUGADORES)
            {
                Console.WriteLine("Jugador Numero : " + numero);
                Console.WriteLine("Nombre: " + i.NOMBRE + 
                                  "Apellido: " + i.APELLIDO + 
                                  "Nacionalidad: " + i.NACIONALIDAD + 
                                  "Posicion: " + i.POSICION + 
                                  "Numero: " + i.NUMERO);
            }

            Console.WriteLine("Nombre Entrenador Equipo: " + equipo.ENTRENADOR.NOMBRE + 
                              "Apellido Entrenador: " + equipo.ENTRENADOR.APELLIDO +
                              "Nacionalidad Entrenador:" + equipo.ENTRENADOR.NACIONALIDAD);

            Console.WriteLine("Nombre Medico Equipo: " + equipo.MEDICO.NOMBRE +
                              "Apellido Medico: " + equipo.MEDICO.APELLIDO +
                              "Nacionalidad Medico:" + equipo.MEDICO.NACIONALIDAD);


        }
    }
}

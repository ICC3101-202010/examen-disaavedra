using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Equipo
    {
        string nombre;
        string tipo; //Liga o Nacional
        List<Jugador> jugadores;
        Medico medico;
        Entrenador entrenador;

        public Equipo(string nombre, string tipo, List<Jugador> jugadores, Medico medico, Entrenador entrenador)
        {
            this.nombre = nombre;
            this.jugadores = jugadores;
            this.medico = medico;
            this.entrenador = entrenador;
            this.tipo = tipo;
        }

        public string NOMBRE
        {
            get { return nombre; }
        }

        public List<Jugador> JUGADORES
        {
            get { return jugadores; }
        }

        public Medico MEDICO
        {
            get { return medico; }
        }

        public Entrenador ENTRENADOR
        {
            get { return entrenador; }
        }

        public string TIPO
        {
            get { return tipo; }
        }

        public bool CorroborarNacionalidad()
        {
            foreach(var i in jugadores)
            {
                if (i.NACIONALIDAD != tipo)
                    return false;
            }

            return true
        }
    }
}

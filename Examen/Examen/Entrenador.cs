using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Entrenador : Persona
    {
        int puntosTactica;

        public Entrenador(string nombre, string apellido, string nacionalidad, string sueldo) : base(nombre, apellido, nacionalidad, sueldo)
        {
            //
        }

        public void Puntos(int puntosTactica)
        {
            this.puntosTactica = puntosTactica;
        }

        public int PUNTOSTACTICA
        {
            get { return puntosTactica; }
        }

        public void CambiarJugador()
        {
            Console.WriteLine("El Entrenador esta realizando cambios en el equipo...");
        }
    }
}

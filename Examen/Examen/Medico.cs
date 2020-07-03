using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Medico : Persona
    {

        int puntosExperiencia;

        public Medico(string nombre, string apellido, string nacionalidad, string sueldo) : base(nombre, apellido, nacionalidad, sueldo)
        {
            //
        }

        private void PuntosExperiencia(int puntosExperiencia)
        {
            this.puntosExperiencia = puntosExperiencia;
        }

        public void Evaluar()
        {
            Console.WriteLine("El Medico esta realizando evaluando la lesion del jugador...");
        }

        public void Curar()
        {
            Console.WriteLine("El Medico esta curando al jugador...");
        }
    }
}

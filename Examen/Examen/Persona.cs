using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Persona
    {
        string nombre;
        string apellido;
        string nacionalidad;
        string sueldo;

        public Persona(string nombre, string apellido, string nacionalidad, string sueldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.sueldo = sueldo;
        }

        public string NOMBRE
        {
            get { return nombre; }
        }

        public string APELLIDO
        {
            get { return apellido; }
        }

        public string NACIONALIDAD
        {
            get { return nacionalidad; }
        }

        public string SUELDO
        {
            get { return sueldo; }
        }
    }
}

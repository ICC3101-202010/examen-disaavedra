using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Jugador : Persona
    {
        string numero;
        string posicion;
        int puntosAtaque;
        int puntosDefensa;

        public Jugador(string nombre, string apellido, string nacionalidad, string sueldo) : base(nombre, apellido, nacionalidad, sueldo)
        {
            //
        }

        public void DatosJugador(string numero, string posicion, int puntosAtaque, int puntosDefensa)
        {
            this.numero = numero;
            this.posicion = posicion;
            this.puntosAtaque = puntosAtaque;
            this.puntosDefensa = puntosDefensa;
        }

       

        public string NUMERO
        {
            get { return numero; }
        }

        public string POSICION
        {
            get { return posicion; }
        }

        public int PUNTOSATAQUE
        {
            get { return puntosAtaque; }
        }

        public int PUNTOSDEFENSA
        {
            get { return puntosDefensa; }
        }
    }
}

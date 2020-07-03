using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Partido
    {
        string tipo;
        string minutos;
        string resultado;
        string Ganador;
        Equipo equipoVisita;
        Equipo equipoLocal;

        public Partido(string tipo, string minutos)
        {
            this.tipo = tipo;
            this.minutos = minutos;
        }

        public void Resultado(string resultado)
        {
            this.resultado = resultado;
        }

        public void Enfrentamiento(Equipo equipoVisita, Equipo equipoLocal)
        {
            this.equipoVisita = equipoVisita;
            this.equipoVisita = equipoLocal ;
        }
    }
}

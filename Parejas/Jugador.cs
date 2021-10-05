using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parejas
{
    public class Jugador
    {
        private string nombre;
        private int numParejasCorrectas;

        public Jugador()
        {
            nombre = "";
            numParejasCorrectas = 0;
        }
        public Jugador(string nombre)
        {
            this.nombre = nombre;
            this.numParejasCorrectas = 0;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int NumParejasCorrectas
        {
            get { return numParejasCorrectas; }
            set { numParejasCorrectas = value; }
        }

        public override string ToString()
        {
            string cadena;
            cadena = "Jugador: " + nombre + " | " + "Parejas: " + numParejasCorrectas + "\n\n";
            return cadena;
        }
    }
}

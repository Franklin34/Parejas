using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parejas
{
    class Carta
    {
        private string letra;
        private bool volteada;

        public Carta()
        {
            letra = "";
            volteada = false;
        }

        public Carta(string letra)
        {
            this.letra = letra;
            volteada = false;
        }

        public string Letra
        {
            get { return letra; }
            set { letra = value; }
        }

        public bool Volteada
        {
            get { return volteada; }
            set { volteada = value; }
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parejas
{
    class Juego
    {
        private Jugador jugador;
        private Tablero tablero;

        public Juego()
        {
            jugador = new Jugador();
            tablero = new Tablero();
        }

        public Juego(string nombre)
        {
            jugador = new Jugador(nombre);
            tablero = new Tablero();
        }

        public Jugador Jugador
        {
            get { return jugador; }
            set { jugador = value; }
        }

        public Tablero Tablero
        {
            get { return tablero; }
            set { tablero = value; }
        }
    }
}

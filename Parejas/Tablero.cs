using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parejas
{
    class Tablero
    {
        private Carta[,] tablero;
        private int filas;
        private int columnas;

        public Tablero()
        {
            tablero = new Carta[6, 6];
            filas = 6;
            columnas = 6;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    tablero[i, j] = new Carta();
                }
            }
            llenarTablero();
            desordenarTablero();
        }

        private void llenarTablero()
        {
            string[] letras = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" };
            int contador = 0;
            int random = 0;
            Random r = new Random();

            for(int i = 0; i < filas; i++)
            {
                for(int j = 0; j < columnas; j++)
                {
                    random = r.Next(0, 26);
                    if(contador < 18)
                    {
                        if (random == 0)
                        {
                            random = r.Next(0,26);
                            tablero[i, j].Letra = letras[random];
                        }
                        else
                        {
                            while (seRepiteCarta(letras[random]) == true)
                            {
                                random = r.Next(0, 26);
                            }
                            tablero[i, j].Letra = letras[random];
                        }
                        contador++;
                    }
                    if(contador >= 18)
                    {
                        while (cantVecesCartaEnTablero(letras[random]) != 1)
                        {
                            random = r.Next(0, 26);
                        }

                        if (seRepiteCarta(letras[random]) == true)
                        {
                            tablero[i, j].Letra = letras[random];
                        }
                    }
                }
            }
        }

        private void desordenarTablero()
        {
            var rnd = new Random();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    var x = rnd.Next(0, 5);
                    var w = rnd.Next(0, 5);
                    var temp = tablero[i,j];
                    tablero[i, j] = tablero[x, w];
                    tablero[x, w] = temp;
                }
            }
        }

        private int cantVecesCartaEnTablero(string letra)
        {
            int contador = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j].Letra == letra)
                    {
                        contador++;
                    }
                }
            }

            return contador;
        }

        private bool seRepiteCarta(string letra)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j].Letra == letra)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public string retornarValorTablero(int i, int y)
        {
            if(tablero[i,y].Volteada == false)
            {
                return "";
            }
            return tablero[i, y].Letra;
        }

        public string retornarValorTablero2(int i, int y)
        {
            return tablero[i, y].Letra;
        }

        public void voltearCarta(string letra,int i,int j)
        {
            if(tablero[i,j].Volteada == false)
            {
                 tablero[i, j].Volteada = true;
                 return;
            }
            else if (tablero[i, j].Volteada == true)
            {
                tablero[i, j].Volteada = false;
                return;
            }
        }

        public void voltearCarta2(string letra, int i, int j)
        {
            if (tablero[i, j].Volteada == false)
            {
                tablero[i, j].Volteada = true;
                return;
            }
            else if (tablero[i, j].Volteada == true)
            {
                tablero[i, j].Volteada = false;
                return;
            }
        }

        public void voltearCarta3(string letra1, string letra2)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if(tablero[i,j].Letra == letra1)
                    {
                        if (tablero[i, j].Volteada == false)
                        {
                            tablero[i, j].Volteada = true;
                            return;
                        }
                        else if (tablero[i, j].Volteada == true)
                        {
                            tablero[i, j].Volteada = false;
                            return;
                        }
                    }
                    if (tablero[i, j].Letra == letra2)
                    {
                        if (tablero[i, j].Volteada == false)
                        {
                            tablero[i, j].Volteada = true;
                            return;
                        }
                        else if (tablero[i, j].Volteada == true)
                        {
                            tablero[i, j].Volteada = false;
                            return;
                        }
                    }
                }
            }


                    
        }

        public bool sonPareja(string letra1,string letra2)
        {
            if(letra1 == letra2)
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parejas
{
    public partial class Form1 : Form
    {
        private Juego juego;
        private List<Button> list;
        private int cantPuntos;
        private int contador;

        private Button botonActual;
        private Button botonSiguiente;

        public Form1()
        {
            InitializeComponent();
            juego = new Juego("Franklin");
            list = new List<Button>();
            list.Add(button1);
            list.Add(button2);
            list.Add(button3);
            list.Add(button4);
            list.Add(button5);
            list.Add(button6);
            list.Add(button7);
            list.Add(button8);
            list.Add(button9);
            list.Add(button10);
            list.Add(button11);
            list.Add(button12);
            list.Add(button13);
            list.Add(button14);
            list.Add(button15);
            list.Add(button16);
            list.Add(button17);
            list.Add(button18);
            list.Add(button19);
            list.Add(button20);
            list.Add(button21); 
            list.Add(button22);
            list.Add(button23);
            list.Add(button24);
            list.Add(button25);
            list.Add(button26);
            list.Add(button27);
            list.Add(button28);
            list.Add(button29);
            list.Add(button30);
            list.Add(button31);
            list.Add(button32);
            list.Add(button33);
            list.Add(button34);
            list.Add(button35);
            list.Add(button36);
            cantPuntos = 0;
            contador = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarTablero();
        }

        private void llenarTablero()
        {
            int contador = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    list[contador].Text = juego.Tablero.retornarValorTablero(i, j).ToString();
                    list[contador].BackColor = default(Color);
                    contador++;
                }
            }
        }

        private void validarCeldas(Button boton)
        {
            if (contador == 0)
            {
                botonActual = boton;
                contador++;
                return;
            }
            if (contador == 1)
            {
                if(cantPuntos == 17)
                {
                    cantPuntos++;
                    label2.Text = cantPuntos.ToString();
                    botonActual.BackColor = Color.AliceBlue;
                    botonSiguiente = boton;
                    botonSiguiente.BackColor = Color.AliceBlue;
                    MessageBox.Show("Felicidades has ganado el juego...");
                }
                else
                {
                    botonSiguiente = boton;
                    contador++;
                    return;
                }
            }
            if (contador == 2)
            {
                if (validarPareja() == false)
                {
                    botonActual.Enabled = true;
                    botonSiguiente.Enabled = true;
                    botonActual.BackColor = default(Color);
                    botonSiguiente.BackColor = default(Color);
                    botonActual.Text = "";
                    botonSiguiente.Text = "";
                }
                botonActual = boton;
                contador = 1;
            }
        }

        private void voltearCartaYValidar(int i, int j, Button boton)
        {
            juego.Tablero.voltearCarta(juego.Tablero.retornarValorTablero2(i, j).ToString(), i, j);
            boton.Enabled = false;
            boton.BackColor = Color.Yellow;
            boton.Text = juego.Tablero.retornarValorTablero2(i, j).ToString();
            validarCeldas(boton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(0, 0, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(0, 1, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(0, 2, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(0, 3, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(0, 4, button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(0, 5, button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(1, 0, button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(1, 1, button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(1, 2, button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(1, 3, button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(1, 4, button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(1, 5, button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(2, 0, button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(2, 1, button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(2, 2, button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(2, 3, button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(2, 4, button17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(2, 5, button18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(3, 0, button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(3, 1, button20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(3, 2, button21);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(3, 3, button28);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(3, 4, button23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(3, 5, button24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(4, 0, button25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(4, 1, button26);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(4, 2, button27);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(4, 3, button22);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(4, 4, button29);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(4, 5, button30);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(5, 0, button31);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(5, 1, button32);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(5, 2, button33);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(5, 3, button34);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(5, 4, button35);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            voltearCartaYValidar(5, 5, button36);
        }

        private bool validarPareja()
        {
            if(juego.Tablero.sonPareja(botonActual.Text,botonSiguiente.Text) == true)
            {
                cantPuntos++;
                label2.Text = cantPuntos.ToString();
                botonActual.BackColor = Color.AliceBlue;
                botonSiguiente.BackColor = Color.AliceBlue;
                botonActual = new Button();
                botonSiguiente = new Button();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pico_fermi_practica_FINISH
{
    public partial class PicoFermi : Form
    {
        //variables

        string playerName;
        List<int> numerosJuego = new List<int> {123, 432, 531, 763, 965 };
        Random rnd = new Random();
        int indicenRandom;
        List<Button> listaBotones = new List<Button> ();
        string numeroJuego1;
        int numeroIngresado;

        public PicoFermi(string nombreJugador)
        {
            playerName = nombreJugador;
            InitializeComponent();
            
        }

        private void PicoFermi_Load(object sender, EventArgs e)
        {
            label1.Text = $"Jugador:{playerName} ";
            listaBotones.Add(button1);
            listaBotones.Add(button2);
            listaBotones.Add(button3);
        }

        public void generarNumero()
        {
            indicenRandom = rnd.Next(0, numerosJuego.Count);
      
            numeroJuego1 = numerosJuego[indicenRandom].ToString();

            label3.Text = numeroJuego1;

            foreach (Button boton in listaBotones)
            {
                boton.Text = "_";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            generarNumero();
        }

        public Boolean verificaIngresoNumero()
        {
           

            try
            {
                numeroIngresado = int.Parse(textBox1.Text);

                if (numeroIngresado > 99 && numeroIngresado < 1000)
                {
                    return true;

                }
                return false;

            }
            catch (Exception)
            {

                
                MessageBox.Show("Usted no ingreso un numero");
            }

            return false;
            

        }

        public void comprobarCoincidencia()
        {

            string numeroIngresado1 = numeroIngresado.ToString();

            for (int i = 0; i < numeroJuego1.Length; i++)
            {
                if(numeroIngresado1[i] == numeroJuego1[i] )
                {
                    listaBotones[i].Text = numeroJuego1[i].ToString();
                }else if (numeroJuego1.Contains(numeroIngresado1[i]))
                {
                    label4.Text = $"El numero {numeroIngresado1[i]} existe en la cadena pero en una posicion diferente";
                }


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if(verificaIngresoNumero() == true)
            {
                comprobarCoincidencia();


            }
            else
            {
                MessageBox.Show("Usted no ingreso los numeros correctamente");
            }

            

            



        }
    }
}

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
    public partial class Form1 : Form
    {
        string nombreJugador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreJugador = textBox1.Text;
            PicoFermi juego = new PicoFermi(nombreJugador);
            this.Hide();
            juego.Show();
        }
    }
}

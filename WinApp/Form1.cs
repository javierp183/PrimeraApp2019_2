using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Form1 : Form // Clase Form1 que hereda de Form.
    {
        public Form1()
        {
            InitializeComponent(); //Constructor de la clase
        }

        private int vecesQuePasastePorHover = 0;
        private bool banderaReloca = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mmmmmm...., esto esta lleno de ninjas");
            VentanaDos ventana = new VentanaDos();

            //ventana.Show();
            //Cambiamos el modo en que nos muestra la ventana como una ventana de Dialogo.
            ventana.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chantun()
        {
            MessageBox.Show("cambio de color, re chantun!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MouseEventArgs click = (MouseEventArgs)e;
            //this.BackColor = Color.Blue;

            /* if (textBox1_TextChanged.Text == "")
                textBox1_TextChanged.BackColor = Color.Red;
            else
                textBox1_TextChanged.BackColor = System.Drawing.SystemColors.Control;
                */
            

            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");

        }

        private void testlabel_MouseMove(object sender, MouseEventArgs e)
        {
            testlabel.BackColor = Color.Cyan;
        }

        private void testlabel_MouseLeave(object sender, EventArgs e)
        {
            testlabel.BackColor = System.Drawing.SystemColors.Control;
       
        }
    }
}

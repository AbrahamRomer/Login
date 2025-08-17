using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Hola Mundo");
        }
        int intentos = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, clave;
            usuario = textBox1.Text;
            clave = textBox2.Text;

            if (usuario == "admin" && clave == "admin123")
            {
                MessageBox.Show("Bienvenido", usuario);
                intentos = 0; // Reinicia intentos si es correcto
            }
            else
            {
                intentos++;
                if (intentos >= 3)
                {
                    MessageBox.Show("Intentos acabados");
                    this.Close(); // Cierra el formulario
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta. Intento " + intentos + " de 3");
                }
            }
        }
    }
}

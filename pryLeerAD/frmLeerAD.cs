using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryLeerAD
{
    public partial class frmLeerAD : Form
    {
        public frmLeerAD()
        {
            InitializeComponent();
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {

            string texto = txtEscribir.Text;

            TextWriter Escribir = new StreamWriter("Libro.txt", true);
            Escribir.WriteLine(texto);
            Escribir.Close();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            TextReader Leer = new StreamReader("Libro.txt");
            /*MessageBox.Show(Leer.ReadLine());*/        // Leer x linea
            MessageBox.Show(Leer.ReadToEnd());       // Lee todo hasta el final

            Leer.Close();
        }

        private void txtEscribir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            StreamReader Leer = new StreamReader("Libro.txt");
            while (Leer.EndOfStream == false)
            {
                string aux = Leer.ReadLine();
                if (aux.Contains(txtBuscar.Text))
                {
                    MessageBox.Show("Encontrado");
                    break;
                }
                else
                {
                    MessageBox.Show("No encontrado");
                }
            }

            Leer.Close();
        }
    }
}

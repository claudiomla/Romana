using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasDeVentanasPrincipales
{
    public partial class EMOpCode : Form
    {
        public EMOpCode()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                case Keys.Delete:
                    e.SuppressKeyPress = false; // el resto de las teclas seran ignoradas
                    return;
                default:
                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back)) // si la tecla presionada no es de digitos o la tecla backspace
            {
                e.Handled = true; // se ignora la tecla
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RelevantDigits.Text) || (DocType.SelectedItem == null))
            {
                // Indicarle al usuario que no lleno algunos de los campos de datos de codigo
                MessageBox.Show("Inserte el resto de los datos", "Error en codigo"); //mostrar ventana de error
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

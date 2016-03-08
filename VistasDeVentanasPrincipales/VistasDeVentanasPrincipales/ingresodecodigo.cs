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
    public partial class ingresodecodigo : Form
    {
        public ingresodecodigo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
            {
                // cancel the "paste" function
                e.SuppressKeyPress = true;
            }

            if (!char.IsDigit(e.KeyChar) && (!e.Control))
            {
                e.Handled = true;
            }

        }
    }
}

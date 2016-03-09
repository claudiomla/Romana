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
    public partial class AddOperationCode : Form
    {
        public AddOperationCode()
        {
            InitializeComponent();
        }

        // Validar que el cuadro de texto RelevantCode solo permita el ingreso de numeros enteros
        // y habilitacion de la tecla Backspace.
        private void RelevantCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        // Habilitacion de las teclas de movimiento arriba,abajo,izquierda,derecha y borrar.
        private void RelevantCode_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                case Keys.Delete:
                    e.SuppressKeyPress = false;
                    return;
                default:
                    break;
            }
        }
    }
}

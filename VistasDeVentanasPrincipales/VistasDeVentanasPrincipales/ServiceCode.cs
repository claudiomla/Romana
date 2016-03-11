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
    public partial class ServiceCode : Form
    {
        public ServiceCode()
        {
            InitializeComponent();
        }

        private void SerTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back)) // si la tecla presionada no es de digitos o la tecla backspace
            {
                e.Handled = true; // se ignora la tecla
            }
        }

        private void SerTicket_KeyDown(object sender, KeyEventArgs e)
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckTicketButton_Click(object sender, EventArgs e)
        {
            PopupSearchSerTicket popup = new PopupSearchSerTicket();
            popup.ShowDialog();
        }
    }
}

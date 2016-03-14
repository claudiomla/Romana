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
    public partial class SMNewService : Form
    {
        public SMNewService()
        {
            InitializeComponent();
        }
        //validacion de la cedula
        private void textCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        // validacion de la cedula
        private void textCard_KeyDown(object sender, KeyEventArgs e)
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
        // verificar que ningun campo este vacio
        private void Register_Click(object sender, EventArgs e)
        {
            if ((!(string.IsNullOrEmpty(textClient.Text))) && (!(string.IsNullOrEmpty(textCard.Text))) && (!(string.IsNullOrEmpty(textPlate.Text))) && (!(string.IsNullOrEmpty(textDriver.Text))) && (!(string.IsNullOrEmpty(textRif.Text))) && (!(string.IsNullOrEmpty(textVehicle.Text)))) 
            {

                

            }
            else
            {

                MessageBox.Show("\t      Verifique: \n\n Ningun campo CI,Nombre,Rif,Cliente,Vehiculo y Placa esten vacios.");

            }
        }

      
    }
}

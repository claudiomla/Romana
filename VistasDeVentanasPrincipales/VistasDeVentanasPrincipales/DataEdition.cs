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
    public partial class DataEdition : Form
    {
        Boolean check = false;  //probando

        Boolean check2 = false;  //probando


        Boolean check3 = false;  //probando

        public DataEdition()
        {
            InitializeComponent();
        }


        private void textBoxcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxcode_KeyDown(object sender, KeyEventArgs e)
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

        private void textBoxcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxcard_KeyDown(object sender, KeyEventArgs e)
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

        private void Modify1_Click(object sender, EventArgs e)
        {    // verifica que ningun campo este vacio
            if ((!(string.IsNullOrEmpty(textBoxcode.Text))) && !(TypeDocument.SelectedItem == null) && (!(string.IsNullOrEmpty(textBoxcard.Text))) && (!(string.IsNullOrEmpty(textBoxName.Text))) && (!(string.IsNullOrEmpty(textBoxplate.Text))) && (!(string.IsNullOrEmpty(textBoxModel.Text))))
            {
                if (!check)
                {


                }


            }
            else {
                MessageBox.Show("Ningun campo ,Correlativo, Codigo,CI,Conductor,Placa y Vehiculo puede estar vacio.", "Verifique:");
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
     
}

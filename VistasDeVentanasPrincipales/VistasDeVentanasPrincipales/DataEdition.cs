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
        {

            if ((!(string.IsNullOrEmpty(textBoxcode.Text))) && !(TypeDocument.SelectedItem == null))//verificar que el tipo de documento y el codigo no esten vacios
            {
                if (!check)
                {


                }


            }
            else {
                MessageBox.Show("\t      Verifique: \n\n Ningun campo ,tipo de documento o Codigo pueden estar vacio.");
            }
        }

        private void Modify2_Click(object sender, EventArgs e)
        {
            if ((!(string.IsNullOrEmpty(textBoxcard.Text))) && (!(string.IsNullOrEmpty(textBoxName.Text))))  //verificar que la cedula que la cedula y el nombre no esten vacios
            {

                if (!check2)
                {


                }



            }
            else
            {

                MessageBox.Show("\t      Verifique: \n\n Ningun campo CI o Nombre esten vacios.");

            }
        }

        private void Modify3_Click(object sender, EventArgs e)
        {
            if ((!(string.IsNullOrEmpty(textBoxplate.Text))) && (!(string.IsNullOrEmpty(textBoxModel.Text))))  //verificar que la cedula que la cedula y el nombre no esten vacios
            {

                if (!check3)
                {


                }



            }
            else
            {

                MessageBox.Show("\t      Verifique: \n\n Ningun campo placa o modelo esten vacios.");

            }
        }
    }
     
}

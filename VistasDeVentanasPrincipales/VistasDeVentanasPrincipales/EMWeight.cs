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
    public partial class EMWeight : Form
    {
        public static Boolean checke;
        public EMWeight()
        {
            InitializeComponent();
        }

        private void Hour_TextChanged(object sender, EventArgs e)
        { 


        }



        public void un() { checkBoxMANUAL.Checked = false; }

        private void checkBoxMANUAL_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkBoxMANUAL.Checked == true)
            {
                PopupAdmin popup = new PopupAdmin();
                popup.ShowDialog();
            }

            if (!checke)
            {
                checkBoxMANUAL.Checked = false;
            }         

        }
    }
}

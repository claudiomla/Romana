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
    public partial class DisplaydataEweighIN : Form
    {
        public static Boolean checke;
        public DisplaydataEweighIN()
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
                PopupActivateManualEdition popup = new PopupActivateManualEdition();
                popup.ShowDialog();
            }

            if (!checke)
            {
                checkBoxMANUAL.Checked = false;
            }         

        }
    }
}

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
    public partial class SMOldService : Form
    {
        public Boolean checke;

        public SMOldService()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void checkBoxMANUAL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMANUAL.Checked == true){
                PopupAdmin popup = new PopupAdmin();
                popup.ShowDialog();
            }

            if (!checke){
                checkBoxMANUAL.Checked = false;
            }         
        }

       

               
    }
}

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
    public partial class EntryVehicleTD : Form
    {
        Boolean check1=false;  //boolean para saber si el chofer esta registrado o no.

        public EntryVehicleTD()
        {
            InitializeComponent();
        }

        private void checkTD_Click(object sender, EventArgs e)
        {
            
            String CI= CITD.Text;
            String typeCI = TypeCI.SelectedItem.ToString();


            if (true/*verificar que los campos no esten vacios*/)
            {

                //verificar en la base de datos si se encuentra la cedula del conductor

                if (/* si el nombre esta en la base de datos*/ true)
                {
                    check1 = true;
                }
                else
                {
                    //
                }

            }
            
        }

        

        
    }
}

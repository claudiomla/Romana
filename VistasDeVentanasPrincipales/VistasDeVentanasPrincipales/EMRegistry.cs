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
    public partial class EMRegistry : Form
    {
        Boolean check1=false;  //boolean para saber si el chofer esta registrado o no.
        Boolean check2 = false; //verifica si el camion esta agregado o no.

        public EMRegistry()
        {
            InitializeComponent();
        }

        

        private void checkTD_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(CITD.Text) || string.IsNullOrEmpty(TypeCI.SelectedItem.ToString()))){  //los datos no pueden estar vacios en la cedula
                

                //verificar en la base de datos si se encuentra la cedula del conductor

                if (/* si el nombre esta en la base de datos*/ true)
                {
                    check1 = true;
                }else{
                    this.notice1.Visible = true; //notifica que el campo cedula o tipo esta vacio.
                }

            }else{
                MessageBox.Show("\t      Verifique: \n\n Ingrese el Tipo y Número de Cedula.");
            }
            
        }

        private void checkVehicle_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(Plate.Text)))
            {

                //verificar en la base de datos si se encuentra la cedula del conductor

                if (/* si el nombre esta en la base de datos*/ true)
                {
                    check2 = true;
                }
                else
                {
                    this.notice2.Visible = true; //notificar que el campo placa esta vacio
                }


            }else{
                MessageBox.Show("\tVerifique: \n\n Ingrese la Placa del Vehiculo.");
            }

        }

        private void CITD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(CITD.Text) || string.IsNullOrEmpty(TypeCI.SelectedItem.ToString()) || string.IsNullOrEmpty(Plate.Text) || string.IsNullOrEmpty(ModelVehicle.Text)))
            {
		         if (!check1){
                        //guardar nuevo chofer
                
                 }
                 if (!check2){
                     //guardar nuevo vehiculo 
                 }
                
            }else{
                MessageBox.Show("\t      Verifique: \n\n Ningun campo puede estar vacio.");
            }
            
        }

  

        

        
    }
}

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
    public partial class TicketReport : Form
    {
        public TicketReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                PDF.LoadFile(@"‪C:\Users\GM66\Desktop\04_verbos.pdf");
          
 
        }
    }
}

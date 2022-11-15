using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ricerca_Operativa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //costi = c;
        }

        private void lsB_Costi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void carica(int costo, int pezzi, int CostoU)
        {
            //FINIRE E AGGIUNGERE MINIMI COSTI
            int c = pezzi * CostoU;
            lsB_Costi.Items.Add(pezzi+"*"+costo+"="+CostoU);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

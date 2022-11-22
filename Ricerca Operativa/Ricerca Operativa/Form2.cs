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
        }

        private void lsB_Costi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        int tot = 0;
        public void carica(int costo, int pezzi, int CostoU)
        {
            if (costo == -3)
            {
                lsB_Costi.Items.Clear();
                CostoU = 0;
            }
            else if (costo == -1)
            {
                lsB_Costi.Items.Add("Totale: "+tot);
                tot = 0;
                lsB_Costi.Items.Add(" ");
                lsB_Costi.Items.Add("MINIMI COSTI");
            }
            else if(costo == -2)
            {
                lsB_Costi.Items.Add("Totale: " + tot);
                tot = 0;
            }else
            {
                int c = pezzi * CostoU;
                tot = tot + c;
                lsB_Costi.Items.Add(pezzi + " X " + CostoU + "" + " = " + c);
            }
           
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            lsB_Costi.Items.Add("NORD OVEST");
            this.ControlBox = false;
        }


        private void Rj_Chiudi_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

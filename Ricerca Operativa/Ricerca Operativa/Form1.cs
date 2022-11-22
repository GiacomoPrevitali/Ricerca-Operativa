using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ricerca_Operativa
{
    public partial class RicercaOperativa : Form
    {
        DataTable table;
        bool ok = true;
        int nColonne=0;
        bool crea = false;
        bool primo=false;
        int costo = 0;
        int pezzi = 0;
        bool full = false;
        Form2 f = new Form2();

        public RicercaOperativa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tabella.RowHeadersVisible = false;
            Tabella.AllowUserToAddRows = false;
            Tabella.AllowUserToOrderColumns = false;
            Tabella.AllowUserToResizeRows = false;
            Tabella.AllowUserToResizeColumns = false;  
        }

        private void creaTabella()
        {

            //ADATTARE LA TABLE GRID AL NUMERO DI COLONNE E ALLA DIMENSIONE DELLA FORM
            //problema scrittura nelle righe datagrid view non risolto anche se lo pensi
             table = new DataTable();
            Tabella.DataSource = table;

            table.Columns.Add(" ");
            for (int i = 0; i < Convert.ToInt32(nUD_Colonne.Text); i++)
            {
             table.Columns.Add("Deposito " + (i + 1));
            }
            table.Columns.Add("Totali");

            for (int i = 1; i <= Convert.ToInt32(nUD_Righe.Text); i++)
            {
                table.Rows.Add("Unità Produttive " + (i));

            }
               
            table.Rows.Add("Totali");
            
            table.Columns[0].ReadOnly = true;
            foreach(DataGridViewColumn t in Tabella.Columns)
            {
                t.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            nColonne = table.Columns.Count;
        }


        //FARE TEST-------------------------------------------------------



       public void pieno()
        {
            int c = 0;
           
                for (int i = 1; i <= Convert.ToInt32(nUD_Colonne.Text); i++)
                {
                    for (int j = 0; j < Convert.ToInt32(nUD_Righe.Text); j++)
                    {
                        if (Convert.ToString(Tabella[i, j].Value) == "")
                        {
                            c++;
                        }
                    }
                }
                if (c == 0)
                {
                    ok = true;
                    full= true;
                }
                else
                {
                    ok = false;
                    full = false;
                }
                if (ok == false)
                {
                    MessageBox.Show("Nella tabella sono presenti uno o più campi privi di valore", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        public void somme()
        {
            int sommaR = 0;
            int sommaC = 0;
            int tmp = 0;
            if (ok)
            {
                for (int i = 1; i <= Convert.ToInt32(nUD_Colonne.Text); i++)
                {
                    tmp = Convert.ToInt32(Tabella[i, Convert.ToInt32(nUD_Righe.Text)].Value);
                    sommaR = sommaR + tmp;

                }

                for (int i = 0; i < Convert.ToInt32(nUD_Righe.Text); i++)
                {
                    tmp = Convert.ToInt32(Tabella[(Convert.ToInt32(nUD_Colonne.Text) + 1), i].Value);
                    sommaC = sommaC + tmp;
                }
                if (sommaR == sommaC)
                {
                    ok = true;
                    if (sommaC == Convert.ToInt32(Tabella[(Convert.ToInt32(nUD_Colonne.Text) + 1), Convert.ToInt32(nUD_Righe.Text)].Value) && sommaR == Convert.ToInt32(Tabella[(Convert.ToInt32(nUD_Colonne.Text) + 1), Convert.ToInt32(nUD_Righe.Text)].Value))
                    {
                        ok = true;
                    }else
                    {
                        ok = false;
                        MessageBox.Show("il totale dei pezzi inserito non è corretto!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ok = false;
                    MessageBox.Show("La somma dei prodotti nel magazzino e quelli richiesti non coincidono!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        public void Max()
        {
            int h = 0;
            if (full)
            {
                for (int i = 1; i <= Convert.ToInt32(nUD_Colonne.Text) + 1; i++)
                {
                    for (int j = 0; j <= Convert.ToInt32(nUD_Righe.Text); j++)
                    {
                        try
                        {
                            h = Convert.ToInt32(Tabella[i, j].Value);
                        }
                        catch
                        {
                            ok = false;
                        }
                    }
                }
                if (!ok)
                {
                    MessageBox.Show("Nella tabella è presente un valore troppo alto", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        //Algoritmi
        public void NordOvest(int colonne, int righe)
        {
           
            while (righe != 0 && colonne != 0)
            {
                if (Convert.ToInt32(Tabella[colonne, 0].Value) > Convert.ToInt32(Tabella[1, righe].Value))
                {
                    pezzi = Convert.ToInt32(Tabella[1, righe].Value);
                    costo = costo + Convert.ToInt32(Tabella[1, 0].Value) * Convert.ToInt32(Tabella[1, righe].Value);
                    f.carica(costo, pezzi, Convert.ToInt32(Tabella[1, 0].Value));
                    Tabella.Columns.Remove(Tabella.Columns[1]);
                    colonne--;
                    Tabella[colonne, 0].Value = Convert.ToInt32(Tabella[colonne, 0].Value) - pezzi;
                    Tabella[colonne, righe].Value = Convert.ToInt32(Tabella[colonne, righe].Value) - pezzi;
                   
                }
                else
                {
                    pezzi = Convert.ToInt32(Tabella[colonne, 0].Value);
                    costo = costo + Convert.ToInt32(Tabella[1, 0].Value) * Convert.ToInt32(Tabella[colonne, 0].Value);
                    f.carica(costo, pezzi, Convert.ToInt32(Tabella[1, 0].Value));
                    Tabella.Rows.Remove(Tabella.Rows[0]);
                    righe--;
                    Tabella[1, righe].Value = Convert.ToInt32(Tabella[1, righe].Value) - pezzi;
                    Tabella[colonne, righe].Value = Convert.ToInt32(Tabella[colonne, righe].Value) - pezzi;
                    
                }
                Application.DoEvents();
                Thread.Sleep(500);
            }
            f.carica(-1, -1, costo);
        }
        private void minimo()
        {

            int costo = 0;
            int pezzi = 0;
            int colonne = Convert.ToInt32(nUD_Colonne.Text) + 1;
            int righe = Convert.ToInt32(nUD_Righe.Text);

            while (righe != 0 && colonne != 0)
            {
                int min = 100000000;
                int x = 0;
                int y = 0;
                for (int i = 1; i < Convert.ToInt32(colonne); i++)
                {
                    for (int j = 0; j < Convert.ToInt32(righe); j++)
                    {
                        if (Convert.ToInt32(Tabella[i, j].Value) == min)
                        {
                            int c1 = 0;
                            int c2 = 0;
                            if (Convert.ToInt32(Tabella[colonne, y].Value) > Convert.ToInt32(Tabella[x, righe].Value))
                            {
                                c1 = Convert.ToInt32(Tabella[x, righe].Value);
                            }
                            else
                            {
                                c1 = Convert.ToInt32(Tabella[colonne, y].Value);
                            }
                            if (Convert.ToInt32(Tabella[colonne, j].Value) > Convert.ToInt32(Tabella[i, righe].Value))
                            {
                                c2 = Convert.ToInt32(Tabella[i, righe].Value);
                            }
                            else
                            {
                                c2 = Convert.ToInt32(Tabella[colonne, j].Value);
                            }
                            if (c1 < c2)
                            {
                                x = i;
                                y = j;
                            }
                        }
                        else if (Convert.ToInt32(Tabella[i, j].Value) < min)
                        {

                            min = Convert.ToInt32(Tabella[i, j].Value);
                            x = i;
                            y = j;
                        }
                    }
                }

                if (Convert.ToInt32(Tabella[colonne, y].Value) > Convert.ToInt32(Tabella[x, righe].Value))
                {
                    pezzi = Convert.ToInt32(Tabella[x, righe].Value);
                    costo = costo + Convert.ToInt32(Tabella[x, y].Value) * Convert.ToInt32(Tabella[x, righe].Value);
                    f.carica(costo, pezzi, Convert.ToInt32(Tabella[x, y].Value));
                    Tabella.Columns.Remove(Tabella.Columns[x]);
                    colonne--;
                    Tabella[colonne, y].Value = Convert.ToInt32(Tabella[colonne, y].Value) - pezzi;
                    Tabella[colonne, righe].Value = Convert.ToInt32(Tabella[colonne, righe].Value) - pezzi;
                }
                else
                {
                    pezzi = Convert.ToInt32(Tabella[colonne, y].Value);
                    costo = costo + Convert.ToInt32(Tabella[x, y].Value) * Convert.ToInt32(Tabella[colonne, y].Value);
                    f.carica(costo, pezzi, Convert.ToInt32(Tabella[x, y].Value));
                    Tabella.Rows.Remove(Tabella.Rows[y]);
                    righe--;
                    Tabella[x, righe].Value = Convert.ToInt32(Tabella[x, righe].Value) - pezzi;
                    Tabella[colonne, righe].Value = Convert.ToInt32(Tabella[colonne, righe].Value) - pezzi;
                }
                Application.DoEvents();
                Thread.Sleep(500);
            }
            f.carica(-2, -2, costo);
        }

       
        private void riempi()
        {
            int somma=0;
            int random = 0;
            bool big=false;
            Random r = new Random();
            if (Convert.ToInt32(nUP_max.Text) >=Convert.ToInt32( nUP_Min.Text))
            {
                big=true;
            }
            else
            {
                big=false;
                primo = true;
                MessageBox.Show("Intervallo dei costi non corretto", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (big)
            {
                for (int i = 1; i <= Convert.ToInt32(nUD_Colonne.Text); i++)
                {
                    for (int j = 0; j < Convert.ToInt32(nUD_Righe.Text); j++)
                    {
                        Tabella[i, j].Value = Convert.ToInt32(r.Next(Convert.ToInt32(nUP_Min.Text), Convert.ToInt32(nUP_max.Text)));
                    }
                }


                for (int i = 1; i <= Convert.ToInt32(nUD_Colonne.Text); i++)
                {
                    random = Convert.ToInt32(r.Next(50, 200));
                    Tabella[i, Convert.ToInt32(nUD_Righe.Text)].Value = random;
                    somma = somma + random;
                }
                Tabella[Convert.ToInt32(nUD_Colonne.Text) + 1, Convert.ToInt32(nUD_Righe.Text)].Value = somma;
                int calcolo = 0;
                int media = 0;
                int diff = 0;
                bool controllo = true;
                if (Convert.ToInt32(nUD_Righe.Text) > 1)
                {
                    media = somma / (Convert.ToInt32(nUD_Righe.Text) - 1);

                }
                if (media < 10)
                {
                    media = 11;

                }

                for (int j = 0; j < Convert.ToInt32(nUD_Righe.Text) - 1; j++)
                {


                    random = Convert.ToInt32(r.Next(media - ((media / 10) * 5), (media + diff)));
                    ;
                    if (controllo == true)
                    {
                        diff = media - random;
                    }
                    else
                    {
                        diff = 0;
                    }
                    controllo = !controllo;
                    Tabella[Convert.ToInt32(nUD_Colonne.Text) + 1, j].Value = random;
                    calcolo = calcolo + random;

                }

                Tabella[Convert.ToInt32(nUD_Colonne.Text) + 1, Convert.ToInt32(nUD_Righe.Text) - 1].Value = somma - calcolo;
            }
        }
        private void ricrea(int[,] t)
        {
            for (int i = 1; i <= Convert.ToInt32(nUD_Colonne.Text) + 1; i++)
            {
                for (int j = 0; j <= Convert.ToInt32(nUD_Righe.Text); j++)
                {
                    Tabella[i, j].Value = t[i, j];
                }
            }

        }
      
        private void Tabella_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dgw_matrice_KeyPress);
            TextBox tb = e.Control as TextBox;
            tb.ShortcutsEnabled = false;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(dgw_matrice_KeyPress);
            }
        }
        private void dgw_matrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Buttons
        private void Rj_CreaTabella_Click(object sender, EventArgs e)
        {
            try
            {
                if (crea == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Creando una nuova tabella i dati attuali verrano cancellati \n Vuoi continuare?", "Avvertimento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        creaTabella();
                    }
                }
                else
                {
                    creaTabella();
                    crea = true;

                }
                primo = true;
                this.Tabella.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch
            {
                MessageBox.Show("Ops, Qualcosa è andato storto \n Riprova.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Rj_Avvia_Click(object sender, EventArgs e)
        {
            try
            {
                int r, c;

                r = (Convert.ToInt32(nUD_Righe.Text) + 1);
                c = (Convert.ToInt32(nUD_Colonne.Text) + 2);
                int[,] t = new int[c, r];
                if (crea)
                {
                    pieno();
                    Max();
                    somme();


                    if (ok == true)
                    {
                        f.carica(-3, -3, -3);
                        Tabella.ReadOnly = true;
                        for (int i = 1; i <= Convert.ToInt32(nUD_Colonne.Text) + 1; i++)
                        {
                            for (int j = 0; j <= Convert.ToInt32(nUD_Righe.Text); j++)
                            {
                                t[i, j] = Convert.ToInt32(Tabella[i, j].Value);
                            }
                        }

                        int colonne = Convert.ToInt32(nUD_Colonne.Text) + 1;
                        int righe = Convert.ToInt32(nUD_Righe.Text);

                        f.Show();
                        NordOvest(colonne, righe);

                        creaTabella();
                        ricrea(t);
                        minimo();

                        creaTabella();
                        ricrea(t);
                    }
                }
                else
                {
                    MessageBox.Show("Tabella inesistente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Tabella.ReadOnly = false;
            }
            catch
            {
                MessageBox.Show("Ops, Qualcosa è andato storto \n Riprova.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void rJ_Riempi_Click(object sender, EventArgs e)
        {
            try
            {
                if (!crea)
                {
                    MessageBox.Show("Tabella inesistente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (primo)
                    {
                        if (crea == true)
                        {
                            riempi();
                        }
                        else
                        {
                            MessageBox.Show("Tabella inesistente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        primo = false;
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Proseguendo se sono presenti dei dati all'interno della tabella verranno cancellati \n Vuoi continuare?", "Avvertimento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            riempi();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ops, Qualcosa è andato storto \n Riprova.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        DataTable table;
        //bool first = false;
        bool ok = true;
        int nColonne=0;
        bool crea = false;
        bool primo=false;
        int costo = 0;
        int pezzi = 0;
        Form2 f = new Form2();

        public Form1()
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
            //TOGLIERE USATO SOLO PER TEST
            //creaTabella();
            //riempi();
          
        }
        private void creaTabella()
        {
            //Inserire controllo sul numero, se si scrive <2 cancellare e risrivere 2
            //ADATTARE LA TABLE GRID AL NUMERO DI COLONNE E ALLA DIMENSIONE DELLA FORM
            //RICORDARE RIMETTERE LE TXT NEI FOR!!-
            //problema scrittura nelle righe datagrid view non risolto anche se lo pensi
            //fare controllo su creazione nuov tabella e perdita vecchi dati
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
            //first = true;
            nColonne = table.Columns.Count;
        }


        private void Btn_CreaTabella_Click(object sender, EventArgs e)
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
        }
        //Cambiare-----------------------------
       public void pieno()
        {
            int c = 0;
            for (int i = 1; i <= Convert.ToInt32(nUD_Colonne.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt32(nUD_Righe.Text); j++)
                {
                    //problema
                    if (Convert.ToString(Tabella[i, j].Value) == "")
                    {
                       // ok = false;
                        c++;


                    }
                }
            }
            if (c == 0)
            {
                ok = true;
            }
            else
            {
                ok = false;
            }
            if(ok== false)
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
        public void NordOvest(int colonne, int righe)
        {
           
            while (righe != 0 && colonne != 0)
            {
                if (Convert.ToInt32(Tabella[colonne, 0].Value) > Convert.ToInt32(Tabella[1, righe].Value))
                {
                    pezzi = Convert.ToInt32(Tabella[1, righe].Value);
                    costo = costo + Convert.ToInt32(Tabella[1, 0].Value) * Convert.ToInt32(Tabella[1, righe].Value);
                    Tabella.Columns.Remove(Tabella.Columns[1]);
                    colonne--;
                    Tabella[colonne, 0].Value = Convert.ToInt32(Tabella[colonne, 0].Value) - pezzi;
                    Tabella[colonne, righe].Value = Convert.ToInt32(Tabella[colonne, righe].Value) - pezzi;
                    f.carica(costo, pezzi, Convert.ToInt32(Tabella[1, 0].Value));
                }
                else
                {
                    pezzi = Convert.ToInt32(Tabella[colonne, 0].Value);
                    costo = costo + Convert.ToInt32(Tabella[1, 0].Value) * Convert.ToInt32(Tabella[colonne, 0].Value);
                    Tabella.Rows.Remove(Tabella.Rows[0]);
                    righe--;
                    Tabella[1, righe].Value = Convert.ToInt32(Tabella[1, righe].Value) - pezzi;
                    Tabella[colonne, righe].Value = Convert.ToInt32(Tabella[colonne, righe].Value) - pezzi;
                    f.carica(costo, pezzi, Convert.ToInt32(Tabella[1, 0].Value));
                }
                // f.costi = costo;
                // MessageBox.Show(Convert.ToString(costo));
                Application.DoEvents();
                Thread.Sleep(500);
            }
        }
        private void btn_AVVIA_Click(object sender, EventArgs e)
        {
            f.Show();
            int r, c;
            
            r = (Convert.ToInt32(nUD_Righe.Text) + 1);
            c = (Convert.ToInt32(nUD_Colonne.Text) + 2);
            int[,] t = new int[c, r];
            if (crea)
            {
              
                //ok = true;
                //FARE TEST SU CONTROLLO DATI MINIMI COSTI
                //Mettere controllo numero minore da messaggio errore 26/10
                //FARE CONTROLLO RIEMPIMENTO TUTTE LE CELLE!!!
                //modificare controllo Tutte le celle anche totali
                //VEDERE ERRORE SU RIGHE E COLONNE VUOTE!!!!
                /*for (int i = 1; i <= Convert.ToInt32(nUD_Colonne.Text); i++)
                {
                    for (int j = 0; j < Convert.ToInt32(nUD_Righe.Text); j++)
                    {
                //problema
                        if (Convert.ToString(Tabella[i, j].Value) == "")
                        {
                            ok = false;
 
                        }  
                    }
                }*/
                pieno();
                somme();


                if (ok == true)
                {
                    Tabella.ReadOnly = true;
                    for (int i = 1; i <= Convert.ToInt32(nUD_Colonne.Text) + 1; i++)
                    {
                        for (int j = 0; j <= Convert.ToInt32(nUD_Righe.Text); j++)
                        {
                            //FARE TEST RIEMPI
                            t[i, j] = Convert.ToInt32(Tabella[i, j].Value);
                        }
                    }
                   
                    int colonne = Convert.ToInt32(nUD_Colonne.Text) + 1;
                    int righe = Convert.ToInt32(nUD_Righe.Text);
                    
                    
                    NordOvest(colonne, righe);
                    //FARE CONTROLLO SU CASELLE TUTTE PIENE
                    f.Show();
                    creaTabella();
                    ricrea(t);
                    MessageBox.Show("minimi in futuro");
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
        private void riempi()
        {
            //fare controllo massimo maggiore minimo
            int somma=0;
            int random = 0;
            Random r = new Random();
             for(int i = 1; i <= Convert.ToInt32(nUD_Colonne.Text); i++)
             {
                 for (int j = 0; j < Convert.ToInt32(nUD_Righe.Text); j++)
                 {
                  //FARE TEST RIEMPI
                     Tabella[i, j].Value = Convert.ToInt32(r.Next(Convert.ToInt32(nUP_Min.Text), Convert.ToInt32(nUP_max.Text)));
                 }
             }

           
           for(int i=1; i<= Convert.ToInt32(nUD_Colonne.Text); i++)
            {
                //Controllo sulla creazione della tabella quando si riempiono gli spazi
                random= Convert.ToInt32(r.Next(50,200));
              //  MessageBox.Show(Convert.ToString(random));
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
                media= somma / (Convert.ToInt32(nUD_Righe.Text) - 1);

            }
            if (media < 10)
            {
                media = 11;
              
            }
                   //RIVEDEREEEEEE

            for (int j = 0; j < Convert.ToInt32(nUD_Righe.Text) - 1; j++)
                {
                
                
                    random = Convert.ToInt32(r.Next(media-((media/10)*5), (media+diff)));
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
            
            Tabella[Convert.ToInt32(nUD_Colonne.Text) + 1, Convert.ToInt32(nUD_Righe.Text)-1].Value = somma-calcolo;

            //creaTabella();
           /*
             Tabella[1,0].Value = 10;
             Tabella[1,1].Value = 15;
             Tabella[1,2].Value = 20;
             Tabella[1,3].Value = 100;

             Tabella[2, 0].Value = 12;
             Tabella[2, 1].Value = 30;
             Tabella[2, 2].Value = 35;
             Tabella[2, 3].Value = 120;

             Tabella[3, 0].Value = 80;
             Tabella[3, 1].Value = 40;
             Tabella[3, 2].Value = 30;
             Tabella[3, 3].Value = 90;

             Tabella[4, 0].Value = 30;
             Tabella[4, 1].Value = 45;
             Tabella[4, 2].Value = 20;
             Tabella[4, 3].Value = 50;

             Tabella[5, 0].Value = 50;
             Tabella[5, 1].Value = 60;
             Tabella[5, 2].Value = 50;
             Tabella[5, 3].Value = 150;

             Tabella[6, 0].Value = 200;
             Tabella[6, 1].Value = 150;
             Tabella[6, 2].Value = 160;
             Tabella[6, 3].Value = 510;*/

        }
       
        private void btn_Test_Click(object sender, EventArgs e)
        {
            //MODIFICAREEEEE
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

        private void ricrea(int[,] t)
        {
            for (int i = 1; i <= Convert.ToInt32(nUD_Colonne.Text) + 1; i++)
            {
                for (int j = 0; j <= Convert.ToInt32(nUD_Righe.Text); j++)
                {
                    //FARE TEST RIEMPI
                    Tabella[i, j].Value = t[i, j];
                    //MessageBox.Show(Convert.ToString(t[i, j]));
                }
            }

        }
        private void minimo()
        {

            int costo = 0;
            int pezzi = 0;
            int colonne = Convert.ToInt32(nUD_Colonne.Text) + 1;
            int righe = Convert.ToInt32(nUD_Righe.Text);
            //FARE CONTROLLO SU CASELLE TUTTE PIENE

            while (righe != 0 && colonne != 0)
            {
                //minimo();
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
                    Tabella.Columns.Remove(Tabella.Columns[x]);
                    colonne--;
                    Tabella[colonne, y].Value = Convert.ToInt32(Tabella[colonne, y].Value) - pezzi;
                    Tabella[colonne, righe].Value = Convert.ToInt32(Tabella[colonne, righe].Value) - pezzi;
                }
                else
                {
                    pezzi = Convert.ToInt32(Tabella[colonne, y].Value);
                    costo = costo + Convert.ToInt32(Tabella[x, y].Value) * Convert.ToInt32(Tabella[colonne, y].Value);
                    Tabella.Rows.Remove(Tabella.Rows[y]);
                    righe--;
                    Tabella[x, righe].Value = Convert.ToInt32(Tabella[x, righe].Value) - pezzi;
                    Tabella[colonne, righe].Value = Convert.ToInt32(Tabella[colonne, righe].Value) - pezzi;
                }

                Application.DoEvents();
                Thread.Sleep(500);
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




        //CONTROLLARE COMMENTI PROGETTO A SCUOLA
        //nUp check se entro toglere 0
    }
}

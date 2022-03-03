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
using System.Drawing.Imaging;

namespace Progetto_TPSIT_2022
{
    public partial class Form1 : Form
    {
        List<Torre> lstT = new List<Torre>();
        int[] Attaccato = new int[4];
        int atk = 3;  //indice massimo dell'array Attaccato
        Random rnd = new Random();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            StartDelGioco();
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Torre t = (Torre)e.Argument;
            BackgroundWorker bgw = (BackgroundWorker)sender;
            //Menù m = new Menù();
            do
            {
               lock (Attaccato)
               {
                  //do
                  //{
                  //    Thread.Sleep(100);
                  //} while (m.Focused==true); tentativo del tasto pausa
                  Thread.Sleep(500);

                  //Verifico se ho subito un attacco
                  for (int i = 0; i < 3; i++)
                  {
                     if (lstT[i].ID == Attaccato[atk])
                     {
                          lstT[i].PS -= 1;
                     }
                  }

                  //Dopo aver modificato i punti salute verifico se sono ancora in gioco, e successivamente attacco
                  Thread.Sleep(500);
                  if (t.PS >= 0)
                  {
                        atk = rnd.Next(0, 4);  // le posizioni dell'array: 0 = torre 1 | 1 = torre 2 | 2 =torre 3
                        Thread.Sleep(1000);
                         bgw.ReportProgress(Attaccato[atk], t);
                  }

                    if (bgw.CancellationPending)
                    {
                       e.Cancel = true; return;
                    }

                  Thread.Sleep(700);

               }
            } while (t.PS > 0);
            
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Torre t = (Torre)e.UserState;
            int attaccato = e.ProgressPercentage;
            t.pb.Value = t.PS;
            Image img = t.PicBox.Image;

            //nel caso in cui il random dovesse generare il proprio id si ha un attacco mancato
            if (attaccato == t.ID)  
            {
                atk = 3;  // nell'array la posizione 3 equivale al valore 4, il quale non corrisponde con nessuna torre
                tbAttaccante.Text = "Torre " + t.ID.ToString();
                tbAttaccato.Text = "MANCATO"; //se si verifica un attacco a vuoto stampo "MANCATO" nella textbox "attaccato"
            }

            //quando non si verifica un attacco a vuoto
            else if (attaccato != 4)  
            {
                tbAttaccante.Text = "Torre " + t.ID.ToString();      //visualizzazione attaccante e attaccato
                tbAttaccato.Text = "Torre " + attaccato.ToString();
                //HitEffect(lstT[atk], EffectPb);   
            }

            //se la torre è eliminata cambio immagine caricandola da un file
            if (t.PS == 0)
            {
                t.tb.Text = "ELIMINATA";
                t.PicBox.Image = Image.FromFile("X.png"); //immagine di una torre distrutta
            }
            else t.tb.Text = t.PS.ToString(); //visualizza vita nella textbox

            #region test verifica vittoria

            if (lstT[0].PS > 0 && lstT[1].PS <= 0 && lstT[2].PS <= 0)
            {
                tbVincente.Text = "HA VINTO LA TORRE " + lstT[0].ID.ToString();
            }
            else if (lstT[1].PS > 0 && lstT[0].PS <= 0 && lstT[2].PS <= 0)
            {
                tbVincente.Text = "HA VINTO LA TORRE " + lstT[1].ID.ToString();
            }
            else if (lstT[2].PS > 0 && lstT[1].PS <= 0 && lstT[0].PS <= 0)
            {
                tbVincente.Text = "HA VINTO LA TORRE " + lstT[2].ID.ToString();
            }
            #endregion test verifica vittoria

        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            bgw1.CancelAsync();
            bgw2.CancelAsync();
            bgw3.CancelAsync();
        }   // bottone stop

        public void ResetTotale()
        {
            #region
            //if (bgw1.IsBusy)
            //{
            //    bgw1.CancelAsync();
            //}
            //if (bgw2.IsBusy)
            //{
            //    bgw2.CancelAsync();
            //}
            //if (bgw3.IsBusy)
            //{
            //    bgw3.CancelAsync();
            //}
            #endregion

            //imposto atk =0 così non attaccherò nessuno
            atk = 3;
            //for (int i = 0; i < 4; i++)
            //{
            //    Attaccato[i] = 0;
            //}
            int j = 0;
            do
            {
                lstT[j].PS = 5;
                j++;
                //lstT.Remove(lstT[j]);
            } while (j<3);

            //Resetto le immagini delle torri
            lstT[0].PicBox.Image = Image.FromFile("torre1.png");
            lstT[1].PicBox.Image = Image.FromFile("torre1.png");
            lstT[2].PicBox.Image = Image.FromFile("torregg.png");

            //faccio ripartire i bgw
            bgw1.RunWorkerAsync(lstT[0]);
            bgw2.RunWorkerAsync(lstT[1]);
            bgw3.RunWorkerAsync(lstT[2]);
            Thread.Sleep(500);
               
        }    //metodo per resettare tutto il gioco 
        public void StartDelGioco()
        {
            Torre t1 = new Torre(5, 1, Prg1, PB1, tb1); //torre del giocatore 1
            Torre t2 = new Torre(5, 2, Prg2, PB2, tb2); //torre del giocatore 2
            Torre t3 = new Torre(5, 3, Prg3, PB3, tb3); //torre del giocatore 3
            bgw1.RunWorkerAsync(t1);
            bgw2.RunWorkerAsync(t2);
            bgw3.RunWorkerAsync(t3);
            lstT.Add(t1);
            lstT.Add(t2);
            lstT.Add(t3);

            int j = 1;
            for (int i = 0; i < 4; i++)  //assegno gli id delle torri all'array
            {
                Attaccato[i] = j;
                j++;
            }
        }    // metodo per far iniziare il gioco

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetTotale();
            Thread.Sleep(500);
        }    //bottone che implementa ResetTotale


        #region Test effetto visivo dell'attacco subito
        public void HitEffect(Torre t, PictureBox pb)
        {
            Bitmap myBitMap = (Bitmap)pb.Image;
            //rendo trasparente lo sfondo dell'immagine
            Color BackColor = myBitMap.GetPixel(1, 1);
            myBitMap.MakeTransparent(BackColor);

            pb.Image = myBitMap;
            pb.Location = t.PicBox.Location;
            Thread.Sleep(1200);
            pb.Image = null;
        }
        #endregion
    }
}

using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Paddle picJoueur1, picJoueur2; 
        Balle   picBalle;
        public int point = 0;
        const int longueur = 600;
        const int largeur = 400;
        IPAddress serverAddress = IPAddress.Parse("127.0.0.1");
        TcpClient client = new TcpClient();
        NetworkStream stream;
        Thread th;

        public int vitessex = 3;
        public int vitessey = 3;
        public int intervalTimer = 1;

        public Form1()
        {
            InitializeComponent();
            picJoueur1 = new Paddle(10, 60);
            picJoueur1.Location = new Point(picJoueur1.Width / 2, playground.Height / 2 - picJoueur1.Height / 2);
            playground.Controls.Add(picJoueur1);

            picMilieu.Location = new Point(playground.Width / 2 + picMilieu.Width / 2);
            picPoints.Left = playground.Left + picPoints.Width;
            picJoueur2 = new Paddle(10, 60);
            picJoueur2.Location = new Point(playground.Left - picJoueur2.Width/2, playground.Height / 2 - picJoueur2.Height / 2);
            playground.Controls.Add(picJoueur2);

            Cursor.Hide();
            picBalle = new Balle (7);
            picBalle.Location = new Point(ClientSize.Width / 2 - picBalle.Width / 2, ClientSize.Height / 2 - picBalle.Height / 2); ;
            playground.Controls.Add(picBalle);

            pongTimer.Enabled = true;

            this.Width = largeur;
            this.Height = longueur;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;
          
            picGameover.Visible = false;

            client.Connect(serverAddress, 8001);
            stream = client.GetStream();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pongTimer_Tick(object sender, System.EventArgs e)
        {
            
            picBalle.Left += vitessex;
            picBalle.Top += vitessey;
            
            Collision();
            CollisionP();

           
            //th = new Thread(Networking);
            //th.Start();
            picJoueur1.DeplacementJ1();
           // picJoueur1.Deplauto(vitessex, picBalle, playground);
            picJoueur2.DeplacementJ2(vitessex,picBalle,playground);
        }//Timer

        public void CollisionP()
        {
            if (picBalle.Bounds.IntersectsWith(picJoueur1.Bounds))
            {
               
                vitessex = -vitessex;
                //vitessey = -vitessey;
                point += 1;
                 picPoints.Text = point.ToString();
             }
            
             if (picBalle.Bounds.IntersectsWith(picJoueur2.Bounds))
          {

              vitessex = -vitessex;
              //vitessey = -vitessey;

          }

         }//Collision avec les joueurs
                
        public void Collision()
        {

            if (picBalle.Top <= playground.Top)
            {

                vitessey = -vitessey;

            }
            if (picBalle.Bottom >= playground.Bottom)
            {
                vitessey = -vitessey;
            }
            if (picBalle.Right > playground.Right)
            {
                vitessex = -vitessex;

            }
            if (picBalle.Left < playground.Left)
            {

                //  PongTimer.Enabled = false;
                picGameover.Visible = true;
                pongTimer.Enabled = false;
                string phraseClient = "Game Over votre score est "+point.ToString();

                Networking(phraseClient);

            }


        }//Collision avec les extremités de la surface de jeu

        public void Networking(string p)
        {
            
            

            byte[] sndBytes = new byte[10];
            ASCIIEncoding encoder = new ASCIIEncoding();
            sndBytes = encoder.GetBytes(p);
            stream.Write(sndBytes, 0, p.Length);
            stream.Flush();
        }//communicatipon réseau

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            
            
            if (e.KeyCode == Keys.F1)
            {

                picBalle.resetBall(playground);

                point = 0;
                picPoints.Text = "0";


                picGameover.Visible = false;
                pongTimer.Enabled = true;



            }
        }// restart et quitter

    }
}

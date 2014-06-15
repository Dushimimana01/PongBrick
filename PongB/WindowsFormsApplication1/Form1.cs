using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Paddle picJoueur1, picJoueur2, picBalle;
        Timer PongTimer;
        public int point = 0;
        const int longueur = 600;
        const int largeur = 400;
       IPAddress serverAddress = IPAddress.Parse("127.0.0.1");
        TcpClient client = new TcpClient();
        NetworkStream stream;
        
        
       public int vitessex = 3;
       public int vitessey = 3;
       public int intervalTimer = 1;
        public Form1()
        {
            InitializeComponent();
            picJoueur1 = new Paddle(10,60);
            picJoueur1.Location = new Point(picJoueur1.Width / 2, playground.Height / 2 - picJoueur1.Height / 2);
            playground.Controls.Add(picJoueur1);

            picMilieu.Location = new Point(playground.Width / 2 + picMilieu.Width / 2);
            picPoints.Left = playground.Left + picPoints.Width;
           /*picJoueur2 = new Paddle(10, 60);
            picJoueur2.Location = new Point(playground.Left - picJoueur2.Width/2, playground.Height / 2 - picJoueur2.Height / 2);
            playground.Controls.Add(picJoueur2);*/


            picBalle = new Paddle(7,7);
            picBalle.Location = new Point(playground.Width / 2 - picBalle.Width / 2, playground.Height / 2 - picBalle.Height / 2);
            playground.Controls.Add(picBalle);


 
            PongTimer = new Timer();
 
            PongTimer.Enabled = true;
            PongTimer.Interval = intervalTimer;
 
 
            this.Width = largeur;
            this.Height = longueur;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;
            PongTimer.Tick += new EventHandler(PongTime_Tick);

            picGameover.Visible = false;

            client.Connect(serverAddress, 8001);
            stream = client.GetStream();
        }
        void PongTime_Tick(object sender, EventArgs e)
        {
            picBalle.Left += vitessex;
            picBalle.Top += vitessey;
            Collision();
            Collis();
       
            picJoueur1.DeplacementJ1();
            //picJoueur2.DeplacementJ2(vitessex,picBalle,playground);
            
           
        }

        public void Collis ()
        {
            if (picBalle.Bounds.IntersectsWith(picJoueur1.Bounds))
            {
                
                vitessex = -vitessex;
                vitessey = -vitessey;
                

                point += 1;
                picPoints.Text = point.ToString();
                string phraseClient = "Vitesse est"+" "+ Math.Abs(vitessey) + " et" + "le score est " + point.ToString();

                byte[] sndBytes = new byte[10];
                ASCIIEncoding encoder = new ASCIIEncoding();
                sndBytes = encoder.GetBytes(phraseClient);
                stream.Write(sndBytes, 0,phraseClient.Length);
                stream.Flush();
            }

           /* if (picBalle.Bounds.IntersectsWith(picJoueur2.Bounds))
            {

                vitessex = -vitessex;
                vitessey = -vitessey;

            }*/
        }


       
       public void Collision () {

           if (picBalle.Top <= playground.Top) {

               vitessey = -vitessey;
           
           }
           if (picBalle.Bottom >= playground.Bottom)
           {
               vitessey = -vitessey;
           }
           if (picBalle.Right > playground.Right) {
               vitessex = -vitessex;
           
           }
           if (picBalle.Left < playground.Left)
           {

               PongTimer.Enabled = false;
               picGameover.Visible = true;

           }
       
       
       }

       private void Form1_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Escape) { this.Close(); }
           if (e.KeyCode == Keys.F1)
           {

               picBalle.resetBall();

               point = 0;
               picPoints.Text = "0";

               PongTimer.Enabled = true;
               picGameover.Visible = false;




           }
       }

       private void Form1_Load(object sender, EventArgs e)
       {

       }
       
       

        }

      

    }


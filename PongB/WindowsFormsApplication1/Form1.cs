using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Paddle picJoueur1, picJoueur2, picBalle;
        Timer PongTimer;

        const int longueur = 500;
        const int largeur = 600;

        

       public int vitessex = 3;
       public int vitessey = 3;
       public int intervalTimer = 1;
        public Form1()
        {
            InitializeComponent();
            picJoueur1 = new Paddle( 10,60);
            picJoueur1.Location = new Point(picJoueur1.Width / 2, playground.Height / 2 - picJoueur1.Height / 2);
            playground.Controls.Add(picJoueur1);


            picJoueur2 = new Paddle(10, 60);
            picJoueur2.Location = new Point(playground.Left - picJoueur2.Width/2, playground.Height / 2 - picJoueur2.Height / 2);
            playground.Controls.Add(picJoueur2);


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
               
            
        }
        void PongTime_Tick(object sender, EventArgs e)
        {
            picBalle.Location = new Point(picBalle.Location.X + vitessex, picBalle.Location.Y+vitessey);
            picBalle.Collisions(vitessex,vitessey,playground);
            picJoueur1.CollisionJ(picBalle, vitessex, vitessey);
            picJoueur2.CollisionJ(picBalle, vitessex, vitessey);
            
            picJoueur1.DeplacementJ1();
            picJoueur2.DeplacementJ2(vitessex,picBalle,playground);
            
           
        }
        
		
       
       
       
       

        }

      

    }


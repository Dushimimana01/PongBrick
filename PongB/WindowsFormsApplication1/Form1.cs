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
        PictureBox picJoueur1, picJoueur2, picBalle;
        Timer PongTimer;

        const int longueur = 800;
        const int largeur = 600;

        Size tJoueur = new Size(25, 100);
        
       Size tBalle = new Size(20, 20);

        int vitesse = 3;
        
        int intervalTimer = 1;
        public Form1()
        {
            InitializeComponent();
            picJoueur1 = new PictureBox();
            picJoueur2 = new PictureBox();
            picBalle = new PictureBox();
 
            PongTimer = new Timer();
 
            PongTimer.Enabled = true;
            PongTimer.Interval = intervalTimer;
 
 
            this.Width = largeur;
            this.Height = longueur;
            this.StartPosition = FormStartPosition.CenterScreen;
 
            picJoueur1.Size = tJoueur;
            picJoueur1.Location = new Point(picJoueur1.Width / 2, ClientSize.Height / 2 - picJoueur1.Height / 2);
            picJoueur1.BackColor = Color.Blue;
            this.Controls.Add(picJoueur1);
 
            picJoueur2.Size = tJoueur;
            picJoueur2.Location = new Point(ClientSize.Width - (picJoueur2.Width + picJoueur2.Width / 2), ClientSize.Height / 2 - picJoueur2.Height / 2);
            picJoueur2.BackColor = Color.Red;
            this.Controls.Add(picJoueur2);
 
            picBalle.Size = tBalle;
            picBalle.Location = new Point(ClientSize.Width / 2 - picBalle.Width / 2, ClientSize.Height / 2 - picBalle.Height / 2);
            picBalle.BackColor = Color.Green;
            this.Controls.Add(picBalle);
        }
        

        }

       

    }
}

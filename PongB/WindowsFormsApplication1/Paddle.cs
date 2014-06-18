using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    class Paddle : PictureBox
    {


        public Paddle() { }
        public Paddle(int width, int height)
        {
            
          
            Size s = new Size(width, height);
            this.BackColor = Color.White;
            this.Size = s;


        }//initialisation du joueur

        public void DeplacementJ1()
        {
            this.Top = Cursor.Position.Y - (this.Height * 2);
        }//Deplacement du joueur avec la souris

        public void Deplauto(int vitessex, Balle balle, Panel p)
        {

            if (vitessex < 0)
            {
                this.Location = new Point((balle.Width + this.Width / 2), balle.Location.Y - this.Height / 2);
            }
        
        
        }//Depalcement automatiqe du joueur

        public void DeplacementJ2(int vitessex, Balle balle, Panel p)
        {
            if (vitessex > 0)
            {
                this.Location = new Point(p.Width - (balle.Width + this.Width / 2), balle.Location.Y - this.Height / 2);
            }
        }//Deplacement du joueur 2

    }
}

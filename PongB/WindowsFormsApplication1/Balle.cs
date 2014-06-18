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
    class Balle : PictureBox

    {
        public Balle(int arete) { 
        Size s =new Size(arete,arete);
            this.BackColor=Color.White;
            this.Size=s;

      }//Initialisation de la balle
    
        public void resetBall(Panel p)
        {
            Random top = new Random();
            Random left = new Random();
            this.Top = top.Next(0, p.Height);
            this.Left = left.Next(0, p.Width);

        }// Reset de la balle
    }
}

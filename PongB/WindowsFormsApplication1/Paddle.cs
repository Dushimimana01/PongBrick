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
    class Paddle: PictureBox
    {

        
         public Paddle() {  }
        public Paddle(int width, int height) {

            Size s = new Size(width, height);
            this.BackColor = Color.White;
            this.Size = s;
            
       
        }
        public void Collisions(int vx,int vy,Panel p)
        {
            if (this.Top <= p.Top )
            {

                vy = -vy;
            }
            else if (this.Location.X > p.Width)
            {
                resetBall();
            }
            else if (this.Bottom >=p.Bottom )
            {
                resetBall();
            }

        }
        public void resetBall() {

            this.Top = 50;
            this.Left = 100;
        
        }


        public void DeplacementJ1(){
            this.Top = Cursor.Position.Y - this.Height / 2;
        }

        public void CollisionJ(Paddle balle,int vitessex,int vitessey)
        {
            if (balle.Bounds.IntersectsWith(this.Bounds))
            {

                vitessex = -vitessex;
                vitessey = -vitessey;

            }

            

        }

        public void DeplacementJ2(int vitessex,Paddle balle,Panel p)
        {
            if (vitessex > 0)
            {
                this.Location = new Point(p.Width - (balle.Width + this.Width / 2), balle.Location.Y - this.Height / 2);
            }
        }

    }
}

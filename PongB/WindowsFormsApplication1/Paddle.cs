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


        }
        public void Collisions(int vx, int vy, Panel p)
        {
            if (this.Top <= p.ClientRectangle.Bottom)
            {

                vy = -vy;
            }
            else if (this.Location.X < 0)
            {
                resetBall(p);
            }
            else if (this.Bottom >= p.Bottom)
            {
                resetBall(p);
            }

        }
        public void resetBall(Panel p)
        {
            Random top = new Random();
            Random left = new Random();
            this.Top = top.Next(0, p.Height);
            this.Left = left.Next(0, p.Width);

        }


        public void DeplacementJ1()
        {
            this.Top = Cursor.Position.Y - (this.Height * 2);
        }

        public void CollisionJ(Paddle balle, int vitessex, int vitessey)
        {
            if (balle.Bounds.IntersectsWith(this.Bounds))
            {
                vitessex += 4;
                vitessey += 4;
                vitessex = -vitessex;
                vitessey = -vitessey;

            }



        }

        public void DeplacementJ2(int vitessex, Paddle balle, Panel p)
        {
            if (vitessex > 0)
            {
                this.Location = new Point(p.Width - (balle.Width + this.Width / 2), balle.Location.Y - this.Height / 2);
            }
        }

    }
}

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
    class Palette : PictureBox

    {
        public Palette (int height,int width,string color) {
            this.BackColor = Color.FromName(color);
            this.Size = new Size(height,width);
           
    
        }

        public Palette() { }


    }
}

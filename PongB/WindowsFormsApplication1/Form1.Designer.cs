namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            this.picMilieu = new System.Windows.Forms.PictureBox();
            this.picPoints = new System.Windows.Forms.Label();
            this.picGameover = new System.Windows.Forms.Label();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMilieu)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.Black;
            this.playground.Controls.Add(this.picGameover);
            this.playground.Controls.Add(this.picPoints);
            this.playground.Controls.Add(this.picMilieu);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(721, 556);
            this.playground.TabIndex = 0;
            // 
            // pongTimer
            // 
            this.pongTimer.Interval = 10;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // picMilieu
            // 
            this.picMilieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picMilieu.BackColor = System.Drawing.Color.White;
            this.picMilieu.Location = new System.Drawing.Point(324, 3);
            this.picMilieu.Name = "picMilieu";
            this.picMilieu.Size = new System.Drawing.Size(10, 541);
            this.picMilieu.TabIndex = 1;
            this.picMilieu.TabStop = false;
            // 
            // picPoints
            // 
            this.picPoints.AutoSize = true;
            this.picPoints.BackColor = System.Drawing.Color.Black;
            this.picPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picPoints.ForeColor = System.Drawing.Color.White;
            this.picPoints.Location = new System.Drawing.Point(252, 3);
            this.picPoints.Name = "picPoints";
            this.picPoints.Size = new System.Drawing.Size(36, 39);
            this.picPoints.TabIndex = 2;
            this.picPoints.Text = "0";
            // 
            // picGameover
            // 
            this.picGameover.AutoSize = true;
            this.picGameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picGameover.ForeColor = System.Drawing.Color.White;
            this.picGameover.Location = new System.Drawing.Point(3, 430);
            this.picGameover.Name = "picGameover";
            this.picGameover.Size = new System.Drawing.Size(303, 117);
            this.picGameover.TabIndex = 3;
            this.picGameover.Text = "Game over\r\nPress F1 to restart\r\nPress Esc to quit\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 556);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMilieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Timer pongTimer;
        private System.Windows.Forms.PictureBox picMilieu;
        private System.Windows.Forms.Label picPoints;
        private System.Windows.Forms.Label picGameover;
    }
}
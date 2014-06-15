namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.picMilieu = new System.Windows.Forms.PictureBox();
            this.playground = new System.Windows.Forms.Panel();
            this.picPoints = new System.Windows.Forms.Label();
            this.picGameover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMilieu)).BeginInit();
            this.playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMilieu
            // 
            this.picMilieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picMilieu.BackColor = System.Drawing.Color.White;
            this.picMilieu.Location = new System.Drawing.Point(315, 0);
            this.picMilieu.Name = "picMilieu";
            this.picMilieu.Size = new System.Drawing.Size(10, 518);
            this.picMilieu.TabIndex = 0;
            this.picMilieu.TabStop = false;
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.Black;
            this.playground.Controls.Add(this.picGameover);
            this.playground.Controls.Add(this.picPoints);
            this.playground.Controls.Add(this.picMilieu);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(680, 502);
            this.playground.TabIndex = 0;
            // 
            // picPoints
            // 
            this.picPoints.AutoSize = true;
            this.picPoints.BackColor = System.Drawing.Color.Transparent;
            this.picPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picPoints.ForeColor = System.Drawing.Color.White;
            this.picPoints.Location = new System.Drawing.Point(270, 9);
            this.picPoints.Name = "picPoints";
            this.picPoints.Size = new System.Drawing.Size(39, 42);
            this.picPoints.TabIndex = 1;
            this.picPoints.Text = "0";
            // 
            // picGameover
            // 
            this.picGameover.AutoSize = true;
            this.picGameover.BackColor = System.Drawing.Color.Transparent;
            this.picGameover.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picGameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picGameover.ForeColor = System.Drawing.Color.White;
            this.picGameover.Location = new System.Drawing.Point(0, 385);
            this.picGameover.Name = "picGameover";
            this.picGameover.Size = new System.Drawing.Size(303, 117);
            this.picGameover.TabIndex = 2;
            this.picGameover.Text = "Game Over\r\nPress F1 to restart\r\nPress Esc to quit\r\n";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(680, 502);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMilieu)).EndInit();
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMilieu;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label picPoints;
        private System.Windows.Forms.Label picGameover;

    }
}


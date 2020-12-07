namespace RPGgameproject
{
    partial class Gameover
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
            this.pbdeath = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbdeath)).BeginInit();
            this.SuspendLayout();
            // 
            // pbdeath
            // 
            this.pbdeath.Image = global::RPGgameproject.Properties.Resources.death_screen;
            this.pbdeath.Location = new System.Drawing.Point(1, 1);
            this.pbdeath.Name = "pbdeath";
            this.pbdeath.Size = new System.Drawing.Size(798, 446);
            this.pbdeath.TabIndex = 0;
            this.pbdeath.TabStop = false;
            // 
            // Gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbdeath);
            this.Name = "Gameover";
            this.Text = "Gameover";
            this.Load += new System.EventHandler(this.Gameover_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbdeath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbdeath;
    }
}
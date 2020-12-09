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
            this.btnstartover = new System.Windows.Forms.Button();
            this.btnclosegame = new System.Windows.Forms.Button();
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
            // btnstartover
            // 
            this.btnstartover.Location = new System.Drawing.Point(145, 293);
            this.btnstartover.Name = "btnstartover";
            this.btnstartover.Size = new System.Drawing.Size(115, 64);
            this.btnstartover.TabIndex = 1;
            this.btnstartover.Text = "Start over";
            this.btnstartover.UseVisualStyleBackColor = true;
            this.btnstartover.Click += new System.EventHandler(this.btnstartover_Click);
            // 
            // btnclosegame
            // 
            this.btnclosegame.Location = new System.Drawing.Point(516, 293);
            this.btnclosegame.Name = "btnclosegame";
            this.btnclosegame.Size = new System.Drawing.Size(115, 64);
            this.btnclosegame.TabIndex = 2;
            this.btnclosegame.Text = "Close Game";
            this.btnclosegame.UseVisualStyleBackColor = true;
            this.btnclosegame.Click += new System.EventHandler(this.btnclosegame_Click);
            // 
            // Gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclosegame);
            this.Controls.Add(this.btnstartover);
            this.Controls.Add(this.pbdeath);
            this.Name = "Gameover";
            this.Text = "Gameover";
            this.Load += new System.EventHandler(this.Gameover_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbdeath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbdeath;
        private System.Windows.Forms.Button btnstartover;
        private System.Windows.Forms.Button btnclosegame;
    }
}
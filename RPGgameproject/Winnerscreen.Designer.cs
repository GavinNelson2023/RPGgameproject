namespace RPGgameproject
{
    partial class Winnerscreen
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
            this.btnclosegame = new System.Windows.Forms.Button();
            this.btnstartover = new System.Windows.Forms.Button();
            this.pbwin = new System.Windows.Forms.PictureBox();
            this.pbcharacter = new System.Windows.Forms.PictureBox();
            this.lblcongatulations = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbwin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclosegame
            // 
            this.btnclosegame.Location = new System.Drawing.Point(517, 344);
            this.btnclosegame.Name = "btnclosegame";
            this.btnclosegame.Size = new System.Drawing.Size(115, 64);
            this.btnclosegame.TabIndex = 5;
            this.btnclosegame.Text = "Close Game";
            this.btnclosegame.UseVisualStyleBackColor = true;
            this.btnclosegame.Click += new System.EventHandler(this.btnclosegame_Click);
            // 
            // btnstartover
            // 
            this.btnstartover.Location = new System.Drawing.Point(152, 344);
            this.btnstartover.Name = "btnstartover";
            this.btnstartover.Size = new System.Drawing.Size(115, 64);
            this.btnstartover.TabIndex = 4;
            this.btnstartover.Text = "Play Again";
            this.btnstartover.UseVisualStyleBackColor = true;
            this.btnstartover.Click += new System.EventHandler(this.btnstartover_Click);
            // 
            // pbwin
            // 
            this.pbwin.Location = new System.Drawing.Point(1, 2);
            this.pbwin.Name = "pbwin";
            this.pbwin.Size = new System.Drawing.Size(798, 446);
            this.pbwin.TabIndex = 3;
            this.pbwin.TabStop = false;
            // 
            // pbcharacter
            // 
            this.pbcharacter.Location = new System.Drawing.Point(277, 43);
            this.pbcharacter.Name = "pbcharacter";
            this.pbcharacter.Size = new System.Drawing.Size(219, 208);
            this.pbcharacter.TabIndex = 21;
            this.pbcharacter.TabStop = false;
            // 
            // lblcongatulations
            // 
            this.lblcongatulations.AutoSize = true;
            this.lblcongatulations.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcongatulations.Location = new System.Drawing.Point(146, 281);
            this.lblcongatulations.Name = "lblcongatulations";
            this.lblcongatulations.Size = new System.Drawing.Size(497, 31);
            this.lblcongatulations.TabIndex = 22;
            this.lblcongatulations.Text = "Congratulations                    Beat the Game!";
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(333, 289);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(128, 31);
            this.lblname.TabIndex = 23;
            this.lblname.Text = "label1";
            // 
            // Winnerscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblcongatulations);
            this.Controls.Add(this.pbcharacter);
            this.Controls.Add(this.btnclosegame);
            this.Controls.Add(this.btnstartover);
            this.Controls.Add(this.pbwin);
            this.Name = "Winnerscreen";
            this.Text = "Winnerscreen";
            this.Load += new System.EventHandler(this.Winnerscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbwin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclosegame;
        private System.Windows.Forms.Button btnstartover;
        private System.Windows.Forms.PictureBox pbwin;
        private System.Windows.Forms.PictureBox pbcharacter;
        private System.Windows.Forms.Label lblcongatulations;
        private System.Windows.Forms.Label lblname;
    }
}
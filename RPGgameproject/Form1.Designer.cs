namespace RPGgameproject
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
            this.lblstart = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbentrance = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbentrance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstart
            // 
            this.lblstart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblstart.AutoSize = true;
            this.lblstart.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstart.Location = new System.Drawing.Point(373, 272);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(49, 23);
            this.lblstart.TabIndex = 0;
            this.lblstart.Text = "Start";
            this.lblstart.Click += new System.EventHandler(this.lblstart_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(178, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(447, 42);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Overused Dungeon Rpg Title";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game made by: Gavin Nelson";
            // 
            // pbentrance
            // 
            this.pbentrance.Image = global::RPGgameproject.Properties.Resources.pb7pczq6ssn21;
            this.pbentrance.Location = new System.Drawing.Point(0, -1);
            this.pbentrance.Name = "pbentrance";
            this.pbentrance.Size = new System.Drawing.Size(800, 454);
            this.pbentrance.TabIndex = 3;
            this.pbentrance.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.pbentrance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbentrance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbentrance;
    }
}


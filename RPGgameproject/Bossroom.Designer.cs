namespace RPGgameproject
{
    partial class Bossroom
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
            this.lblsearchoption1 = new System.Windows.Forms.Label();
            this.lblsearchoption2 = new System.Windows.Forms.Label();
            this.lblresults = new System.Windows.Forms.Label();
            this.gbactions = new System.Windows.Forms.GroupBox();
            this.lblact3 = new System.Windows.Forms.Label();
            this.lblact5 = new System.Windows.Forms.Label();
            this.lblact4 = new System.Windows.Forms.Label();
            this.lblact2 = new System.Windows.Forms.Label();
            this.lblact1 = new System.Windows.Forms.Label();
            this.gbstatistics = new System.Windows.Forms.GroupBox();
            this.lblhealthnum = new System.Windows.Forms.Label();
            this.lblhealthstatistic = new System.Windows.Forms.Label();
            this.lbllucknum = new System.Windows.Forms.Label();
            this.lblwisnum = new System.Windows.Forms.Label();
            this.lbldexnum = new System.Windows.Forms.Label();
            this.lblmpnum = new System.Windows.Forms.Label();
            this.lblstrnum = new System.Windows.Forms.Label();
            this.lblluckstatistic = new System.Windows.Forms.Label();
            this.lblwisstatistic = new System.Windows.Forms.Label();
            this.lbldexstatistic = new System.Windows.Forms.Label();
            this.lblmpstatistic = new System.Windows.Forms.Label();
            this.lblstrstatistic = new System.Windows.Forms.Label();
            this.pbcharacter = new System.Windows.Forms.PictureBox();
            this.pbdragon = new System.Windows.Forms.PictureBox();
            this.gbdragon = new System.Windows.Forms.GroupBox();
            this.lbldragonhealth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldragonluck = new System.Windows.Forms.Label();
            this.lbldragonwisdom = new System.Windows.Forms.Label();
            this.lbldragondexterity = new System.Windows.Forms.Label();
            this.lbldragonmagic = new System.Windows.Forms.Label();
            this.lbldragonstrength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbactions.SuspendLayout();
            this.gbstatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdragon)).BeginInit();
            this.gbdragon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsearchoption1
            // 
            this.lblsearchoption1.AutoSize = true;
            this.lblsearchoption1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchoption1.Location = new System.Drawing.Point(8, 289);
            this.lblsearchoption1.Name = "lblsearchoption1";
            this.lblsearchoption1.Size = new System.Drawing.Size(227, 23);
            this.lblsearchoption1.TabIndex = 25;
            this.lblsearchoption1.Text = "1. Search around the door.";
            // 
            // lblsearchoption2
            // 
            this.lblsearchoption2.AutoSize = true;
            this.lblsearchoption2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchoption2.Location = new System.Drawing.Point(259, 289);
            this.lblsearchoption2.Name = "lblsearchoption2";
            this.lblsearchoption2.Size = new System.Drawing.Size(330, 23);
            this.lblsearchoption2.TabIndex = 24;
            this.lblsearchoption2.Text = "2. Search around the edge of the room.";
            // 
            // lblresults
            // 
            this.lblresults.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresults.Location = new System.Drawing.Point(8, 222);
            this.lblresults.Name = "lblresults";
            this.lblresults.Size = new System.Drawing.Size(772, 90);
            this.lblresults.TabIndex = 23;
            this.lblresults.Text = "a";
            // 
            // gbactions
            // 
            this.gbactions.Controls.Add(this.lblact3);
            this.gbactions.Controls.Add(this.lblact5);
            this.gbactions.Controls.Add(this.lblact4);
            this.gbactions.Controls.Add(this.lblact2);
            this.gbactions.Controls.Add(this.lblact1);
            this.gbactions.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbactions.Location = new System.Drawing.Point(12, 315);
            this.gbactions.Name = "gbactions";
            this.gbactions.Size = new System.Drawing.Size(768, 123);
            this.gbactions.TabIndex = 22;
            this.gbactions.TabStop = false;
            this.gbactions.Text = "Actions:";
            // 
            // lblact3
            // 
            this.lblact3.AutoSize = true;
            this.lblact3.Location = new System.Drawing.Point(350, 29);
            this.lblact3.Name = "lblact3";
            this.lblact3.Size = new System.Drawing.Size(222, 21);
            this.lblact3.TabIndex = 4;
            this.lblact3.Text = "3. Attack Dragon with magic";
            this.lblact3.Click += new System.EventHandler(this.lblact3_Click_1);
            // 
            // lblact5
            // 
            this.lblact5.AutoSize = true;
            this.lblact5.Location = new System.Drawing.Point(190, 68);
            this.lblact5.Name = "lblact5";
            this.lblact5.Size = new System.Drawing.Size(62, 21);
            this.lblact5.TabIndex = 3;
            this.lblact5.Text = "5. Heal";
            this.lblact5.Click += new System.EventHandler(this.lblact4_Click);
            // 
            // lblact4
            // 
            this.lblact4.AutoSize = true;
            this.lblact4.Location = new System.Drawing.Point(26, 68);
            this.lblact4.Name = "lblact4";
            this.lblact4.Size = new System.Drawing.Size(158, 21);
            this.lblact4.TabIndex = 2;
            this.lblact4.Text = "4. Find Weaknesses";
            this.lblact4.Click += new System.EventHandler(this.lblact3_Click);
            // 
            // lblact2
            // 
            this.lblact2.AutoSize = true;
            this.lblact2.Location = new System.Drawing.Point(190, 29);
            this.lblact2.Name = "lblact2";
            this.lblact2.Size = new System.Drawing.Size(137, 21);
            this.lblact2.TabIndex = 1;
            this.lblact2.Text = "2. Attack Dragon";
            this.lblact2.Click += new System.EventHandler(this.lblact2_Click);
            // 
            // lblact1
            // 
            this.lblact1.AutoSize = true;
            this.lblact1.Location = new System.Drawing.Point(26, 29);
            this.lblact1.Name = "lblact1";
            this.lblact1.Size = new System.Drawing.Size(156, 21);
            this.lblact1.TabIndex = 0;
            this.lblact1.Text = "1. Go Through Exit";
            this.lblact1.Click += new System.EventHandler(this.lblact1_Click);
            // 
            // gbstatistics
            // 
            this.gbstatistics.Controls.Add(this.lblhealthnum);
            this.gbstatistics.Controls.Add(this.lblhealthstatistic);
            this.gbstatistics.Controls.Add(this.lbllucknum);
            this.gbstatistics.Controls.Add(this.lblwisnum);
            this.gbstatistics.Controls.Add(this.lbldexnum);
            this.gbstatistics.Controls.Add(this.lblmpnum);
            this.gbstatistics.Controls.Add(this.lblstrnum);
            this.gbstatistics.Controls.Add(this.lblluckstatistic);
            this.gbstatistics.Controls.Add(this.lblwisstatistic);
            this.gbstatistics.Controls.Add(this.lbldexstatistic);
            this.gbstatistics.Controls.Add(this.lblmpstatistic);
            this.gbstatistics.Controls.Add(this.lblstrstatistic);
            this.gbstatistics.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbstatistics.Location = new System.Drawing.Point(192, 12);
            this.gbstatistics.Name = "gbstatistics";
            this.gbstatistics.Size = new System.Drawing.Size(219, 207);
            this.gbstatistics.TabIndex = 21;
            this.gbstatistics.TabStop = false;
            this.gbstatistics.Text = "Character Statistics:";
            // 
            // lblhealthnum
            // 
            this.lblhealthnum.AutoSize = true;
            this.lblhealthnum.Location = new System.Drawing.Point(124, 175);
            this.lblhealthnum.Name = "lblhealthnum";
            this.lblhealthnum.Size = new System.Drawing.Size(36, 27);
            this.lblhealthnum.TabIndex = 13;
            this.lblhealthnum.Text = "10";
            // 
            // lblhealthstatistic
            // 
            this.lblhealthstatistic.AutoSize = true;
            this.lblhealthstatistic.Location = new System.Drawing.Point(13, 175);
            this.lblhealthstatistic.Name = "lblhealthstatistic";
            this.lblhealthstatistic.Size = new System.Drawing.Size(82, 27);
            this.lblhealthstatistic.TabIndex = 12;
            this.lblhealthstatistic.Text = "Health:";
            // 
            // lbllucknum
            // 
            this.lbllucknum.AutoSize = true;
            this.lbllucknum.Location = new System.Drawing.Point(136, 148);
            this.lbllucknum.Name = "lbllucknum";
            this.lbllucknum.Size = new System.Drawing.Size(24, 27);
            this.lbllucknum.TabIndex = 9;
            this.lbllucknum.Text = "0";
            // 
            // lblwisnum
            // 
            this.lblwisnum.AutoSize = true;
            this.lblwisnum.Location = new System.Drawing.Point(136, 121);
            this.lblwisnum.Name = "lblwisnum";
            this.lblwisnum.Size = new System.Drawing.Size(24, 27);
            this.lblwisnum.TabIndex = 8;
            this.lblwisnum.Text = "0";
            // 
            // lbldexnum
            // 
            this.lbldexnum.AutoSize = true;
            this.lbldexnum.Location = new System.Drawing.Point(136, 94);
            this.lbldexnum.Name = "lbldexnum";
            this.lbldexnum.Size = new System.Drawing.Size(24, 27);
            this.lbldexnum.TabIndex = 7;
            this.lbldexnum.Text = "0";
            // 
            // lblmpnum
            // 
            this.lblmpnum.AutoSize = true;
            this.lblmpnum.Location = new System.Drawing.Point(136, 62);
            this.lblmpnum.Name = "lblmpnum";
            this.lblmpnum.Size = new System.Drawing.Size(24, 27);
            this.lblmpnum.TabIndex = 6;
            this.lblmpnum.Text = "0";
            // 
            // lblstrnum
            // 
            this.lblstrnum.AutoSize = true;
            this.lblstrnum.Location = new System.Drawing.Point(136, 35);
            this.lblstrnum.Name = "lblstrnum";
            this.lblstrnum.Size = new System.Drawing.Size(24, 27);
            this.lblstrnum.TabIndex = 5;
            this.lblstrnum.Text = "0";
            // 
            // lblluckstatistic
            // 
            this.lblluckstatistic.AutoSize = true;
            this.lblluckstatistic.Location = new System.Drawing.Point(10, 148);
            this.lblluckstatistic.Name = "lblluckstatistic";
            this.lblluckstatistic.Size = new System.Drawing.Size(68, 27);
            this.lblluckstatistic.TabIndex = 4;
            this.lblluckstatistic.Text = "Luck:";
            // 
            // lblwisstatistic
            // 
            this.lblwisstatistic.AutoSize = true;
            this.lblwisstatistic.Location = new System.Drawing.Point(10, 121);
            this.lblwisstatistic.Name = "lblwisstatistic";
            this.lblwisstatistic.Size = new System.Drawing.Size(55, 27);
            this.lblwisstatistic.TabIndex = 3;
            this.lblwisstatistic.Text = "Wis:";
            // 
            // lbldexstatistic
            // 
            this.lbldexstatistic.AutoSize = true;
            this.lbldexstatistic.Location = new System.Drawing.Point(10, 94);
            this.lbldexstatistic.Name = "lbldexstatistic";
            this.lbldexstatistic.Size = new System.Drawing.Size(58, 27);
            this.lbldexstatistic.TabIndex = 2;
            this.lbldexstatistic.Text = "Dex:";
            // 
            // lblmpstatistic
            // 
            this.lblmpstatistic.AutoSize = true;
            this.lblmpstatistic.Location = new System.Drawing.Point(10, 62);
            this.lblmpstatistic.Name = "lblmpstatistic";
            this.lblmpstatistic.Size = new System.Drawing.Size(51, 27);
            this.lblmpstatistic.TabIndex = 1;
            this.lblmpstatistic.Text = "Mp:";
            // 
            // lblstrstatistic
            // 
            this.lblstrstatistic.AutoSize = true;
            this.lblstrstatistic.Location = new System.Drawing.Point(10, 35);
            this.lblstrstatistic.Name = "lblstrstatistic";
            this.lblstrstatistic.Size = new System.Drawing.Size(45, 27);
            this.lblstrstatistic.TabIndex = 0;
            this.lblstrstatistic.Text = "Str:";
            // 
            // pbcharacter
            // 
            this.pbcharacter.Location = new System.Drawing.Point(4, 12);
            this.pbcharacter.Name = "pbcharacter";
            this.pbcharacter.Size = new System.Drawing.Size(166, 203);
            this.pbcharacter.TabIndex = 20;
            this.pbcharacter.TabStop = false;
            // 
            // pbdragon
            // 
            this.pbdragon.Image = global::RPGgameproject.Properties.Resources.dragon;
            this.pbdragon.Location = new System.Drawing.Point(423, 16);
            this.pbdragon.Name = "pbdragon";
            this.pbdragon.Size = new System.Drawing.Size(161, 202);
            this.pbdragon.TabIndex = 26;
            this.pbdragon.TabStop = false;
            // 
            // gbdragon
            // 
            this.gbdragon.Controls.Add(this.lbldragonhealth);
            this.gbdragon.Controls.Add(this.label2);
            this.gbdragon.Controls.Add(this.lbldragonluck);
            this.gbdragon.Controls.Add(this.lbldragonwisdom);
            this.gbdragon.Controls.Add(this.lbldragondexterity);
            this.gbdragon.Controls.Add(this.lbldragonmagic);
            this.gbdragon.Controls.Add(this.lbldragonstrength);
            this.gbdragon.Controls.Add(this.label8);
            this.gbdragon.Controls.Add(this.label9);
            this.gbdragon.Controls.Add(this.label10);
            this.gbdragon.Controls.Add(this.label11);
            this.gbdragon.Controls.Add(this.label12);
            this.gbdragon.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdragon.Location = new System.Drawing.Point(595, 16);
            this.gbdragon.Name = "gbdragon";
            this.gbdragon.Size = new System.Drawing.Size(202, 207);
            this.gbdragon.TabIndex = 22;
            this.gbdragon.TabStop = false;
            this.gbdragon.Text = "Dragon stats:";
            // 
            // lbldragonhealth
            // 
            this.lbldragonhealth.AutoSize = true;
            this.lbldragonhealth.Location = new System.Drawing.Point(124, 175);
            this.lbldragonhealth.Name = "lbldragonhealth";
            this.lbldragonhealth.Size = new System.Drawing.Size(36, 27);
            this.lbldragonhealth.TabIndex = 13;
            this.lbldragonhealth.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Health:";
            // 
            // lbldragonluck
            // 
            this.lbldragonluck.AutoSize = true;
            this.lbldragonluck.Location = new System.Drawing.Point(136, 148);
            this.lbldragonluck.Name = "lbldragonluck";
            this.lbldragonluck.Size = new System.Drawing.Size(24, 27);
            this.lbldragonluck.TabIndex = 9;
            this.lbldragonluck.Text = "4";
            // 
            // lbldragonwisdom
            // 
            this.lbldragonwisdom.AutoSize = true;
            this.lbldragonwisdom.Location = new System.Drawing.Point(136, 121);
            this.lbldragonwisdom.Name = "lbldragonwisdom";
            this.lbldragonwisdom.Size = new System.Drawing.Size(24, 27);
            this.lbldragonwisdom.TabIndex = 8;
            this.lbldragonwisdom.Text = "5";
            // 
            // lbldragondexterity
            // 
            this.lbldragondexterity.AutoSize = true;
            this.lbldragondexterity.Location = new System.Drawing.Point(136, 94);
            this.lbldragondexterity.Name = "lbldragondexterity";
            this.lbldragondexterity.Size = new System.Drawing.Size(24, 27);
            this.lbldragondexterity.TabIndex = 7;
            this.lbldragondexterity.Text = "2";
            // 
            // lbldragonmagic
            // 
            this.lbldragonmagic.AutoSize = true;
            this.lbldragonmagic.Location = new System.Drawing.Point(136, 62);
            this.lbldragonmagic.Name = "lbldragonmagic";
            this.lbldragonmagic.Size = new System.Drawing.Size(24, 27);
            this.lbldragonmagic.TabIndex = 6;
            this.lbldragonmagic.Text = "4";
            // 
            // lbldragonstrength
            // 
            this.lbldragonstrength.AutoSize = true;
            this.lbldragonstrength.Location = new System.Drawing.Point(136, 35);
            this.lbldragonstrength.Name = "lbldragonstrength";
            this.lbldragonstrength.Size = new System.Drawing.Size(24, 27);
            this.lbldragonstrength.TabIndex = 5;
            this.lbldragonstrength.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "Luck:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "Wis:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 27);
            this.label10.TabIndex = 2;
            this.label10.Text = "Dex:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 27);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 27);
            this.label12.TabIndex = 0;
            this.label12.Text = "Str:";
            // 
            // Bossroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbdragon);
            this.Controls.Add(this.pbdragon);
            this.Controls.Add(this.lblsearchoption1);
            this.Controls.Add(this.lblsearchoption2);
            this.Controls.Add(this.lblresults);
            this.Controls.Add(this.gbactions);
            this.Controls.Add(this.gbstatistics);
            this.Controls.Add(this.pbcharacter);
            this.Name = "Bossroom";
            this.Text = "Bossroom";
            this.Load += new System.EventHandler(this.Bossroom_Load);
            this.gbactions.ResumeLayout(false);
            this.gbactions.PerformLayout();
            this.gbstatistics.ResumeLayout(false);
            this.gbstatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdragon)).EndInit();
            this.gbdragon.ResumeLayout(false);
            this.gbdragon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblsearchoption1;
        private System.Windows.Forms.Label lblsearchoption2;
        private System.Windows.Forms.Label lblresults;
        private System.Windows.Forms.GroupBox gbactions;
        private System.Windows.Forms.Label lblact5;
        private System.Windows.Forms.Label lblact4;
        private System.Windows.Forms.Label lblact2;
        private System.Windows.Forms.Label lblact1;
        private System.Windows.Forms.GroupBox gbstatistics;
        private System.Windows.Forms.Label lblhealthnum;
        private System.Windows.Forms.Label lblhealthstatistic;
        private System.Windows.Forms.Label lbllucknum;
        private System.Windows.Forms.Label lblwisnum;
        private System.Windows.Forms.Label lbldexnum;
        private System.Windows.Forms.Label lblmpnum;
        private System.Windows.Forms.Label lblstrnum;
        private System.Windows.Forms.Label lblluckstatistic;
        private System.Windows.Forms.Label lblwisstatistic;
        private System.Windows.Forms.Label lbldexstatistic;
        private System.Windows.Forms.Label lblmpstatistic;
        private System.Windows.Forms.Label lblstrstatistic;
        private System.Windows.Forms.PictureBox pbcharacter;
        private System.Windows.Forms.PictureBox pbdragon;
        private System.Windows.Forms.GroupBox gbdragon;
        private System.Windows.Forms.Label lbldragonhealth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldragonluck;
        private System.Windows.Forms.Label lbldragonwisdom;
        private System.Windows.Forms.Label lbldragondexterity;
        private System.Windows.Forms.Label lbldragonmagic;
        private System.Windows.Forms.Label lbldragonstrength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblact3;
    }
}
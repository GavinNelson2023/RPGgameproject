namespace RPGgameproject
{
    partial class CharacterCreation
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
            this.cbstrength = new System.Windows.Forms.ComboBox();
            this.pbcharacter = new System.Windows.Forms.PictureBox();
            this.cbchracterpic = new System.Windows.Forms.ComboBox();
            this.lblstrength = new System.Windows.Forms.Label();
            this.lblmagic = new System.Windows.Forms.Label();
            this.lbldexterity = new System.Windows.Forms.Label();
            this.lblluck = new System.Windows.Forms.Label();
            this.lblwisdom = new System.Windows.Forms.Label();
            this.cbmagic = new System.Windows.Forms.ComboBox();
            this.cbdexterity = new System.Windows.Forms.ComboBox();
            this.cbluck = new System.Windows.Forms.ComboBox();
            this.cbwisdom = new System.Windows.Forms.ComboBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.gbstatistics = new System.Windows.Forms.GroupBox();
            this.lblchrarctername = new System.Windows.Forms.Label();
            this.lblnamestatistic = new System.Windows.Forms.Label();
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
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbllooks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbcharacter)).BeginInit();
            this.gbstatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbstrength
            // 
            this.cbstrength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstrength.FormattingEnabled = true;
            this.cbstrength.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbstrength.Location = new System.Drawing.Point(131, 9);
            this.cbstrength.Name = "cbstrength";
            this.cbstrength.Size = new System.Drawing.Size(215, 29);
            this.cbstrength.TabIndex = 1;
            this.cbstrength.SelectedIndexChanged += new System.EventHandler(this.cbstrength_SelectedIndexChanged);
            // 
            // pbcharacter
            // 
            this.pbcharacter.Location = new System.Drawing.Point(436, 0);
            this.pbcharacter.Name = "pbcharacter";
            this.pbcharacter.Size = new System.Drawing.Size(352, 283);
            this.pbcharacter.TabIndex = 0;
            this.pbcharacter.TabStop = false;
            // 
            // cbchracterpic
            // 
            this.cbchracterpic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbchracterpic.FormattingEnabled = true;
            this.cbchracterpic.Items.AddRange(new object[] {
            "Wizard",
            "Tank",
            "Alien",
            "Soldier"});
            this.cbchracterpic.Location = new System.Drawing.Point(436, 352);
            this.cbchracterpic.Name = "cbchracterpic";
            this.cbchracterpic.Size = new System.Drawing.Size(352, 29);
            this.cbchracterpic.TabIndex = 2;
            this.cbchracterpic.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lblstrength
            // 
            this.lblstrength.AutoSize = true;
            this.lblstrength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstrength.Location = new System.Drawing.Point(40, 12);
            this.lblstrength.Name = "lblstrength";
            this.lblstrength.Size = new System.Drawing.Size(76, 21);
            this.lblstrength.TabIndex = 3;
            this.lblstrength.Text = "Strength:";
            // 
            // lblmagic
            // 
            this.lblmagic.AutoSize = true;
            this.lblmagic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmagic.Location = new System.Drawing.Point(41, 46);
            this.lblmagic.Name = "lblmagic";
            this.lblmagic.Size = new System.Drawing.Size(60, 21);
            this.lblmagic.TabIndex = 4;
            this.lblmagic.Text = "Magic:";
            // 
            // lbldexterity
            // 
            this.lbldexterity.AutoSize = true;
            this.lbldexterity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldexterity.Location = new System.Drawing.Point(39, 82);
            this.lbldexterity.Name = "lbldexterity";
            this.lbldexterity.Size = new System.Drawing.Size(81, 21);
            this.lbldexterity.TabIndex = 5;
            this.lbldexterity.Text = "Dexterity:";
            // 
            // lblluck
            // 
            this.lblluck.AutoSize = true;
            this.lblluck.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblluck.Location = new System.Drawing.Point(41, 161);
            this.lblluck.Name = "lblluck";
            this.lblluck.Size = new System.Drawing.Size(52, 21);
            this.lblluck.TabIndex = 6;
            this.lblluck.Text = "Luck:";
            // 
            // lblwisdom
            // 
            this.lblwisdom.AutoSize = true;
            this.lblwisdom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwisdom.Location = new System.Drawing.Point(39, 122);
            this.lblwisdom.Name = "lblwisdom";
            this.lblwisdom.Size = new System.Drawing.Size(77, 21);
            this.lblwisdom.TabIndex = 7;
            this.lblwisdom.Text = "Wisdom:";
            // 
            // cbmagic
            // 
            this.cbmagic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmagic.FormattingEnabled = true;
            this.cbmagic.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbmagic.Location = new System.Drawing.Point(131, 43);
            this.cbmagic.Name = "cbmagic";
            this.cbmagic.Size = new System.Drawing.Size(215, 29);
            this.cbmagic.TabIndex = 8;
            this.cbmagic.SelectedIndexChanged += new System.EventHandler(this.cbmagic_SelectedIndexChanged);
            // 
            // cbdexterity
            // 
            this.cbdexterity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdexterity.FormattingEnabled = true;
            this.cbdexterity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbdexterity.Location = new System.Drawing.Point(131, 79);
            this.cbdexterity.Name = "cbdexterity";
            this.cbdexterity.Size = new System.Drawing.Size(215, 29);
            this.cbdexterity.TabIndex = 9;
            this.cbdexterity.SelectedIndexChanged += new System.EventHandler(this.cbdexterity_SelectedIndexChanged);
            // 
            // cbluck
            // 
            this.cbluck.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbluck.FormattingEnabled = true;
            this.cbluck.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbluck.Location = new System.Drawing.Point(131, 158);
            this.cbluck.Name = "cbluck";
            this.cbluck.Size = new System.Drawing.Size(215, 29);
            this.cbluck.TabIndex = 10;
            this.cbluck.SelectedIndexChanged += new System.EventHandler(this.cbluck_SelectedIndexChanged);
            // 
            // cbwisdom
            // 
            this.cbwisdom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbwisdom.FormattingEnabled = true;
            this.cbwisdom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbwisdom.Location = new System.Drawing.Point(131, 119);
            this.cbwisdom.Name = "cbwisdom";
            this.cbwisdom.Size = new System.Drawing.Size(215, 29);
            this.cbwisdom.TabIndex = 11;
            this.cbwisdom.SelectedIndexChanged += new System.EventHandler(this.cbwisdom_SelectedIndexChanged);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.Location = new System.Drawing.Point(695, 408);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(93, 30);
            this.btnconfirm.TabIndex = 12;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // gbstatistics
            // 
            this.gbstatistics.Controls.Add(this.lblchrarctername);
            this.gbstatistics.Controls.Add(this.lblnamestatistic);
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
            this.gbstatistics.Location = new System.Drawing.Point(43, 221);
            this.gbstatistics.Name = "gbstatistics";
            this.gbstatistics.Size = new System.Drawing.Size(303, 217);
            this.gbstatistics.TabIndex = 13;
            this.gbstatistics.TabStop = false;
            this.gbstatistics.Text = "Character Statistics:";
            // 
            // lblchrarctername
            // 
            this.lblchrarctername.AutoSize = true;
            this.lblchrarctername.Location = new System.Drawing.Point(117, 35);
            this.lblchrarctername.Name = "lblchrarctername";
            this.lblchrarctername.Size = new System.Drawing.Size(64, 27);
            this.lblchrarctername.TabIndex = 11;
            this.lblchrarctername.Text = "name";
            // 
            // lblnamestatistic
            // 
            this.lblnamestatistic.AutoSize = true;
            this.lblnamestatistic.Location = new System.Drawing.Point(9, 35);
            this.lblnamestatistic.Name = "lblnamestatistic";
            this.lblnamestatistic.Size = new System.Drawing.Size(75, 27);
            this.lblnamestatistic.TabIndex = 10;
            this.lblnamestatistic.Text = "Name:";
            // 
            // lbllucknum
            // 
            this.lbllucknum.AutoSize = true;
            this.lbllucknum.Location = new System.Drawing.Point(136, 170);
            this.lbllucknum.Name = "lbllucknum";
            this.lbllucknum.Size = new System.Drawing.Size(24, 27);
            this.lbllucknum.TabIndex = 9;
            this.lbllucknum.Text = "0";
            // 
            // lblwisnum
            // 
            this.lblwisnum.AutoSize = true;
            this.lblwisnum.Location = new System.Drawing.Point(136, 143);
            this.lblwisnum.Name = "lblwisnum";
            this.lblwisnum.Size = new System.Drawing.Size(24, 27);
            this.lblwisnum.TabIndex = 8;
            this.lblwisnum.Text = "0";
            // 
            // lbldexnum
            // 
            this.lbldexnum.AutoSize = true;
            this.lbldexnum.Location = new System.Drawing.Point(136, 116);
            this.lbldexnum.Name = "lbldexnum";
            this.lbldexnum.Size = new System.Drawing.Size(24, 27);
            this.lbldexnum.TabIndex = 7;
            this.lbldexnum.Text = "0";
            // 
            // lblmpnum
            // 
            this.lblmpnum.AutoSize = true;
            this.lblmpnum.Location = new System.Drawing.Point(136, 89);
            this.lblmpnum.Name = "lblmpnum";
            this.lblmpnum.Size = new System.Drawing.Size(24, 27);
            this.lblmpnum.TabIndex = 6;
            this.lblmpnum.Text = "0";
            // 
            // lblstrnum
            // 
            this.lblstrnum.AutoSize = true;
            this.lblstrnum.Location = new System.Drawing.Point(136, 62);
            this.lblstrnum.Name = "lblstrnum";
            this.lblstrnum.Size = new System.Drawing.Size(24, 27);
            this.lblstrnum.TabIndex = 5;
            this.lblstrnum.Text = "0";
            // 
            // lblluckstatistic
            // 
            this.lblluckstatistic.AutoSize = true;
            this.lblluckstatistic.Location = new System.Drawing.Point(9, 170);
            this.lblluckstatistic.Name = "lblluckstatistic";
            this.lblluckstatistic.Size = new System.Drawing.Size(68, 27);
            this.lblluckstatistic.TabIndex = 4;
            this.lblluckstatistic.Text = "Luck:";
            // 
            // lblwisstatistic
            // 
            this.lblwisstatistic.AutoSize = true;
            this.lblwisstatistic.Location = new System.Drawing.Point(6, 143);
            this.lblwisstatistic.Name = "lblwisstatistic";
            this.lblwisstatistic.Size = new System.Drawing.Size(55, 27);
            this.lblwisstatistic.TabIndex = 3;
            this.lblwisstatistic.Text = "Wis:";
            // 
            // lbldexstatistic
            // 
            this.lbldexstatistic.AutoSize = true;
            this.lbldexstatistic.Location = new System.Drawing.Point(7, 116);
            this.lbldexstatistic.Name = "lbldexstatistic";
            this.lbldexstatistic.Size = new System.Drawing.Size(58, 27);
            this.lbldexstatistic.TabIndex = 2;
            this.lbldexstatistic.Text = "Dex:";
            // 
            // lblmpstatistic
            // 
            this.lblmpstatistic.AutoSize = true;
            this.lblmpstatistic.Location = new System.Drawing.Point(10, 89);
            this.lblmpstatistic.Name = "lblmpstatistic";
            this.lblmpstatistic.Size = new System.Drawing.Size(51, 27);
            this.lblmpstatistic.TabIndex = 1;
            this.lblmpstatistic.Text = "Mp:";
            // 
            // lblstrstatistic
            // 
            this.lblstrstatistic.AutoSize = true;
            this.lblstrstatistic.Location = new System.Drawing.Point(7, 62);
            this.lblstrstatistic.Name = "lblstrstatistic";
            this.lblstrstatistic.Size = new System.Drawing.Size(45, 27);
            this.lblstrstatistic.TabIndex = 0;
            this.lblstrstatistic.Text = "Str:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(352, 310);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(75, 27);
            this.lblname.TabIndex = 11;
            this.lblname.Text = "Name:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(436, 310);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(352, 32);
            this.txtname.TabIndex = 14;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // lbllooks
            // 
            this.lbllooks.AutoSize = true;
            this.lbllooks.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllooks.Location = new System.Drawing.Point(352, 352);
            this.lbllooks.Name = "lbllooks";
            this.lbllooks.Size = new System.Drawing.Size(78, 27);
            this.lbllooks.TabIndex = 15;
            this.lbllooks.Text = "Looks:";
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllooks);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.gbstatistics);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.cbwisdom);
            this.Controls.Add(this.cbluck);
            this.Controls.Add(this.cbdexterity);
            this.Controls.Add(this.cbmagic);
            this.Controls.Add(this.lblwisdom);
            this.Controls.Add(this.lblluck);
            this.Controls.Add(this.lbldexterity);
            this.Controls.Add(this.lblmagic);
            this.Controls.Add(this.lblstrength);
            this.Controls.Add(this.cbchracterpic);
            this.Controls.Add(this.cbstrength);
            this.Controls.Add(this.pbcharacter);
            this.Name = "CharacterCreation";
            this.Text = "CharacterCreation";
            this.Load += new System.EventHandler(this.CharacterCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbcharacter)).EndInit();
            this.gbstatistics.ResumeLayout(false);
            this.gbstatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbcharacter;
        private System.Windows.Forms.ComboBox cbstrength;
        private System.Windows.Forms.ComboBox cbchracterpic;
        private System.Windows.Forms.Label lblstrength;
        private System.Windows.Forms.Label lblmagic;
        private System.Windows.Forms.Label lbldexterity;
        private System.Windows.Forms.Label lblluck;
        private System.Windows.Forms.Label lblwisdom;
        private System.Windows.Forms.ComboBox cbmagic;
        private System.Windows.Forms.ComboBox cbdexterity;
        private System.Windows.Forms.ComboBox cbluck;
        private System.Windows.Forms.ComboBox cbwisdom;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.GroupBox gbstatistics;
        private System.Windows.Forms.Label lblluckstatistic;
        private System.Windows.Forms.Label lblwisstatistic;
        private System.Windows.Forms.Label lbldexstatistic;
        private System.Windows.Forms.Label lblmpstatistic;
        private System.Windows.Forms.Label lblstrstatistic;
        private System.Windows.Forms.Label lbllucknum;
        private System.Windows.Forms.Label lblwisnum;
        private System.Windows.Forms.Label lbldexnum;
        private System.Windows.Forms.Label lblmpnum;
        private System.Windows.Forms.Label lblstrnum;
        private System.Windows.Forms.Label lblchrarctername;
        private System.Windows.Forms.Label lblnamestatistic;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbllooks;
    }
}
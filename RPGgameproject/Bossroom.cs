using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGgameproject
{
    public partial class Bossroom : Form
    {
        Character info;
        Random rng = new Random();
        public Bossroom(Character c)
        {
            InitializeComponent();
            info = c;
        }

        private void Bossroom_Load(object sender, EventArgs e)
        {
            lblstrnum.Text = "" + info.stregth;
            lblmpnum.Text = "" + info.magic;
            lbldexnum.Text = "" + info.dexterity;
            lblwisnum.Text = "" + info.wisdom;
            lbllucknum.Text = "" + info.luck;
            lblhealthnum.Text = "" + info.health;
            pbcharacter.Image = info.picture;
            lblresults.Text = "";
            lblsearchoption1.Text = "";
            lblsearchoption2.Text = "";
            if (info.health == 10)
            {
                lblact4.Text = "";
            }
            pbbossroom.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}

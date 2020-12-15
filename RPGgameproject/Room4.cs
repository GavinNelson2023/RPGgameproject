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
    public partial class Room4 : Form
    {
        Character info;
        Random rng = new Random();
        public Room4(Character c)
        {
            InitializeComponent();
            info = c;
        }

        private void Room4_Load(object sender, EventArgs e)
        {
            lblstrnum.Text = "" + info.strength;
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
            pbroomfour.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public bool door = false;

        private void lblact1_Click(object sender, EventArgs e)
        {
            if (door == true)
            {
                lblresults.Text = "You try to open the door but it is still locked. You feel like you have to destroy something in the room inorder to leave.";
            }
            else
            {
                Bossroom go = new Bossroom(info);
                go.Show();
                this.Hide();
            }
        }

        private void lblact2_Click(object sender, EventArgs e)
        {

        }

        private void lblact3_Click(object sender, EventArgs e)
        {

        }

        private void lblact4_Click(object sender, EventArgs e)
        {
            if (info.health == 10)
            {
                lblresults.Text = "You are already at full health. Please select another option.";
            }
            else if (info.health == 9 || info.health == 8)
            {
                info.health = 10;
                lblresults.Text = "You heal to full health.";
                lblhealthnum.Text = "" + info.health;
                lblact4.Text = "";
            }
            else if (info.health == 7)
            {
                info.health = 9;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact4.Text = "";
            }
            else if (info.health == 6)
            {
                info.health = 8;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact4.Text = "";
            }
            else if (info.health == 5)
            {
                info.health = 7;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact4.Text = "";
            }
            else if (info.health == 4)
            {
                info.health = 6;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact4.Text = "";
            }
            else if (info.health == 3)
            {
                info.health = 5;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact4.Text = "";
            }
            else if (info.health == 2)
            {
                info.health = 4;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact4.Text = "";
            }
            else if (info.health == 1)
            {
                info.health = 3;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact4.Text = "";
            }
            else
            {
                Gameover go = new Gameover();
                go.Show();
                this.Hide();
            }
        }
    }
}

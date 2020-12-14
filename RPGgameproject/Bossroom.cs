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
            pbcharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            pbdragon.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public bool win = false;
        public bool weakness = false;

        private void lblact1_Click(object sender, EventArgs e)
        {
            if (win == true)
            {
                lblresults.Text = "You try to get to the exit but a Giant Dragon blocks your path to fame and glory.";
            }
            else
            {
                Winnerscreen go = new Winnerscreen(info);
                go.Show();
                this.Hide();
            }
        }

        private void lblact2_Click(object sender, EventArgs e)
        {
            if(weakness == false)
            {
                if (info.stregth >= 3)
                {
                    lblresults.Text = "";
                }
                else if (info.stregth == 2)
                {
                    lblresults.Text = "";
                }
                else
                {
                    lblresults.Text = "";
                }
            }
            else
            {
                lblresults.Text = "";
            }
        }

        private void lblact3_Click(object sender, EventArgs e)
        {
            int rngnum = rng.Next(0, 6);
            if (info.wisdom >= 4 && info.dexterity >= 4 && rngnum == 1)
            {
                lblresults.Text = "You focus on the Dragon in the room. You see that the dragon has a small area of sclaes missing on the right side of it's body.";
                weakness = true;
                lblact3.Text = "";
            }
            else if (info.wisdom >= 3 && info.dexterity >= 3 && rngnum == 2)
            {
                lblresults.Text = "You focus on the Dragon in the room. You notice the dragon has a slight limp on it's right side.";
                weakness = true;
                lblact3.Text = "";
            }
            else if(info.wisdom >= 3 && info.dexterity >= 3 && rngnum == 3)
            {
                lblresults.Text = "You focus on the Dragon in the room. You see that it still has an open wound on the right side of it's body";
                weakness = true;
                lblact3.Text = "";
            }
            else if(info.wisdom >= 3 && info.dexterity >= 3 && rngnum == 4)
            {
                lblresults.Text = "You focus on the Dragon in the room. You see that the dragon is blind in it's right eye.";
                weakness = true;
                lblact3.Text = "";
            }
            else if (info.wisdom >= 3 && info.dexterity >= 3 && rngnum == 5)
            {
                lblresults.Text = "You focus on the Dragon in the room. You end up focusing a little to hard. You get a really bad headache and then you blackout falling onto a convenient pile of swords.";
                info.health = info.health - 2;
                lblhealthnum.Text = "" + info.health;
                lblact3.Text = "";
            }
            else
            {
                lblresults.Text = "You focus on the Dragon in the room. You don't see any weaknesses";
                lblact3.Text = "";
            }
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

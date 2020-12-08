using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RPGgameproject
{
    public partial class Room2 : Form
    {
        Character info;
        Random rng = new Random();
        public Room2(Character c)
        {
            InitializeComponent();
            info = c;
        }


        private void Room2_Load(object sender, EventArgs e)
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
            lblact2.Text = "";
            pbroomtwo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public bool traps = true;
        public bool goodnews = false;
        public bool badnews = false;
        private void lblact1_Click(object sender, EventArgs e)
        {
            if (traps == true)
            {
                lblresults.Text = "You try to open the door but it is still locked. You feel like you have to destroy something in the room inorder to leave.";
            }
            else
            {
                Room2 go = new Room2(info);
                go.Show();
                this.Hide();
            }
            
        }

        private void lblact2_Click(object sender, EventArgs e)
        {
            if(info.wisdom >= 3)
            {
                int rngnum = rng.Next(0, 6);
                rngnum = 5;
                if(rngnum == 1)
                {
                    lblresults.Text = "With your ultra large brain you somehow disarm all the traps in the room perfectly. When you finish disarming the last trap you hear a click from the direction of the door.";
                    lblact2.Text = "";
                    lblact3.Text = "";
                    traps = false;
                }
                else if(rngnum == 2)
                {
                    lblresults.Text = "";
                    lblact2.Text = "";
                    lblact3.Text = "";
                    traps = false;
                }
                else if(rngnum == 3)
                {
                    lblresults.Text = "";
                    lblact2.Text = "";
                    lblact3.Text = "";
                    traps = false;
                }
                else if(rngnum == 4)
                {
                    lblresults.Text = "";
                    lblact2.Text = "";
                    lblact3.Text = "";
                    traps = false;
                }
                else
                {
                    lblresults.Text = "Do you want to hear the good news or the bad news?";
                    lblsearchoption1.Text = "1. Good news";
                    lblsearchoption2.Text = "2. Bad news";
                    lblact1.Text = "";
                    lblact2.Text = "";
                    lblact3.Text = "";
                    lblact4.Text = "";
                    lblhealthnum.Text = "0";
                    info.health = 0;
                }
            }
            else
            {
                
            }
        }

        private void lblact3_Click(object sender, EventArgs e)
        {
            if (info.magic >= 3)
            {
                if(info.luck >= 4)
                {
                    lblresults.Text = "You cast a spell that reveals traps. You now can see all the traps in the room.";
                    lblact2.Text = "2. Disarm Traps";
                }
                else
                {
                    lblresults.Text = "You cast a spell to detect danger. You now can see the whole world is dangerous but all the traps in the room are not helping that feeling.";
                    lblact2.Text = "2. Disarm Traps";
                }
                
            }
            else
            {
                lblresults.Text = "You acidentily steped on a preassure plate and got shot in the knee with a arrow. You suddenly feel compelled to say 'I used to be an adventurer like you. Then I took an arrow in the knee.'";
                lblact2.Text = "2. Disarm Traps";
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

        private void lblsearchoption1_Click(object sender, EventArgs e)
        {
            lblresults.Text = "The good news is you cleared the dungeon.";
            lblsearchoption1.Text = "";
            
        }

        private void lblsearchoption2_Click(object sender, EventArgs e)
        {
            
            lblresults.Text = "The bad news is you are dead, and you took half of the country side with you.";
            lblsearchoption2.Text = "";
            lblsearchoption1.Text = "";

            Thread.Sleep(1000);
            Gameover go = new Gameover();
            go.Show();
            this.Hide();
        }
    }
}

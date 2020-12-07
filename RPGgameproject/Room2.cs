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
        private void lblact1_Click(object sender, EventArgs e)
        {
            if (traps == true)
            {
                lblresults.Text = "You try to open the door but it is still locked. You might have to disarm the traps in the room.";
                lblact2.Text = "2. Disarm Traps";
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
                    traps = false;
                }
                else if(rngnum == 2)
                {
                    lblresults.Text = "";
                }
                else if(rngnum == 3)
                {
                    lblresults.Text = "";
                }
                else if(rngnum == 4)
                {
                    lblresults.Text = "";
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
                }
            }
            else
            {
                
            }
        }

        private void lblact3_Click(object sender, EventArgs e)
        {

        }

        private void lblact4_Click(object sender, EventArgs e)
        {

        }

        private void lblsearchoption1_Click(object sender, EventArgs e)
        {
            lblresults.Text = "The good news is you cleared the dungeon.";
            lblsearchoption1.Text = "";
        }

        private void lblsearchoption2_Click(object sender, EventArgs e)
        {
            //lblresults.Text = "The bad news is you are dead, and you took half of the country side with you.";
            //lblsearchoption2.Text = "";
            Gameover go = new Gameover();
            go.Show();
            this.Hide();
        }
    }
}

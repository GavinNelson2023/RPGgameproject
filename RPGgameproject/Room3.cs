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
    public partial class Room3 : Form
    {
        Character info;
        Random rng = new Random();
        public Room3(Character c)
        {
            InitializeComponent();
            info = c;
        }

        private void Room3_Load(object sender, EventArgs e)
        {
            lblstrnum.Text = "" + info.strength;
            lblmpnum.Text = "" + info.magic;
            lbldexnum.Text = "" + info.dexterity;
            lblwisnum.Text = "" + info.wisdom;
            lbllucknum.Text = "" + info.luck;
            lblhealthnum.Text = "" + info.health;
            pbcharacter.Image = info.picture;
            lblresults.Text = "You enter a large room full of tables, chairs, books, and bookshelves. There is a door directly acroos from you.";
            lblsearchoption1.Text = "";
            lblsearchoption2.Text = "";
            lblact2.Text = "";
            if (info.health == 10)
            {
                lblact4.Text = "";
            }
            pbroomthree.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public bool door = false;
        public bool Switch = false;
        private void lblact1_Click(object sender, EventArgs e)
        {
            if (door == false)
            {
                lblresults.Text = "You try to open the door but it is still locked. There must be a hidden switch nearby.";
            }
            else
            {
                Room4 go = new Room4(info);
                go.Show();
                this.Hide();
            }
        }

        private void lblact2_Click(object sender, EventArgs e)
        {
            if(Switch == true)
            {
                lblresults.Text = "You turn the hidden switch on and then you hear a faint click from the direction of the door opposite from where you came in.";
                door = true;
                lblact2.Text = "";
            }
            
        }

        private void lblact3_Click(object sender, EventArgs e)
        {
            if (info.magic >= 3)
            {
                lblresults.Text = "You cast a spell that revels the hidden switch in the room.";
                lblact3.Text = "";
                lblact2.Text = "2. Activate Hidden Switch";
                Switch = true;
            }
            else
            {
                lblresults.Text = "You can't seem to get any spell to work in this room. But you randomly stumbled upon a hidden Switch behimd a bookshelf.";
                lblact3.Text = "";
                lblact2.Text = "2. Activate Hidden Switch";
                Switch = true;
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

        private void label1_Click(object sender, EventArgs e)
        {
            if(info.luck >= 3)
            {
                int rngnum = rng.Next(0, 3);
                if(rngnum == 1)
                {
                    lblresults.Text = "When you are done reading the book you chose you suddenly feel stronger.";
                    info.strength = info.strength + 1;
                    lblstrnum.Text = "" + info.strength;
                    lblact5.Text = "";
                }
                else if(rngnum == 2)
                {
                    lblresults.Text = "When you are done reading the book you chose you suddenly feel faster and more nimble.";
                    info.dexterity = info.dexterity + 1;
                    lbldexnum.Text = "" + info.dexterity;
                    lblact5.Text = "";
                }
                else
                {
                    lblresults.Text = "When you are done reading the book you chose you suddenly feel smarter.";
                    info.wisdom = info.wisdom + 1;
                    lblwisnum.Text = "" + info.wisdom;
                    lblact5.Text = "";
                }
            }
            else
            {
                lblresults.Text = "The book you chose is completely blank.";
                lblact5.Text = "";
            }
        }
    }
}

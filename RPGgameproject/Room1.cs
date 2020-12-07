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
    public partial class Room1 : Form
    {
        Character info;
        Random rng = new Random();
        public Room1(Character c)
        {
            InitializeComponent();
            info = c;
        }

        private void Room1_Load_1(object sender, EventArgs e)
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
            pbroomone.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }
       

        private void lblact1_Click(object sender, EventArgs e)
        {
            if (key == false)
            {
                lblresults.Text = "You try to open the door but it is still locked. You have a feeling the key is nearby.";
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
            if(info.stregth >= 3)
            {
                int rngnum = rng.Next(0,4);
                if(rngnum == 1 || rngnum == 2)
                {
                    
                    if(info.luck >= 3 && key == false)
                    {
                        lblresults.Text = "You swing your sword and crush the skull of the skeleton. You find a key inside it's pulverized skull.";
                        lblact3.Text = "";
                        lblact2.Text = "";
                        key = true;
                        attacked = true;
                    }
                    else if(info.luck >= 3 && key == true)
                    {
                        lblresults.Text = "You swing your sword and crush the skull of the skeleton.";
                        lblact2.Text = "";
                        lblact3.Text = "";
                        attacked = true;
                    }
                }
                else
                {
                    lblresults.Text = "You swing your sword at the skeleton but you somehow get your sword stuck in it's ribcage. The skeleton looks very annoyed. Then the skeleton quickly stabs you and at the same time it removes the sword from it's ribcage and leaves the room.";
                    info.health = info.health - 2;
                    lblhealthnum.Text = "" + info.health;
                    lblact2.Text = "";
                    lblact4.Text = "4. Heal";
                    attacked = true;
                }
            }
            else
            {
                lblresults.Text = "You attacked the skeleton but missed and then the skeleton escapes through the door on the other side of the room.";
                lblact2.Text = "";
                attacked = true;
            }
            pbroomone.Image = Properties.Resources.Dungoen_room_1_without_enemy;
        }

        private void lblact3_Click(object sender, EventArgs e)
        {
            lblresults.Text = "Where do you want to search first?";
            lblact1.Text = "";
            lblact2.Text = "";
            lblact3.Text = "";
            lblact4.Text = "";
            lblsearchoption1.Text = "1. Search around the door.";
            lblsearchoption2.Text = "2. Search around the edge of the room.";
            
        }

        private void lblact4_Click(object sender, EventArgs e)
        {
            if(info.health == 10)
            {
                lblresults.Text = "You are already at full health. Please select another option.";
            }
            else if(info.health == 9 || info.health == 8)
            {
                info.health = 10;
                lblresults.Text = "You heal to max health";
                lblhealthnum.Text = "" + info.health;
                lblact4.Text = "";
            }
        }

        public bool key;
        public bool attacked;
        

        private void lblsearchoption1_Click(object sender, EventArgs e)
        {
            if(info.luck == 5)
            {
                lblresults.Text = "While you where walking to the door you ended up triping and falling on top of a key. You have aquired a key!";
                lblsearchoption1.Text = "";
                lblsearchoption2.Text = "";
                lblact1.Text = "1. Open Door";
                key = true;
                if (attacked == true)
                {
                    lblact2.Text = "";
                }
                else
                {
                    lblact2.Text = "2. Attack Enemy";
                }
                if (info.health == 10)
                {
                    lblact4.Text = "";
                }
                else
                {
                    lblact4.Text = "4. Heal";
                }

                
            }
            else
            {
                lblresults.Text = "You searched around the door but found nothing.";
                lblsearchoption1.Text = "";
            }
            
        }

        private void lblsearchoption2_Click(object sender, EventArgs e)
        {
           
            if (info.wisdom >= 3)
            {
                lblresults.Text = "You notice that one of the floor boards is a differnt color. So you pull on it and it comes loose. you find a key underneath in the hidden compartment. You have aquired a key!";
                key = true;
                lblsearchoption1.Text = "";
                lblsearchoption2.Text = "";
                lblact1.Text = "1. Open Door";
                if (attacked == true)
                {
                    lblact2.Text = "";
                }
                else
                {
                    lblact2.Text = "2. Attack Enemy";
                }
                if (info.health == 10)
                {
                    lblact4.Text = "";
                }
                else
                {
                    lblact4.Text = "4. Heal";
                }
            }
            else
            {
                lblresults.Text = "You searched around the edges of the room and find a key.";
                lblsearchoption1.Text = "";
                lblsearchoption2.Text = "";
                lblact1.Text = "1. Open Door";
                if (attacked == true)
                {
                    lblact2.Text = "";
                }
                else
                {
                    lblact2.Text = "2. Attack Enemy";
                }
                if (info.health == 10)
                {
                    lblact4.Text = "";
                }
                else
                {
                    lblact4.Text = "4. Heal";
                }
                key = true;
            }
        }

        
    }
}

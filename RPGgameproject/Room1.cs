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
        Character d = new Character();
        Random rng = new Random();
        public Room1(Character c)
        {
            InitializeComponent();
            info = c;
        }

        private void Room1_Load(object sender, EventArgs e)
        {
            lblstrnum.Text = "" + info.stregth;
            lblmpnum.Text = "" + info.magic;
            lbldexnum.Text = "" + info.dexterity;
            lblwisnum.Text = "" + info.wisdom;
            lbllucknum.Text = "" + info.luck;
            lblhealthnum.Text = "" + info.health;
            lblresults.Text = "";
            lblsearchoption1.Text = "";
            lblsearchoption2.Text = "";

        }

        private void lblact1_Click(object sender, EventArgs e)
        {
            if (key == false)
            {
                string message = "You try to open the door but it is still locked. You have a feeling the key is nearby.";
                MessageBox.Show(message);
            }
            else
            {
                Room2 go = new Room2(d);
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
                        lblresults.Text = "You swing your sword and decapitate the enemy. You find a key on it's body.";
                        key = true;
                        lblact3.Text = "";
                        lblact2.Text = "";
                    }
                    else if(info.luck >= 3 && key == true)
                    {
                        lblresults.Text = "You swing your sword and decapitate the enemy.";
                        lblact2.Text = "";
                        lblact3.Text = "";
                    }
                }
                else
                {
                    lblresults.Text = "You swing your sword at the enemy but you missed and hit yourself. The enemy ran away while you were distracted.";
                    info.health = info.health - 1;
                    lblact2.Text = "";
                }
            }
            else
            {
                lblresults.Text = "You attacked the enemy but missed and then enemy ran away.";
                lblact2.Text = "";
            }
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

        }

        public bool key;
        public bool searched;

        private void lblsearchoption1_Click(object sender, EventArgs e)
        {
            if(info.luck == 5)
            {
                lblresults.Text = "While you where walking to the door you ended up triping and falling on top of a key. You have aquired a key!";
                key = true;
                searched = true;
                lblsearchoption1.Text = "";
                lblsearchoption2.Text = "";
                lblact1.Text = "1. Open Door";
                lblact2.Text = "2. Attack Enemy";
                lblact4.Text = "4. Heal";
            }
            else
            {
                lblresults.Text = "You searched around the door but found nothing.";
                searched = true;
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
                lblact2.Text = "2. Attack Enemy";
                lblact4.Text = "4. Heal";
            }
            else
            {
                lblresults.Text = "You searched around the edges of the room and find a key.";
                lblsearchoption1.Text = "";
                lblsearchoption2.Text = "";
                lblact1.Text = "1. Open Door";
                lblact2.Text = "2. Attack Enemy";
                lblact4.Text = "4. Heal";
            }
        }
    }
}

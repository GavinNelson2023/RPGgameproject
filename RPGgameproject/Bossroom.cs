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
                lblact5.Text = "";
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
                if (info.strength >= 3)
                {
                    lblresults.Text = "You attack the dragon without a plan.";
                    int rngnum = rng.Next(0, 4);
                    int dragonrngnum = rng.Next(0, 3);
                    if (dragonrngnum == 1)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 1;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 1 damage to the dragon.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 2;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 2 damage to the dragon.";
                        }
                        else
                        {
                            info.dragonhealth = info.dragonhealth - 3;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 3 damage to the dragon.";
                        }
                    }
                    else if (dragonrngnum == 2)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 1;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 1 damage to the dragon.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 2;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 2 damage to the dragon.";
                        }
                        else
                        {
                            lblresults.Text = "You miss";
                        }
                    }
                }
                else if (info.strength == 2)
                {
                    lblresults.Text = "You attack the dragon without a plan.";
                    int rngnum = rng.Next(0, 4);
                    int dragonrngnum = rng.Next(0, 3);
                    if (dragonrngnum == 1)
                    {
                        if (rngnum == 1)
                        {
                            
                            lblresults.Text = "Your sword bounces off the dragons scales.";
                        }
                        else if (rngnum == 2)
                        {
                            
                            lblresults.Text = "The dragon knocks you over with it's tale stoping you from attacking.";
                        }
                        else
                        {
                            info.dragonhealth = info.dragonhealth - 1;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 1 damage to the dragon. Only because the dragon caught your sword in it's claw causing a small cut.";
                        }
                    }
                    else if (dragonrngnum == 2)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 2;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 2 damage to the dragon.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 1;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 1 damage to the dragon.";
                        }
                        else
                        {
                            lblresults.Text = "You miss";
                        }
                    }
                }
                else
                {
                    lblresults.Text = "You attack the dragon without a plan and you miss the dragon completly.";

                }
            }
            else //if weakness == true;
            {
                if (info.strength >= 3)
                {
                    lblresults.Text = "You attack the dragon.";
                    Thread.Sleep(1500);
                    int rngnum = rng.Next(0,4);
                    int dragonrngnum = rng.Next(0,3);
                    if(dragonrngnum == 1)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 3;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 3 damage to the dragon.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 4;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 4 damage to the dragon.";
                        }
                        else
                        {
                            info.dragonhealth = info.dragonhealth - 5;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 5 damage to the dragon.";
                        }
                    }
                    else if (dragonrngnum == 2)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 2;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 2 damage to the dragon.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 1;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 1 damage to the dragon.";
                        }
                        else
                        {
                            lblresults.Text = "You miss";
                        }
                    }
                    
                }
                else if (info.strength == 2)
                {
                    lblresults.Text = "You throw your sword at the dragon.";
                    int rngnum = rng.Next(0, 4);
                    int dragonrngnum = rng.Next(0, 3);
                    if (dragonrngnum == 1)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 2;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 2 damage to the dragon and you retrieve your sword.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 3;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 3 damage to the dragon and you retrieve your sword.";
                        }
                        else
                        {
                            info.dragonhealth = info.dragonhealth - 4;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 4 damage to the dragon and you retrieve your sword.";
                        }
                        
                    }
                    else if (dragonrngnum == 2)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 2;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 2 damage to the dragon and you retrieve your sword.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 1;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 1 damage to the dragon and you retrieve your sword.";
                        }
                        else
                        {
                            lblresults.Text = "You miss but you end up retrieving your sword.";
                        }
                    }
                }
                else
                {
                    lblresults.Text = "You try try to attack the dragon. But the dragon holds you in place at a safe distance with a long stick.";
                    lblact2.Text = "";
                }
            }
        }
        private void lblact3_Click_1(object sender, EventArgs e)
        {
            if (weakness == false)
            {
                if (info.magic >= 3)
                {
                    lblresults.Text = "You attack the dragon without a plan.";
                    int rngnum = rng.Next(0, 4);
                    int dragonrngnum = rng.Next(0, 3);
                    if (dragonrngnum == 1)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 1;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 1 damage to the dragon.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 2;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 2 damage to the dragon.";
                        }
                        else
                        {
                            info.dragonhealth = info.dragonhealth - 3;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 3 damage to the dragon.";
                        }
                    }
                    else if (dragonrngnum == 2)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 1;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 1 damage to the dragon.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 2;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 2 damage to the dragon.";
                        }
                        else
                        {
                            lblresults.Text = "You miss";
                        }
                    }
                }
                else if (info.magic == 2)
                {
                    lblresults.Text = "You attack the dragon without a plan.";
                    int rngnum = rng.Next(0, 4);
                    int dragonrngnum = rng.Next(0, 3);
                    if (dragonrngnum == 1)
                    {
                        if (rngnum == 1)
                        {

                            lblresults.Text = "Your spell bounces off the dragons scales.";
                        }
                        else if (rngnum == 2)
                        {

                            lblresults.Text = "The dragon knocks you over with it's tale stoping you from attacking.";
                        }
                        else
                        {
                            info.dragonhealth = info.dragonhealth - 1;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 1 damage to the dragon because you went for a low blow. The dragon's face.";
                        }
                    }
                    else if (dragonrngnum == 2)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 2;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 2 damage to the dragon.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 1;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 1 damage to the dragon.";
                        }
                        else
                        {
                            lblresults.Text = "You miss";
                        }
                    }
                }
                else
                {
                    lblresults.Text = "You attack the dragon without a plan and you miss the dragon completly.";

                }
            }
            else //if weakness == true;
            {
                if (info.magic >= 3)
                {
                    lblresults.Text = "You attack the dragon.";
                    Thread.Sleep(1500);
                    int rngnum = rng.Next(0, 4);
                    int dragonrngnum = rng.Next(0, 3);
                    if (dragonrngnum == 1)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 3;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 3 damage to the dragon.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 4;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 4 damage to the dragon.";
                        }
                        else
                        {
                            info.dragonhealth = info.dragonhealth - 5;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 5 damage to the dragon.";
                        }
                    }
                    else if (dragonrngnum == 2)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 2;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 2 damage to the dragon.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 1;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You deal 1 damage to the dragon.";
                        }
                        else
                        {
                            lblresults.Text = "You miss";
                        }
                    }

                }
                else if (info.magic == 2)
                {
                    lblresults.Text = "You cast a random spell and hope that it works.";
                    int rngnum = rng.Next(0, 4);
                    int dragonrngnum = rng.Next(0, 3);
                    if (dragonrngnum == 1)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 2;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You cast a confusion spell on the dragon so it falls onto a convenient pile of swords. The dragon takes 2 points of damage.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 3;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You cast frostblot and deal 3 damage to the dragon.";
                        }
                        else
                        {
                            info.dragonhealth = info.dragonhealth - 4;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You cast animate dead causing multiple nearby skeletons to shudder to life again and start to stumble torwads the dragon. The skeletons deal 4 damage to the dragon.";
                        }

                    }
                    else if (dragonrngnum == 2)
                    {
                        if (rngnum == 1)
                        {
                            info.dragonhealth = info.dragonhealth - 2;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You cast fire bolt dealing 2 damage to the dragon.";
                        }
                        else if (rngnum == 2)
                        {
                            info.dragonhealth = info.dragonhealth - 1;
                            lbldragonhealth.Text = "" + info.dragonhealth;
                            lblresults.Text = "You cast a mind control spell but you end up contoling a very large mass of ants. The ants deal 1 damage to the dragon.";
                        }
                        else
                        {
                            lblresults.Text = "You miss but you end up causing a massive explosion.";
                        }
                    }
                }
                else
                {
                    lblresults.Text = "You try try to attack the dragon. But the dragon casts a counter spell that negates any spell cast within it's range";
                    lblact3.Text = "";
                }
            }
        }

        private void lblact3_Click(object sender, EventArgs e)
        {
            int rngnum = rng.Next(0, 6);
            if (info.wisdom >= 4 && info.dexterity >= 4 && rngnum == 1)
            {
                lblresults.Text = "You focus on the Dragon in the room. You see that the dragon has a small area of sclaes missing on the right side of it's body.";
                weakness = true;
                lblact4.Text = "";
            }
            else if (info.wisdom >= 3 && info.dexterity >= 3 && rngnum == 2)
            {
                lblresults.Text = "You focus on the Dragon in the room. You notice the dragon has a slight limp on it's right side.";
                weakness = true;
                lblact4.Text = "";
            }
            else if(info.wisdom >= 3 && info.dexterity >= 3 && rngnum == 3)
            {
                lblresults.Text = "You focus on the Dragon in the room. You see that it still has an open wound on the right side of it's body";
                weakness = true;
                lblact4.Text = "";
            }
            else if(info.wisdom >= 3 && info.dexterity >= 3 && rngnum == 4)
            {
                lblresults.Text = "You focus on the Dragon in the room. You see that the dragon is blind in it's right eye.";
                weakness = true;
                lblact4.Text = "";
            }
            else if (info.wisdom >= 3 && info.dexterity >= 3 && rngnum == 5)
            {
                lblresults.Text = "You focus on the Dragon in the room. You end up focusing a little to hard. You get a really bad headache and then you blackout falling onto a convenient pile of swords.";
                info.health = info.health - 2;
                lblhealthnum.Text = "" + info.health;
                lblact4.Text = "";
            }
            else
            {
                lblresults.Text = "You focus on the Dragon in the room. You don't see any weaknesses";
                lblact4.Text = "";
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
                lblact5.Text = "";
            }
            else if (info.health == 7)
            {
                info.health = 9;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact5.Text = "";
            }
            else if (info.health == 6)
            {
                info.health = 8;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact5.Text = "";
            }
            else if (info.health == 5)
            {
                info.health = 7;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact5.Text = "";
            }
            else if (info.health == 4)
            {
                info.health = 6;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact5.Text = "";
            }
            else if (info.health == 3)
            {
                info.health = 5;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact5.Text = "";
            }
            else if (info.health == 2)
            {
                info.health = 4;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact5.Text = "";
            }
            else if (info.health == 1)
            {
                info.health = 3;
                lblresults.Text = "You heal for two points of damage.";
                lblhealthnum.Text = "" + info.health;
                lblact5.Text = "";
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

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
            lblresults.Text = "You enter a large room with a chest in the center and a large door directly behind it with a large gold lock.";
            lblsearchoption1.Text = "";
            lblsearchoption2.Text = "";
            lblact2.Text = "";
            if (info.health == 10)
            {
                lblact4.Text = "";
            }
            pbroomfour.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public bool door = false;
        public bool chest = false;
        public int mimichealth = 10;

        private void lblact1_Click(object sender, EventArgs e)
        {
            if (door == false)
            {
                lblresults.Text = "There is a giant lock on the door stoping you from entering the next room.";
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
            if (info.strength >= 3)
            {
                int rngnum = rng.Next(0, 4);
                if (rngnum == 1 || rngnum == 2)
                {

                    if (info.luck >= 3)
                    {
                        lblresults.Text = "You swing your sword and chop of it's long tongue. You deal 4 points of damage to the mimic.";
                        mimichealth = mimichealth - 4;
                        lblmimichealthnum.Text = "" + mimichealth;
                        if(mimichealth <= 0)
                        {
                            Thread.Sleep(750);
                            lblresults.Text = "You have killed the mimic. You find a gold key on it's dead body.";
                            lblact2.Text = "";
                            door = true;
                        }
                    }
                    else if (info.luck >= 3)
                    {
                        lblresults.Text = "You swing your sword and slice clean through the top right corner of the mimic. You deal 5 points of damage to the mimic.";
                        mimichealth = mimichealth - 5;
                        lblmimichealthnum.Text = "" + mimichealth;
                        if (mimichealth <= 0)
                        {
                            Thread.Sleep(750);
                            lblresults.Text = "You have killed the mimic. You find a gold key on it's dead body.";
                            lblact2.Text = "";
                            door = true;
                        }
                    }
                }
                else
                {
                    lblresults.Text = "You attacked the mimic but only end up grazing it. You deal 1 point of damage to the mimic.";
                    mimichealth = mimichealth - 1;
                    lblmimichealthnum.Text = "" + mimichealth;
                    if (mimichealth <= 0)
                    {
                        Thread.Sleep(750);
                        lblresults.Text = "You have killed the mimic. You find a gold key on it's dead body.";
                        lblact2.Text = "";
                        door = true;
                    }
                }
            }
            else
            {
                int rngnum = rng.Next(0, 3);
                if(rngnum == 1)
                {
                    lblresults.Text = "You swing your sword at the mimic and get you sword stuck in it's side. You quickly pull your sword out but not before the mimic bites you. You take 2 points of damage.";
                    info.health = info.health - 2;
                    lblhealthnum.Text = "" + info.health;
                    if(info.health <= 0)
                    {
                        Gameover go = new Gameover();
                        go.Show();
                        this.Hide();
                    }
                    mimichealth = mimichealth - 3;
                    lblmimichealthnum.Text = "" + mimichealth;
                    if (mimichealth <= 0)
                    {
                        Thread.Sleep(750);
                        lblresults.Text = "You have killed the mimic. You find a gold key on it's dead body.";
                        lblact2.Text = "";
                        door = true;
                    }
                    lblact4.Text = "4. Heal";
                }
                else
                {
                    lblresults.Text = "You stab the mimic with your sword. You deal 3 points of damage to the mimic.";
                    mimichealth = mimichealth - 3;
                    lblmimichealthnum.Text = "" + mimichealth;
                    if (mimichealth <= 0)
                    {
                        Thread.Sleep(750);
                        lblresults.Text = "You have killed the mimic. You find a gold key on it's dead body.";
                        lblact2.Text = "";
                        door = true;
                    }
                }
            }
        }
    

        private void lblact3_Click(object sender, EventArgs e)
        {
            if (info.wisdom <= 2)
            {
                lblresults.Text = "When you go to open the chest it shudenly attacks you unveiling that it was a mimic. you take 3 points of damage.";
                info.health = info.health - 3;
                lblhealthnum.Text = "" + info.health;
                lblact3.Text = "";
                lblact2.Text = "2. Attack Enemy";
            }
            else
            {
                lblresults.Text = "You see the chest breathing a little out of the coner of your eye.";
                lblact3.Text = "";
                lblact2.Text = "2. Attack Enemy";
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

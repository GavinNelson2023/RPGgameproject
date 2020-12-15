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
    public partial class CharacterCreation : Form
    {
        int str;
        int luck;
        int wis;
        int mp;
        int dex;
        int health = 10;
        

        string name;
        string picture;

        Character n = new Character();
        public CharacterCreation()
        {
            InitializeComponent();
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {
            

        }

        private void cbstrength_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            str = Convert.ToInt32(cbstrength.Text);
            lblstrnum.Text = cbstrength.Text;
            cbmagic.Items.Remove(cbstrength.Text);
            cbdexterity.Items.Remove(cbstrength.Text);
            cbwisdom.Items.Remove(cbstrength.Text);
            cbluck.Items.Remove(cbstrength.Text);

        }
        private void cbmagic_SelectedIndexChanged(object sender, EventArgs e)
        {
            mp = Convert.ToInt32(cbmagic.Text);
            lblmpnum.Text = cbmagic.Text;
            cbstrength.Items.Remove(cbmagic.Text);
            cbdexterity.Items.Remove(cbmagic.Text);
            cbwisdom.Items.Remove(cbmagic.Text);
            cbluck.Items.Remove(cbmagic.Text);
        }
        private void cbdexterity_SelectedIndexChanged(object sender, EventArgs e)
        {
            dex = Convert.ToInt32(cbdexterity.Text);
            lbldexnum.Text = cbdexterity.Text;
            cbstrength.Items.Remove(cbdexterity.Text);
            cbmagic.Items.Remove(cbdexterity.Text);
            cbwisdom.Items.Remove(cbdexterity.Text);
            cbluck.Items.Remove(cbdexterity.Text);
        }
        private void cbwisdom_SelectedIndexChanged(object sender, EventArgs e)
        {
            wis = Convert.ToInt32(cbwisdom.Text);
            lblwisnum.Text = cbwisdom.Text;
            cbstrength.Items.Remove(cbwisdom.Text);
            cbdexterity.Items.Remove(cbwisdom.Text);
            cbmagic.Items.Remove(cbwisdom.Text);
            cbluck.Items.Remove(cbwisdom.Text);
        }
        private void cbluck_SelectedIndexChanged(object sender, EventArgs e)
        {
            luck = Convert.ToInt32(cbluck.Text);
            lbllucknum.Text = cbluck.Text;
            cbstrength.Items.Remove(cbluck.Text);
            cbdexterity.Items.Remove(cbluck.Text);
            cbwisdom.Items.Remove(cbluck.Text);
            cbmagic.Items.Remove(cbluck.Text);
        }
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if(str != 0 && mp != 0 && dex != 0 && wis != 0 && luck != 0 && cbchracterpic.Text != "" && txtname.Text != "")
            {
                n.strength = str;
                n.dexterity = dex;
                n.wisdom = wis;
                n.magic = mp;
                n.luck = luck;
                n.health = 10;
                n.name = txtname.Text;
                n.picture = pbcharacter.Image;


                Room1 go = new Room1(n);
                go.Show();
                this.Hide();
            }
            else
            {
                string message = "Please finish entering all required information";
                MessageBox.Show(message);
                
            }
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cbchracterpic.Text == "Wizard")
            {
                pbcharacter.Image = Properties.Resources.Wizard_Alligator;
            }
            else if(cbchracterpic.Text == "Alien")
            {
                pbcharacter.Image = Properties.Resources.Alien_Dog;
            }
            else if (cbchracterpic.Text == "Soldier")
            {
                pbcharacter.Image = Properties.Resources.Soldier_Dog;
            }
            else if (cbchracterpic.Text == "Tank")
            {
                pbcharacter.Image = Properties.Resources.Bear_Tank;
            }
            
            pbcharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
    }
}

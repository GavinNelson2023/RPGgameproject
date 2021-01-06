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
    public partial class Winnerscreen : Form
    {
        Character info;
        public Winnerscreen(Character c)
        {
            InitializeComponent();
            info = c;
        }

        private void Winnerscreen_Load(object sender, EventArgs e)
        {
            lblname.Text = info.name;
            pbcharacter.Image = info.picture;
            pbwin.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnstartover_Click(object sender, EventArgs e)
        {
            CharacterCreation go = new CharacterCreation();
            go.Show();
            this.Hide();
        }

        private void btnclosegame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

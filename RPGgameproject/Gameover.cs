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
    public partial class Gameover : Form
    {
        public Gameover()
        {
            InitializeComponent();
        }

        private void Gameover_Load(object sender, EventArgs e)
        {
            pbdeath.SizeMode = PictureBoxSizeMode.StretchImage;

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

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
        public Room1(Character c)
        {
            InitializeComponent();
            info = c;
        }

        private void Room1_Load(object sender, EventArgs e)
        {

        }
    }
}

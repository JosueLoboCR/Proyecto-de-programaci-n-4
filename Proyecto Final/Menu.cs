using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class MenuVertical : Form
    {
        public MenuVertical()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.width == 250)
            {
                MenuVertical.width = 80;
            }
            else
                MenuVertical.width = 250;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

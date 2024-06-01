using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pluto_Launcher_V1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
       
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            pictureBox1.Parent = pictureBox2;
            pictureBox1.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

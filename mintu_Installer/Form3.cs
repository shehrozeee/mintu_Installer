using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mintu_Installer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int n1 = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                pictureBox1.Image = global::mintu_Installer.Properties.Resources.h2;
                n1++;
                return;
            }
            if (n1 == 1) { pictureBox1.Image = global::mintu_Installer.Properties.Resources.h3; n1++; return; }
            if (n1 == 2) { pictureBox1.Image = global::mintu_Installer.Properties.Resources.h4; n1++; return; }
            if (n1 == 3) { pictureBox1.Image = global::mintu_Installer.Properties.Resources.h5; n1++; return; }
            if (n1 == 4) { pictureBox1.Image = global::mintu_Installer.Properties.Resources.h6; n1++; return; }
            if (n1 == 5) { pictureBox1.Image = global::mintu_Installer.Properties.Resources.h1; n1 = 0; return; }

        }
    }
}

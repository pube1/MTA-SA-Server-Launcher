using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdmdeneme
{
    public partial class yuklenmeekrani : Form
    {
        public yuklenmeekrani()
        {
            InitializeComponent();
        }

        public void yuklenmeekrani_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;

            if (panel2.Width == 151)
            {
                label1.Text = "Info: This loading screen doesn't actually do anything";
            }

           else if (panel2.Width >= 383)
            {
                timer1.Stop();
                Form1 mainscreen = new Form1();
                mainscreen.Show();
                this.Hide();
            }
        }
    }
}

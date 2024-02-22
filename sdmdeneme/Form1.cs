using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Net;
using System.Security.Policy;
using System.Runtime.Remoting.Contexts;



namespace sdmdeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            label3.Text = "Welcome!" + " " + Environment.UserName;

            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
                this.WindowState = FormWindowState.Minimized;

                string target = "mtasa://ip:port"; // In this line you need write your server ip and port 

                System.Diagnostics.Process.Start(target); 
            

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Exit button
            var durum=MessageBox.Show("Really? Will you exit this beautiful application?", ":(",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if (durum == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // minimize button
            this.WindowState = FormWindowState.Minimized;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string discord = "https://discord.gg/"; // You can write here your discord server link

            System.Diagnostics.Process.Start(discord);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // When the connect button is pressed getting notification

            if (FormWindowState.Minimized == WindowState)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "If you want to open me again you can click on me twice";
                notifyIcon1.BalloonTipTitle = "I AM HERE!!";
                notifyIcon1.Text = "MTA Server Launcher";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(30000);
                ShowInTaskbar = false;
            }
            else
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {   // Code that makes the application appear on the screen again when the notification button is pressed

            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //nothing .d  
        }
    }
}

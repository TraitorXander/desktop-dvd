using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDTest
{
    public partial class Main : Form
    {
        int locX = 0, locY = 0;
        int speedX = 5, speedY = 5;
        Image imgDVD;
        
        public Main()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Region = new Region(imgMain.Bounds);
            this.TransparencyKey = Color.White;
            this.BackColor = Color.White;

            try
            {
                imgDVD = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + Defs.dvdPath);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Cant find Assets:\n" + exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

            Bitmap newImg = new Bitmap(imgDVD, imgMain.Size);
            imgMain.BackgroundImage = newImg;

            this.Size = new Size(imgMain.Size.Width + 10, imgMain.Size.Height + 5);

            locX = imgMain.Location.X;
            locY = imgMain.Location.Y;
        }

        private void MainEvent()
        {            
            while (true)
            {
            this.Location = new Point(locX, locY);

            locX += speedX;
            locY += speedY;

            //if (locX < 0 || locX + imgMain.Width > Screen.PrimaryScreen.Bounds.Width)
            if (locX < 0 || locX + imgMain.Width > Screen.GetWorkingArea(this.Location).Width)
            {
                speedX *= -1;
            }

            //if (locY < 0 || locY + imgMain.Height > Screen.PrimaryScreen.Bounds.Height)
            if (locY < 0 || locY + imgMain.Height > Screen.GetWorkingArea(this.Location).Height)
            {
                speedY *= -1;
            }

            Thread.Sleep(25);
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                MainEvent();
            }
        }
    }
}

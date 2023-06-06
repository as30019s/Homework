using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Homework_10_Frm : Form
    {
        public Homework_10_Frm()
        {
            InitializeComponent();
        }
        
        // Date time display
        private void timer_dateTime_Tick(object sender, EventArgs e)
        {
            label_dateTime.Text = DateTime.Now.ToString();
        }

        // photo select and move step setting
        int currentPhoto = 0;
        int xStep = 5;
        int yStep = 5;
        private void timer_photo_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            int width = this.Width;
            int height = this.Height;

            if (x < 0 || x + pictureBox1.Width > width)
            {
                xStep *= -1;
            }
            if (y < 0 || y + pictureBox1.Height > height)
            {
                yStep *= -1;
            }
            x += xStep;
            y += yStep;
            pictureBox1.Location = new Point(x, y);

        }

        private void timer_photoChange_Tick(object sender, EventArgs e)
        {
            currentPhoto++;
            if (currentPhoto > 4) { currentPhoto = 0; }
            switch (currentPhoto)
            {
                case 0:
                    pictureBox1.BackgroundImage = Properties.Resources.P3;
                    break;
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources.P4;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.P5;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources.P6;
                    break;
                case 4:
                    pictureBox1.BackgroundImage = Properties.Resources.P7;
                    break;
            }
        }

        private void Homework_10_Frm_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

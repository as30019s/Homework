using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Homework_13_Frm : Form
    {
        public Homework_13_Frm()
        {
            InitializeComponent();
            pictureBox();
        }

        public void pictureBox()
        {
            List<PictureBox> lsPB = new List<PictureBox>();
            string[] imagePath = Directory.GetFiles(@"..\..\Resources\", "*.jp*");
            foreach (string item in imagePath)
            {
                PictureBox PB = new PictureBox();
                PB.Size = new Size(200, 200);
                PB.SizeMode = PictureBoxSizeMode.Zoom;
                PB.Image = Image.FromFile(item);
                flowLayoutPanel.Controls.Add(PB);
                PB.MouseClick += PB_MouseClick;
            }

        }

        private void PB_MouseClick(object sender, MouseEventArgs e)
        {
            Form singleImgForm = new Form();
            singleImgForm.BackgroundImage = ((PictureBox)sender).Image;
            singleImgForm.BackgroundImageLayout = ImageLayout.Zoom;
            singleImgForm.Show();
        }
    }
}

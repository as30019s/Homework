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
        // parameter definition
        FolderBrowserDialog folderBrowserDialog;
        List<PictureBox> lsPB;
        string folderPath;
        string[] imagePath;
        Image[] images = { Properties.Resources.P1, Properties.Resources.P2, Properties.Resources.P3, Properties.Resources.P4, Properties.Resources.P5, Properties.Resources.P6, Properties.Resources.P7 };

        public Homework_13_Frm()
        {
            InitializeComponent();
            resourcesPicture();
        }

        public void resourcesPicture()
        {
            foreach (Image item in images)
            {
                PictureBox PB = new PictureBox();
                PB.Size = new Size(200, 200);
                PB.SizeMode = PictureBoxSizeMode.Zoom;
                PB.Image = item;
                flowLayoutPanel.Controls.Add(PB);
                PB.MouseClick += PB_MouseClick;
            }


        }

        public void pictureBox()
        {
            lsPB = new List<PictureBox>();
            
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

        // Open single form for image
        private void PB_MouseClick(object sender, MouseEventArgs e)
        {
            Form singleImgForm = new Form();
            singleImgForm.BackgroundImage = ((PictureBox)sender).Image;
            singleImgForm.BackgroundImageLayout = ImageLayout.Zoom;
            singleImgForm.Show();
        }

        private void 開啟資料夾ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
                imagePath = Directory.GetFiles(folderPath, "*.jp*");
            }

            // Clear current picture box
            List<Control> listControls = new List<Control>();

            foreach (Control control in flowLayoutPanel.Controls)
            {
                listControls.Add(control);
            }

            foreach (Control control in listControls)
            {
                flowLayoutPanel.Controls.Remove(control);
                control.Dispose();
            }

            pictureBox();
        }
    }
}

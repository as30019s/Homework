using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
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
        string folderPath;
        string[] imagePath;
        
        public Homework_13_Frm()
        {
            InitializeComponent();
            resourcesPicture();
        }

        public void resourcesPicture()
        {
            List<Image> dynamicImageList = new List<Image>();
            var resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.InvariantCulture,true,false);
            if (resourceSet != null)
            {
                foreach (DictionaryEntry entry in resourceSet)
                {
                    var value = entry.Value as Bitmap;
                    if (value != null)
                    {
                        dynamicImageList.Add((Image)value);
                    }
                }
            }

            foreach (Image item in dynamicImageList)
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

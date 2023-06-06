using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homework
{
    public partial class Homework_12_Frm : Form
    {
        public Homework_12_Frm()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(800,600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);

            PB_currentColor.BackColor = Color.Black;
        }

        // mouse location
        int x, y;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; 
            y = e.Y;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            MyDialog.AllowFullOpen = false;

            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                PB_currentColor.BackColor = MyDialog.Color;
            }

        }

        private void trackBar_fontSize_Scroll(object sender, EventArgs e)
        {
            label_fontSize.Text = trackBar_fontSize.Value.ToString();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen p = new Pen(PB_currentColor.BackColor,int.Parse(label_fontSize.Text));
                g.DrawLine(p,x,y,e.X,e.Y);
                x = e.X;
                y = e.Y;
                pictureBox1.Refresh();
            }
        }
    }
}

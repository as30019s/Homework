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
    public partial class Homework_ControlList : Form
    {
        public Homework_ControlList()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void btn_homework_01_Click(object sender, EventArgs e)
        {
            Homework_01_Frm frm_01 = new Homework_01_Frm();
            frmCall(frm_01);
        }

        private void btn_homework_02_Click(object sender, EventArgs e)
        {
            Homework_02_Frm frm_02 = new Homework_02_Frm();
            frmCall(frm_02);
        }

        private void btn_homework_03_Click(object sender, EventArgs e)
        {
            Homework_03_Frm frm_03 = new Homework_03_Frm();
            frmCall(frm_03);
        }

        private void btn_Homework_04_Click(object sender, EventArgs e)
        {
            Homework_04_Frm frm_04 = new Homework_04_Frm();
            frmCall(frm_04);
        }

        private void btn_homework_05_Click(object sender, EventArgs e)
        {
            Homework_05_Frm frm_05 = new Homework_05_Frm();
            frmCall(frm_05);
        }
        private void btn_homework_06_Click(object sender, EventArgs e)
        {
            Homework_06_Frm frm_06 = new Homework_06_Frm();
            frmCall(frm_06);
        }


        private void btn_homework_07_Click(object sender, EventArgs e)
        {
            Homework_07_Frm frm_07 = new Homework_07_Frm();
            frmCall(frm_07);
        }

        private void btn_homework_08_Click(object sender, EventArgs e)
        {
            Homework_08_Frm frm_08 = new Homework_08_Frm();
            frmCall(frm_08);
        }

        private void btn_homework_09_Click(object sender, EventArgs e)
        {
            Homework_09_Frm frm_09 = new Homework_09_Frm();
            frmCall(frm_09);
        }

        private void btn_homework_10_Click(object sender, EventArgs e)
        {
            // close other opening form
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            Homework_10_Frm frm_10 = new Homework_10_Frm();

            frm_10.Show();
        }

        private void btn_homework_11_Click(object sender, EventArgs e)
        {
            Homework_11_Frm frm_11 = new Homework_11_Frm();
            frmCall(frm_11);
        }

        private void btn_homework_12_Click(object sender, EventArgs e)
        {
            Homework_12_Frm frm_12 = new Homework_12_Frm();
            frmCall(frm_12);
        }

        private void btn_pictureViewer_Click(object sender, EventArgs e)
        {
            Homework_13_Frm frm_13 = new Homework_13_Frm();
            frmCall(frm_13);
        }


        private void btn_homework_14_Click(object sender, EventArgs e)
        {
            Homework_14_Frm frm_14 = new Homework_14_Frm();
            frmCall(frm_14);
        }

        private void btn_homework_15_Click(object sender, EventArgs e)
        {
            Homework_15_Frm frm_15 = new Homework_15_Frm();
            frmCall(frm_15);
        }

        public void frmCall(Form frm)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            //非最上層
            frm.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frm.Visible = true;

            //設定From位置
            frm.Top = 0;
            frm.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homework_09_02_Frm frm_09_02 = new Homework_09_02_Frm();
            frmCall(frm_09_02);
        }

        private void btn_homework_14_02_Click(object sender, EventArgs e)
        {
            Homework_14_02_Frm frm_14_02 = new Homework_14_02_Frm();
            frmCall(frm_14_02);
        }
    }
}

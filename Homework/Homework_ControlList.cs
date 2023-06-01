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
        }

        private void btn_homework_01_Click(object sender, EventArgs e)
        {
            // close other opening form
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            Homework_01_Frm frm_01 = new Homework_01_Frm();

            //非最上層
            frm_01.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frm_01.Visible = true;

            //設定From位置
            frm_01.Top = 0;
            frm_01.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm_01);
        }

        private void btn_homework_02_Click(object sender, EventArgs e)
        {
            // close other opening form
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            Homework_02_Frm frm_02 = new Homework_02_Frm();

            //非最上層
            frm_02.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frm_02.Visible = true;

            //設定From位置
            frm_02.Top = 0;
            frm_02.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm_02);
        }

        private void btn_homework_03_Click(object sender, EventArgs e)
        {
            // close other opening form
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            Homework_03_Frm frm_03 = new Homework_03_Frm();

            //非最上層
            frm_03.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frm_03.Visible = true;

            //設定From位置
            frm_03.Top = 0;
            frm_03.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm_03);
        }

        private void btn_Homework_04_Click(object sender, EventArgs e)
        {
            // close other opening form
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            Homework_04_Frm frm_04 = new Homework_04_Frm();

            //非最上層
            frm_04.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frm_04.Visible = true;

            //設定From位置
            frm_04.Top = 0;
            frm_04.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm_04);
        }

        private void btn_homework_05_Click(object sender, EventArgs e)
        {
            // close other opening form
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            Homework_05_Frm frm_05 = new Homework_05_Frm();

            //非最上層
            frm_05.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frm_05.Visible = true;

            //設定From位置
            frm_05.Top = 0;
            frm_05.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm_05);
        }


        private void btn_homework_07_Click(object sender, EventArgs e)
        {
            // close other opening form
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            Homework_07_Frm frm_07 = new Homework_07_Frm();

            //非最上層
            frm_07.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frm_07.Visible = true;

            //設定From位置
            frm_07.Top = 0;
            frm_07.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm_07);
        }

        private void btn_homework_08_Click(object sender, EventArgs e)
        {
            // close other opening form
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            Homework_08_Frm frm_08 = new Homework_08_Frm();

            //非最上層
            frm_08.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frm_08.Visible = true;

            //設定From位置
            frm_08.Top = 0;
            frm_08.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm_08);

        }

        private void btn_homework_09_Click(object sender, EventArgs e)
        {
            // close other opening form
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            Homework_09_Frm frm_09 = new Homework_09_Frm();

            //非最上層
            frm_09.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frm_09.Visible = true;

            //設定From位置
            frm_09.Top = 0;
            frm_09.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm_09);

        }

        private void btn_homework_14_Click(object sender, EventArgs e)
        {
            // close other opening form
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            Homework_14_Frm frm_14 = new Homework_14_Frm();

            //非最上層
            frm_14.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frm_14.Visible = true;

            //設定From位置
            frm_14.Top = 0;
            frm_14.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm_14);
        }
    }
}

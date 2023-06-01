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
    public partial class Homework_09_Frm : Form
    {
        public Homework_09_Frm()
        {
            InitializeComponent();
        }

        bool currentUserCheck = true;

        private void btn_OX_00_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_00.Text = "〇";
            }
            else
            {
                btn_OX_00.Text = "X";
            }
            btn_OX_00.Enabled = false;
            currentUserCheck = !currentUserCheck;
        }

        private void btn_OX_10_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_10.Text = "〇";
            }
            else
            {
                btn_OX_10.Text = "X";
            }
            btn_OX_10.Enabled = false;
            currentUserCheck = !currentUserCheck;

        }

        private void btn_OX_20_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_20.Text = "〇";
            }
            else
            {
                btn_OX_20.Text = "X";
            }
            btn_OX_20.Enabled = false;
            currentUserCheck = !currentUserCheck;

        }

        private void btn_OX_01_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_01.Text = "〇";
            }
            else
            {
                btn_OX_01.Text = "X";
            }
            btn_OX_01.Enabled = false;
            currentUserCheck = !currentUserCheck;

        }

        private void btn_OX_11_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_11.Text = "〇";
            }
            else
            {
                btn_OX_11.Text = "X";
            }
            btn_OX_11.Enabled = false;
            currentUserCheck = !currentUserCheck;
        }

        private void btn_OX_21_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_21.Text = "〇";
            }
            else
            {
                btn_OX_21.Text = "X";
            }
            btn_OX_21.Enabled = false;
            currentUserCheck = !currentUserCheck;
        }

        private void btn_OX_02_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_02.Text = "〇";
            }
            else
            {
                btn_OX_02.Text = "X";
            }
            btn_OX_02.Enabled = false;
            currentUserCheck = !currentUserCheck;
        }

        private void btn_OX_12_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_12.Text = "〇";
            }
            else
            {
                btn_OX_12.Text = "X";
            }
            btn_OX_12.Enabled = false;
            currentUserCheck = !currentUserCheck;
        }

        private void btn_OX_22_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_22.Text = "〇";
            }
            else
            {
                btn_OX_22.Text = "X";
            }
            btn_OX_22.Enabled = false;
            currentUserCheck = !currentUserCheck;
        }
    }
}

﻿using System;
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
    public partial class Homework_07_Frm : Form
    {
        // parameter definition
        double Num1;
        double Num2;
        bool checkResult;

        public Homework_07_Frm()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            checkResult = checkInput();
            if (checkResult)
            {
                textB_Answer.Text = (Num1 + Num2).ToString();
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            checkResult = checkInput();
            if (checkResult)
            {
                textB_Answer.Text = (Num1 - Num2).ToString();
            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            checkResult = checkInput();
            if (checkResult)
            {
                textB_Answer.Text = (Num1 * Num2).ToString();
            }
        }

        private void btn_divided_Click(object sender, EventArgs e)
        {
            checkResult = checkInput();
            if (checkResult)
            {
                if (double.Parse(textB_Num2.Text) == 0)
                {
                    textB_Answer.Text = "∞";
                } else
                {
                    textB_Answer.Text = (Num1 / Num2).ToString();
                }
            }
        }

        // Check input number is correct
        public bool checkInput()
        {
            if (!double.TryParse(textB_Num1.Text, out Num1))
            {
                MessageBox.Show("請輸入數值。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(textB_Num2.Text,out Num2))
            {
                MessageBox.Show("請輸入數值。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}

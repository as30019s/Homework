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
    public partial class Homework_01_Frm : Form
    {
        public Homework_01_Frm()
        {
            InitializeComponent();
        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            string name = textB_name.Text;
            string Ename = textB_Ename.Text;
            string sex = textB_sex.Text;
            string StarSign = textB_SS.Text;
            string result = $"Hello, 我是{name} , \n英文名子是{Ename},\n性別是{sex},\n星座是{StarSign},\n很高興認識你。\n";
            MessageBox.Show(result);
        }

        private void btn_Hi_Click(object sender, EventArgs e)
        {
            string name = textB_name.Text;
            string Ename = textB_Ename.Text;
            string sex = textB_sex.Text;
            string StarSign = textB_SS.Text;
            string result = $"Hi, 我是{name} , \n英文名子是{Ename},\n性別是{sex},\n星座是{StarSign},\n很高興認識你。\n";
            MessageBox.Show(result);
        }
    }
}

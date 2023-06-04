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
    public partial class Homework_11_Frm : Form
    {
        public Homework_11_Frm()
        {
            InitializeComponent();
            TSSLabel_time.Text = DateTime.Now.ToString();
        }

        private void timer_statusTime_Tick(object sender, EventArgs e)
        {
            TSSLabel_time.Text = DateTime.Now.ToString();
        }
    }
}

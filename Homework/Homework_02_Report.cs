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
    public partial class Frm_report : Form
    {
        // improve way, use static variable to catch the report value.
        public Frm_report(double report_money,int report_year,double report_percentage, decimal report_monthPay, decimal report_totalPay)
        {
            InitializeComponent();
            textB_report_money.Text = report_money.ToString();
            textB_report_year.Text = report_year.ToString();
            textB_report_percentage.Text = report_percentage.ToString();
            textB_report_monthpay.Text = report_monthPay.ToString();   
            textB_report_totalPay.Text = report_totalPay.ToString();

        }
        // future method, generate email report

    }
}

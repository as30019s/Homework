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
    public partial class Homework_02_Frm : Form
    {
        // parameter definition
        double totalLoanMoney;
        int year;
        double rate;
        double downpayment;

        public Homework_02_Frm()
        {
            InitializeComponent();

            // parameter initial value
            totalLoanMoney = double.Parse(textB_money.Text);
            year = int.Parse(textB_year.Text);
            rate = double.Parse(textB_rate.Text);
            downpayment = double.Parse(textB_payment.Text);
        }

        // month pay button click event
        private void btn_monthPay_Click(object sender, EventArgs e)
        {
            getCurrentValue();
            if ((totalLoanMoney - downpayment) == 0)
            {
                MessageBox.Show("月付額：0");
            }
            else if (totalLoanMoney < 0 || year < 0 || rate < 0 || downpayment < 0)
            {
                MessageBox.Show("請輸入正整數");
            }
            else
            {
                var result = LoanCal();
                MessageBox.Show($"月付額：{result.monthPay}");
            }
        }

        // total pay button click event
        private void btn_totalPay_Click(object sender, EventArgs e)
        {
            getCurrentValue();
            if ((totalLoanMoney - downpayment) == 0)
            {
                MessageBox.Show("總付款：0");
            }
            else if (totalLoanMoney<0 || year<0 || rate<0 || downpayment<0)
            {
                MessageBox.Show("請輸入正整數");
            }
            else
            {
                var result = LoanCal();
                MessageBox.Show($"總付款：{result.totalPay}");
            }
        }

        // report button click event
        private void btn_report_Click(object sender, EventArgs e)
        {
            getCurrentValue();
            if ((totalLoanMoney - downpayment) == 0)
            {
                Frm_report report = new Frm_report(0, year, rate, 0, 0);
                report.Show();
            }
            else if (totalLoanMoney < 0 || year < 0 || rate < 0 || downpayment < 0)
            {
                MessageBox.Show("請輸入正整數");
            }
            else
            {
                var result = LoanCal();
                Frm_report report = new Frm_report(totalLoanMoney - downpayment, year, rate, result.monthPay, result.totalPay);
                report.ShowDialog();
            }
        }

        // Loan calculation method
        public (decimal monthPay, decimal totalPay) LoanCal()
        {
            decimal monthPay;
            decimal totalPay;
            if (rate == 0)
            {
                monthPay = Convert.ToDecimal((totalLoanMoney - downpayment))/year/12;
            }
            else
            {
                monthPay = Convert.ToDecimal((totalLoanMoney - downpayment) * Math.Pow((1 + rate / 100 / 12), (year * 12)) * (rate / 100 / 12) / (Math.Pow((1 + rate / 100 / 12), (year * 12)) - 1));
            }
            totalPay = Convert.ToDecimal(Math.Round(monthPay)) * year * 12;

            return (Math.Round(monthPay), Math.Round(totalPay));
        }

        // get current parameter value method
        public void getCurrentValue()
        {
            if (!double.TryParse(textB_money.Text,out totalLoanMoney))
            {
                totalLoanMoney = -1;
            }


            if (!int.TryParse(textB_year.Text, out year))
            {
                year = -1;
            }


            if (!double.TryParse(textB_rate.Text, out rate))
            {
                rate = -1;
            }


            if (!double.TryParse(textB_payment.Text, out downpayment))
            {
                downpayment = -1;
            }
        }
    }
}

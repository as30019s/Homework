using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Homework_15_Frm : Form
    {
        public Homework_15_Frm()
        {
            InitializeComponent();
            label_currentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label_currentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        TimeSpan alarmCountdown;
        private void checkBox_setAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_setAlarm.Checked == true)
            {
                DateTime alarmTime;
                if (DateTime.TryParseExact($"{comboBox_hour.SelectedItem}{comboBox_minute.SelectedItem}{comboBox_second.SelectedItem}","HHmmss", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out alarmTime))
                {
                    if (alarmTime > DateTime.Now)
                    {
                        alarmCountdown = alarmTime - DateTime.Now;
                        label_countdown.Text = alarmCountdown.ToString(@"hh\:mm\:ss");
                    }
                    else
                    {
                        alarmCountdown = alarmTime.Add(new TimeSpan(1, 0, 0, 0)) - DateTime.Now;
                        label_countdown.Text = alarmCountdown.ToString(@"hh\:mm\:ss");
                    }
                    timer_countdown.Enabled = true;
                }
                else
                {
                    MessageBox.Show("請選取時間");
                    checkBox_setAlarm.Checked = false;
                    timer_countdown.Enabled = false;
                    return;
                }
            }
            else
            {
                label_countdown.Text = "00:00:00";
                timer_countdown.Enabled = false;
            }
        }

        private void timer_countdown_Tick(object sender, EventArgs e)
        {
            alarmCountdown = alarmCountdown.Add(new TimeSpan(0,0,0,-1));
            label_countdown.Text = alarmCountdown.ToString(@"hh\:mm\:ss");

            if (alarmCountdown.TotalSeconds < 0)
            {
                label_countdown.Text = "00:00:00";
                checkBox_setAlarm.Checked = false;
                timer_countdown.Enabled = false;
                MessageBox.Show("Alarm");
            }
        }
    }
}

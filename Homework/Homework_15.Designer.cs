namespace Homework
{
    partial class Homework_15_Frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_currentTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gb_selectTime = new System.Windows.Forms.GroupBox();
            this.label_title = new System.Windows.Forms.Label();
            this.comboBox_hour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_minute = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_second = new System.Windows.Forms.ComboBox();
            this.checkBox_setAlarm = new System.Windows.Forms.CheckBox();
            this.label_countdown = new System.Windows.Forms.Label();
            this.timer_countdown = new System.Windows.Forms.Timer(this.components);
            this.gb_selectTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_currentTime
            // 
            this.label_currentTime.AutoSize = true;
            this.label_currentTime.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentTime.Location = new System.Drawing.Point(82, 43);
            this.label_currentTime.Name = "label_currentTime";
            this.label_currentTime.Size = new System.Drawing.Size(0, 57);
            this.label_currentTime.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gb_selectTime
            // 
            this.gb_selectTime.Controls.Add(this.label_countdown);
            this.gb_selectTime.Controls.Add(this.checkBox_setAlarm);
            this.gb_selectTime.Controls.Add(this.label3);
            this.gb_selectTime.Controls.Add(this.comboBox_second);
            this.gb_selectTime.Controls.Add(this.label2);
            this.gb_selectTime.Controls.Add(this.comboBox_minute);
            this.gb_selectTime.Controls.Add(this.label1);
            this.gb_selectTime.Controls.Add(this.comboBox_hour);
            this.gb_selectTime.Controls.Add(this.label_title);
            this.gb_selectTime.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_selectTime.Location = new System.Drawing.Point(136, 133);
            this.gb_selectTime.Name = "gb_selectTime";
            this.gb_selectTime.Size = new System.Drawing.Size(531, 263);
            this.gb_selectTime.TabIndex = 1;
            this.gb_selectTime.TabStop = false;
            this.gb_selectTime.Text = "Select Time";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(65, 78);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(106, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Alarm Time:";
            // 
            // comboBox_hour
            // 
            this.comboBox_hour.DropDownHeight = 100;
            this.comboBox_hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hour.FormattingEnabled = true;
            this.comboBox_hour.IntegralHeight = false;
            this.comboBox_hour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox_hour.Location = new System.Drawing.Point(180, 75);
            this.comboBox_hour.Name = "comboBox_hour";
            this.comboBox_hour.Size = new System.Drawing.Size(45, 33);
            this.comboBox_hour.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "時";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "分";
            // 
            // comboBox_minute
            // 
            this.comboBox_minute.DropDownHeight = 100;
            this.comboBox_minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_minute.FormattingEnabled = true;
            this.comboBox_minute.IntegralHeight = false;
            this.comboBox_minute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_minute.Location = new System.Drawing.Point(260, 75);
            this.comboBox_minute.Name = "comboBox_minute";
            this.comboBox_minute.Size = new System.Drawing.Size(45, 33);
            this.comboBox_minute.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "秒";
            // 
            // comboBox_second
            // 
            this.comboBox_second.DropDownHeight = 100;
            this.comboBox_second.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_second.FormattingEnabled = true;
            this.comboBox_second.IntegralHeight = false;
            this.comboBox_second.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_second.Location = new System.Drawing.Point(340, 75);
            this.comboBox_second.Name = "comboBox_second";
            this.comboBox_second.Size = new System.Drawing.Size(45, 33);
            this.comboBox_second.TabIndex = 5;
            // 
            // checkBox_setAlarm
            // 
            this.checkBox_setAlarm.AutoSize = true;
            this.checkBox_setAlarm.Location = new System.Drawing.Point(189, 130);
            this.checkBox_setAlarm.Name = "checkBox_setAlarm";
            this.checkBox_setAlarm.Size = new System.Drawing.Size(107, 29);
            this.checkBox_setAlarm.TabIndex = 7;
            this.checkBox_setAlarm.Text = "Set Alarm";
            this.checkBox_setAlarm.UseVisualStyleBackColor = true;
            this.checkBox_setAlarm.CheckedChanged += new System.EventHandler(this.checkBox_setAlarm_CheckedChanged);
            // 
            // label_countdown
            // 
            this.label_countdown.AutoSize = true;
            this.label_countdown.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_countdown.Location = new System.Drawing.Point(182, 180);
            this.label_countdown.Name = "label_countdown";
            this.label_countdown.Size = new System.Drawing.Size(121, 37);
            this.label_countdown.TabIndex = 8;
            this.label_countdown.Text = "00:00:00";
            // 
            // timer_countdown
            // 
            this.timer_countdown.Interval = 1000;
            this.timer_countdown.Tick += new System.EventHandler(this.timer_countdown_Tick);
            // 
            // Homework_15_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_selectTime);
            this.Controls.Add(this.label_currentTime);
            this.Name = "Homework_15_Frm";
            this.Text = "Alarm";
            this.gb_selectTime.ResumeLayout(false);
            this.gb_selectTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_currentTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox gb_selectTime;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ComboBox comboBox_hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_second;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_minute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_setAlarm;
        private System.Windows.Forms.Label label_countdown;
        private System.Windows.Forms.Timer timer_countdown;
    }
}
using System.Windows.Forms;

namespace Homework
{
    partial class Homework_ControlList
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_homework_09_02 = new System.Windows.Forms.Button();
            this.btn_homework_15 = new System.Windows.Forms.Button();
            this.btn_pictureViewer = new System.Windows.Forms.Button();
            this.btn_homework_12 = new System.Windows.Forms.Button();
            this.btn_homework_10 = new System.Windows.Forms.Button();
            this.btn_homework_06 = new System.Windows.Forms.Button();
            this.btn_homework_11 = new System.Windows.Forms.Button();
            this.btn_homework_14 = new System.Windows.Forms.Button();
            this.btn_homework_09 = new System.Windows.Forms.Button();
            this.btn_homework_08 = new System.Windows.Forms.Button();
            this.btn_homework_05 = new System.Windows.Forms.Button();
            this.btn_homework_07 = new System.Windows.Forms.Button();
            this.btn_Homework_04 = new System.Windows.Forms.Button();
            this.btn_homework_03 = new System.Windows.Forms.Button();
            this.btn_homework_01 = new System.Windows.Forms.Button();
            this.btn_homework_02 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.label_title);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.BackgroundImage = global::Homework.Properties.Resources.Background_image;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1424, 681);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_title.Location = new System.Drawing.Point(128, 58);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(100, 27);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "C#作業";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::Homework.Properties.Resources.Background_image;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 145);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel3);
            this.splitContainer2.Size = new System.Drawing.Size(1424, 532);
            this.splitContainer2.SplitterDistance = 260;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_homework_09_02);
            this.panel2.Controls.Add(this.btn_homework_15);
            this.panel2.Controls.Add(this.btn_pictureViewer);
            this.panel2.Controls.Add(this.btn_homework_12);
            this.panel2.Controls.Add(this.btn_homework_10);
            this.panel2.Controls.Add(this.btn_homework_06);
            this.panel2.Controls.Add(this.btn_homework_11);
            this.panel2.Controls.Add(this.btn_homework_14);
            this.panel2.Controls.Add(this.btn_homework_09);
            this.panel2.Controls.Add(this.btn_homework_08);
            this.panel2.Controls.Add(this.btn_homework_05);
            this.panel2.Controls.Add(this.btn_homework_07);
            this.panel2.Controls.Add(this.btn_Homework_04);
            this.panel2.Controls.Add(this.btn_homework_03);
            this.panel2.Controls.Add(this.btn_homework_01);
            this.panel2.Controls.Add(this.btn_homework_02);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 532);
            this.panel2.TabIndex = 4;
            // 
            // btn_homework_09_02
            // 
            this.btn_homework_09_02.Location = new System.Drawing.Point(30, 479);
            this.btn_homework_09_02.Name = "btn_homework_09_02";
            this.btn_homework_09_02.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_09_02.TabIndex = 15;
            this.btn_homework_09_02.Text = "Homework_09-2_OX GAME";
            this.btn_homework_09_02.UseVisualStyleBackColor = true;
            this.btn_homework_09_02.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_homework_15
            // 
            this.btn_homework_15.Location = new System.Drawing.Point(30, 450);
            this.btn_homework_15.Name = "btn_homework_15";
            this.btn_homework_15.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_15.TabIndex = 14;
            this.btn_homework_15.Text = "Homework_15_Alarm";
            this.btn_homework_15.UseVisualStyleBackColor = true;
            this.btn_homework_15.Click += new System.EventHandler(this.btn_homework_15_Click);
            // 
            // btn_pictureViewer
            // 
            this.btn_pictureViewer.Location = new System.Drawing.Point(30, 390);
            this.btn_pictureViewer.Name = "btn_pictureViewer";
            this.btn_pictureViewer.Size = new System.Drawing.Size(200, 23);
            this.btn_pictureViewer.TabIndex = 13;
            this.btn_pictureViewer.Text = "Homework_13_Picture Viewer";
            this.btn_pictureViewer.UseVisualStyleBackColor = true;
            this.btn_pictureViewer.Click += new System.EventHandler(this.btn_pictureViewer_Click);
            // 
            // btn_homework_12
            // 
            this.btn_homework_12.Location = new System.Drawing.Point(30, 360);
            this.btn_homework_12.Name = "btn_homework_12";
            this.btn_homework_12.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_12.TabIndex = 12;
            this.btn_homework_12.Text = "Homework_12_小畫家";
            this.btn_homework_12.UseVisualStyleBackColor = true;
            this.btn_homework_12.Click += new System.EventHandler(this.btn_homework_12_Click);
            // 
            // btn_homework_10
            // 
            this.btn_homework_10.Location = new System.Drawing.Point(30, 300);
            this.btn_homework_10.Name = "btn_homework_10";
            this.btn_homework_10.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_10.TabIndex = 11;
            this.btn_homework_10.Text = "Homework_10_Screen Saver";
            this.btn_homework_10.UseVisualStyleBackColor = true;
            this.btn_homework_10.Click += new System.EventHandler(this.btn_homework_10_Click);
            // 
            // btn_homework_06
            // 
            this.btn_homework_06.Location = new System.Drawing.Point(30, 180);
            this.btn_homework_06.Name = "btn_homework_06";
            this.btn_homework_06.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_06.TabIndex = 10;
            this.btn_homework_06.Text = "Homework_06_StudentsGrade List";
            this.btn_homework_06.UseVisualStyleBackColor = true;
            this.btn_homework_06.Click += new System.EventHandler(this.btn_homework_06_Click);
            // 
            // btn_homework_11
            // 
            this.btn_homework_11.Location = new System.Drawing.Point(30, 330);
            this.btn_homework_11.Name = "btn_homework_11";
            this.btn_homework_11.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_11.TabIndex = 9;
            this.btn_homework_11.Text = "Homework_11_Notepad";
            this.btn_homework_11.UseVisualStyleBackColor = true;
            this.btn_homework_11.Click += new System.EventHandler(this.btn_homework_11_Click);
            // 
            // btn_homework_14
            // 
            this.btn_homework_14.Location = new System.Drawing.Point(30, 420);
            this.btn_homework_14.Name = "btn_homework_14";
            this.btn_homework_14.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_14.TabIndex = 8;
            this.btn_homework_14.Text = "Homework_14_Guess";
            this.btn_homework_14.UseVisualStyleBackColor = true;
            this.btn_homework_14.Click += new System.EventHandler(this.btn_homework_14_Click);
            // 
            // btn_homework_09
            // 
            this.btn_homework_09.Location = new System.Drawing.Point(30, 270);
            this.btn_homework_09.Name = "btn_homework_09";
            this.btn_homework_09.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_09.TabIndex = 7;
            this.btn_homework_09.Text = "Homework_09_OX GAME";
            this.btn_homework_09.UseVisualStyleBackColor = true;
            this.btn_homework_09.Click += new System.EventHandler(this.btn_homework_09_Click);
            // 
            // btn_homework_08
            // 
            this.btn_homework_08.Location = new System.Drawing.Point(30, 240);
            this.btn_homework_08.Name = "btn_homework_08";
            this.btn_homework_08.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_08.TabIndex = 6;
            this.btn_homework_08.Text = "Homework_08_MethodForDoWhile";
            this.btn_homework_08.UseVisualStyleBackColor = true;
            this.btn_homework_08.Click += new System.EventHandler(this.btn_homework_08_Click);
            // 
            // btn_homework_05
            // 
            this.btn_homework_05.Location = new System.Drawing.Point(30, 150);
            this.btn_homework_05.Name = "btn_homework_05";
            this.btn_homework_05.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_05.TabIndex = 5;
            this.btn_homework_05.Text = "Homework_05_StudentsGrade";
            this.btn_homework_05.UseVisualStyleBackColor = true;
            this.btn_homework_05.Click += new System.EventHandler(this.btn_homework_05_Click);
            // 
            // btn_homework_07
            // 
            this.btn_homework_07.Location = new System.Drawing.Point(30, 210);
            this.btn_homework_07.Name = "btn_homework_07";
            this.btn_homework_07.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_07.TabIndex = 4;
            this.btn_homework_07.Text = "Homework_07_My Cal";
            this.btn_homework_07.UseVisualStyleBackColor = true;
            this.btn_homework_07.Click += new System.EventHandler(this.btn_homework_07_Click);
            // 
            // btn_Homework_04
            // 
            this.btn_Homework_04.Location = new System.Drawing.Point(30, 120);
            this.btn_Homework_04.Name = "btn_Homework_04";
            this.btn_Homework_04.Size = new System.Drawing.Size(200, 23);
            this.btn_Homework_04.TabIndex = 3;
            this.btn_Homework_04.Text = "Homework_04_Student StructForm";
            this.btn_Homework_04.UseVisualStyleBackColor = true;
            this.btn_Homework_04.Click += new System.EventHandler(this.btn_Homework_04_Click);
            // 
            // btn_homework_03
            // 
            this.btn_homework_03.Location = new System.Drawing.Point(30, 90);
            this.btn_homework_03.Name = "btn_homework_03";
            this.btn_homework_03.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_03.TabIndex = 2;
            this.btn_homework_03.Text = "Homework_03_POS";
            this.btn_homework_03.UseVisualStyleBackColor = true;
            this.btn_homework_03.Click += new System.EventHandler(this.btn_homework_03_Click);
            // 
            // btn_homework_01
            // 
            this.btn_homework_01.Location = new System.Drawing.Point(30, 30);
            this.btn_homework_01.Name = "btn_homework_01";
            this.btn_homework_01.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_01.TabIndex = 0;
            this.btn_homework_01.Text = "Homework_01_Hello";
            this.btn_homework_01.UseVisualStyleBackColor = true;
            this.btn_homework_01.Click += new System.EventHandler(this.btn_homework_01_Click);
            // 
            // btn_homework_02
            // 
            this.btn_homework_02.Location = new System.Drawing.Point(30, 60);
            this.btn_homework_02.Name = "btn_homework_02";
            this.btn_homework_02.Size = new System.Drawing.Size(200, 23);
            this.btn_homework_02.TabIndex = 1;
            this.btn_homework_02.Text = "Homework_02_Loan";
            this.btn_homework_02.UseVisualStyleBackColor = true;
            this.btn_homework_02.Click += new System.EventHandler(this.btn_homework_02_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1160, 532);
            this.panel3.TabIndex = 0;
            // 
            // Homework_ControlList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 681);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "Homework_ControlList";
            this.Text = "C";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_homework_01;
        private System.Windows.Forms.Button btn_homework_02;
        private System.Windows.Forms.Button btn_homework_03;
        private System.Windows.Forms.Button btn_Homework_04;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_homework_07;
        private System.Windows.Forms.Button btn_homework_05;
        private System.Windows.Forms.Button btn_homework_08;
        private System.Windows.Forms.Button btn_homework_09;
        private System.Windows.Forms.Button btn_homework_14;
        private System.Windows.Forms.Button btn_homework_11;
        private System.Windows.Forms.Button btn_homework_06;
        private System.Windows.Forms.Button btn_homework_10;
        private System.Windows.Forms.Button btn_homework_12;
        private System.Windows.Forms.Button btn_pictureViewer;
        private System.Windows.Forms.Button btn_homework_15;
        private Button btn_homework_09_02;
    }
}


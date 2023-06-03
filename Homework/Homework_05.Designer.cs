namespace Homework
{
    partial class Homework_05_Frm
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_ch = new System.Windows.Forms.Label();
            this.label_en = new System.Windows.Forms.Label();
            this.label_math = new System.Windows.Forms.Label();
            this.btn_addData = new System.Windows.Forms.Button();
            this.btn_randomAddData = new System.Windows.Forms.Button();
            this.btn_statistic = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_randomAddData20 = new System.Windows.Forms.Button();
            this.textB_name = new System.Windows.Forms.TextBox();
            this.textB_chScore = new System.Windows.Forms.TextBox();
            this.textB_enScore = new System.Windows.Forms.TextBox();
            this.textB_mathScore = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textB_title = new System.Windows.Forms.TextBox();
            this.textB_result = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(34, 33);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(41, 12);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "姓名：";
            // 
            // label_ch
            // 
            this.label_ch.AutoSize = true;
            this.label_ch.Location = new System.Drawing.Point(34, 70);
            this.label_ch.Name = "label_ch";
            this.label_ch.Size = new System.Drawing.Size(41, 12);
            this.label_ch.TabIndex = 1;
            this.label_ch.Text = "國文：";
            // 
            // label_en
            // 
            this.label_en.AutoSize = true;
            this.label_en.Location = new System.Drawing.Point(34, 108);
            this.label_en.Name = "label_en";
            this.label_en.Size = new System.Drawing.Size(41, 12);
            this.label_en.TabIndex = 2;
            this.label_en.Text = "英文：";
            // 
            // label_math
            // 
            this.label_math.AutoSize = true;
            this.label_math.Location = new System.Drawing.Point(34, 144);
            this.label_math.Name = "label_math";
            this.label_math.Size = new System.Drawing.Size(41, 12);
            this.label_math.TabIndex = 3;
            this.label_math.Text = "數學：";
            // 
            // btn_addData
            // 
            this.btn_addData.Location = new System.Drawing.Point(36, 186);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(91, 23);
            this.btn_addData.TabIndex = 4;
            this.btn_addData.Text = "加入學生資料";
            this.btn_addData.UseVisualStyleBackColor = true;
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click);
            // 
            // btn_randomAddData
            // 
            this.btn_randomAddData.Location = new System.Drawing.Point(36, 226);
            this.btn_randomAddData.Name = "btn_randomAddData";
            this.btn_randomAddData.Size = new System.Drawing.Size(91, 23);
            this.btn_randomAddData.TabIndex = 5;
            this.btn_randomAddData.Text = "隨機儲存資料";
            this.btn_randomAddData.UseVisualStyleBackColor = true;
            this.btn_randomAddData.Click += new System.EventHandler(this.btn_randomAddData_Click);
            // 
            // btn_statistic
            // 
            this.btn_statistic.Location = new System.Drawing.Point(36, 267);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(91, 23);
            this.btn_statistic.TabIndex = 6;
            this.btn_statistic.Text = "各科統計";
            this.btn_statistic.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(36, 345);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(91, 23);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "重設資料";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_randomAddData20
            // 
            this.btn_randomAddData20.Location = new System.Drawing.Point(36, 391);
            this.btn_randomAddData20.Name = "btn_randomAddData20";
            this.btn_randomAddData20.Size = new System.Drawing.Size(91, 23);
            this.btn_randomAddData20.TabIndex = 8;
            this.btn_randomAddData20.Text = "隨機加入20筆";
            this.btn_randomAddData20.UseVisualStyleBackColor = true;
            // 
            // textB_name
            // 
            this.textB_name.Location = new System.Drawing.Point(79, 30);
            this.textB_name.Name = "textB_name";
            this.textB_name.Size = new System.Drawing.Size(48, 22);
            this.textB_name.TabIndex = 9;
            // 
            // textB_chScore
            // 
            this.textB_chScore.Location = new System.Drawing.Point(79, 67);
            this.textB_chScore.Name = "textB_chScore";
            this.textB_chScore.Size = new System.Drawing.Size(48, 22);
            this.textB_chScore.TabIndex = 10;
            // 
            // textB_enScore
            // 
            this.textB_enScore.Location = new System.Drawing.Point(79, 105);
            this.textB_enScore.Name = "textB_enScore";
            this.textB_enScore.Size = new System.Drawing.Size(48, 22);
            this.textB_enScore.TabIndex = 11;
            // 
            // textB_mathScore
            // 
            this.textB_mathScore.Location = new System.Drawing.Point(79, 144);
            this.textB_mathScore.Name = "textB_mathScore";
            this.textB_mathScore.Size = new System.Drawing.Size(48, 22);
            this.textB_mathScore.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(157, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 257);
            this.panel1.TabIndex = 13;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textB_title);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textB_result);
            this.splitContainer1.Size = new System.Drawing.Size(518, 253);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // textB_title
            // 
            this.textB_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textB_title.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_title.Location = new System.Drawing.Point(0, 0);
            this.textB_title.Name = "textB_title";
            this.textB_title.Size = new System.Drawing.Size(518, 23);
            this.textB_title.TabIndex = 0;
            this.textB_title.Text = "姓名      國文    英文    數學    總分    平均      最低      最高";
            // 
            // textB_result
            // 
            this.textB_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textB_result.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_result.Location = new System.Drawing.Point(1, 1);
            this.textB_result.Multiline = true;
            this.textB_result.Name = "textB_result";
            this.textB_result.ReadOnly = true;
            this.textB_result.Size = new System.Drawing.Size(514, 22);
            this.textB_result.TabIndex = 0;
            // 
            // Homework_05_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textB_mathScore);
            this.Controls.Add(this.textB_enScore);
            this.Controls.Add(this.textB_chScore);
            this.Controls.Add(this.textB_name);
            this.Controls.Add(this.btn_randomAddData20);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_statistic);
            this.Controls.Add(this.btn_randomAddData);
            this.Controls.Add(this.btn_addData);
            this.Controls.Add(this.label_math);
            this.Controls.Add(this.label_en);
            this.Controls.Add(this.label_ch);
            this.Controls.Add(this.label_name);
            this.Name = "Homework_05_Frm";
            this.Text = "Homework_05";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_ch;
        private System.Windows.Forms.Label label_en;
        private System.Windows.Forms.Label label_math;
        private System.Windows.Forms.Button btn_addData;
        private System.Windows.Forms.Button btn_randomAddData;
        private System.Windows.Forms.Button btn_statistic;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_randomAddData20;
        private System.Windows.Forms.TextBox textB_name;
        private System.Windows.Forms.TextBox textB_chScore;
        private System.Windows.Forms.TextBox textB_enScore;
        private System.Windows.Forms.TextBox textB_mathScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textB_title;
        private System.Windows.Forms.TextBox textB_result;
    }
}
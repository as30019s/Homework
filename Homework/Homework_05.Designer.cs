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
            this.label1 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.textB_Summary = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_name.Location = new System.Drawing.Point(20, 30);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(55, 16);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "姓名：";
            // 
            // label_ch
            // 
            this.label_ch.AutoSize = true;
            this.label_ch.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ch.Location = new System.Drawing.Point(20, 70);
            this.label_ch.Name = "label_ch";
            this.label_ch.Size = new System.Drawing.Size(55, 16);
            this.label_ch.TabIndex = 1;
            this.label_ch.Text = "國文：";
            // 
            // label_en
            // 
            this.label_en.AutoSize = true;
            this.label_en.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_en.Location = new System.Drawing.Point(20, 110);
            this.label_en.Name = "label_en";
            this.label_en.Size = new System.Drawing.Size(55, 16);
            this.label_en.TabIndex = 2;
            this.label_en.Text = "英文：";
            // 
            // label_math
            // 
            this.label_math.AutoSize = true;
            this.label_math.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_math.Location = new System.Drawing.Point(20, 150);
            this.label_math.Name = "label_math";
            this.label_math.Size = new System.Drawing.Size(55, 16);
            this.label_math.TabIndex = 3;
            this.label_math.Text = "數學：";
            // 
            // btn_addData
            // 
            this.btn_addData.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addData.Location = new System.Drawing.Point(23, 190);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(120, 30);
            this.btn_addData.TabIndex = 4;
            this.btn_addData.Text = "加入學生資料";
            this.btn_addData.UseVisualStyleBackColor = true;
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click);
            // 
            // btn_randomAddData
            // 
            this.btn_randomAddData.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_randomAddData.Location = new System.Drawing.Point(23, 230);
            this.btn_randomAddData.Name = "btn_randomAddData";
            this.btn_randomAddData.Size = new System.Drawing.Size(120, 30);
            this.btn_randomAddData.TabIndex = 5;
            this.btn_randomAddData.Text = "隨機儲存資料";
            this.btn_randomAddData.UseVisualStyleBackColor = true;
            this.btn_randomAddData.Click += new System.EventHandler(this.btn_randomAddData_Click);
            // 
            // btn_statistic
            // 
            this.btn_statistic.Enabled = false;
            this.btn_statistic.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_statistic.Location = new System.Drawing.Point(23, 271);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(120, 30);
            this.btn_statistic.TabIndex = 6;
            this.btn_statistic.Text = "各科統計";
            this.btn_statistic.UseVisualStyleBackColor = true;
            this.btn_statistic.Click += new System.EventHandler(this.btn_statistic_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_reset.Location = new System.Drawing.Point(23, 349);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(120, 30);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "重設資料";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_randomAddData20
            // 
            this.btn_randomAddData20.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_randomAddData20.Location = new System.Drawing.Point(23, 395);
            this.btn_randomAddData20.Name = "btn_randomAddData20";
            this.btn_randomAddData20.Size = new System.Drawing.Size(120, 30);
            this.btn_randomAddData20.TabIndex = 8;
            this.btn_randomAddData20.Text = "隨機加入20筆";
            this.btn_randomAddData20.UseVisualStyleBackColor = true;
            this.btn_randomAddData20.Click += new System.EventHandler(this.btn_randomAddData20_Click);
            // 
            // textB_name
            // 
            this.textB_name.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_name.Location = new System.Drawing.Point(80, 23);
            this.textB_name.Name = "textB_name";
            this.textB_name.Size = new System.Drawing.Size(48, 27);
            this.textB_name.TabIndex = 9;
            // 
            // textB_chScore
            // 
            this.textB_chScore.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_chScore.Location = new System.Drawing.Point(80, 63);
            this.textB_chScore.Name = "textB_chScore";
            this.textB_chScore.Size = new System.Drawing.Size(48, 27);
            this.textB_chScore.TabIndex = 10;
            // 
            // textB_enScore
            // 
            this.textB_enScore.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_enScore.Location = new System.Drawing.Point(80, 103);
            this.textB_enScore.Name = "textB_enScore";
            this.textB_enScore.Size = new System.Drawing.Size(48, 27);
            this.textB_enScore.TabIndex = 11;
            // 
            // textB_mathScore
            // 
            this.textB_mathScore.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_mathScore.Location = new System.Drawing.Point(80, 143);
            this.textB_mathScore.Name = "textB_mathScore";
            this.textB_mathScore.Size = new System.Drawing.Size(48, 27);
            this.textB_mathScore.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(160, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 250);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "姓名      國文   英文   數學   總分   平均      最低      最高";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_result.Location = new System.Drawing.Point(5, 5);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 13);
            this.label_result.TabIndex = 2;
            // 
            // textB_Summary
            // 
            this.textB_Summary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textB_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textB_Summary.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_Summary.Location = new System.Drawing.Point(0, 0);
            this.textB_Summary.Multiline = true;
            this.textB_Summary.Name = "textB_Summary";
            this.textB_Summary.ReadOnly = true;
            this.textB_Summary.Size = new System.Drawing.Size(596, 121);
            this.textB_Summary.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textB_Summary);
            this.panel2.Location = new System.Drawing.Point(160, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 125);
            this.panel2.TabIndex = 15;
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.label_result);
            this.splitContainer1.Size = new System.Drawing.Size(596, 246);
            this.splitContainer1.SplitterDistance = 26;
            this.splitContainer1.TabIndex = 15;
            // 
            // Homework_05_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textB_Summary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
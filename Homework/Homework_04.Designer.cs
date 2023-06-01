namespace Homework
{
    partial class Homework_04_Frm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Name = new System.Windows.Forms.Label();
            this.label_CH_Score = new System.Windows.Forms.Label();
            this.label_EN_Score = new System.Windows.Forms.Label();
            this.label_Math_Score = new System.Windows.Forms.Label();
            this.textB_Name = new System.Windows.Forms.TextBox();
            this.textB_CH_Score = new System.Windows.Forms.TextBox();
            this.textB_EN_Score = new System.Windows.Forms.TextBox();
            this.textB_Math_Score = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Show_Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textB_Show_HighLow_Score = new System.Windows.Forms.TextBox();
            this.textB_Show_Score = new System.Windows.Forms.TextBox();
            this.btn_HighLow_Score = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Name.Location = new System.Drawing.Point(54, 36);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(69, 19);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "姓名：";
            // 
            // label_CH_Score
            // 
            this.label_CH_Score.AutoSize = true;
            this.label_CH_Score.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_CH_Score.Location = new System.Drawing.Point(54, 86);
            this.label_CH_Score.Name = "label_CH_Score";
            this.label_CH_Score.Size = new System.Drawing.Size(69, 19);
            this.label_CH_Score.TabIndex = 1;
            this.label_CH_Score.Text = "國文：";
            // 
            // label_EN_Score
            // 
            this.label_EN_Score.AutoSize = true;
            this.label_EN_Score.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_EN_Score.Location = new System.Drawing.Point(54, 134);
            this.label_EN_Score.Name = "label_EN_Score";
            this.label_EN_Score.Size = new System.Drawing.Size(69, 19);
            this.label_EN_Score.TabIndex = 2;
            this.label_EN_Score.Text = "英文：";
            // 
            // label_Math_Score
            // 
            this.label_Math_Score.AutoSize = true;
            this.label_Math_Score.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Math_Score.Location = new System.Drawing.Point(54, 188);
            this.label_Math_Score.Name = "label_Math_Score";
            this.label_Math_Score.Size = new System.Drawing.Size(69, 19);
            this.label_Math_Score.TabIndex = 3;
            this.label_Math_Score.Text = "數學：";
            // 
            // textB_Name
            // 
            this.textB_Name.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_Name.Location = new System.Drawing.Point(129, 33);
            this.textB_Name.Name = "textB_Name";
            this.textB_Name.Size = new System.Drawing.Size(100, 30);
            this.textB_Name.TabIndex = 4;
            this.textB_Name.Text = "0";
            this.textB_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textB_CH_Score
            // 
            this.textB_CH_Score.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_CH_Score.Location = new System.Drawing.Point(129, 86);
            this.textB_CH_Score.Name = "textB_CH_Score";
            this.textB_CH_Score.Size = new System.Drawing.Size(100, 30);
            this.textB_CH_Score.TabIndex = 5;
            this.textB_CH_Score.Text = "0";
            this.textB_CH_Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textB_EN_Score
            // 
            this.textB_EN_Score.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_EN_Score.Location = new System.Drawing.Point(129, 134);
            this.textB_EN_Score.Name = "textB_EN_Score";
            this.textB_EN_Score.Size = new System.Drawing.Size(100, 30);
            this.textB_EN_Score.TabIndex = 6;
            this.textB_EN_Score.Text = "0";
            this.textB_EN_Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textB_Math_Score
            // 
            this.textB_Math_Score.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_Math_Score.Location = new System.Drawing.Point(129, 185);
            this.textB_Math_Score.Name = "textB_Math_Score";
            this.textB_Math_Score.Size = new System.Drawing.Size(100, 30);
            this.textB_Math_Score.TabIndex = 7;
            this.textB_Math_Score.Text = "0";
            this.textB_Math_Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.Location = new System.Drawing.Point(48, 258);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(85, 34);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "儲存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Show_Save
            // 
            this.btn_Show_Save.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Show_Save.Location = new System.Drawing.Point(144, 258);
            this.btn_Show_Save.Name = "btn_Show_Save";
            this.btn_Show_Save.Size = new System.Drawing.Size(144, 34);
            this.btn_Show_Save.TabIndex = 9;
            this.btn_Show_Save.Text = "顯示儲存內容";
            this.btn_Show_Save.UseVisualStyleBackColor = true;
            this.btn_Show_Save.Click += new System.EventHandler(this.btn_Show_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textB_Show_HighLow_Score);
            this.groupBox1.Controls.Add(this.textB_Show_Score);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(333, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 256);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // textB_Show_HighLow_Score
            // 
            this.textB_Show_HighLow_Score.BackColor = System.Drawing.SystemColors.Control;
            this.textB_Show_HighLow_Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textB_Show_HighLow_Score.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textB_Show_HighLow_Score.Location = new System.Drawing.Point(3, 169);
            this.textB_Show_HighLow_Score.Multiline = true;
            this.textB_Show_HighLow_Score.Name = "textB_Show_HighLow_Score";
            this.textB_Show_HighLow_Score.ReadOnly = true;
            this.textB_Show_HighLow_Score.Size = new System.Drawing.Size(305, 84);
            this.textB_Show_HighLow_Score.TabIndex = 12;
            // 
            // textB_Show_Score
            // 
            this.textB_Show_Score.BackColor = System.Drawing.SystemColors.Control;
            this.textB_Show_Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textB_Show_Score.Dock = System.Windows.Forms.DockStyle.Top;
            this.textB_Show_Score.Location = new System.Drawing.Point(3, 26);
            this.textB_Show_Score.Multiline = true;
            this.textB_Show_Score.Name = "textB_Show_Score";
            this.textB_Show_Score.ReadOnly = true;
            this.textB_Show_Score.Size = new System.Drawing.Size(305, 137);
            this.textB_Show_Score.TabIndex = 12;
            // 
            // btn_HighLow_Score
            // 
            this.btn_HighLow_Score.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_HighLow_Score.Location = new System.Drawing.Point(454, 294);
            this.btn_HighLow_Score.Name = "btn_HighLow_Score";
            this.btn_HighLow_Score.Size = new System.Drawing.Size(187, 34);
            this.btn_HighLow_Score.TabIndex = 11;
            this.btn_HighLow_Score.Text = "最高分/最低分科目";
            this.btn_HighLow_Score.UseVisualStyleBackColor = true;
            this.btn_HighLow_Score.Click += new System.EventHandler(this.btn_HighLow_Score_Click);
            // 
            // Homework_04_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.btn_HighLow_Score);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Show_Save);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.textB_Math_Score);
            this.Controls.Add(this.textB_EN_Score);
            this.Controls.Add(this.textB_CH_Score);
            this.Controls.Add(this.textB_Name);
            this.Controls.Add(this.label_Math_Score);
            this.Controls.Add(this.label_EN_Score);
            this.Controls.Add(this.label_CH_Score);
            this.Controls.Add(this.label_Name);
            this.Name = "Homework_04_Frm";
            this.Text = "Student_StructForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_CH_Score;
        private System.Windows.Forms.Label label_EN_Score;
        private System.Windows.Forms.Label label_Math_Score;
        private System.Windows.Forms.TextBox textB_Name;
        private System.Windows.Forms.TextBox textB_CH_Score;
        private System.Windows.Forms.TextBox textB_EN_Score;
        private System.Windows.Forms.TextBox textB_Math_Score;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Show_Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_HighLow_Score;
        private System.Windows.Forms.TextBox textB_Show_Score;
        private System.Windows.Forms.TextBox textB_Show_HighLow_Score;
    }
}


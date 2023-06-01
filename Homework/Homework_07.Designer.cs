namespace Homework
{
    partial class Homework_07_Frm
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
            this.label_Num1 = new System.Windows.Forms.Label();
            this.label_Num2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_Answer = new System.Windows.Forms.Label();
            this.textB_Num1 = new System.Windows.Forms.TextBox();
            this.textB_Num2 = new System.Windows.Forms.TextBox();
            this.textB_Answer = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_divided = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Num1
            // 
            this.label_Num1.AutoSize = true;
            this.label_Num1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Num1.Location = new System.Drawing.Point(53, 48);
            this.label_Num1.Name = "label_Num1";
            this.label_Num1.Size = new System.Drawing.Size(59, 21);
            this.label_Num1.TabIndex = 0;
            this.label_Num1.Text = "Num1:";
            // 
            // label_Num2
            // 
            this.label_Num2.AutoSize = true;
            this.label_Num2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Num2.Location = new System.Drawing.Point(53, 92);
            this.label_Num2.Name = "label_Num2";
            this.label_Num2.Size = new System.Drawing.Size(59, 21);
            this.label_Num2.TabIndex = 1;
            this.label_Num2.Text = "Num2:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(29, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(324, 20);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "= = = = = = = = = = = = = = = = = = = = = = = =";
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Answer.Location = new System.Drawing.Point(41, 149);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(71, 21);
            this.label_Answer.TabIndex = 3;
            this.label_Answer.Text = "Answer:";
            // 
            // textB_Num1
            // 
            this.textB_Num1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_Num1.Location = new System.Drawing.Point(118, 45);
            this.textB_Num1.Name = "textB_Num1";
            this.textB_Num1.Size = new System.Drawing.Size(100, 29);
            this.textB_Num1.TabIndex = 4;
            // 
            // textB_Num2
            // 
            this.textB_Num2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_Num2.Location = new System.Drawing.Point(118, 89);
            this.textB_Num2.Name = "textB_Num2";
            this.textB_Num2.Size = new System.Drawing.Size(100, 29);
            this.textB_Num2.TabIndex = 5;
            // 
            // textB_Answer
            // 
            this.textB_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textB_Answer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_Answer.Location = new System.Drawing.Point(118, 146);
            this.textB_Answer.Name = "textB_Answer";
            this.textB_Answer.ReadOnly = true;
            this.textB_Answer.Size = new System.Drawing.Size(100, 29);
            this.textB_Answer.TabIndex = 6;
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(224, 48);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(47, 23);
            this.btn_plus.TabIndex = 7;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(224, 92);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(47, 23);
            this.btn_minus.TabIndex = 8;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(277, 48);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(47, 23);
            this.btn_multiply.TabIndex = 9;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_divided
            // 
            this.btn_divided.Location = new System.Drawing.Point(277, 92);
            this.btn_divided.Name = "btn_divided";
            this.btn_divided.Size = new System.Drawing.Size(47, 23);
            this.btn_divided.TabIndex = 10;
            this.btn_divided.Text = "/";
            this.btn_divided.UseVisualStyleBackColor = true;
            this.btn_divided.Click += new System.EventHandler(this.btn_divided_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.btn_divided);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.textB_Answer);
            this.Controls.Add(this.textB_Num2);
            this.Controls.Add(this.textB_Num1);
            this.Controls.Add(this.label_Answer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label_Num2);
            this.Controls.Add(this.label_Num1);
            this.Name = "Form1";
            this.Text = "MyCal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Num1;
        private System.Windows.Forms.Label label_Num2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_Answer;
        private System.Windows.Forms.TextBox textB_Num1;
        private System.Windows.Forms.TextBox textB_Num2;
        private System.Windows.Forms.TextBox textB_Answer;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_divided;
    }
}


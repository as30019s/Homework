namespace Homework
{
    partial class Homework_02_Frm
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
            this.label_money = new System.Windows.Forms.Label();
            this.textB_money = new System.Windows.Forms.TextBox();
            this.label_year = new System.Windows.Forms.Label();
            this.label_per = new System.Windows.Forms.Label();
            this.label_payment = new System.Windows.Forms.Label();
            this.textB_year = new System.Windows.Forms.TextBox();
            this.textB_rate = new System.Windows.Forms.TextBox();
            this.textB_payment = new System.Windows.Forms.TextBox();
            this.btn_monthPay = new System.Windows.Forms.Button();
            this.btn_totalPay = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_money.Location = new System.Drawing.Point(40, 40);
            this.label_money.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(124, 27);
            this.label_money.TabIndex = 0;
            this.label_money.Text = "貸款金額";
            // 
            // textB_money
            // 
            this.textB_money.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_money.Location = new System.Drawing.Point(200, 32);
            this.textB_money.Margin = new System.Windows.Forms.Padding(7);
            this.textB_money.Name = "textB_money";
            this.textB_money.Size = new System.Drawing.Size(228, 40);
            this.textB_money.TabIndex = 1;
            this.textB_money.Text = "100000";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_year.Location = new System.Drawing.Point(40, 100);
            this.label_year.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(124, 27);
            this.label_year.TabIndex = 2;
            this.label_year.Text = "期限(年)";
            // 
            // label_per
            // 
            this.label_per.AutoSize = true;
            this.label_per.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_per.Location = new System.Drawing.Point(40, 160);
            this.label_per.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_per.Name = "label_per";
            this.label_per.Size = new System.Drawing.Size(110, 27);
            this.label_per.TabIndex = 3;
            this.label_per.Text = "利率(%)";
            // 
            // label_payment
            // 
            this.label_payment.AutoSize = true;
            this.label_payment.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_payment.Location = new System.Drawing.Point(40, 220);
            this.label_payment.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_payment.Name = "label_payment";
            this.label_payment.Size = new System.Drawing.Size(96, 27);
            this.label_payment.TabIndex = 4;
            this.label_payment.Text = "頭期款";
            // 
            // textB_year
            // 
            this.textB_year.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_year.Location = new System.Drawing.Point(200, 97);
            this.textB_year.Margin = new System.Windows.Forms.Padding(7);
            this.textB_year.Name = "textB_year";
            this.textB_year.Size = new System.Drawing.Size(228, 40);
            this.textB_year.TabIndex = 5;
            this.textB_year.Text = "2";
            // 
            // textB_rate
            // 
            this.textB_rate.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_rate.Location = new System.Drawing.Point(200, 160);
            this.textB_rate.Margin = new System.Windows.Forms.Padding(7);
            this.textB_rate.Name = "textB_rate";
            this.textB_rate.Size = new System.Drawing.Size(228, 40);
            this.textB_rate.TabIndex = 6;
            this.textB_rate.Text = "10";
            // 
            // textB_payment
            // 
            this.textB_payment.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_payment.Location = new System.Drawing.Point(200, 217);
            this.textB_payment.Margin = new System.Windows.Forms.Padding(7);
            this.textB_payment.Name = "textB_payment";
            this.textB_payment.Size = new System.Drawing.Size(228, 40);
            this.textB_payment.TabIndex = 7;
            this.textB_payment.Text = "0";
            // 
            // btn_monthPay
            // 
            this.btn_monthPay.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_monthPay.Location = new System.Drawing.Point(40, 300);
            this.btn_monthPay.Margin = new System.Windows.Forms.Padding(7);
            this.btn_monthPay.Name = "btn_monthPay";
            this.btn_monthPay.Size = new System.Drawing.Size(150, 50);
            this.btn_monthPay.TabIndex = 8;
            this.btn_monthPay.Text = "PMT(月付)";
            this.btn_monthPay.UseVisualStyleBackColor = true;
            this.btn_monthPay.Click += new System.EventHandler(this.btn_monthPay_Click);
            // 
            // btn_totalPay
            // 
            this.btn_totalPay.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_totalPay.Location = new System.Drawing.Point(220, 300);
            this.btn_totalPay.Margin = new System.Windows.Forms.Padding(7);
            this.btn_totalPay.Name = "btn_totalPay";
            this.btn_totalPay.Size = new System.Drawing.Size(150, 50);
            this.btn_totalPay.TabIndex = 9;
            this.btn_totalPay.Text = "總付款";
            this.btn_totalPay.UseVisualStyleBackColor = true;
            this.btn_totalPay.Click += new System.EventHandler(this.btn_totalPay_Click);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_report.Location = new System.Drawing.Point(400, 300);
            this.btn_report.Margin = new System.Windows.Forms.Padding(7);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(150, 50);
            this.btn_report.TabIndex = 10;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // Homework_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_totalPay);
            this.Controls.Add(this.btn_monthPay);
            this.Controls.Add(this.textB_payment);
            this.Controls.Add(this.textB_rate);
            this.Controls.Add(this.textB_year);
            this.Controls.Add(this.label_payment);
            this.Controls.Add(this.label_per);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.textB_money);
            this.Controls.Add(this.label_money);
            this.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Homework_02";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.TextBox textB_money;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_per;
        private System.Windows.Forms.Label label_payment;
        private System.Windows.Forms.TextBox textB_year;
        private System.Windows.Forms.TextBox textB_rate;
        private System.Windows.Forms.TextBox textB_payment;
        private System.Windows.Forms.Button btn_monthPay;
        private System.Windows.Forms.Button btn_totalPay;
        private System.Windows.Forms.Button btn_report;
    }
}


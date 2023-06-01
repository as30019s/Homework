namespace Homework
{
    partial class Homework_01_Frm
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_EName = new System.Windows.Forms.Label();
            this.label_sex = new System.Windows.Forms.Label();
            this.label_SS = new System.Windows.Forms.Label();
            this.textB_name = new System.Windows.Forms.TextBox();
            this.textB_Ename = new System.Windows.Forms.TextBox();
            this.textB_sex = new System.Windows.Forms.TextBox();
            this.textB_SS = new System.Windows.Forms.TextBox();
            this.btn_hello = new System.Windows.Forms.Button();
            this.btn_Hi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_name.Location = new System.Drawing.Point(20, 40);
            this.label_name.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(96, 27);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "姓名：";
            // 
            // label_EName
            // 
            this.label_EName.AutoSize = true;
            this.label_EName.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_EName.Location = new System.Drawing.Point(20, 100);
            this.label_EName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_EName.Name = "label_EName";
            this.label_EName.Size = new System.Drawing.Size(208, 27);
            this.label_EName.TabIndex = 1;
            this.label_EName.Text = "English Name: ";
            // 
            // label_sex
            // 
            this.label_sex.AutoSize = true;
            this.label_sex.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_sex.Location = new System.Drawing.Point(20, 160);
            this.label_sex.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(96, 27);
            this.label_sex.TabIndex = 2;
            this.label_sex.Text = "性別：";
            // 
            // label_SS
            // 
            this.label_SS.AutoSize = true;
            this.label_SS.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_SS.Location = new System.Drawing.Point(20, 220);
            this.label_SS.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_SS.Name = "label_SS";
            this.label_SS.Size = new System.Drawing.Size(96, 27);
            this.label_SS.TabIndex = 3;
            this.label_SS.Text = "星座：";
            // 
            // textB_name
            // 
            this.textB_name.Location = new System.Drawing.Point(240, 32);
            this.textB_name.Name = "textB_name";
            this.textB_name.Size = new System.Drawing.Size(232, 40);
            this.textB_name.TabIndex = 4;
            // 
            // textB_Ename
            // 
            this.textB_Ename.Location = new System.Drawing.Point(240, 97);
            this.textB_Ename.Name = "textB_Ename";
            this.textB_Ename.Size = new System.Drawing.Size(232, 40);
            this.textB_Ename.TabIndex = 5;
            // 
            // textB_sex
            // 
            this.textB_sex.Location = new System.Drawing.Point(240, 157);
            this.textB_sex.Name = "textB_sex";
            this.textB_sex.Size = new System.Drawing.Size(232, 40);
            this.textB_sex.TabIndex = 6;
            // 
            // textB_SS
            // 
            this.textB_SS.Location = new System.Drawing.Point(240, 217);
            this.textB_SS.Name = "textB_SS";
            this.textB_SS.Size = new System.Drawing.Size(232, 40);
            this.textB_SS.TabIndex = 7;
            // 
            // btn_hello
            // 
            this.btn_hello.Location = new System.Drawing.Point(25, 288);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(161, 52);
            this.btn_hello.TabIndex = 8;
            this.btn_hello.Text = "Say HELLO!";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // btn_Hi
            // 
            this.btn_Hi.Location = new System.Drawing.Point(240, 288);
            this.btn_Hi.Name = "btn_Hi";
            this.btn_Hi.Size = new System.Drawing.Size(161, 52);
            this.btn_Hi.TabIndex = 9;
            this.btn_Hi.Text = "Say HI!";
            this.btn_Hi.UseVisualStyleBackColor = true;
            this.btn_Hi.Click += new System.EventHandler(this.btn_Hi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btn_Hi);
            this.Controls.Add(this.btn_hello);
            this.Controls.Add(this.textB_SS);
            this.Controls.Add(this.textB_sex);
            this.Controls.Add(this.textB_Ename);
            this.Controls.Add(this.textB_name);
            this.Controls.Add(this.label_SS);
            this.Controls.Add(this.label_sex);
            this.Controls.Add(this.label_EName);
            this.Controls.Add(this.label_name);
            this.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "你好! C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_EName;
        private System.Windows.Forms.Label label_sex;
        private System.Windows.Forms.Label label_SS;
        private System.Windows.Forms.TextBox textB_name;
        private System.Windows.Forms.TextBox textB_Ename;
        private System.Windows.Forms.TextBox textB_sex;
        private System.Windows.Forms.TextBox textB_SS;
        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.Button btn_Hi;
    }
}


namespace Homework
{
    partial class Homework_14_Frm
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
            this.label_title = new System.Windows.Forms.Label();
            this.btn_guess = new System.Windows.Forms.Button();
            this.btn_showAns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(81, 68);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(427, 27);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Please Select A Number Between 1 to 100!";
            // 
            // btn_guess
            // 
            this.btn_guess.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guess.Location = new System.Drawing.Point(127, 151);
            this.btn_guess.Name = "btn_guess";
            this.btn_guess.Size = new System.Drawing.Size(108, 40);
            this.btn_guess.TabIndex = 1;
            this.btn_guess.Text = "Guess";
            this.btn_guess.UseVisualStyleBackColor = true;
            this.btn_guess.Click += new System.EventHandler(this.btn_guess_Click);
            // 
            // btn_showAns
            // 
            this.btn_showAns.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAns.Location = new System.Drawing.Point(263, 151);
            this.btn_showAns.Name = "btn_showAns";
            this.btn_showAns.Size = new System.Drawing.Size(171, 40);
            this.btn_showAns.TabIndex = 2;
            this.btn_showAns.Text = "Show Answer";
            this.btn_showAns.UseVisualStyleBackColor = true;
            // 
            // Homework_14_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.btn_showAns);
            this.Controls.Add(this.btn_guess);
            this.Controls.Add(this.label_title);
            this.Name = "Homework_14_Frm";
            this.Text = "Form Guess Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_guess;
        private System.Windows.Forms.Button btn_showAns;
    }
}
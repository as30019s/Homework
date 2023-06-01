namespace Homework
{
    partial class Frm_guess
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.textB_guessNumber = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(283, 18);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(82, 41);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(283, 67);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 41);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // textB_guessNumber
            // 
            this.textB_guessNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textB_guessNumber.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_guessNumber.Location = new System.Drawing.Point(21, 117);
            this.textB_guessNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textB_guessNumber.Name = "textB_guessNumber";
            this.textB_guessNumber.Size = new System.Drawing.Size(344, 21);
            this.textB_guessNumber.TabIndex = 2;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(35, 43);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(213, 29);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Please input a number.";
            // 
            // Frm_guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 148);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textB_guessNumber);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_guess";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox textB_guessNumber;
        private System.Windows.Forms.Label label_title;
    }
}
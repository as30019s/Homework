namespace Homework
{
    partial class Homework_12_Frm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_color = new System.Windows.Forms.Button();
            this.PB_currentColor = new System.Windows.Forms.PictureBox();
            this.trackBar_fontSize = new System.Windows.Forms.TrackBar();
            this.label_fontSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_currentColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btn_color
            // 
            this.btn_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color.Location = new System.Drawing.Point(713, 12);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(75, 23);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "顏色";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // PB_currentColor
            // 
            this.PB_currentColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_currentColor.Location = new System.Drawing.Point(713, 41);
            this.PB_currentColor.Name = "PB_currentColor";
            this.PB_currentColor.Size = new System.Drawing.Size(75, 30);
            this.PB_currentColor.TabIndex = 2;
            this.PB_currentColor.TabStop = false;
            // 
            // trackBar_fontSize
            // 
            this.trackBar_fontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_fontSize.LargeChange = 1;
            this.trackBar_fontSize.Location = new System.Drawing.Point(730, 77);
            this.trackBar_fontSize.Maximum = 36;
            this.trackBar_fontSize.Minimum = 1;
            this.trackBar_fontSize.Name = "trackBar_fontSize";
            this.trackBar_fontSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_fontSize.Size = new System.Drawing.Size(45, 150);
            this.trackBar_fontSize.TabIndex = 3;
            this.trackBar_fontSize.Value = 1;
            this.trackBar_fontSize.Scroll += new System.EventHandler(this.trackBar_fontSize_Scroll);
            // 
            // label_fontSize
            // 
            this.label_fontSize.AutoSize = true;
            this.label_fontSize.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fontSize.Location = new System.Drawing.Point(737, 230);
            this.label_fontSize.Name = "label_fontSize";
            this.label_fontSize.Size = new System.Drawing.Size(22, 25);
            this.label_fontSize.TabIndex = 4;
            this.label_fontSize.Text = "1";
            // 
            // Homework_12_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_fontSize);
            this.Controls.Add(this.trackBar_fontSize);
            this.Controls.Add(this.PB_currentColor);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Homework_12_Frm";
            this.Text = "Draw Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_currentColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_fontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.PictureBox PB_currentColor;
        private System.Windows.Forms.TrackBar trackBar_fontSize;
        private System.Windows.Forms.Label label_fontSize;
    }
}
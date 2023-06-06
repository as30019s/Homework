namespace Homework
{
    partial class Homework_13_Frm
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.選擇圖片資料夾ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟資料夾ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選擇圖片資料夾ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 選擇圖片資料夾ToolStripMenuItem
            // 
            this.選擇圖片資料夾ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟資料夾ToolStripMenuItem});
            this.選擇圖片資料夾ToolStripMenuItem.Name = "選擇圖片資料夾ToolStripMenuItem";
            this.選擇圖片資料夾ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.選擇圖片資料夾ToolStripMenuItem.Text = "檔案";
            // 
            // 開啟資料夾ToolStripMenuItem
            // 
            this.開啟資料夾ToolStripMenuItem.Name = "開啟資料夾ToolStripMenuItem";
            this.開啟資料夾ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開啟資料夾ToolStripMenuItem.Text = "開啟資料夾";
            this.開啟資料夾ToolStripMenuItem.Click += new System.EventHandler(this.開啟資料夾ToolStripMenuItem_Click);
            // 
            // Homework_13_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "Homework_13_Frm";
            this.Text = "Picture Viewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 選擇圖片資料夾ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟資料夾ToolStripMenuItem;
    }
}
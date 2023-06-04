namespace Homework
{
    partial class Homework_03_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homework_03_Frm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Menu_Wine = new System.Windows.Forms.Button();
            this.btn_Menu_Whisky = new System.Windows.Forms.Button();
            this.btn_Menu_Tequila = new System.Windows.Forms.Button();
            this.btn_Menu_beer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Total_Price = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_message_01 = new System.Windows.Forms.Label();
            this.btn_Pay_Card = new System.Windows.Forms.Button();
            this.btn_Pay_Cash = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Clear_List = new System.Windows.Forms.Button();
            this.textB_Detail_List = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Menu_Wine);
            this.groupBox1.Controls.Add(this.btn_Menu_Whisky);
            this.groupBox1.Controls.Add(this.btn_Menu_Tequila);
            this.groupBox1.Controls.Add(this.btn_Menu_beer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單 Menu";
            // 
            // btn_Menu_Wine
            // 
            this.btn_Menu_Wine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Menu_Wine.BackgroundImage")));
            this.btn_Menu_Wine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Menu_Wine.Font = new System.Drawing.Font("標楷體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Menu_Wine.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Menu_Wine.Location = new System.Drawing.Point(102, 135);
            this.btn_Menu_Wine.Name = "btn_Menu_Wine";
            this.btn_Menu_Wine.Size = new System.Drawing.Size(90, 100);
            this.btn_Menu_Wine.TabIndex = 7;
            this.btn_Menu_Wine.Text = "紅酒 Wine NT$320";
            this.btn_Menu_Wine.UseVisualStyleBackColor = true;
            this.btn_Menu_Wine.Click += new System.EventHandler(this.btn_Menu_Wine_Click);
            // 
            // btn_Menu_Whisky
            // 
            this.btn_Menu_Whisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Menu_Whisky.BackgroundImage")));
            this.btn_Menu_Whisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Menu_Whisky.Font = new System.Drawing.Font("標楷體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Menu_Whisky.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Menu_Whisky.Location = new System.Drawing.Point(6, 135);
            this.btn_Menu_Whisky.Name = "btn_Menu_Whisky";
            this.btn_Menu_Whisky.Size = new System.Drawing.Size(90, 100);
            this.btn_Menu_Whisky.TabIndex = 6;
            this.btn_Menu_Whisky.Text = "威士忌 Whisky NT$350";
            this.btn_Menu_Whisky.UseVisualStyleBackColor = true;
            this.btn_Menu_Whisky.Click += new System.EventHandler(this.btn_Menu_Whisky_Click);
            // 
            // btn_Menu_Tequila
            // 
            this.btn_Menu_Tequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Menu_Tequila.BackgroundImage")));
            this.btn_Menu_Tequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Menu_Tequila.Font = new System.Drawing.Font("標楷體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Menu_Tequila.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Menu_Tequila.Location = new System.Drawing.Point(102, 29);
            this.btn_Menu_Tequila.Name = "btn_Menu_Tequila";
            this.btn_Menu_Tequila.Size = new System.Drawing.Size(90, 100);
            this.btn_Menu_Tequila.TabIndex = 5;
            this.btn_Menu_Tequila.Text = "龍舌蘭 Tequila NT$180";
            this.btn_Menu_Tequila.UseVisualStyleBackColor = true;
            this.btn_Menu_Tequila.Click += new System.EventHandler(this.btn_Menu_Tequila_Click);
            // 
            // btn_Menu_beer
            // 
            this.btn_Menu_beer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Menu_beer.BackgroundImage")));
            this.btn_Menu_beer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Menu_beer.Font = new System.Drawing.Font("標楷體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Menu_beer.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Menu_beer.Location = new System.Drawing.Point(6, 29);
            this.btn_Menu_beer.Name = "btn_Menu_beer";
            this.btn_Menu_beer.Size = new System.Drawing.Size(90, 100);
            this.btn_Menu_beer.TabIndex = 4;
            this.btn_Menu_beer.Text = "啤酒 Beer NT$120";
            this.btn_Menu_beer.UseVisualStyleBackColor = true;
            this.btn_Menu_beer.Click += new System.EventHandler(this.btn_Menu_beer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Total_Price);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "總金額 Total Price";
            // 
            // label_Total_Price
            // 
            this.label_Total_Price.BackColor = System.Drawing.Color.Black;
            this.label_Total_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Total_Price.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Total_Price.ForeColor = System.Drawing.Color.White;
            this.label_Total_Price.Location = new System.Drawing.Point(6, 26);
            this.label_Total_Price.Name = "label_Total_Price";
            this.label_Total_Price.Padding = new System.Windows.Forms.Padding(3);
            this.label_Total_Price.Size = new System.Drawing.Size(215, 30);
            this.label_Total_Price.TabIndex = 5;
            this.label_Total_Price.Text = "NT$ 0";
            this.label_Total_Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_message_01);
            this.groupBox3.Controls.Add(this.btn_Pay_Card);
            this.groupBox3.Controls.Add(this.btn_Pay_Cash);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 102);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "付款方式";
            // 
            // label_message_01
            // 
            this.label_message_01.AutoSize = true;
            this.label_message_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_message_01.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_message_01.Location = new System.Drawing.Point(98, 67);
            this.label_message_01.Name = "label_message_01";
            this.label_message_01.Padding = new System.Windows.Forms.Padding(3);
            this.label_message_01.Size = new System.Drawing.Size(119, 24);
            this.label_message_01.TabIndex = 4;
            this.label_message_01.Text = "信用卡享九折!";
            // 
            // btn_Pay_Card
            // 
            this.btn_Pay_Card.Location = new System.Drawing.Point(116, 29);
            this.btn_Pay_Card.Name = "btn_Pay_Card";
            this.btn_Pay_Card.Size = new System.Drawing.Size(80, 35);
            this.btn_Pay_Card.TabIndex = 1;
            this.btn_Pay_Card.Text = "信用卡";
            this.btn_Pay_Card.UseVisualStyleBackColor = true;
            this.btn_Pay_Card.Click += new System.EventHandler(this.btn_Pay_Card_Click);
            // 
            // btn_Pay_Cash
            // 
            this.btn_Pay_Cash.Location = new System.Drawing.Point(19, 29);
            this.btn_Pay_Cash.Name = "btn_Pay_Cash";
            this.btn_Pay_Cash.Size = new System.Drawing.Size(80, 35);
            this.btn_Pay_Cash.TabIndex = 0;
            this.btn_Pay_Cash.Text = "現金";
            this.btn_Pay_Cash.UseVisualStyleBackColor = true;
            this.btn_Pay_Cash.Click += new System.EventHandler(this.btn_Pay_Cash_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Clear_List);
            this.groupBox4.Controls.Add(this.textB_Detail_List);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 242);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "購物清單 List";
            // 
            // btn_Clear_List
            // 
            this.btn_Clear_List.Location = new System.Drawing.Point(231, 199);
            this.btn_Clear_List.Name = "btn_Clear_List";
            this.btn_Clear_List.Size = new System.Drawing.Size(100, 35);
            this.btn_Clear_List.TabIndex = 5;
            this.btn_Clear_List.Text = "清除清單";
            this.btn_Clear_List.UseVisualStyleBackColor = true;
            this.btn_Clear_List.Click += new System.EventHandler(this.btn_Clear_List_Click);
            // 
            // textB_Detail_List
            // 
            this.textB_Detail_List.BackColor = System.Drawing.Color.White;
            this.textB_Detail_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textB_Detail_List.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textB_Detail_List.Location = new System.Drawing.Point(8, 26);
            this.textB_Detail_List.Multiline = true;
            this.textB_Detail_List.Name = "textB_Detail_List";
            this.textB_Detail_List.ReadOnly = true;
            this.textB_Detail_List.Size = new System.Drawing.Size(323, 164);
            this.textB_Detail_List.TabIndex = 0;
            this.textB_Detail_List.Text = "尚未點餐";
            this.textB_Detail_List.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 245);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(227, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 64);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(227, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 104);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.groupBox4);
            this.panel4.Location = new System.Drawing.Point(472, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 244);
            this.panel4.TabIndex = 7;
            // 
            // Homework_03_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 311);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Homework_03_Frm";
            this.Text = "Bar POS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Menu_Wine;
        private System.Windows.Forms.Button btn_Menu_Whisky;
        private System.Windows.Forms.Button btn_Menu_Tequila;
        private System.Windows.Forms.Button btn_Menu_beer;
        private System.Windows.Forms.Button btn_Pay_Card;
        private System.Windows.Forms.Button btn_Pay_Cash;
        private System.Windows.Forms.Label label_message_01;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Total_Price;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Clear_List;
        private System.Windows.Forms.TextBox textB_Detail_List;
    }
}


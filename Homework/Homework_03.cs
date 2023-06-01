using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Homework_03_Frm : Form
    {
        public Homework_03_Frm()
        {
            InitializeComponent();
        }

        int totalPrice;

        // Menu Parameter defination
        DrinkMenu beer = new DrinkMenu
        {
            Name = "啤酒Beer",
            unitPrice = 120
        };
        DrinkMenu Tequila = new DrinkMenu
        {
            Name = "龍舌蘭Tequila",
            unitPrice = 180
        };
        DrinkMenu Whisky = new DrinkMenu
        {
            Name = "威士忌Whisky",
            unitPrice = 350
        };
        DrinkMenu Wine = new DrinkMenu
        {
            Name = "紅酒Wine",
            unitPrice = 320
        };

        // Menu Click Event
        private void btn_Menu_beer_Click(object sender, EventArgs e)
        {
            beer.count++;
            priceAndListUpdate();
        }

        private void btn_Menu_Tequila_Click(object sender, EventArgs e)
        {
            Tequila.count++;
            priceAndListUpdate();
        }

        private void btn_Menu_Whisky_Click(object sender, EventArgs e)
        {
            Whisky.count++;
            priceAndListUpdate();
        }

        private void btn_Menu_Wine_Click(object sender, EventArgs e)
        {
            Wine.count++;
            priceAndListUpdate();
        }

        private void btn_Clear_List_Click(object sender, EventArgs e)
        {
            beer.count = 0;
            Tequila.count = 0;
            Whisky.count = 0;
            Wine.count = 0;
            priceAndListUpdate();
        }

        private void btn_Pay_Cash_Click(object sender, EventArgs e)
        {
            if (totalPrice == 0)
            {
                MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"總金額：NT$ {totalPrice}", "確認付款", MessageBoxButtons.OKCancel);
            }
        }

        private void btn_Pay_Card_Click(object sender, EventArgs e)
        {
            if (totalPrice == 0)
            {
                MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"總金額：NT$ {totalPrice}\r\n折扣後金額：NT$ {totalPrice*0.9}","確認付款",MessageBoxButtons.OKCancel);
            }
        }

        public void priceAndListUpdate()
        {
            totalPrice = 0;
            textB_Detail_List.Text = "";

            if ( beer.count > 0 )
            {
                totalPrice += beer.count * beer.unitPrice;
                textB_Detail_List.Text += $"{beer.Name} x {beer.count}, 共NT$ {beer.count * beer.unitPrice}元\r\n";
            }
            if ( Tequila.count > 0 )
            {
                totalPrice += Tequila.count * Tequila.unitPrice;
                textB_Detail_List.Text += $"{Tequila.Name} x {Tequila.count}, 共NT$ {Tequila.count * Tequila.unitPrice}元\r\n";
            }
            if (Whisky.count > 0 )
            {
                totalPrice += Whisky.count * Whisky.unitPrice;
                textB_Detail_List.Text += $"{Whisky.Name} x {Whisky.count}, 共NT$ {Whisky.count * Whisky.unitPrice}元\r\n";
            }
            if (Wine.count > 0 )
            {
                totalPrice += Wine.count * Wine.unitPrice;
                textB_Detail_List.Text += $"{Wine.Name} x {Wine.count}, 共NT$ {Wine.count * Wine.unitPrice}元\r\n";
            }
            if ((totalPrice) == 0)
            {
                textB_Detail_List.Text = "尚未點餐";
            }
            label_Total_Price.Text = $"NT$ {totalPrice}";
        }


    }
}

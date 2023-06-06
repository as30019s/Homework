using System;
using System.Collections;
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
    public partial class Homework_09_02_Frm : Form
    {
        // parameter definition
        string[,] layout;
        List<OXGame> lsgames = new List<OXGame>();
        bool result = false;
        bool currentUserCheck = true;
        int count;

        public Homework_09_02_Frm()
        {
            InitializeComponent();
            btnCreate();
        }

        // create OX button
        // using large size array and condition to limit button only create 3x3
        private void btnCreate()
        {
            layout = new string[7, 7];
            int x = 60;
            int y = 80;
            for (int i = 0; i < layout.GetLength(0); i++)
            {
                x = 60;
                for (int j = 0; j < layout.GetLength(1); j++)
                {
                    if ((i > 1 && i < 5) && (j > 1 && j < 5))
                    {
                        Button btn = new Button();
                        btn.Size = new System.Drawing.Size(80, 80);
                        btn.Location = new System.Drawing.Point(x, y);
                        btn.BackColor = Color.LemonChiffon;
                        btn.Font = new Font("Arial", 36);
                        this.Controls.Add(btn);
                        btn.MouseClick += Btn_MouseClick;
                        x += 85;

                        // Save the created button information in the list
                        OXGame oxGame;
                        oxGame.OXbutton = btn;
                        oxGame.indexX = i;
                        oxGame.indexY = j;
                        lsgames.Add( oxGame );
                    }
                    
                }
                if (i > 1 && i < 5)
                {
                    y += 85;
                }
            }
        }

        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            // find current click button
            foreach (OXGame item in lsgames)
            {
                if (item.OXbutton == (Button)sender)
                {
                    if (currentUserCheck)
                    {
                        ((Button)sender).Text = "〇";
                        layout[item.indexX, item.indexY] = "〇";
                    }
                    else
                    {
                        ((Button)sender).Text = "X";
                        layout[item.indexX, item.indexY] = "X";
                    }
                    ((Button)sender).Enabled = false;
                    currentUserCheck = !currentUserCheck;
                    result = checkGameResult(item.indexX, item.indexY);
                    winnerMessage(result, layout[item.indexX, item.indexY]);
                }
            }

        }

        // use index of click button to check the game result
        public bool checkGameResult(int x, int y)
        {
            int countRow = 0;
            int countCol = 0;
            int countSlash = 0;
            int countSlashReverse = 0;
            count++;
            for (int i = 0; i < 3; i++)
            {
                countRow = 0;
                countCol = 0;
                countSlash = 0;
                countSlashReverse = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (layout[x - i + j, y] == layout[x, y])
                    {
                        countRow++;
                    }
                    if (layout[x, y - i + j] == layout[x, y])
                    {
                        countCol++;
                    }
                    if (layout[x - i + j, y - i + j] == layout[x, y])
                    {
                        countSlash++;
                    }
                    if (layout[x - i + j, y + i - j] == layout[x, y])
                    {
                        countSlashReverse++;
                    }
                }
                if (countRow == 3 || countCol == 3 || countSlash == 3 || countSlashReverse == 3)
                {
                    return true;
                }
         
            }
            if (count == 9)
            {
                MessageBox.Show("平手");
                btnReset();
            }
            return false;

        }
        void winnerMessage(bool boolResult, string user)
        {
            if (boolResult)
            {
                MessageBox.Show($"{user}獲勝");
                currentUserCheck = true;
                result = false;
                layout = new string[3, 3];
                btnReset();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            currentUserCheck = true;
            result = false;
            layout = new string[3, 3];
            btnReset();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Homework_09_Frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 82)
            {
                currentUserCheck = true;
                result = false;
                layout = new string[3, 3];
                btnReset();
            }
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }
        private void btnReset()
        {
            layout = new string[7, 7];
            currentUserCheck = true;
            count = 0;
            foreach (OXGame item in lsgames)
            {
                item.OXbutton.Enabled = true;
                item.OXbutton.Text = string.Empty;
            }
        }
    }
}

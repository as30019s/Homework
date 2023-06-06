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
        string[,] layout = new string[7, 7];
        List<OXGame> lsgames = new List<OXGame>();
        bool result = false;
        int x = 60;
        int y = 80;
        public Homework_09_02_Frm()
        {
            InitializeComponent();
            btnCreate();
        }

        bool currentUserCheck = true;

        private void btnCreate()
        {
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
                    result = checkGameResult(x, y);
                    winnerMessage(result, layout[x, y]);


                }
            }

        }

        public bool checkGameResult(int x, int y)
        {
            int countRow = 0;
            int countCol = 0;
            int countSlash = 0;
            int countSlashReverse = 0;

            for (int i = x-2; i <= x; i++)
            {
                if (layout[i, y] == layout[x, y])
                {
                    countRow++;
                }
                if (layout[x, i] == layout[x, y])
                {
                    countCol++;
                }
                if (layout[i, i] == layout[x, y])
                {
                    countSlash++;
                }
                if (layout[i, 2 - i] == layout[x, y])
                {
                    countSlashReverse++;
                }
            }

            if (countRow == 3 || countCol == 3 || countSlash == 3 || countSlashReverse == 3)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        void winnerMessage(bool boolResult, string user)
        {
            if (boolResult)
            {
                MessageBox.Show($"{user}獲勝");
                currentUserCheck = true;
                result = false;
                layout = new string[3, 3];
                Controls.Clear();
                InitializeComponent();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            currentUserCheck = true;
            result = false;
            layout = new string[3, 3];
            Controls.Clear();
            InitializeComponent();
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
                Controls.Clear();
                InitializeComponent();
            }
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }
    }
}

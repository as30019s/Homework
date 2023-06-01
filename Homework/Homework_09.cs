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
    public partial class Homework_09_Frm : Form
    {
        string[,] layout = new string[3, 3];
        bool result = false;
        public Homework_09_Frm()
        {
            InitializeComponent();
        }

        bool currentUserCheck = true;

        private void btn_OX_00_Click(object sender, EventArgs e)
        {

            if (currentUserCheck)
            {
                btn_OX_00.Text = "〇";
                layout[0, 0] = "〇";
            }
            else
            {
                btn_OX_00.Text = "X";
                layout[0, 0] = "X";
            }
            btn_OX_00.Enabled = false;
            currentUserCheck = !currentUserCheck;
            result = checkGameResult(0,0);
            winnerMessage(result, layout[0, 0]);

        }

        private void btn_OX_10_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_10.Text = "〇";
                layout[1, 0] = "〇";
            }
            else
            {
                btn_OX_10.Text = "X";
                layout[1, 0] = "X";
            }
            btn_OX_10.Enabled = false;
            currentUserCheck = !currentUserCheck;
            result = checkGameResult(1, 0);
            winnerMessage(result, layout[1, 0]);

        }

        private void btn_OX_20_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_20.Text = "〇";
                layout[2, 0] = "〇";
            }
            else
            {
                btn_OX_20.Text = "X";
                layout[2, 0] = "X";
            }
            btn_OX_20.Enabled = false;
            currentUserCheck = !currentUserCheck;
            result = checkGameResult(2, 0);
            winnerMessage(result, layout[2, 0]);

        }

        private void btn_OX_01_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_01.Text = "〇";
                layout[0, 1] = "〇";
            }
            else
            {
                btn_OX_01.Text = "X";
                layout[0, 1] = "X";
            }
            btn_OX_01.Enabled = false;
            currentUserCheck = !currentUserCheck;
            result = checkGameResult(0, 1);
            winnerMessage(result, layout[0, 1]);

        }

        private void btn_OX_11_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_11.Text = "〇";
                layout[1, 1] = "〇";
            }
            else
            {
                btn_OX_11.Text = "X";
                layout[1, 1] = "X";
            }
            btn_OX_11.Enabled = false;
            currentUserCheck = !currentUserCheck;
            result = checkGameResult(1, 1);
            winnerMessage(result, layout[1, 1]);

        }

        private void btn_OX_21_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_21.Text = "〇";
                layout[2, 1] = "〇";
            }
            else
            {
                btn_OX_21.Text = "X";
                layout[2, 1] = "X";
            }
            btn_OX_21.Enabled = false;
            currentUserCheck = !currentUserCheck;
            result = checkGameResult(2, 1);
            winnerMessage(result, layout[2, 1]);

        }

        private void btn_OX_02_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_02.Text = "〇";
                layout[0, 2] = "〇";
            }
            else
            {
                btn_OX_02.Text = "X";
                layout[0, 2] = "X";
            }
            btn_OX_02.Enabled = false;
            currentUserCheck = !currentUserCheck;
            result = checkGameResult(0, 2);
            winnerMessage(result, layout[0, 2]);

        }

        private void btn_OX_12_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_12.Text = "〇";
                layout[1, 2] = "〇";
            }
            else
            {
                btn_OX_12.Text = "X";
                layout[1, 2] = "X";
            }
            btn_OX_12.Enabled = false;
            currentUserCheck = !currentUserCheck;
            result = checkGameResult(1, 2);
            winnerMessage(result, layout[1, 2]);

        }

        private void btn_OX_22_Click(object sender, EventArgs e)
        {
            if (currentUserCheck)
            {
                btn_OX_22.Text = "〇";
                layout[2, 2] = "〇";
            }
            else
            {
                btn_OX_22.Text = "X";
                layout[2, 2] = "X";
            }
            btn_OX_22.Enabled = false;
            currentUserCheck = !currentUserCheck;
            result = checkGameResult(2, 2);
            winnerMessage(result, layout[2, 2]);

        }
        public bool checkGameResult(int x, int y)
        {
            int countRow = 0;
            int countCol = 0;
            int countSlash = 0;
            if (x == 0 && y == 0)
            {
                for (int i = 0; i < 3; i++)
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
                }
            }
            else if (x == 0 && y == 2)
            {
                for (int i = 2; i >= 0; i--)
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
                }
            } else if (x == 2 && y ==0)
            {
                for (int i = 2; i >= 0; i--)
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
                }
            } else if (x == 2 && y == 2) 
            {
                for (int i = 2; i >= 0; i--)
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
                }
            }




            if (countRow == 3 || countCol == 3 || countSlash == 3)
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
            }
        }
    }
}

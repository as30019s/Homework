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
            updateMethod(btn_OX_00, 0, 0);

        }

        private void btn_OX_10_Click(object sender, EventArgs e)
        {
            updateMethod(btn_OX_10, 1,0);
        }

        private void btn_OX_20_Click(object sender, EventArgs e)
        {
            updateMethod(btn_OX_20, 2, 0);

        }

        private void btn_OX_01_Click(object sender, EventArgs e)
        {
            updateMethod(btn_OX_01, 0, 1);
        }

        private void btn_OX_11_Click(object sender, EventArgs e)
        {
            updateMethod(btn_OX_11, 1, 1);
        }

        private void btn_OX_21_Click(object sender, EventArgs e)
        {
            updateMethod(btn_OX_21, 2, 1);

        }

        private void btn_OX_02_Click(object sender, EventArgs e)
        {
            updateMethod(btn_OX_02, 0, 2);

        }

        private void btn_OX_12_Click(object sender, EventArgs e)
        {
            updateMethod(btn_OX_12, 1, 2);

        }

        private void btn_OX_22_Click(object sender, EventArgs e)
        {
            updateMethod(btn_OX_22, 2, 2);
        }
        public bool checkGameResult(int x, int y)
        {
            int countRow = 0;
            int countCol = 0;
            int countSlash = 0;
            int countSlashReverse = 0;

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
            } else if (x == 1 && y == 0 )
            {
                for (int i = x-1;i<=2;i++)
                {
                    if (layout[i,y] == layout[x,y])
                    {
                        countRow++;
                    }
                    if (layout[x,i] == layout[x,y])
                    {
                        countCol++;
                    }
                }
            } else if (x == 1 && y == 2)
            {
                for (int i = x - 1; i <= 2; i++)
                {
                    if (layout[i, y] == layout[x, y])
                    {
                        countRow++;
                    }
                }
                for (int i = 2; i >= 0;i--)
                {
                    if (layout[x, i] == layout[x, y])
                    {
                        countCol++;
                    }
                }
            } else if (x == 0 && y == 1)
            {
                for (int i = y - 1; i <= 2; i++)
                {
                    if (layout[i, y] == layout[x, y])
                    {
                        countRow++;
                    }
                    if (layout[x, i] == layout[x, y])
                    {
                        countCol++;
                    }
                }
            } else if ( x == 2 && y == 1)
            {
                for (int i = y - 1; i <= 2; i++)
                {
                    if (layout[i, y] == layout[x, y])
                    {
                        countRow++;
                    }
                }
                for (int i = 2; i >= 0; i--)
                {
                    if (layout[x, i] == layout[x, y])
                    {
                        countCol++;
                    }
                }
            } else if (x==1 && y ==1)
            {
                for (int i = 0; i <= 2; i++)
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

        void updateMethod(Button button, int x, int y) 
        {
            if (currentUserCheck)
            {
                button.Text = "〇";
                layout[x, y] = "〇";
            }
            else
            {
                button.Text = "X";
                layout[x, y] = "X";
            }
            button.Enabled = false;
            currentUserCheck = !currentUserCheck;
            result = checkGameResult(x, y);
            winnerMessage(result, layout[x, y]);
        }

        void winnerMessage(bool boolResult, string user)
        {
            if (boolResult)
            {
                MessageBox.Show($"{user}獲勝");
                currentUserCheck = true;
                result = false;
                Controls.Clear();
                InitializeComponent();
            }
        }
    }
}

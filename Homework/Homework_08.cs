using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Homework
{
    public partial class Homework_08_Frm : Form
    {
        public Homework_08_Frm()
        {
            InitializeComponent();
        }

        private void btn_checkOddEven_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            int numOddEven;
            bool isNum = checkIsNum(textB_number.Text, out numOddEven);
            if (isNum)
            {
                if ( (Math.Abs(numOddEven)) % 2 == 0)
                {
                    label_resultInput.Text = $"輸入的數 {numOddEven} 為偶數。";
                }
                else
                {
                    label_resultInput.Text = $"輸入的數 {numOddEven} 為奇數。";
                }
            }
            else
            {
                MessageBox.Show("請輸入數值","錯誤訊息",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            int numFrom, numTo, numStep;
            bool checkReturn = true;
            label_resultInput.Text = "結果";

            if (checkIsNum(textB_from.Text, out numFrom) && checkIsNum(textB_to.Text,out numTo) && checkIsNum(textB_step.Text,out numStep)) 
            {
                if (numFrom > numTo)
                {
                    MessageBox.Show("From數字需要大於To", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkReturn = false;
                }
                if (numStep < 1)
                {
                    MessageBox.Show("Stpe數字需要大於0", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkReturn = false;
                }
                if (checkReturn)
                {
                    int total = 0;
                    for (int i = numFrom; i <= numTo; i += numStep)
                    {
                        total += i;
                    }
                    label_resultInput.Text = $"{numFrom} 到 {numTo} 相隔 {numStep}\n加總為 {total}";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_while_Click(object sender, EventArgs e)
        {
            int numFrom, numTo, numStep;
            bool checkReturn = true;
            label_resultInput.Text = "結果";

            if (checkIsNum(textB_from.Text, out numFrom) && checkIsNum(textB_to.Text, out numTo) && checkIsNum(textB_step.Text, out numStep))
            {
                if (numFrom > numTo)
                {
                    MessageBox.Show("From數字需要大於To", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkReturn = false;
                }
                if (numStep < 1)
                {
                    MessageBox.Show("Stpe數字需要大於0", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkReturn = false;
                }
                if (checkReturn)
                {
                    int total = 0;
                    int i = numFrom;
                    while (i <= numTo)
                    {
                        total += i;
                        i += numStep;
                    }
                    label_resultInput.Text = $"{numFrom} 到 {numTo} 相隔 {numStep}\n加總為 {total}";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_do_Click(object sender, EventArgs e)
        {
            int numFrom, numTo, numStep;
            bool checkReturn = true;
            label_resultInput.Text = "結果";

            if (checkIsNum(textB_from.Text, out numFrom) && checkIsNum(textB_to.Text, out numTo) && checkIsNum(textB_step.Text, out numStep))
            {
                if (numFrom > numTo)
                {
                    MessageBox.Show("From數字需要大於To", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkReturn = false;
                }
                if (numStep < 1)
                {
                    MessageBox.Show("Stpe數字需要大於0", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkReturn = false;
                }
                if (checkReturn)
                {
                    int total = 0;
                    int i = numFrom;
                    do
                    {
                        total += i;
                        i += numStep;
                    } while (i <= numTo);
                    label_resultInput.Text = $"{numFrom} 到 {numTo} 相隔 {numStep}\n加總為 {total}";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            int rows;
            if (int.TryParse(textB_rows.Text, out rows))
            {
                if (rows < 0)
                {
                    MessageBox.Show("Rows數字需要大於0", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < rows;i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            result += "*";
                        }
                        result += "\n";
                    }
                    label_resultInput.Text = result;
                }
            }
            else
            {
                MessageBox.Show("請輸入數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_arrayMaxMin_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int maxNum=0;
            int minNum = 0;
            for (int i = 0;i < arr0711.Length;i++)
            {
                if (i == 0)
                {
                    maxNum = arr0711[i];
                    minNum = arr0711[i];
                }
                if (maxNum < arr0711[i])
                {
                    maxNum = arr0711[i];
                }
                if (minNum > arr0711[i])
                {
                    minNum = arr0711[i];
                }
            }
            result =$"int陣列arr0711[ {string.Join(", ",arr0711)} ]\n最大值為{maxNum}\n最小值為{minNum}";
            label_resultInput.Text = result;
        }

        private void btn_strArrayContainC_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            string[] arr0711_Str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int count = 0;
            for (int i = 0; i < arr0711_Str.Length;i++)
            {
                if (arr0711_Str[i].IndexOf("c") >= 0 || arr0711_Str[i].IndexOf("C") >= 0)
                {
                    count++;
                }
            }
            result = $"int陣列arr0711_Str: {string.Join(" ", arr0711_Str)} \n有C及c的名子共有{count}個";
            label_resultInput.Text = result;
        }

        private void btn_arrayOddEvenCount_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int countOdd = 0;
            int countEven = 0;
            for (int i = 0;i < arr0711.Length;i++)
            {
                if (arr0711[i] % 2 ==0)
                {
                    countEven++;
                } 
                else
                {
                    countOdd++;
                } 
            }
            result = $"int陣列arr0711[ {string.Join(", ", arr0711)} ]\n奇數共 {countOdd}\n偶數共 {countEven}";
            label_resultInput.Text = result;

        }

        public bool checkIsNum(string strNum, out int numOddEven)
        {
            bool isNum = int.TryParse(strNum, out numOddEven);
            return isNum;
        }

        private void btn_arrStrLongName_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            int strLength = 0;
            int indexOfMaxLength = 0;
            string[] arr0711_Str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            for (int i = 0; i < arr0711_Str.Length; i++)
            {
                if (i == 0)
                {
                    strLength = arr0711_Str[i].Length;
                }
                else
                {
                    if (strLength < arr0711_Str[i].Length)
                    {
                        strLength = arr0711_Str[i].Length;
                        indexOfMaxLength = i;
                    }
                }
            }
            result = $"int陣列arr0711_Str: {string.Join(" ", arr0711_Str)} \n最長的名子為{arr0711_Str[indexOfMaxLength]}";
            label_resultInput.Text = result;
        }

        private void btn_1AND0_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            for (int i = 0;i<10;i++)
            {
                for (int j = 0;j<10;j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j ==9)
                    {
                        result += " 1 ";
                    }
                    else
                    {
                        result += " 0 ";
                    }
                }
                result += "\n";
            }
            label_resultInput.Text = result;
        }

        private void btn_0And1_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                    {
                        result += " 0 ";
                    }
                    else
                    {
                        result += " 1 ";
                    }
                }
                result += "\n";
            }
            label_resultInput.Text = result;
        }

        private void btn_10And01_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            bool check0And1 = true;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (check0And1)
                    {
                        result += " 1 ";
                    }
                    else
                    {
                        result += " 0 ";
                    }
                    check0And1 = !check0And1;
                }
                check0And1 = !check0And1;
                result += "\n";
            }
            label_resultInput.Text = result;
        }

        private void btn_swap_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            int n1 = 100;
            int n2 = 200;
            result = $"換位前n1={n1}, n2={n2}\n";
            (n1, n2) = (n2, n1);
            result += $"換位前n1={n1}, n2={n2}\n";
            label_resultInput.Text = result;
        }

        private void btn_sumArr_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int total = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                total += arr0711[i];
            }
            result = $"int陣列arr0711[ {string.Join(", ", arr0711)} ]\n加總為 {total}";
            label_resultInput.Text = result;
        }

        private void btn_arrMax_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int maxNum = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (i == 0)
                {
                    maxNum = arr0711[i];
                }
                if (maxNum < arr0711[i])
                {
                    maxNum = arr0711[i];
                }
            }
            result = $"int陣列arr0711[ {string.Join(", ", arr0711)} ]\n最大值為{maxNum}";
            label_resultInput.Text = result;
        }

        private void btn_arrMin_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int minNum = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (i == 0)
                {
                    minNum = arr0711[i];
                }
                if (minNum > arr0711[i])
                {
                    minNum = arr0711[i];
                }
            }
            result = $"int陣列arr0711[ {string.Join(", ", arr0711)} ]\n最小值為{minNum}";
            label_resultInput.Text = result;
        }

        private void btn_100ToBinary_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "";
            string reverseResult = "";
            int num100 = 100;
            while (num100 > 0)
            {
                if (num100 % 2 == 1)
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
                if (num100 == 1)
                {
                    break;
                }
                num100 /= 2;
            }
            for (int i = result.Length - 1; i >= 0;i--)
            {
                reverseResult += result[i];
            }
            label_resultInput.Text = reverseResult;
        }

        private void btn_lotteryNumber_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "樂透號碼\n";
            int[] lotteryNum = new int[6];
            int randomNum;
            Random rand = new Random(); 
            int i = 0;
            while (i < 6)
            {
                randomNum = rand.Next(1,50);
                for (int j = 0;j<i; j++)
                {
                    if (randomNum == lotteryNum[j])
                    {
                        randomNum = 0;
                    }
                }
                if (randomNum != 0) 
                {
                    lotteryNum[i] = randomNum;
                    result += $"{lotteryNum[i]} ";
                    i++;
                }
            }
            label_resultInput.Text = result;
        }

        private void btn_multiplicationTable_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
            string result = "九九乘法表\n";

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    if (i*j < 10)
                    {
                        result += $" {j}x {i}=  {j * i}|";
                    }
                    else
                    {
                        result += $" {j}x {i}= {j * i}|";
                    }
                }
                result += "\n";
            }
            label_resultInput.Text = result;
        }

        private void btn_clearResult_Click(object sender, EventArgs e)
        {
            label_resultInput.Text = "結果";
        }
    }
}

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
    public partial class Homework_04_Frm : Form
    {
        // parameter definition
        string chName;
        int chScore;
        int enScore;
        int mathScore;
        string[] subjects = new string[3]{ "國文","英文","數學"};
        int[] scores;

        public Homework_04_Frm()
        {
            InitializeComponent();
            chName = textB_Name.Text;
            chScore = int.Parse(textB_CH_Score.Text);
            enScore = int.Parse(textB_EN_Score.Text);
            mathScore = int.Parse(textB_Math_Score.Text);
            scores = new int[3] {chScore, enScore, mathScore};
        }

        // save data
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if ( !(textB_Name.Text == ""))
            {
                chName = textB_Name.Text;
            }
            else
            {
                MessageBox.Show("姓名不可為空白。");
                return;
            }
            if (int.TryParse(textB_CH_Score.Text,out chScore) && int.TryParse(textB_EN_Score.Text, out enScore) && int.TryParse(textB_Math_Score.Text,out mathScore))
            {
                scores = new int[3] { chScore, enScore, mathScore };
            }
            else
            {
                MessageBox.Show("請填入正確成績，成績介於0~100。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chScore = 0;
                enScore = 0;
                mathScore = 0;
                textB_CH_Score.Text = 0.ToString();
                textB_EN_Score.Text = 0.ToString();
                textB_Math_Score.Text = 0.ToString();
                return;
            }

            if (chScore < 0 ||  chScore > 100 || enScore < 0 || enScore > 100 || mathScore < 0 || mathScore > 100 )
            {
                MessageBox.Show("請填入正確成績，成績介於0~100。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chScore = 0;
                enScore = 0;
                mathScore = 0;
                textB_CH_Score.Text = 0.ToString();
                textB_EN_Score.Text = 0.ToString();
                textB_Math_Score.Text = 0.ToString();
                return;
            }
        }

        // show data
        private void btn_Show_Save_Click(object sender, EventArgs e)
        {
            textB_Show_Score.Text = "";
            textB_Show_Score.Text += $"{label_Name.Text} {chName}\r\n";
            for (int i = 0; i < 3; i++)
            {
                textB_Show_Score.Text += $"{subjects[i]}： {scores[i]}\r\n";
            }
        }

        // show high and low score
        private void btn_HighLow_Score_Click(object sender, EventArgs e)
        {
            textB_Show_HighLow_Score.Text = "";
            int maxScore = 0;
            int minScore = 0;
            string maxScoreSubject = "";
            string minScoreSubject = "";

            for (int i = 0;i < subjects.Length;i++)
            {
                if (i == 0)
                {
                    maxScore = scores[i];
                    minScore = scores[i];
                    maxScoreSubject = $"{subjects[i]} ";
                    minScoreSubject = $"{subjects[i]} ";
                }
                else
                {
                    if (maxScore < scores[i])
                    {
                        maxScore = scores[i];
                        maxScoreSubject = $"{subjects[i]} ";
                    }
                    else if (maxScore == scores[i]) 
                    {
                        maxScoreSubject += $"{subjects[i]} ";
                    }
                    if (minScore > scores[i])
                    {
                        minScore = scores[i];
                        minScoreSubject = $"{subjects[i]} ";
                    }
                    else if (minScore == scores[i])
                    {
                        minScoreSubject += $"{subjects[i]} ";
                    }
                }
            }
            if (maxScore == minScore)
            {
                textB_Show_HighLow_Score.Text = $"各科成績相同：{chScore}";
            }
            else
            {
                textB_Show_HighLow_Score.Text += $"最高科目成績為：{maxScoreSubject}{maxScore}\r\n";
                textB_Show_HighLow_Score.Text += $"最低科目成績為：{minScoreSubject}{minScore}\r\n";
            }
        }
    }
}

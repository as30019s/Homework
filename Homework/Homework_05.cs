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
    public partial class Homework_05_Frm : Form
    {
        string chName;
        int chScore;
        int enScore;
        int mathScore;
        string[] subjects = new string[3] { "國文", "英文", "數學" };
        int[] scores;
        string result = "";
        int totalScore = 0;

        public Homework_05_Frm()
        {
            InitializeComponent();
        }


        private void btn_addData_Click(object sender, EventArgs e)
        {
            chName = textB_name.Text;
            if (int.TryParse(textB_chScore.Text, out chScore) && int.TryParse(textB_enScore.Text, out enScore) && int.TryParse(textB_mathScore.Text, out mathScore))
            {
                scores = new int[3] { chScore, enScore, mathScore };
                result += $"  {chName} ";
                totalScore = 0;
                for (int i = 0; i < 3; i++)
                {
                    result += $"{scores[i]}    ";
                    totalScore += scores[i];
                }
                result += $"{totalScore} {Math.Round(Convert.ToDouble(totalScore) / 3,1)} ";

                int maxScore = 0;
                int minScore = 0;
                string maxScoreSubject = "";
                string minScoreSubject = "";

                for (int i = 0; i < subjects.Length; i++)
                {
                    if (i == 0)
                    {
                        maxScore = scores[i];
                        minScore = scores[i];
                    }
                    else
                    {
                        if (maxScore < scores[i])
                        {
                            maxScore = scores[i];
                        }
                        if (minScore > scores[i])
                        {
                            minScore = scores[i];
                        }
                    }
                }
                if (maxScore == minScore)
                {
                    result += $"{chScore}\r\n";
                }
                else
                {
                    for (int i = 0; i < subjects.Length; i++)
                    {
                        if (maxScore == scores[i])
                        {
                            maxScoreSubject += $"{subjects[i]} ";
                        }
                        if (minScore == scores[i])
                        {
                            minScoreSubject += $"{subjects[i]} ";
                        }
                    }
                    result += $" {maxScoreSubject}{maxScore}    ";
                    result += $" {minScoreSubject}{minScore}\r\n";
                }

            }
            else
            {
                MessageBox.Show("請填入正確成績，成績介於0~100。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chScore = 0;
                enScore = 0;
                mathScore = 0;
                textB_chScore.Text = 0.ToString();
                textB_enScore.Text = 0.ToString();
                textB_mathScore.Text = 0.ToString();
            }

            if (chScore < 0 || chScore > 100 || enScore < 0 || enScore > 100 || mathScore < 0 || mathScore > 100)
            {
                MessageBox.Show("請填入正確成績，成績介於0~100。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chScore = 0;
                enScore = 0;
                mathScore = 0;
                textB_chScore.Text = 0.ToString();
                textB_enScore.Text = 0.ToString();
                textB_mathScore.Text = 0.ToString();
            }
            if (textB_result.Height < 200)
            {
                textB_result.Height += 20;
            }
            else
            {
            }
            textB_result.BorderStyle = BorderStyle.FixedSingle;
            textB_result.Text = result ;
        }


    }
}

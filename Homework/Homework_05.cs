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
using System.Xml.Linq;

namespace Homework
{
    public partial class Homework_05_Frm : Form
    {
        List<Students> lsStudent = new List<Students>();
        string[] subjects = new string[3] { "國文", "英文", "數學" };

        public Homework_05_Frm()
        {
            InitializeComponent();
        }


        private void btn_addData_Click(object sender, EventArgs e)
        {
            string chName;
            int chScore;
            int enScore;
            int mathScore;

            if (textB_chScore.Text == "")
            {
                MessageBox.Show("請輸入名子");
                return;
            }
            else
            {
                chName = textB_name.Text;
            }

            if (int.TryParse(textB_chScore.Text, out chScore) && int.TryParse(textB_enScore.Text, out enScore) && int.TryParse(textB_mathScore.Text, out mathScore))
            {
                if (chScore < 0 || chScore > 100 || enScore < 0 || enScore > 100 || mathScore < 0 || mathScore > 100)
                {
                    MessageBox.Show("請填入正確成績，成績介於0~100。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chScore = 0;
                    enScore = 0;
                    mathScore = 0;
                    textB_chScore.Text = 0.ToString();
                    textB_enScore.Text = 0.ToString();
                    textB_mathScore.Text = 0.ToString();
                    return;
                }
                else
                {
                    scoreMethod(chName, chScore,enScore,mathScore);
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
                return;
            }



        }
        private void btn_randomAddData_Click(object sender, EventArgs e)
        {

        }

        public void scoreMethod(string chName, int chScore, int enScore, int mathScore)
        {
            Students stu;
            string result = "";
            int totalScore = 0;

            stu.Name = chName;
            stu.ChScore = chScore;
            stu.EnScore = enScore;
            stu.MathScore = mathScore;
            lsStudent.Add(stu);

            foreach (Students S in lsStudent)
            {
                int[] scores = new int[3] { S.ChScore, S.EnScore, S.MathScore };
                result += $"{chName,-4} ";
                totalScore = 0;
                for (int i = 0; i < 3; i++)
                {
                    result += $"{scores[i],8}";
                    totalScore += scores[i];
                }
                result += $"{totalScore,8} {Math.Round(Convert.ToDouble(totalScore) / 3, 1),7} ";

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
                    result += $"各科成績相同：{S.ChScore,2}\r\n";
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
                    result += $" {minScoreSubject,4}{minScore}    ";
                    result += $" {maxScoreSubject}{maxScore}\r\n";
                }

            }
            if (textB_result.Height < 200)
            {
                textB_result.Height += 20;
            }
            else
            {
            }
            textB_result.BorderStyle = BorderStyle.FixedSingle;
            textB_result.Text = result;
        }
    }
}

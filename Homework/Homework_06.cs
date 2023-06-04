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
    public partial class Homework_06_Frm : Form
    {
        List<Students> lsStudent = new List<Students>();
        string[] subjects = new string[3] { "國文", "英文", "數學" };
        bool addButtonClick = true;

        public Homework_06_Frm()
        {
            InitializeComponent();
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            addButtonClick = true;
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
                    scoreStruct(chName, chScore, enScore, mathScore);
                    scoreMethod();
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

        private void btn_insertData_Click(object sender, EventArgs e)
        {
            addButtonClick = false;
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
                    scoreStruct(chName, chScore, enScore, mathScore);
                    scoreMethod();
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
            addButtonClick = true;
            Random rand = new Random();
            string chName = (lsStudent.Count() + 1).ToString();
            int chScore = rand.Next(0, 101);
            int enScore = rand.Next(0, 101);
            int mathScore = rand.Next(0, 101);
            scoreStruct(chName, chScore, enScore, mathScore);
            scoreMethod();
        }

        private void btn_randomAddData20_Click(object sender, EventArgs e)
        {
            addButtonClick = true;
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                string chName = (lsStudent.Count() + 1).ToString();
                int chScore = rand.Next(0, 101);
                int enScore = rand.Next(0, 101);
                int mathScore = rand.Next(0, 101);
                scoreStruct(chName, chScore, enScore, mathScore);
                scoreMethod();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            lsStudent.RemoveAt(0);
            scoreMethod();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            textB_Summary.Text = "";
            label_result.Text = "";
            label_result.Height = 0;
            label_result.BorderStyle = BorderStyle.None;
            lsStudent.Clear();
            btn_statistic.Enabled = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int highScore, lowScore;
            if (int.TryParse(textB_highScore.Text,out highScore) && int.TryParse(textB_lowScore.Text,out lowScore)) 
            {
                if (highScore < lowScore)
                {
                    MessageBox.Show("請參考預設格式填寫分數區間。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textB_highScore.Text = "100";
                    textB_lowScore.Text = "0";
                    return;
                } else if (highScore < 0 || highScore >100 || lowScore < 0 || lowScore > 100)
                {
                    MessageBox.Show("請填入正確成績，成績介於0~100。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textB_highScore.Text = "100";
                    textB_lowScore.Text = "0";
                    return;
                }
                else
                {
                    scoreSearch(highScore, lowScore);
                }

            }
            else
            {
                MessageBox.Show("請填入正確成績，成績介於0~100。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textB_highScore.Text = "100";
                textB_lowScore.Text = "0";
                return;
            }
        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            string result = "";

            int totalChScore = lsStudent.Sum(x => x.ChScore);
            int totalEnScore = lsStudent.Sum(x => x.EnScore);
            int totalMathScore = lsStudent.Sum(x => x.MathScore);
            int maxChScore = lsStudent.Max(x => x.ChScore);
            int maxEnScore = lsStudent.Max(x => x.EnScore);
            int maxMathScore = lsStudent.Max(x => x.MathScore);
            int minChScore = lsStudent.Min(x => x.ChScore);
            int minEnScore = lsStudent.Min(x => x.EnScore);
            int minMathScore = lsStudent.Min((x) => x.MathScore);

            result += $"總分{totalChScore,12}{totalEnScore,8}{totalMathScore,8}\r\n" +
                $"平均{totalChScore / lsStudent.Count,12}{totalEnScore / lsStudent.Count,8}{totalMathScore / lsStudent.Count,8}\r\n" +
                $"最高分{maxChScore,10}{maxEnScore,8}{maxMathScore,8}\r\n" +
                $"最低分{minChScore,10}{minEnScore,8}{minMathScore,8}";

            textB_Summary.Text = result;
        }

        public void scoreStruct(string chName, int chScore, int enScore, int mathScore)
        {
            Students stu;

            stu.Name = chName;
            stu.ChScore = chScore;
            stu.EnScore = enScore;
            stu.MathScore = mathScore;
            
            if (addButtonClick)
            {
                lsStudent.Add(stu);
            } 
            else
            {
                lsStudent.Insert(0, stu);
            }
        }

        public void scoreMethod()
        {
            string result = "";
            int totalScore = 0;

            foreach (Students S in lsStudent)
            {
                int[] scores = new int[3] { S.ChScore, S.EnScore, S.MathScore };
                result += $"{S.Name,-6} ";
                totalScore = 0;
                for (int i = 0; i < 3; i++)
                {
                    result += $"{scores[i],8}";
                    totalScore += scores[i];
                }
                result += $"{totalScore,8} {Math.Round(Convert.ToDouble(totalScore) / 3, 1),8} ";

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
                    result += $"      各科成績相同：{S.ChScore}\r\n";
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
                    result += $" {minScoreSubject,6}{minScore}    ";
                    result += $" {maxScoreSubject}{maxScore}\r\n";
                }
            }
            label_result.Text = result;
            label_result.BorderStyle = BorderStyle.FixedSingle;

            if (lsStudent.Count > 0)
            {
                btn_statistic.Enabled = true;
                btn_search.Enabled = true;
            }
            else
            {
                btn_statistic.Enabled = false;
                btn_search.Enabled = false;
            }
            textB_Summary.Text = "";
        }

        public void scoreSearch(int highScore, int lowScore)
        {
            string result = "";
            int totalScore = 0;

            foreach (Students S in lsStudent)
            {
                if (S.ChScore >= lowScore && S.ChScore <= highScore)
                {
                    int[] scores = new int[3] { S.ChScore, S.EnScore, S.MathScore };
                    result += $"{S.Name,-6} ";
                    totalScore = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        result += $"{scores[i],8}";
                        totalScore += scores[i];
                    }
                    result += $"{totalScore,8} {Math.Round(Convert.ToDouble(totalScore) / 3, 1),8} ";

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
                        result += $"      各科成績相同：{S.ChScore}\r\n";
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
                        result += $" {minScoreSubject,6}{minScore}    ";
                        result += $" {maxScoreSubject}{maxScore}\r\n";
                    }
                }
                
            }
            label_result.Text = result;
            label_result.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}

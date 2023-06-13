using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homework
{
    public partial class Homework_14_02_Frm : Form
    {
        // parameter definition
        Random rand = new Random();
        public int answer;
        public string input = "";
        public bool checkResult = true;
        public int max = 100;
        public int min = 1;

        public int guessNumber;
        public bool isNum;

        public Homework_14_02_Frm()
        {
            InitializeComponent();
            answer = rand.Next(1, 101);
        }


        private void btn_guess_Click(object sender, EventArgs e)
        {
            ShowInputDialogBox(input,answer);
        }

        private void btn_showAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"數字是{answer}");
        }

        private void ShowInputDialogBox(string input, int answer)
        {
            //Specify the size of the window using the parameters passed
            Size size = new Size(400, 150);
            //Create a new form
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            //Set the window title using the parameter passed
            inputBox.Text = "Guess";
            inputBox.StartPosition = FormStartPosition.CenterScreen;


            //Create a new label to hold the prompt
            Label label = new Label();
            label.Text = "Please input a number.";
            label.Location = new Point(10, 50);
            label.Font = new Font("Arial",18);
            label.Width = 270;
            label.Height = 27;
            inputBox.Controls.Add(label);

            //Create a textbox to accept the user's input
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Size = new Size(size.Width - 20, 23);
            textBox.Location = new Point(10, 117);
            textBox.Text = input;
            textBox.TextChanged += TextBox_TextChanged;
            inputBox.Controls.Add(textBox);

            //Create an OK Button 
            System.Windows.Forms.Button okButton = new System.Windows.Forms.Button();
            okButton.Name = "okButton";
            okButton.Font = new Font("Arial", 18);
            okButton.Size = new Size(100, 35);
            okButton.Text = "&Enter";
            okButton.Location = new Point(285, 30);
            okButton.Click += OkButton_Click;
            inputBox.Controls.Add(okButton);

            //Create a Cancel Button
            System.Windows.Forms.Button cancelButton = new System.Windows.Forms.Button();
            cancelButton.Name = "cancelButton";
            cancelButton.Font = new Font("Arial", 18);
            cancelButton.Size = new Size(100, 35);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(285, 70);
            cancelButton.Click += CancelButton_Click;
            inputBox.Controls.Add(cancelButton);

            inputBox.Show();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            button.Parent.Hide();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox t = (System.Windows.Forms.TextBox)sender;
            input = t.Text;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            isNum = int.TryParse(input, out guessNumber);
            if (isNum)
            {
                if (guessNumber < min || guessNumber > max)
                {
                    MessageBox.Show($"請輸入{min}到{max}之間的整數!!!");
                }
                else if (guessNumber == answer)
                {
                    checkResult = !checkResult;
                    MessageBox.Show($"Congradulations!!! You got {answer}!!!");
                    label_title.Text = "Please Select A Number Between 1 to 100!";
                    answer = rand.Next(1, 101);
                    max = 100;
                    min = 1;
    }
                else if (guessNumber < answer)
                {
                    min = guessNumber;
                    label_title.Text = $"Too Small!!!\nBetween {min} and {max}";
                }
                else
                {
                    max = guessNumber;
                    label_title.Text = $"Too Small!!!\nBetween {min} and {max}";
                }
            }
            else
            {
                MessageBox.Show($"請輸入{min}到{max}之間的整數!!!");
            }

        }
    }
}

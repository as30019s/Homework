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
    public partial class Homework_14_Frm : Form
    {
        Random rand = new Random();
        int answer;
        int max = 100, min = 1;
        bool checkResult = true;
        
        public Homework_14_Frm()
        {
            InitializeComponent();
            answer = rand.Next(1, 101);
        }


        private void btn_guess_Click(object sender, EventArgs e)
        {
            int guessNumber;
            bool isNum;
            string input = "";
            while (checkResult)
            {
                ShowInputDialogBox(ref input, "Please input a number.", "Guess");
                isNum = int.TryParse(input, out guessNumber);
                if (isNum)
                {
                    if (guessNumber < min ||  guessNumber > max)
                    {
                        MessageBox.Show($"請輸入{min}到{max}之間的整數!!!");
                    }
                    if (guessNumber == answer)
                    {
                        checkResult = !checkResult;
                        MessageBox.Show($"Congradulations!!! You got {answer}!!!");
                    } else if (guessNumber < answer)
                    {
                        min = guessNumber;
                        label_title.Text = $"Too Small!!!\nBetween {min} and {max}";
                    } else
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


        private static DialogResult ShowInputDialogBox(ref string input, string prompt, string title = "Title", int width = 400, int height = 150)
        {
            //This function creates the custom input dialog box by individually creating the different window elements and adding them to the dialog box

            //Specify the size of the window using the parameters passed
            Size size = new Size(width, height);
            //Create a new form using a System.Windows Form
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            //Set the window title using the parameter passed
            inputBox.Text = title;
            inputBox.Location = new Point(500, 500);

            //Create a new label to hold the prompt
            Label label = new Label();
            label.Text = prompt;
            label.Location = new Point(10, 50);
            label.Font = new Font("Arial",18);
            label.Width = 270;
            label.Height = 27;
            inputBox.Controls.Add(label);

            //Create a textbox to accept the user's input
            TextBox textBox = new TextBox();
            textBox.Size = new Size(size.Width - 20, 23);
            textBox.Location = new Point(10, 117);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            //Create an OK Button 
            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Font = new Font("Arial", 18);
            okButton.Size = new Size(100, 35);
            okButton.Text = "&Enter";
            okButton.Location = new Point(285, 30);
            inputBox.Controls.Add(okButton);

            //Create a Cancel Button
            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Font = new Font("Arial", 18);
            cancelButton.Size = new Size(100, 35);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(285, 70);
            inputBox.Controls.Add(cancelButton);




            //Set the input box's buttons to the created OK and Cancel Buttons respectively so the window appropriately behaves with the button clicks
            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            //Show the window dialog box 
            DialogResult result = inputBox.ShowDialog();
            inputBox.Update();
            input = textBox.Text;


            //After input has been submitted, return the input value
            return result;
        }


    }
}

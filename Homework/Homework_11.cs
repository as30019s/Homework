using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Homework_11_Frm : Form
    {
        // Dialogs
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;

        public Homework_11_Frm()
        {
            InitializeComponent();
            TSSLabel_time.Text = DateTime.Now.ToString();
        }
        string filePath = string.Empty;

        private void timer_statusTime_Tick(object sender, EventArgs e)
        {
            TSSLabel_time.Text = DateTime.Now.ToString();
        }

        private void 新增NCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }


        private void 開啟OCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileAs();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitFile();
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox_input.Font = fontDialog.Font;
                }
            }
            catch (Exception ex)
            {

            }
            finally 
            {
                
            }
        }

        // Create a new file
        private void newFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox_input.Text))
                {
                    MessageBox.Show("Need to save first!");
                }
                else
                {
                    this.richTextBox_input.Text = string.Empty;
                    this.Text = "Untitled";
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        // Open file
        private void openFile()
        {
            try
            {
                openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox_input.Text = File.ReadAllText(openFileDialog.FileName);
                    this.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while trying to open file!");
            }
            finally 
            {
                openFileDialog = null;
            }
        }

        // Save file
        private void saveFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox_input.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text File (*.txt) | *.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, this.richTextBox_input.Text);
                        this.Text = saveFileDialog.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("The file is empty!");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        // Save as file
        private void saveFileAs()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox_input.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text File (*.txt) | *.txt All Files (*.*)| *.* ";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, this.richTextBox_input.Text);
                        this.Text = saveFileDialog.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("The file is empty!");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        // Exit
        private void exitFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox_input.Text))
                {
                    saveFile();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void Homework_11_Frm_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
        }
    }
}

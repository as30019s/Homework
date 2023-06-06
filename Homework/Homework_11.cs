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
        private ColorDialog colorDialog;

        bool saveStatus;
        string currentFileName = string.Empty;

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
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                
            }
        }


        private void Homework_11_Frm_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
        }

        private void richTextBox_input_TextChanged(object sender, EventArgs e)
        {
            saveStatus = false;
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_input.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_input.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_input.Paste();
        }

        private void 全選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_input.SelectAll();
        }

        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_input.Undo();
        }

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_input.Redo();
        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox_input.ForeColor = colorDialog.Color;
            }
        }

        private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_input.Text = richTextBox_input.Text.ToUpper();
        }

        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_input.Text = richTextBox_input.Text.ToLower();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_input.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_input.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_input.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_input.ForeColor = Color.Black;
        }
        // Create a new file
        private void newFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox_input.Text) && !saveStatus)
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
                MessageBox.Show(ex.Message);
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
                    saveStatus = true;
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
                    if (this.Text != "Untitled")
                    {
                        if (saveStatus)
                        {
                            return;
                        }
                        else
                        {
                            File.WriteAllText(this.Text, this.richTextBox_input.Text);
                        }
                    }
                    else
                    {
                        saveFileAs();
                    }
                }
                else
                {
                    MessageBox.Show("The file is empty!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                saveStatus = true;
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
                    saveFileDialog.Filter = "Text File (*.txt) | *.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, this.richTextBox_input.Text);
                        this.Text = saveFileDialog.FileName;
                        saveStatus = true;
                    }
                }
                else
                {
                    MessageBox.Show("The file is empty!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    if (this.Text != "Untitled")
                    {
                        if (saveStatus)
                        {
                            this.Close();
                        }
                        else
                        {
                            saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = "Text File (*.txt) | *.txt";
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                File.WriteAllText(this.Text, this.richTextBox_input.Text);
                            }
                            this.Close();
                        }
                    }
                    else
                    {
                        saveFileAs();
                    }
                }
                else
                {
                    this.Close();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void 列印PCtrlPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void 預覽列印VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog.Close();
            }
        }
    }
}

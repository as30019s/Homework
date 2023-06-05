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
            textB_input.Enabled = true;
        }

        private void 開啟OCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                Stream fs = openFileDialog.OpenFile();

                StreamReader sr = new StreamReader(fs);
                textB_input.Text = sr.ReadToEnd();
                buttonEnable(true);
            }
        }

        public void buttonEnable(bool openClose)
        {
            textB_input.Enabled = openClose;
            儲存SToolStripMenuItem.Enabled = openClose;
            另存新檔AToolStripMenuItem.Enabled = openClose;
            列印PCtrlPToolStripMenuItem1.Enabled = openClose;
            預覽列印VToolStripMenuItem.Enabled = openClose;
            復原UToolStripMenuItem.Enabled = openClose;
            取消復原RToolStripMenuItem.Enabled = openClose;
            剪下TToolStripMenuItem.Enabled = openClose;
            複製CToolStripMenuItem.Enabled = openClose;
            貼上PToolStripMenuItem.Enabled = openClose;
            全選ToolStripMenuItem.Enabled = openClose;
            顏色CToolStripMenuItem.Enabled = openClose;
            字型VToolStripMenuItem.Enabled = openClose;
            toUpperUToolStripMenuItem.Enabled = openClose;
            toLowerLToolStripMenuItem.Enabled = openClose;
            自動換行ToolStripMenuItem.Enabled = openClose;
            索引IToolStripMenuItem.Enabled = openClose;
            搜尋SToolStripMenuItem.Enabled = openClose;
        }
    }
}

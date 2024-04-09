using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFile.FileName;
                string[] lines = File.ReadAllLines(filePath);
                string fileContent = string.Join(Environment.NewLine, lines);
                txtFileContent.Text = fileContent;
                ShowFileName(openFile.SafeFileName);
                ShowSize(new FileInfo(filePath).Length);
                ShowURL(filePath);
                ShowLineCount(lines);
                ShowWordsCount(lines);
                ShowCharacterCount(fileContent);
            }
        }

        void ShowFileName(string filename)
        {
            txtFileName.Text = filename;
        }

        void ShowSize(long size)
        {
            txtSize.Text = size.ToString("#,0") + " bytes";
        }

        void ShowURL(string url)
        {
            txtURL.Text = url;
        }

        void ShowLineCount(string[] lines)
        {
            txtLineCount.Text = lines.Length.ToString();
        }

        void ShowWordsCount(string[] lines)
        {
            int wordCount = lines.Sum(line => line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length);
            txtWordsCount.Text = wordCount.ToString();
        }

        void ShowCharacterCount(string content)
        {
            txtCharCount.Text = content.Length.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

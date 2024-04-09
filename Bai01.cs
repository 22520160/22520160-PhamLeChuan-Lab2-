using System;
using System.IO;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("input1.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    xuat.Text = reader.ReadToEnd();
                }
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("output1.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    string output = xuat.Text.ToUpper();
                    writer.WriteLine(output);
                }
            }
        }

        private void xuat_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

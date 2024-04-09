using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json; 
using System.Windows.Forms;

namespace Lab02
{

    public partial class Bai04 : Form
    {
        private ListView listView;
        public Bai04()
        {
            InitializeComponent();

        }

        List<Student> students = new List<Student>();
        List<int> pagenumbers = new List<int>();
        private void btnRead_Click(object sender, EventArgs e)
        {
            Serialized();
            Deserialized();
            Setup();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int currentpagenumber = Convert.ToInt32(lbPageNumber.Text);
            if (currentpagenumber == 1)
            {
                ShowObject(pagenumbers.Count - 1);
            }
            else
            {
                ShowObject(currentpagenumber - 2);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentpagenumber = Convert.ToInt32(lbPageNumber.Text);
            if (currentpagenumber == pagenumbers.Count)
            {
                ShowObject(0);
            }
            else
            {
                ShowObject(currentpagenumber);
            }
        }
        private void doc_Click(object sender, EventArgs e)
        {
            ShowObject(0);
        }
        private void button1_Click(object sender, EventArgs e) //Write_click
        {
            FileStream fsout = new FileStream("output4.txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fsout);
            writer.Write(txtFileContent.Text);
            writer.Close();
            fsout.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckProperty() == true)
            {
                Student student = new Student();
                student.Name = txtWriteName.Text;
                student.ID = Convert.ToInt32(txtWriteID.Text);
                student.PhoneNumber = txtWritePhone.Text;
                student.Course1 = Convert.ToSingle(txtWriteCourse1.Text);
                student.Course2 = Convert.ToSingle(txtWriteCourse2.Text);
                student.Course3 = Convert.ToSingle(txtWriteCourse3.Text);
                student.Average = (student.Course1 + student.Course2 + student.Course3) / 3;
                student.Average = (float)Math.Round(student.Average, 2);
                txtFileContent.Text += student.Name + "\r\n"
                                  + student.ID + "\r\n"
                                  + student.PhoneNumber + "\r\n"
                                  + student.Course1 + "\r\n"
                                  + student.Course2 + "\r\n"
                                  + student.Course3 + "\r\n"
                                  + student.Average + "\r\n"
                                  + "\r\n";
                students.Add(student);
                pagenumbers.Add(pagenumbers.Count + 1);
                button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Invalid Input.", "Notice");
                txtWriteName.Text = "";
                txtWriteID.Text = "";
                txtWritePhone.Text = "";
                txtWriteCourse1.Text = "";
                txtWriteCourse2.Text = "";
                txtWriteCourse3.Text = "";
            }

        }
        void Setup()
        {
            for (int index = 0; index < students.Count; index++)
            {
                pagenumbers.Add(index + 1);
                txtFileContent.Text += students[index].Name + "\r\n"
                              + students[index].ID + "\r\n"
                              + students[index].PhoneNumber + "\r\n"
                              + students[index].Course1 + "\r\n"
                              + students[index].Course2 + "\r\n"
                              + students[index].Course3 + "\r\n"
                              + students[index].Average + "\r\n"
                              + "\r\n";
            }
            ShowObject(0);
        }
        void ShowObject(int pagenumber)
        {
            txtReadName.Text = students[pagenumber].Name;
            txtReadID.Text = Convert.ToString(students[pagenumber].ID);
            txtReadPhone.Text = students[pagenumber].PhoneNumber;
            txtReadCourse1.Text = Convert.ToString(students[pagenumber].Course1);
            txtReadCourse2.Text = Convert.ToString(students[pagenumber].Course2);
            txtReadCourse3.Text = Convert.ToString(students[pagenumber].Course3);
            txtAverage.Text = Convert.ToString(students[pagenumber].Average);
            lbPageNumber.Text = Convert.ToString(pagenumbers[pagenumber]);
        }
        bool CheckProperty()
        {
            if (txtWriteID.Text.Length != 8 || !int.TryParse(txtWriteID.Text, out int id) || id < 0)
            {
                return false;
            }
            else if ((Convert.ToSingle(txtWriteCourse1.Text) < 0) || (Convert.ToSingle(txtWriteCourse1.Text) > 10))
            {
                return false;
            }
            else if ((Convert.ToSingle(txtWriteCourse2.Text) < 0) || (Convert.ToSingle(txtWriteCourse2.Text) > 10))
            {
                return false;
            }
            else if ((Convert.ToSingle(txtWriteCourse3.Text) < 0) || (Convert.ToSingle(txtWriteCourse3.Text) > 10))
            {
                return false;
            }
            else if (txtWritePhone.Text.Length != 10 || !txtWritePhone.Text.StartsWith("0"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        void Serialized()
        {
            FileStream fsinput = new FileStream("input4.txt", FileMode.Open, FileAccess.Read);
            FileStream fsmid = new FileStream("midput4.txt", FileMode.Open, FileAccess.Write);
            StreamReader reader = new StreamReader(fsinput);
            Student student = new Student();
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            while (reader.Peek() != -1)
            {
                student.Name = reader.ReadLine();
                student.ID = Convert.ToInt32(reader.ReadLine());
                student.PhoneNumber = reader.ReadLine();
                student.Course1 = Convert.ToSingle(reader.ReadLine());
                student.Course2 = Convert.ToSingle(reader.ReadLine());
                student.Course3 = Convert.ToSingle(reader.ReadLine());
                student.Average = (student.Course1 + student.Course2 + student.Course3) / 3;
                student.Average = (float)Math.Round(student.Average, 2);
                string jsonString = JsonSerializer.Serialize(student, options);
                byte[] jsonUtf8Bytes = Encoding.UTF8.GetBytes(jsonString);
                fsmid.Write(jsonUtf8Bytes, 0, jsonUtf8Bytes.Length);
            }
            reader.Close();
            fsinput.Close();
            fsmid.Close();
        }
        void Deserialized()
        {
            FileStream fsmid = new FileStream("midput4.txt", FileMode.OpenOrCreate, FileAccess.Read);
            Student student = new Student();
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            while (fsmid.Position < fsmid.Length)
            {
                byte[] jsonUtf8Bytes = new byte[fsmid.Length - fsmid.Position];
                fsmid.Read(jsonUtf8Bytes, 0, jsonUtf8Bytes.Length);
                string jsonString = Encoding.UTF8.GetString(jsonUtf8Bytes);
                student = JsonSerializer.Deserialize<Student>(jsonString, options);
                students.Add(student);
            }
            fsmid.Close();
        }
        [Serializable]
        class Student
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string PhoneNumber { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public float Average { get; set; }
        }
    }
}


namespace Lab02
{
    partial class Bai04
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnWrite = new Button();
            btnRead = new Button();
            btnNext = new Button();
            btnBack = new Button();
            btnAdd = new Button();
            txtWriteName = new TextBox();
            txtWritePhone = new TextBox();
            txtWriteID = new TextBox();
            txtWriteCourse2 = new TextBox();
            txtWriteCourse1 = new TextBox();
            txtReadName = new TextBox();
            txtWriteAverage = new TextBox();
            txtWriteCourse3 = new TextBox();
            txtReadID = new TextBox();
            txtReadPhone = new TextBox();
            txtReadCourse1 = new TextBox();
            txtReadCourse2 = new TextBox();
            txtReadCourse3 = new TextBox();
            txtAverage = new TextBox();
            txtFileContent = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            lbPageNumber = new Label();
            SuspendLayout();
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(30, 11);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(173, 29);
            btnWrite.TabIndex = 0;
            btnWrite.Text = "Write to a File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += button1_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(529, 12);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(241, 29);
            btnRead.TabIndex = 1;
            btnRead.Text = "Button to Read a File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += doc_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(704, 424);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(529, 424);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(109, 424);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtWriteName
            // 
            txtWriteName.Location = new Point(78, 60);
            txtWriteName.Name = "txtWriteName";
            txtWriteName.Size = new Size(125, 27);
            txtWriteName.TabIndex = 5;
            // 
            // txtWritePhone
            // 
            txtWritePhone.Location = new Point(78, 161);
            txtWritePhone.Name = "txtWritePhone";
            txtWritePhone.Size = new Size(125, 27);
            txtWritePhone.TabIndex = 6;
            // 
            // txtWriteID
            // 
            txtWriteID.Location = new Point(78, 109);
            txtWriteID.Name = "txtWriteID";
            txtWriteID.Size = new Size(125, 27);
            txtWriteID.TabIndex = 7;
            // 
            // txtWriteCourse2
            // 
            txtWriteCourse2.Location = new Point(78, 260);
            txtWriteCourse2.Name = "txtWriteCourse2";
            txtWriteCourse2.Size = new Size(125, 27);
            txtWriteCourse2.TabIndex = 8;
            // 
            // txtWriteCourse1
            // 
            txtWriteCourse1.Location = new Point(78, 214);
            txtWriteCourse1.Name = "txtWriteCourse1";
            txtWriteCourse1.Size = new Size(125, 27);
            txtWriteCourse1.TabIndex = 9;
            // 
            // txtReadName
            // 
            txtReadName.Location = new Point(529, 60);
            txtReadName.Name = "txtReadName";
            txtReadName.ReadOnly = true;
            txtReadName.Size = new Size(125, 27);
            txtReadName.TabIndex = 10;
            // 
            // txtWriteAverage
            // 
            txtWriteAverage.Location = new Point(78, 360);
            txtWriteAverage.Name = "txtWriteAverage";
            txtWriteAverage.ReadOnly = true;
            txtWriteAverage.Size = new Size(125, 27);
            txtWriteAverage.TabIndex = 11;
            // 
            // txtWriteCourse3
            // 
            txtWriteCourse3.Location = new Point(78, 308);
            txtWriteCourse3.Name = "txtWriteCourse3";
            txtWriteCourse3.Size = new Size(125, 27);
            txtWriteCourse3.TabIndex = 12;
            // 
            // txtReadID
            // 
            txtReadID.Location = new Point(529, 109);
            txtReadID.Name = "txtReadID";
            txtReadID.ReadOnly = true;
            txtReadID.Size = new Size(125, 27);
            txtReadID.TabIndex = 13;
            // 
            // txtReadPhone
            // 
            txtReadPhone.Location = new Point(529, 161);
            txtReadPhone.Name = "txtReadPhone";
            txtReadPhone.ReadOnly = true;
            txtReadPhone.Size = new Size(125, 27);
            txtReadPhone.TabIndex = 14;
            // 
            // txtReadCourse1
            // 
            txtReadCourse1.Location = new Point(529, 214);
            txtReadCourse1.Name = "txtReadCourse1";
            txtReadCourse1.ReadOnly = true;
            txtReadCourse1.Size = new Size(125, 27);
            txtReadCourse1.TabIndex = 15;
            // 
            // txtReadCourse2
            // 
            txtReadCourse2.Location = new Point(529, 260);
            txtReadCourse2.Name = "txtReadCourse2";
            txtReadCourse2.ReadOnly = true;
            txtReadCourse2.Size = new Size(125, 27);
            txtReadCourse2.TabIndex = 16;
            // 
            // txtReadCourse3
            // 
            txtReadCourse3.Location = new Point(529, 308);
            txtReadCourse3.Name = "txtReadCourse3";
            txtReadCourse3.ReadOnly = true;
            txtReadCourse3.Size = new Size(125, 27);
            txtReadCourse3.TabIndex = 18;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(529, 360);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(125, 27);
            txtAverage.TabIndex = 19;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(224, 12);
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(282, 441);
            txtFileContent.TabIndex = 20;
            txtFileContent.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 63);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 21;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 311);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 22;
            label2.Text = "Course 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 263);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 23;
            label3.Text = "Course 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 217);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 24;
            label4.Text = "Course 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 164);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 25;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 112);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 26;
            label6.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 363);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 27;
            label7.Text = "Average";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(660, 63);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 28;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(660, 112);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 29;
            label9.Text = "ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(660, 164);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 30;
            label10.Text = "Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(660, 217);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 31;
            label11.Text = "Course 1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(660, 263);
            label12.Name = "label12";
            label12.Size = new Size(66, 20);
            label12.TabIndex = 32;
            label12.Text = "Course 2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(660, 311);
            label13.Name = "label13";
            label13.Size = new Size(66, 20);
            label13.TabIndex = 33;
            label13.Text = "Course 3";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(662, 363);
            label14.Name = "label14";
            label14.Size = new Size(64, 20);
            label14.TabIndex = 34;
            label14.Text = "Average";
            // 
            // lbPageNumber
            // 
            lbPageNumber.Location = new Point(644, 424);
            lbPageNumber.Name = "lbPageNumber";
            lbPageNumber.Size = new Size(40, 29);
            lbPageNumber.TabIndex = 35;
            lbPageNumber.Text = "1";
            // 
            // Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(lbPageNumber);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFileContent);
            Controls.Add(txtAverage);
            Controls.Add(txtReadCourse3);
            Controls.Add(txtReadCourse2);
            Controls.Add(txtReadCourse1);
            Controls.Add(txtReadPhone);
            Controls.Add(txtReadID);
            Controls.Add(txtWriteCourse3);
            Controls.Add(txtWriteAverage);
            Controls.Add(txtReadName);
            Controls.Add(txtWriteCourse1);
            Controls.Add(txtWriteCourse2);
            Controls.Add(txtWriteID);
            Controls.Add(txtWritePhone);
            Controls.Add(txtWriteName);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Name = "Bai04";
            Text = "Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWrite;
        private Button btnRead;
        private Button btnNext;
        private Button btnBack;
        private Button btnAdd;
        private TextBox txtWriteName;
        private TextBox txtWritePhone;
        private TextBox txtWriteID;
        private TextBox txtWriteCourse2;
        private TextBox txtWriteCourse1;
        private TextBox txtReadName;
        private TextBox txtWriteAverage;
        private TextBox txtWriteCourse3;
        private TextBox txtReadID;
        private TextBox txtReadPhone;
        private TextBox txtReadCourse1;
        private TextBox txtReadCourse2;
        private TextBox txtReadCourse3;
        private TextBox txtAverage;
        private RichTextBox txtFileContent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lbPageNumber;
    }
}
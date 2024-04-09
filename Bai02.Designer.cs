namespace Lab02
{
    partial class Bai02
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRead = new Button();
            btnExit = new Button();
            txtFileContent = new RichTextBox();
            txtFileName = new TextBox();
            txtSize = new TextBox();
            txtURL = new TextBox();
            txtLineCount = new TextBox();
            txtWordsCount = new TextBox();
            txtCharCount = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 83);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 147);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 203);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 2;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 257);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Line Count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 313);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 4;
            label5.Text = "Words Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 364);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 5;
            label6.Text = "Character Count";
            // 
            // btnRead
            // 
            btnRead.Location = new Point(12, 12);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(297, 29);
            btnRead.TabIndex = 6;
            btnRead.Text = "Read from File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 409);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(297, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(315, 13);
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(463, 425);
            txtFileContent.TabIndex = 8;
            txtFileContent.Text = "";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(130, 80);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(179, 27);
            txtFileName.TabIndex = 9;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(130, 144);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(179, 27);
            txtSize.TabIndex = 10;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(54, 200);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(255, 27);
            txtURL.TabIndex = 11;
            // 
            // txtLineCount
            // 
            txtLineCount.Location = new Point(130, 254);
            txtLineCount.Name = "txtLineCount";
            txtLineCount.Size = new Size(179, 27);
            txtLineCount.TabIndex = 12;
            // 
            // txtWordsCount
            // 
            txtWordsCount.Location = new Point(130, 310);
            txtWordsCount.Name = "txtWordsCount";
            txtWordsCount.Size = new Size(179, 27);
            txtWordsCount.TabIndex = 13;
            // 
            // txtCharCount
            // 
            txtCharCount.Location = new Point(130, 364);
            txtCharCount.Name = "txtCharCount";
            txtCharCount.Size = new Size(179, 27);
            txtCharCount.TabIndex = 14;
            txtCharCount.TextChanged += textBox6_TextChanged;
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCharCount);
            Controls.Add(txtWordsCount);
            Controls.Add(txtLineCount);
            Controls.Add(txtURL);
            Controls.Add(txtSize);
            Controls.Add(txtFileName);
            Controls.Add(txtFileContent);
            Controls.Add(btnExit);
            Controls.Add(btnRead);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai02";
            Text = "Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRead;
        private Button btnExit;
        private RichTextBox txtFileContent;
        private TextBox txtFileName;
        private TextBox txtSize;
        private TextBox txtURL;
        private TextBox txtLineCount;
        private TextBox txtWordsCount;
        private TextBox txtCharCount;
    }
}
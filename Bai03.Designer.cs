namespace Lab02
{
    partial class Bai03
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
            btnRead = new Button();
            btnWrite = new Button();
            txtFileContent = new RichTextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(68, 68);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(158, 57);
            btnRead.TabIndex = 1;
            btnRead.Text = "Đọc file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(68, 181);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(158, 63);
            btnWrite.TabIndex = 2;
            btnWrite.Text = "Ghi file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(316, 30);
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(434, 396);
            txtFileContent.TabIndex = 3;
            txtFileContent.Text = "";
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFileContent);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Name = "Bai03";
            Text = "Bai03";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private Button btnWrite;
        private RichTextBox txtFileContent;
    }
}
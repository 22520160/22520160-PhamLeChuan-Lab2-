namespace Lab02
{
    partial class Bai01
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
            doc = new Button();
            viet = new Button();
            xuat = new RichTextBox();
            SuspendLayout();
            // 
            // doc
            // 
            doc.Location = new Point(59, 50);
            doc.Name = "doc";
            doc.Size = new Size(158, 57);
            doc.TabIndex = 0;
            doc.Text = "Đọc file";
            doc.UseVisualStyleBackColor = true;
            doc.Click += btnRead_Click;
            // 
            // viet
            // 
            viet.Location = new Point(59, 157);
            viet.Name = "viet";
            viet.Size = new Size(158, 63);
            viet.TabIndex = 1;
            viet.Text = "Ghi file";
            viet.UseVisualStyleBackColor = true;
            viet.Click += btnWrite_Click;
            // 
            // xuat
            // 
            xuat.Location = new Point(311, 25);
            xuat.Name = "xuat";
            xuat.Size = new Size(434, 396);
            xuat.TabIndex = 2;
            xuat.Text = "";
            xuat.TextChanged += xuat_TextChanged;
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(xuat);
            Controls.Add(viet);
            Controls.Add(doc);
            Name = "Bai01";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button doc;
        private Button viet;
        private RichTextBox xuat;
    }
}
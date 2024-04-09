namespace Lab02
{
    partial class Bai07
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
            treeView1 = new TreeView();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(164, 426);
            treeView1.TabIndex = 0;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(215, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "FileContent";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(16, 19);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(269, 401);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(291, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 401);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(treeView1);
            Name = "Bai07";
            Text = "Bai07";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
    }
}
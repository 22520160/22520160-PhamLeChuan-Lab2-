namespace Lab02
{
    partial class Bai06
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
            btAdd = new Button();
            btSearch = new Button();
            btDelete = new Button();
            btOut = new Button();
            tbInput = new TextBox();
            tbDish = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lvMenu = new ListView();
            pbDish = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbDish).BeginInit();
            SuspendLayout();
            // 
            // btAdd
            // 
            btAdd.Location = new Point(226, 67);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 0;
            btAdd.Text = "Thêm";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(74, 211);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 1;
            btSearch.Text = "Tìm món ăn";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(338, 211);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 2;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btOut
            // 
            btOut.Location = new Point(582, 211);
            btOut.Name = "btOut";
            btOut.Size = new Size(94, 29);
            btOut.TabIndex = 3;
            btOut.Text = "Thoát";
            btOut.UseVisualStyleBackColor = true;
            btOut.Click += btOut_Click;
            // 
            // tbInput
            // 
            tbInput.Location = new Point(211, 25);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(143, 27);
            tbInput.TabIndex = 4;
            tbInput.Text = "Ăn gì cũng được";
            tbInput.TextAlign = HorizontalAlignment.Center;
            // 
            // tbDish
            // 
            tbDish.Location = new Point(182, 266);
            tbDish.Name = "tbDish";
            tbDish.Size = new Size(408, 27);
            tbDish.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 28);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 6;
            label1.Text = "Nhập món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 243);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 7;
            label2.Text = "Món ăn hôm nay là:";
            // 
            // lvMenu
            // 
            lvMenu.Location = new Point(405, 12);
            lvMenu.Name = "lvMenu";
            lvMenu.Size = new Size(359, 180);
            lvMenu.TabIndex = 8;
            lvMenu.UseCompatibleStateImageBehavior = false;
            lvMenu.View = View.List;
            lvMenu.SelectedIndexChanged += lvMenu_SelectedIndexChanged;
            // 
            // pbDish
            // 
            pbDish.Location = new Point(121, 315);
            pbDish.Name = "pbDish";
            pbDish.Size = new Size(532, 173);
            pbDish.SizeMode = PictureBoxSizeMode.CenterImage;
            pbDish.TabIndex = 9;
            pbDish.TabStop = false;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(pbDish);
            Controls.Add(lvMenu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbDish);
            Controls.Add(tbInput);
            Controls.Add(btOut);
            Controls.Add(btDelete);
            Controls.Add(btSearch);
            Controls.Add(btAdd);
            Name = "Bai06";
            Text = "Bai06";
            ((System.ComponentModel.ISupportInitialize)pbDish).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAdd;
        private Button btSearch;
        private Button btDelete;
        private Button btOut;
        private TextBox tbInput;
        private TextBox tbDish;
        private Label label1;
        private Label label2;
        private ListView lvMenu;
        private PictureBox pbDish;
    }
}
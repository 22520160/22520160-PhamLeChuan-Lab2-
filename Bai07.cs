using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();

            treeView1.BeginUpdate();
            DriveInfo[] drives = DriveInfo.GetDrives();
            var nodes = drives.Select(drive => new TreeNode(drive.Name) { Tag = drive.RootDirectory }).ToArray();
            treeView1.Nodes.AddRange(nodes);

            foreach (TreeNode node in treeView1.Nodes)
            {
                Load(node);
            }

            treeView1.EndUpdate();
        }

        private void Load(TreeNode parentNode)
        {
            string directoryPath = ((DirectoryInfo)parentNode.Tag).FullName;

            try
            {
                foreach (string directory in Directory.EnumerateDirectories(directoryPath))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(directory);
                    TreeNode node = new TreeNode(dirInfo.Name);
                    node.Tag = dirInfo;
                    node.Nodes.Add("");
                    parentNode.Nodes.Add(node);
                }

                foreach (string file in Directory.EnumerateFiles(directoryPath))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    TreeNode node = new TreeNode(fileInfo.Name);
                    node.Tag = fileInfo;
                    parentNode.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is FileInfo)
            {
                FileInfo fileInfo = (FileInfo)e.Node.Tag;
                string extension = fileInfo.Extension.ToLower();

                if (extension == ".txt")
                {
                    DisplayText(fileInfo.FullName);
                }
                else if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                {
                    DisplayImage(fileInfo.FullName);
                }

            }
        }


        private void HandleDirectoryNodeDoubleClick(TreeNode directoryNode)
        {
            directoryNode.Nodes.Clear();

            DirectoryInfo directoryInfo = (DirectoryInfo)directoryNode.Tag;
            DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
            FileInfo[] files = directoryInfo.GetFiles();

            AddNodes(directoryNode, subDirectories);
            AddNodes(directoryNode, files);
        }

        private void HandleFileNodeDoubleClick(TreeNode fileNode)
        {
            FileInfo fileInfo = (FileInfo)fileNode.Tag;
            if (IsImage(fileInfo.FullName))
            {
                DisplayImageContent(fileInfo.FullName);
            }
            else
            {
                DisplayTextContent(fileInfo.FullName);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();

            string[] items = Directory.GetFileSystemEntries(node.FullPath);

            foreach (string item in items)
            {
                if (File.Exists(item))
                {
                    string extension = Path.GetExtension(item).ToLower();
                    if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                    {
                        TreeNode n = node.Nodes.Add(Path.GetFileName(item));
                    }
                    else if (extension == ".txt")
                    {
                        TreeNode n = node.Nodes.Add(Path.GetFileName(item));
                    }
                }
                else if (Directory.Exists(item))
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(item));
                    n.Nodes.Add("");
                }
            }
        }


        private bool IsImage(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLowerInvariant();
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png";
        }

        private void DisplayFileContent(FileInfo fileInfo)
        {
            if (fileInfo != null && fileInfo.Exists)
            {
                if (IsImage(fileInfo.FullName))
                {
                    DisplayImageContent(fileInfo.FullName);
                }
                else
                {
                    DisplayTextContent(fileInfo.FullName);
                }
            }
        }

        private void DisplayImageContent(string imagePath)
        {
            try
            {
                Image image = Image.FromFile(imagePath);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Visible = true;
                richTextBox1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            string filePath = selectedNode.FullPath;
            if (File.Exists(filePath))
            {
                string extension = Path.GetExtension(filePath).ToLower();

                if (extension == ".txt")
                {
                    string textContent = File.ReadAllText(filePath);
                    richTextBox1.Text = textContent;
                }
                else if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(filePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void DisplayTextContent(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                richTextBox1.Text = content;
                richTextBox1.Visible = true;
                pictureBox1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayText(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                richTextBox1.Text = content;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayImage(string filePath)
        {
            try
            {
                Image image = Image.FromFile(filePath);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNodes(TreeNode parentNode, FileSystemInfo[] items)
        {
            var nodes = new TreeNode[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                TreeNode node;
                if (items[i] is DirectoryInfo directory)
                {
                    node = new TreeNode(directory.Name);
                    node.Tag = directory;
                    node.Nodes.Add("");
                }
                else
                {
                    node = new TreeNode(items[i].Name);
                    node.Tag = items[i];
                }
                nodes[i] = node;
            }
            parentNode.Nodes.AddRange(nodes);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
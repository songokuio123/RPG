using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn thư mục
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog1.SelectedPath;
                txtNoidung.Text = selectedPath;

                // Xóa nội dung cũ trong TreeView
                treeView1.Nodes.Clear();

                // Tạo một node gốc cho thư mục đã chọn
                TreeNode rootNode = new TreeNode(selectedPath);
                treeView1.Nodes.Add(rootNode);

                // Biến đếm số tệp
                int fileCount = 0;

                // Gọi phương thức đệ quy để thêm các thư mục và tệp vào TreeView
                PopulateTreeView(selectedPath, rootNode, ref fileCount);

                // Hiển thị số lượng tệp trong TextBox
                txtFileCount.Text = fileCount.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đường dẫn");
            }
        }

        private void PopulateTreeView(string directory, TreeNode parentNode, ref int fileCount)
        {
            // Lấy tất cả các thư mục trong thư mục hiện tại
            string[] subDirectories = Directory.GetDirectories(directory);
            foreach (string subDirectory in subDirectories)
            {
                TreeNode directoryNode = new TreeNode(Path.GetFileName(subDirectory));
                parentNode.Nodes.Add(directoryNode);

                // Đệ quy để thêm các thư mục con
                PopulateTreeView(subDirectory, directoryNode, ref fileCount);
            }

            // Lấy tất cả các tệp trong thư mục hiện tại
            string[] files = Directory.GetFiles(directory);
            foreach (string file in files)
            {
                TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                parentNode.Nodes.Add(fileNode);

                // Tăng biến đếm số tệp
                fileCount++;
            }
        }


    }
}

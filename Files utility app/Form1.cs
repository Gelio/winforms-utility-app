using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Files_utility_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonShowPartitions_Click(object sender, EventArgs e)
        {
            treeViewDirectory.Nodes.Clear();
            foreach (string partition in Environment.GetLogicalDrives())
            {
                try
                {
                    TreeNode partitionNode = new TreeNode(StripTrailingSlash(partition), GetChildrenNodes(partition).ToArray());
                    treeViewDirectory.Nodes.Add(partitionNode);
                }
                catch { };
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            DialogResult folderSelectResult = folderBrowserDialog1.ShowDialog(this);
            
            if (folderSelectResult == DialogResult.OK)
            {
                textBoxDirectory.Text = folderBrowserDialog1.SelectedPath;
                ListDirectories();
            }
        }

        private void ListDirectories()
        {
            string basePath = textBoxDirectory.Text;
            
            if (!Directory.Exists(basePath))
            {
                MessageBox.Show("Folder nie istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            treeViewDirectory.Nodes.Clear();

            TreeNode root = new TreeNode(StripTrailingSlash(basePath), GetChildrenNodes(basePath).ToArray());
            treeViewDirectory.Nodes.Add(root);
        }

        private string StripTrailingSlash(string path)
        {
            int lastSlash = path.LastIndexOf('/');
            return (lastSlash > -1) ? path.Substring(0, lastSlash) : path;
        }

        private TreeNode CreateTreeNode(string basePath)
        {
            TreeNode node = new TreeNode(basePath);

            foreach (string childPath in Directory.EnumerateDirectories(basePath))
                node.Nodes.Add(CreateTreeNode(childPath));

            return node;
        }

        private List<TreeNode> GetChildrenNodes(string basePath, bool loadChildren = true)
        {
            List<TreeNode> children = new List<TreeNode>();
            foreach (string childDirectoryPath in Directory.EnumerateDirectories(basePath))
            {
                try
                {
                    TreeNode child = new TreeNode(Path.GetFileName(childDirectoryPath));
                    if (loadChildren)
                        child.Nodes.AddRange(GetChildrenNodes(childDirectoryPath, false).ToArray());
                    children.Add(child);
                }
                catch { };
            }

            foreach (string childPathPath in Directory.EnumerateFiles(basePath))
            {
                try
                {
                    TreeNode child = new TreeNode(Path.GetFileName(childPathPath));
                    children.Add(child);
                }
                catch { };
            }

            return children;
        }

        private void textBoxDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListDirectories();
            }
        }

        private void treeViewDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // Reload children nodes of the current node (load their children aswell, so they have + signs on the list)
            e.Node.Nodes.Clear();
            e.Node.Nodes.AddRange(GetChildrenNodes(e.Node.FullPath).ToArray());
        }

        private void buttonAddToSelected_Click(object sender, EventArgs e)
        {
            if (treeViewDirectory.SelectedNode == null)
                return;

            bool containsPath = false;
            foreach (var item in listBoxSelected.Items)
            {
                if (item as string == treeViewDirectory.SelectedNode.FullPath)
                {
                    containsPath = true;
                    break;
                }
                    
            }
            if (!containsPath)
                listBoxSelected.Items.Add(treeViewDirectory.SelectedNode.FullPath);
        }

        private void buttonCollapseAll_Click(object sender, EventArgs e)
        {
            treeViewDirectory.CollapseAll();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            treeViewDirectory.Nodes.Clear();
            listBoxSelected.Items.Clear();
        }

        private void listBoxSelected_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxSelected.SelectedIndex >= 0)
                listBoxSelected.Items.RemoveAt(listBoxSelected.SelectedIndex);
        }
    }
}

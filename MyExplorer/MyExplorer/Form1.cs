using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Directory.GetCurrentDirectory();
            //ListFiles();
            //ListFolders();
            tommyinnit();
        }
        void tommyinnit()
        {
            TreeNode t1 = new TreeNode();
            t1.ImageIndex = 1;
            t1.Text = "a";
            treeView1.Nodes.Add(t1);
            TreeNode t2 = new TreeNode();
            t2.ImageIndex = 1;
            t2.Text = "b";
            treeView1.Nodes.Add(t2);
            TreeNode t3 = new TreeNode();
            t3.ImageIndex = 1;
            t3.Text = "c";
            treeView1.Nodes.Add(t3);

            ListViewItem l1 = new ListViewItem();
            l1.Text = "1";
            l1.ImageIndex = 0;
            l1.SubItems.Add("s1a");
            l1.SubItems.Add("s2a");
            l1.SubItems.Add("s3a");
            listView1.Items.Add(l1);
            ListViewItem l2 = new ListViewItem();
            l2.Text = "2";
            l2.ImageIndex = 1;
            l2.SubItems.Add("s1b");
            l2.SubItems.Add("s2b");
            l2.SubItems.Add("s3b");
            listView1.Items.Add(l2);
            ListViewItem l3 = new ListViewItem();
            l3.Text = "3";
            l3.ImageIndex = 2;
            l3.SubItems.Add("s1c");
            l3.SubItems.Add("s2c");
            l3.SubItems.Add("s3c");
            listView1.Items.Add(l3);
        }
        void ListFiles()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            listView1.Items.Clear();
            foreach (string FileName in files)
            {
                listView1.Items.Add(FileName);
            }
        }
        void ListFolders()
        {
            string[] folders = Directory.GetDirectories(Directory.GetCurrentDirectory());
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("..");
            foreach (string DirName in folders)
            {
                treeView1.Nodes.Add(DirName);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "..")
            {
                //string curr = Directory.GetCurrentDirectory();
                //Directory.SetCurrentDirectory(Directory.GetParent(curr).ToString());
                //ListFiles();
                textBox1.Text = "Ello m8!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
    }
}

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

namespace MyExplorer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void PopulateListView(string s)
        {
            listView1.Items.Clear();
            try
            {
                DirectoryInfo dir = new DirectoryInfo("c:\\" + s);
                foreach (DirectoryInfo d in dir.GetDirectories())
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = d.Name;
                    li.ImageIndex = 1;
                    listView1.Items.Add(li);
                }
                foreach (FileInfo f in dir.GetFiles())
                {

                    ListViewItem li = new ListViewItem();
                    ListViewItem.ListViewSubItem si = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem sii = new ListViewItem.ListViewSubItem();
                    si.Text = f.CreationTime.ToString();
                    li.SubItems.Add(si);
                    li.Text = s;
                    sii.Text = f.Extension;
                    li.SubItems.Add(sii);
                    li.Text = f.Name;
                    li.ImageIndex = 2;
                    listView1.Items.Add(li);

                }
            }
            catch (Exception)
            {

            }
        }

    }
}

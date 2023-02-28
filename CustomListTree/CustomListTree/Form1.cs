using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomListTree
{
    public partial class PokeDex : Form
    {
        public PokeDex()
        {
            InitializeComponent();
            //3 icons
            TreeNode t = treeView1.Nodes.Add("Generation 1", "Generation 1", 6, 6);
            t.Nodes.Add("Diglett", "Diglett Family", 0, 6);
            t.Nodes.Add("Gastly", "Gastly Family", 1, 6);
            t.Nodes.Add("Eevee", "Eevee Family", 2, 6);

            TreeNode t2 = treeView1.Nodes.Add("Generation 2", "Generation 2", 6, 6);
            t2.Nodes.Add("Chikorita", "Chikorita Family", 3, 6);
            t2.Nodes.Add("Cyndaquil", "Cyndaquil Family", 4, 6);
            t2.Nodes.Add("Totodile", "Totodile Family", 5, 6);
        }

        private void button1_Click(object sender, EventArgs e)
        { }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //3 icons
            //sub items
            listView1.Clear();
            listView1.Columns.Add("Name", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Species", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("Abilty", 70, HorizontalAlignment.Left);

            switch (e.Node.Text)
            {
                case "Gastly Family":
                    ListViewItem l = listView1.Items.Add("Gastly", 1);
                    l.SubItems.Add("Gas");
                    l.SubItems.Add("Levitate");
                    ListViewItem ll = listView1.Items.Add("Haunter", 13);
                    ll.SubItems.Add("Gas");
                    ll.SubItems.Add("Levitate");
                    ListViewItem lll = listView1.Items.Add("Gengar", 14);
                    lll.SubItems.Add("Shadow");
                    lll.SubItems.Add("Cursed Body");
                    break;
                case "a_2":
                    ListViewItem l2 = listView1.Items.Add("B");
                    l2.SubItems.Add("a_1");
                    l2.SubItems.Add("a_2");
                    l2.SubItems.Add("a_3");
                    break;
                default:
                    break;
            }
        }
    }
}

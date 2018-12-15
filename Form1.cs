using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form k;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes[0].ExpandAll();
            k = new home();
            k.TopLevel = false;
            this.UMUHOZA.Controls.Add(k);
            k.Dock = DockStyle.Fill;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            switch (node.Text)
            {
                case "CALCULATOR":

            k.Dispose();
                    k = new Form2();
                    k.TopLevel = false;
                    this.UMUHOZA.Controls.Add(k);
                    k.Dock = DockStyle.Fill;
                    k.Show();
                    break;
                case "ROOM":

                    k.Dispose();
                    k = new home();
                    k.TopLevel = false;
                    this.UMUHOZA.Controls.Add(k);
                    k.Dock = DockStyle.Fill;
                    k.Show();
                    break;
            }
            

        }

        private void CALCULATOR(object sender, EventArgs e)
        {
            UMUHOZA.Controls.Clear();
            Form2 clarisse = new Form2();
            clarisse.TopLevel = false;
            UMUHOZA.Controls.Add(clarisse);
            clarisse.Show();

        }
    }
}

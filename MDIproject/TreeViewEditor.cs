using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MDIproject
{
    public partial class TreeViewEditor : Form
    {
        TreeNode mySelectedNode;
        XmlDocument xmlDocument;
        bool Changed = false;

        public TreeViewEditor()
        {
            InitializeComponent();
        }

        #region OpenSave
        public void Open_File(string FileName)
        {
           xmlDocument = new XmlDocument();

            OpenFromXML.XmlToTreeView(FileName, treeView1, xmlDocument);
            Changed = false;

        }

        public void Save_File(string FileName)
        {
            xmlDocument = new XmlDocument();
            SaveToXML.TreeViewToXml(treeView1, FileName, xmlDocument);
        }
        #endregion OpenSave

        #region Editing

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) //Сохранение последнего выбранного элемента
        {
            mySelectedNode = treeView1.SelectedNode;

        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            { treeView1.SelectedNode.BeginEdit();
                Changed = true;
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                mySelectedNode.BeginEdit();
                Changed = true;
            }
            else
                MessageBox.Show("Выберите элемент", "Ошибка");

        }

        #endregion Editing

        #region Add_And_Remove_Tree_View_Elements
        private void Root_add(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Root");
            Changed = true;
        }

        private void Child_Add(object sender, EventArgs e)
        {
            if (mySelectedNode != null)
            {
                mySelectedNode.Nodes.Add("Child elem");
                Changed = true;
            }
            else MessageBox.Show("Выберите элемент", "Ошибка");

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySelectedNode.Remove();
            Changed = true;

        }

        #endregion Add_And_Remove_Tree_View_Elements

        public void CloseTab(object sender, EventArgs e)
        {
            if (Changed == true)
            {
                MDIparent mDIparent = new MDIparent();
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                Console.WriteLine(result);
                if (result == DialogResult.Yes)
                {

                    if (mDIparent.path != null)
                    {
                        Save_File(mDIparent.path);
                    }
                    else if (mDIparent.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        mDIparent.path = mDIparent.saveFileDialog1.FileName;
                        Save_File(mDIparent.path);
                    }
                    this.Close();
                    Changed = false;
                }
                else if (result == DialogResult.No)
                {
                    Close();
                    Changed = false;

                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            } else
            {
                Close();
            }
            

        }


    }
}

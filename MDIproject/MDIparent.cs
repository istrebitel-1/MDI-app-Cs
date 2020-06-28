using System;
using System.Windows.Forms;

namespace MDIproject
{
    public partial class MDIparent : Form
    {
        public string path;
        public int count = 1;
        public MDIparent()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "XML files|*.xml";
            openFileDialog1.Filter = "XML files|*.xml|All files|*.*";

        }

        private void OpenNewChild(object sender, EventArgs e)
        {
            TreeViewEditor childForm = new TreeViewEditor();
            childForm.MdiParent = this;
            childForm.Text = "Новое дерево иерархий "+ count.ToString();
            childForm.Show();
            count++;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TreeViewEditor childForm = new TreeViewEditor
                {
                    MdiParent = this
                };
                childForm.Open_File(openFileDialog1.FileName);
                childForm.Show();
                path = openFileDialog1.FileName;
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            TreeViewEditor childForm = (TreeViewEditor)this.ActiveMdiChild;
            if (MdiChildren.Length == 0)
            {
                MessageBox.Show("Нечего сохранять!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (path != null)
            {
                childForm.Save_File(path);
            }
            else
                if
             (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                childForm = (TreeViewEditor)this.ActiveMdiChild;
                path = saveFileDialog1.FileName;
                childForm.Save_File(path);

            }
            
        }



        private void SaveFileAs(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0)
            {
                MessageBox.Show("Нечего сохранять!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TreeViewEditor childForm = (TreeViewEditor)this.ActiveMdiChild;
                path = saveFileDialog1.FileName;
                childForm.Save_File(path);
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void запуститьГусяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goose form1 = new Goose();
            form1.Show();
        }

        private void аЭтоЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DFC dFC = new DFC();
            dFC.Show();
        }
    }
}

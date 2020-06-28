namespace MDIproject
{
    partial class TreeViewEditor
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
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.добавитьКорневойЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьДочернийЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.закрытьТекущуюВкладкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(365, 392);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.добавитьКорневойЭлементToolStripMenuItem,
            this.добавитьДочернийЭлементToolStripMenuItem,
            this.toolStripSeparator2,
            this.закрытьТекущуюВкладкуToolStripMenuItem,
            this.toolStripSeparator3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(329, 142);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(328, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(328, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(325, 6);
            // 
            // добавитьКорневойЭлементToolStripMenuItem
            // 
            this.добавитьКорневойЭлементToolStripMenuItem.Name = "добавитьКорневойЭлементToolStripMenuItem";
            this.добавитьКорневойЭлементToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.добавитьКорневойЭлементToolStripMenuItem.Size = new System.Drawing.Size(328, 24);
            this.добавитьКорневойЭлементToolStripMenuItem.Text = "Добавить корневой элемент";
            this.добавитьКорневойЭлементToolStripMenuItem.Click += new System.EventHandler(this.Root_add);
            // 
            // добавитьДочернийЭлементToolStripMenuItem
            // 
            this.добавитьДочернийЭлементToolStripMenuItem.Name = "добавитьДочернийЭлементToolStripMenuItem";
            this.добавитьДочернийЭлементToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.добавитьДочернийЭлементToolStripMenuItem.Size = new System.Drawing.Size(328, 24);
            this.добавитьДочернийЭлементToolStripMenuItem.Text = "Добавить дочерний элемент";
            this.добавитьДочернийЭлементToolStripMenuItem.Click += new System.EventHandler(this.Child_Add);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(325, 6);
            // 
            // закрытьТекущуюВкладкуToolStripMenuItem
            // 
            this.закрытьТекущуюВкладкуToolStripMenuItem.Name = "закрытьТекущуюВкладкуToolStripMenuItem";
            this.закрытьТекущуюВкладкуToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.закрытьТекущуюВкладкуToolStripMenuItem.Size = new System.Drawing.Size(328, 24);
            this.закрытьТекущуюВкладкуToolStripMenuItem.Text = "Закрыть текущую вкладку";
            this.закрытьТекущуюВкладкуToolStripMenuItem.Click += new System.EventHandler(this.CloseTab);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(325, 6);
            // 
            // TreeViewEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 392);
            this.Controls.Add(this.treeView1);
            this.Name = "TreeViewEditor";
            this.Text = "TreeViewEditor";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКорневойЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьДочернийЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem закрытьТекущуюВкладкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
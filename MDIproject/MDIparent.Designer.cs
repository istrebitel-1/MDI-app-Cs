namespace MDIproject
{
    partial class MDIparent
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIparent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNew = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьГусяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьГусяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.аЭтоЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.запуститьГусяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNew,
            this.open,
            this.toolStripSeparator1,
            this.save,
            this.save_as,
            this.toolStripSeparator2,
            this.close});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // createNew
            // 
            this.createNew.Name = "createNew";
            this.createNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createNew.Size = new System.Drawing.Size(288, 26);
            this.createNew.Text = "&Создать";
            this.createNew.Click += new System.EventHandler(this.OpenNewChild);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open.Size = new System.Drawing.Size(288, 26);
            this.open.Text = "&Открыть";
            this.open.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(285, 6);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save.Size = new System.Drawing.Size(288, 26);
            this.save.Text = "&Сохранить";
            this.save.Click += new System.EventHandler(this.SaveFile);
            // 
            // save_as
            // 
            this.save_as.Name = "save_as";
            this.save_as.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.save_as.Size = new System.Drawing.Size(288, 26);
            this.save_as.Text = "&Сохранить как..";
            this.save_as.Click += new System.EventHandler(this.SaveFileAs);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(285, 6);
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(288, 26);
            this.close.Text = "Выход";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // запуститьГусяToolStripMenuItem
            // 
            this.запуститьГусяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьГусяToolStripMenuItem1,
            this.аЭтоЯToolStripMenuItem});
            this.запуститьГусяToolStripMenuItem.Name = "запуститьГусяToolStripMenuItem";
            this.запуститьГусяToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.запуститьГусяToolStripMenuItem.Text = "&От создателя";
            // 
            // запуститьГусяToolStripMenuItem1
            // 
            this.запуститьГусяToolStripMenuItem1.Name = "запуститьГусяToolStripMenuItem1";
            this.запуститьГусяToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.запуститьГусяToolStripMenuItem1.Text = "Запустить гуся";
            this.запуститьГусяToolStripMenuItem1.Click += new System.EventHandler(this.запуститьГусяToolStripMenuItem_Click);
            // 
            // аЭтоЯToolStripMenuItem
            // 
            this.аЭтоЯToolStripMenuItem.Name = "аЭтоЯToolStripMenuItem";
            this.аЭтоЯToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.аЭтоЯToolStripMenuItem.Text = "А это я";
            this.аЭтоЯToolStripMenuItem.Click += new System.EventHandler(this.аЭтоЯToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "New Document";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 28);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.создатьToolStripMenuItem.Text = "&Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.OpenNewChild);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MDIparent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIparent";
            this.Text = "MDI app";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem save_as;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem запуститьГусяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьГусяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem аЭтоЯToolStripMenuItem;
    }
}


namespace Files_utility_app
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.buttonAddToSelected = new System.Windows.Forms.Button();
            this.treeViewDirectory = new System.Windows.Forms.TreeView();
            this.buttonCollapseAll = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonShowPartitions = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wypisywanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wizualizacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBoxMatchedDirectories = new System.Windows.Forms.ListBox();
            this.listBoxMatchedFiles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxSelected);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddToSelected);
            this.splitContainer1.Panel1.Controls.Add(this.treeViewDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCollapseAll);
            this.splitContainer1.Panel1.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.buttonShowPartitions);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSelect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.Controls.Add(this.listBoxMatchedFiles);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxMatchedDirectories);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(748, 474);
            this.splitContainer1.SplitterDistance = 324;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.Location = new System.Drawing.Point(4, 359);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(311, 108);
            this.listBoxSelected.TabIndex = 9;
            this.listBoxSelected.DoubleClick += new System.EventHandler(this.listBoxSelected_DoubleClick);
            // 
            // buttonAddToSelected
            // 
            this.buttonAddToSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddToSelected.Location = new System.Drawing.Point(12, 330);
            this.buttonAddToSelected.Name = "buttonAddToSelected";
            this.buttonAddToSelected.Size = new System.Drawing.Size(128, 23);
            this.buttonAddToSelected.TabIndex = 8;
            this.buttonAddToSelected.Text = "Dodaj do wybranych";
            this.buttonAddToSelected.UseVisualStyleBackColor = true;
            this.buttonAddToSelected.Click += new System.EventHandler(this.buttonAddToSelected_Click);
            // 
            // treeViewDirectory
            // 
            this.treeViewDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewDirectory.Location = new System.Drawing.Point(4, 118);
            this.treeViewDirectory.Name = "treeViewDirectory";
            this.treeViewDirectory.Size = new System.Drawing.Size(311, 203);
            this.treeViewDirectory.TabIndex = 6;
            this.treeViewDirectory.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewDirectory_BeforeExpand);
            // 
            // buttonCollapseAll
            // 
            this.buttonCollapseAll.Location = new System.Drawing.Point(85, 88);
            this.buttonCollapseAll.Name = "buttonCollapseAll";
            this.buttonCollapseAll.Size = new System.Drawing.Size(96, 23);
            this.buttonCollapseAll.TabIndex = 5;
            this.buttonCollapseAll.Text = "Zwiń wszystkie";
            this.buttonCollapseAll.UseVisualStyleBackColor = true;
            this.buttonCollapseAll.Click += new System.EventHandler(this.buttonCollapseAll_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(4, 88);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Wyczyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder";
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.Location = new System.Drawing.Point(4, 49);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(234, 20);
            this.textBoxDirectory.TabIndex = 2;
            this.textBoxDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDirectory_KeyDown);
            // 
            // buttonShowPartitions
            // 
            this.buttonShowPartitions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowPartitions.Location = new System.Drawing.Point(226, 88);
            this.buttonShowPartitions.Name = "buttonShowPartitions";
            this.buttonShowPartitions.Size = new System.Drawing.Size(89, 23);
            this.buttonShowPartitions.TabIndex = 1;
            this.buttonShowPartitions.Text = "Pokaż partycje";
            this.buttonShowPartitions.UseVisualStyleBackColor = true;
            this.buttonShowPartitions.Click += new System.EventHandler(this.buttonShowPartitions_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect.Location = new System.Drawing.Point(240, 47);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Wybierz";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pluginyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem,
            this.koniecToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.koniecToolStripMenuItem.Text = "Koniec";
            // 
            // pluginyToolStripMenuItem
            // 
            this.pluginyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wypisywanieToolStripMenuItem,
            this.wizualizacjaToolStripMenuItem});
            this.pluginyToolStripMenuItem.Name = "pluginyToolStripMenuItem";
            this.pluginyToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.pluginyToolStripMenuItem.Text = "Pluginy";
            // 
            // wypisywanieToolStripMenuItem
            // 
            this.wypisywanieToolStripMenuItem.Name = "wypisywanieToolStripMenuItem";
            this.wypisywanieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wypisywanieToolStripMenuItem.Text = "Wypisywanie";
            this.wypisywanieToolStripMenuItem.Click += new System.EventHandler(this.wypisywanieToolStripMenuItem_Click);
            // 
            // wizualizacjaToolStripMenuItem
            // 
            this.wizualizacjaToolStripMenuItem.Name = "wizualizacjaToolStripMenuItem";
            this.wizualizacjaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wizualizacjaToolStripMenuItem.Text = "Wizualizacja";
            // 
            // listBoxMatchedDirectories
            // 
            this.listBoxMatchedDirectories.FormattingEnabled = true;
            this.listBoxMatchedDirectories.Location = new System.Drawing.Point(4, 27);
            this.listBoxMatchedDirectories.Name = "listBoxMatchedDirectories";
            this.listBoxMatchedDirectories.Size = new System.Drawing.Size(202, 199);
            this.listBoxMatchedDirectories.TabIndex = 0;
            // 
            // listBoxMatchedFiles
            // 
            this.listBoxMatchedFiles.FormattingEnabled = true;
            this.listBoxMatchedFiles.Location = new System.Drawing.Point(212, 27);
            this.listBoxMatchedFiles.Name = "listBoxMatchedFiles";
            this.listBoxMatchedFiles.Size = new System.Drawing.Size(202, 199);
            this.listBoxMatchedFiles.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 474);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "Form1";
            this.Text = "FileWalker";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonShowPartitions;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonCollapseAll;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wypisywanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wizualizacjaToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddToSelected;
        private System.Windows.Forms.TreeView treeViewDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.ListBox listBoxMatchedDirectories;
        private System.Windows.Forms.ListBox listBoxMatchedFiles;
    }
}


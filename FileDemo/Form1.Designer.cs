namespace FileDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewProject = new System.Windows.Forms.ListView();
            this.contextMenuStripProjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripNothing = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripGroups = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStripProjects.SuspendLayout();
            this.contextMenuStripUsers.SuspendLayout();
            this.contextMenuStripNothing.SuspendLayout();
            this.contextMenuStripGroups.SuspendLayout();
            this.contextMenuStripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(1, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 343);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageListSmall;
            this.treeView1.Location = new System.Drawing.Point(0, -3);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(317, 343);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "directory.ico");
            this.imageListSmall.Images.SetKeyName(1, "file.ico");
            this.imageListSmall.Images.SetKeyName(2, "project.ico");
            this.imageListSmall.Images.SetKeyName(3, "user.ico");
            this.imageListSmall.Images.SetKeyName(4, "group.ico");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewProject);
            this.panel2.Location = new System.Drawing.Point(350, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 343);
            this.panel2.TabIndex = 0;
            // 
            // listViewProject
            // 
            this.listViewProject.Location = new System.Drawing.Point(0, 3);
            this.listViewProject.Name = "listViewProject";
            this.listViewProject.Size = new System.Drawing.Size(417, 337);
            this.listViewProject.SmallImageList = this.imageListSmall;
            this.listViewProject.TabIndex = 0;
            this.listViewProject.UseCompatibleStateImageBehavior = false;
            this.listViewProject.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStripProjects
            // 
            this.contextMenuStripProjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.getURLToolStripMenuItem,
            this.helpToolStripMenuItem2});
            this.contextMenuStripProjects.Name = "contextMenuStripProjects";
            this.contextMenuStripProjects.Size = new System.Drawing.Size(144, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addToolStripMenuItem.Text = "add Project";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // getURLToolStripMenuItem
            // 
            this.getURLToolStripMenuItem.Name = "getURLToolStripMenuItem";
            this.getURLToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.getURLToolStripMenuItem.Text = "Update";
            this.getURLToolStripMenuItem.Click += new System.EventHandler(this.getURLToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.helpToolStripMenuItem2.Text = "Help";
            // 
            // contextMenuStripUsers
            // 
            this.contextMenuStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.updateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.contextMenuStripUsers.Name = "contextMenuStripUsers";
            this.contextMenuStripUsers.Size = new System.Drawing.Size(131, 70);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.addToolStripMenuItem1.Text = "add User";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contextMenuStripNothing
            // 
            this.contextMenuStripNothing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nothingToolStripMenuItem});
            this.contextMenuStripNothing.Name = "contextMenuStripNothing";
            this.contextMenuStripNothing.Size = new System.Drawing.Size(124, 26);
            // 
            // nothingToolStripMenuItem
            // 
            this.nothingToolStripMenuItem.Name = "nothingToolStripMenuItem";
            this.nothingToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.nothingToolStripMenuItem.Text = "Nothing";
            // 
            // contextMenuStripGroups
            // 
            this.contextMenuStripGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGroupToolStripMenuItem,
            this.updataToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.contextMenuStripGroups.Name = "contextMenuStripGroups";
            this.contextMenuStripGroups.Size = new System.Drawing.Size(141, 70);
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addGroupToolStripMenuItem.Text = "add Group";
            // 
            // updataToolStripMenuItem
            // 
            this.updataToolStripMenuItem.Name = "updataToolStripMenuItem";
            this.updataToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.updataToolStripMenuItem.Text = "Updata";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // contextMenuStripFile
            // 
            this.contextMenuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyURLToolStripMenuItem,
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.addFileToolStripMenuItem,
            this.uploadToolStripMenuItem,
            this.importToolStripMenuItem});
            this.contextMenuStripFile.Name = "contextMenuStripFile";
            this.contextMenuStripFile.Size = new System.Drawing.Size(153, 158);
            // 
            // copyURLToolStripMenuItem
            // 
            this.copyURLToolStripMenuItem.Name = "copyURLToolStripMenuItem";
            this.copyURLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyURLToolStripMenuItem.Text = "CopyURL";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addFileToolStripMenuItem.Text = "add File";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 377);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contextMenuStripProjects.ResumeLayout(false);
            this.contextMenuStripUsers.ResumeLayout(false);
            this.contextMenuStripNothing.ResumeLayout(false);
            this.contextMenuStripGroups.ResumeLayout(false);
            this.contextMenuStripFile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listViewProject;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProjects;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getURLToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNothing;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGroups;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nothingToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem copyURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
    }
}


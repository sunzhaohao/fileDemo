using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO; 
 
namespace FileDemo
{
    public partial class Form1 : Form
    {
        private FileDemo.Window.LogInWindow login=new Window.LogInWindow();
        private AddProjectWindow addProject=new AddProjectWindow();
        private FileInfoManager fileManager = new FileInfoManager();
        private ImageManager imageManager = new ImageManager();
        public Form1()
        {
            this.SetVisibleCore(false);
            this.Visible = false;
            InitializeComponent();
            fileManager.InitProject();
           
            login.SetDesktopLocation(Screen.PrimaryScreen.Bounds.Width/2, Screen.PrimaryScreen.Bounds.Height/2);
            
            login.ShowDialog(this);
            if (login.getLoginResult() == false)
                System.Environment.Exit(0);
        }
        
        private void InitProTree()
        {       
            TreeNode proNode = this.treeView1.Nodes[0];

            int num = 0;
            foreach(string str in fileManager.proInfo)
            {
                DirNode node = new DirNode();
                
                node.Text = str;
                node.ImageIndex = 2;
                proNode.Nodes.Add(node);

                DirNode dirNode = new DirNode();
                string dirStr =(string) fileManager.dirInfo[num];
                if (dirStr != "nothing")  
                {
                    dirNode.addFileNode(dirStr);
                    dirNode.Text = dirStr.Substring(dirStr.LastIndexOf('\\') + 1);
                   
                    node.Nodes.Add(dirNode);
                    
                }
                
                num++;
            }
        }

        private void CreateHeader()
        {
            ColumnHeader colHead=new ColumnHeader();
           
            colHead.Width = listViewProject.Width/2;       
            colHead.Text = "名称";
            this.listViewProject.Columns.Add(colHead);
        }
        private void Form1_Load(object sender, EventArgs e)
        {     
            TreeNode project=new TreeNode();
            project.Text = "Projects";
            
            this.treeView1.Nodes.Add(project);
            this.treeView1.Nodes[0].ImageIndex = 2;
            
            TreeNode users = new TreeNode();
            users.Text = "Users";
            users.ImageIndex = 3;
            this.treeView1.Nodes.Add(users);
            this.treeView1.Nodes[1].ImageIndex = 3;
            for(int i=0;i<=5;i++)
            {
                TreeNode user=new TreeNode();
                user.Text = "user " + i;
                user.ImageIndex = 3;
                users.Nodes.Add(user);
            }

            TreeNode groups = new TreeNode();
            groups.Text = "Groups";
            
            this.treeView1.Nodes.Add(groups);
            this.treeView1.Nodes[2].ImageIndex = 4;
           
            CreateHeader();

            InitProTree(); 
       

        }

        public DataSet getDataSet(string tableName)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection("Data Source=localhost;uid=root;pwd=sunzhao;Database=CodeProject"))
            {
                con.Open();
                string strSQL = "select * from " + tableName;
                using (SqlDataAdapter sda = new SqlDataAdapter(strSQL, con))
                {
                    sda.Fill(ds);
                }
            }
            return ds;
        }  
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {     
                TreeNode selectNode = treeView1.SelectedNode;
                changeListView(selectNode);

                if (selectNode.Text == "Projects")
                {
                    this.treeView1.ContextMenuStrip = contextMenuStripProjects;                   
                }
                else if (selectNode.Text == "Users")
                {
                    this.treeView1.ContextMenuStrip = contextMenuStripUsers;                 
                }
                else if (selectNode.Text == "Groups")
                {
                    this.treeView1.ContextMenuStrip = contextMenuStripGroups;
                }
                else if (selectNode.Parent.Text == "Projects")
                {
                    this.treeView1.ContextMenuStrip = contextMenuStripFile;
                }
                else             
                    this.treeView1.ContextMenuStrip = contextMenuStripNothing;
                    
                

                selectNode.SelectedImageIndex = selectNode.ImageIndex;
            
        }
    
        private  void changeListView(TreeNode node)
        {
            listViewProject.Clear();
            CreateHeader();
            listViewProject.BeginUpdate();
            for(int i=0;i<node.GetNodeCount(false) ;i++)
            {
                  
                ListViewItem item = new ListViewItem();
                item.Text = node.Nodes[i].Text;
                if (node.Text == "Projects")
                    item.ImageIndex = 2;
                else if(node.Text =="Users")
                {
                    item.ImageIndex = 3;
                    
                }
                else if(node.Text=="Groups")
                {
                    item.ImageIndex = 4;
                }
                else  
                {
                    DirNode  dirnode=(DirNode)node.Nodes[i];
                   
                    if (Directory.Exists(dirnode.getdirName()))
                        item.ImageIndex = 0;
                    else
                        item.ImageIndex = 1;
                }
                listViewProject.Items.Add(item);
                 
            }
            listViewProject.EndUpdate();
 
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProject.ShowDialog();

            if (!fileManager.projectionAlreadyExist(addProject.projectName))    
                addProjection(addProject.projectName);
            else
                MessageBox.Show(addProject.projectName + " 已经存在！");
        }
        private void addProjection(string proName)
        {    
            DirNode proNode = new DirNode();
            proNode.Text = proName;
            proNode.ImageIndex = 2;
            TreeNode tr = this.treeView1.Nodes[0];
            tr.Nodes.Add(proNode);

            fileManager.proInfo.AddLast(proName);
            fileManager.dirInfo.Add("nothing");
            fileManager.writeToProFile();
            
            
        }

        private void addProjectionFile(string proName)
        {
            DirNode dirNode = new DirNode();
            dirNode.addFileNode(proName);
           
            dirNode.Text = proName.Substring(proName.LastIndexOf('\\')+1);

            DirNode proNode =(DirNode) treeView1.SelectedNode;

            if (proNode.GetNodeCount(true) == 0)
            {
                proNode.Nodes.Add(dirNode);

                int num = 0 ;
                foreach(string str in fileManager.proInfo)
                {
                    if (str == proNode.Text)
                        break;
                    num++;
                }

                fileManager.dirInfo[num] = proName;
                fileManager.writeToProFile();
                
            }
            else
                MessageBox.Show("One project only can create one directory!");

        }

        
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode tn = treeView1.GetNodeAt(e.X, e.Y);
                if (tn != null) treeView1.SelectedNode = tn;
                
            }
          
        }

        private void getURLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TreeNode tr = this.treeView1.SelectedNode;

            this.treeView1.Nodes.Remove(tr);
            fileManager.proInfo.Remove(tr.Text);
            fileManager.writeToProFile();
        }

        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirNode proNode = (DirNode)this.treeView1.SelectedNode;
            if(proNode.GetNodeCount(true)!=0)
            {
                MessageBox.Show("一个项目只能创建一个目录");
                return;
            }
            FolderBrowserDialog filter = new FolderBrowserDialog();
            filter.ShowDialog();
            addProjectionFile(filter.SelectedPath);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // fileManager.DownLoadSoft("df", "http://localhost/xss/", "ex1.php");
            DirNode dirNode = (DirNode)treeView1.SelectedNode.Nodes[0];
            DirectoryInfo dir = new DirectoryInfo(dirNode.getdirName());
            DirectoryInfo destination = new DirectoryInfo(dir.Name + ".zip");

            fileManager.ImportFiles(@"http://localhost/code/test/"+destination.Name, "Download/"+destination.Name);

            StringBuilder str = new StringBuilder(dir.FullName);
            str.Replace('\\', '/');
            MessageBox.Show(str.ToString());

            ZipClass zip = new ZipClass();
            zip.UnZip2("Download/"+destination.Name, str.ToString());
            
        }

        // 上传文件
        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirNode dirNode=(DirNode)treeView1.SelectedNode.Nodes[0];
            DirectoryInfo dir = new DirectoryInfo(dirNode.getdirName());
            DirectoryInfo destination = new DirectoryInfo(dir.Name+".zip");

            ZipClass zip = new ZipClass();
            StringBuilder str = new StringBuilder(dir.FullName);
            str.Replace('\\','/');
           
           zip.ZipFileFromDirectory(str.ToString(), destination.FullName,1);
           fileManager.uploadFile("http://localhost/code/testfile.php", destination.Name);
           File.Delete(destination.Name);
        }

        public void changDirectoryPath(String name)
        {

        }
    }
}

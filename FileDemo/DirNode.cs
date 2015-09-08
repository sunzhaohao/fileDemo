using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace FileDemo
{
    class DirNode :TreeNode
    {
        private string dirName;
        public bool isEmpty=true;
        public void setDirName(string dirName)
        {
            this.dirName = dirName;
        }

        public string getdirName()
        {
            return dirName;
        }
        public void moreOperation()
        {
            if(Directory.Exists(dirName))
            {
                string[] dirs=Directory.GetDirectories(dirName);
                foreach(string dir in dirs)
                {
                    this.Nodes.Add(dir);
                }
            }
        }

        private void addDirNode(string name, int i)
        {
            DirNode dirNode = new DirNode();
            dirNode.Text = name.Substring(name.LastIndexOf('\\') + 1);
            dirNode.ImageIndex = i;

            this.Nodes.Add(dirNode);
        }
        public void addFileNode(string name)
        {
            this.isEmpty = false;
            this.dirName = name;
            if(File.Exists(name))
            { 
                FileInfo f = new FileInfo(name);
                addDirNode(name, 1);             
            }
            else if(Directory.Exists(name))
            { 
                    string[] dirs = Directory.GetDirectories(name);
                    foreach (string dir in dirs)
                    {
                        DirNode dirNode = new DirNode();

                        dirNode.addFileNode(dir);
                        dirNode.Text = dir.Substring(dir.LastIndexOf('\\') + 1);
                        this.Nodes.Add(dirNode);

                    }
                    
                    string []files = Directory.GetFiles(name);
                    foreach (string file in files)
                    {
                        addDirNode(file, 1);
                    }    
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Net;

namespace FileDemo
{
    class FileInfoManager
    {
        private string projectInfo="project.ini";
        private string directoryInfo = "directory.ini";
        
        public LinkedList<string> proInfo=new LinkedList<string>();
        public ArrayList dirInfo = new ArrayList();

        //* 判断项目是否已存在
        public FileInfoManager()
        {
            
        }
        public void InitProject()
        {
            
            try
            {
                FileStream proStream = new FileStream(projectInfo, FileMode.OpenOrCreate);
                FileStream dirStream = new FileStream(directoryInfo, FileMode.OpenOrCreate);

                StreamReader reader = new StreamReader(proStream);
                StreamReader dirreader = new StreamReader(dirStream);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    proInfo.AddLast(str);

                    str = dirreader.ReadLine();
                    dirInfo.Add(str);
               
                }

                reader.Close();
                dirreader.Close();

            }
            catch (IOException e)
            {
                MessageBox.Show("文件读取发生错误，请装作什么都没看到，并自行重启");
                System.Environment.Exit(0);
            }
        }
        
        public bool projectionAlreadyExist(string name)
        {
            if (proInfo.Contains(name))
                return true;
            else
                return false;
        }
        public void writeToProFile()
        {
            FileStream writeStream = new FileStream(projectInfo, FileMode.Truncate);
            FileStream dirStream = new FileStream(directoryInfo, FileMode.Truncate);
            
            StreamWriter proWriter = new StreamWriter(writeStream);
            StreamWriter dirWriter = new StreamWriter(dirStream);
            for (int i = 0; i < proInfo.Count();i++ )
            {
                proWriter.WriteLine(proInfo.ElementAt(i));
                dirWriter.WriteLine(dirInfo[i]);

            }
                
            proWriter.Close();
            dirWriter.Close();
        }

        public void uploadFile(String path,String name)
        {
            WebClient client = new WebClient();
            
            client.UploadFile(path, name);
           
            
        }
        public void ImportFiles(String url,String filename)
        {
            WebClient client = new WebClient();
            
            client.DownloadFile(url, filename);
        }



        readonly string DownloadPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\Download\";//本地存放路径
        /// <summary>
        /// 下载
        /// </summary>
        public bool DownLoadSoft(string Version, string FullFilePath, string FileName)
        {
            string path = DownloadPath.Remove(DownloadPath.Length - 1);
            bool flag = false;
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                using (FileStream fs = new FileStream(DownloadPath + FileName, FileMode.Create, FileAccess.Write))
                {
                    //创建请求
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(FullFilePath);
                    //接收响应                
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    //输出流
                    MessageBox.Show("dflfkj");
                    Stream responseStream = response.GetResponseStream();
                    byte[] bufferBytes = new byte[10000];//缓冲字节数组
                    int bytesRead = -1;
                    while ((bytesRead = responseStream.Read(bufferBytes, 0, bufferBytes.Length)) > 0)
                    {
                        fs.Write(bufferBytes, 0, bytesRead);
                    }
                    if (fs.Length > 0)
                    {
                        flag = true;
                    }
                    //关闭写入
                    fs.Flush();
                    fs.Close();

                    MessageBox.Show("导入成功");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                //返回错误消息

            }
            return flag;
        }
    }
  
}

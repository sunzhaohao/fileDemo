using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDemo.Window
{
    public partial class LogInWindow : Form
    {
        private bool loginSuccess=false;
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void LogInWindow_Load(object sender, EventArgs e)
        {

        }

        public bool getLoginResult()
        {
            return loginSuccess;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loginSuccess = ifCanLogin(textBoxName.Text, textBoxPassword.Text);
            this.Close();
        }

        private bool ifCanLogin(String name,String passwd)
        {

            return true;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginSuccess = false;
            this.Close();
        }
    }
}

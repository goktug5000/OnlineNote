using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace OnlineNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool testt()
        {
            string google = "https://www.google.com/";
            try
            {
                WebRequest istek = WebRequest.Create(google);
                WebResponse yanit = istek.GetResponse();

            }
            catch
            {
                return false;
            }
            return true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (testt() == true)
            {
                MessageBox.Show("net var");
            }
            else
            {
                MessageBox.Show("net yok");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate("http://www.itextpad.com/anBLXVfSxc");
                
            }
            catch
            {
                
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=webBrowser1.Document.GetElementById("formPad").InnerText;
            webBrowser1.Document.GetElementById("formPad").InnerText = webBrowser1.Document.GetElementById("formPad").InnerText + richTextBox2.Text;
        }
    }
}

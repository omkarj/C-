using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApplicationDemo
{
    public partial class StudentDataForm : Form
    {
        public StudentDataForm()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void StudentDataForm_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;
            webBrowser1.GoHome();
        }
    }
}

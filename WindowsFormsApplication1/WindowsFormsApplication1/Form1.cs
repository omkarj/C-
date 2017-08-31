using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
           
            try
            {
                myLibrary helper = new myLibrary();
                helper.MyProgram(openFileDialog1.FileName, "This is Manu and Omkar");
            }
            catch (Exception)
            {
                MessageBox.Show("ACCESS DENIED");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.ShowDialog();

            try
            {
                myLibrary helper = new myLibrary();
                helper.MyProgramRead(openFileDialog2.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("ACCESS DENIED");
            }
        }
    }
}

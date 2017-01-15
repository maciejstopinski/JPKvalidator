using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPKvalidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenFile()
        {
            OpenFileDialog openMyFile = new OpenFileDialog();

            //openMyFile.InitialDirectory = "c:\\";
            openMyFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|xml files (*.xml)|*.xml";
            openMyFile.FilterIndex = 2;
            openMyFile.RestoreDirectory = true;

            if (openMyFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //ReadXML(openMyFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void otwóżToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
    }
}

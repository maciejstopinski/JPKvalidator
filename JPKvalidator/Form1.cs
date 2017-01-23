using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JPKvalidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<JPK> listaJPK;
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
                    ReadXML(openMyFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        private void ReadXML(string fileName)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(fileName);
                       
            using (xmlFile)
            {
                JPK jpkItem= new JPK();
                jpkItem.AddNaglowek("JPK_VAT (1)", "1-0", "JPK_VAT", "1","1", "2016 - 11 - 30T09: 21:22", "2016-10-01", "2016-10-31","PLN","1473");
                xmlFile.ReadToFollowing("tns:KodFormularza");
                string genre = xmlFile.ReadElementContentAsString();
                MessageBox.Show(genre);
               
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

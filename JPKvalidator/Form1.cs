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
        private List<JPK> listaJPK= new List<JPK>();
        private JPK jpkItem = new JPK();
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
            #region testy
            //jpkItem.AddNaglowek("JPK_VAT (1)", "1-0", "JPK_VAT", "1","1", "2016 - 11 - 30T09: 21:22", "2016-10-01", "2016-10-31","PLN","1473");
            //jpkItem.AddPodmiot1("7393855178", "DONLIN SPÓŁKA Z OGRANICZONĄ ODPOWIEDZIALNOŚCIĄ", "281407100", "PL", "WARMIŃSKO-MAZURSKIE", "BRAK" , "BRAK", "JAGIELLOŃSKA","37","","OLSZTYN", "10-273","OLSZTYN");

            //jpkItem.AddJPKSprzedarzWiersz();
            //jpkItem.AddJPKSprzedarzWiersz();
            //jpkItem.AddJPKSprzedarzWiersz();


            //xmlFile.ReadToFollowing("etd:NIP");
            //jpkItem.Podmiot1.IdentyfikatorPodmiotu.NIP = xmlFile.ReadElementContentAsString();

            //xmlFile.ReadToFollowing("kodSystemowy");
            //jpkItem.Naglowek.KodFormularza.kodSystemowy = xmlFile.ReadElementContentAsString();
            //xmlFile.ReadToFollowing("wersjaSchemy");
            //jpkItem.Naglowek.KodFormularza.wersjaSchemy = xmlFile.ReadElementContentAsString();
            //xmlFile.ReadToFollowing("tns:KodFormularza");
            //jpkItem.Naglowek.KodFormularza.Value = (TKodFormularza)Enum.Parse(typeof(TKodFormularza), xmlFile.ReadElementContentAsString());
            //xmlFile.ReadToFollowing("tns:WariantFormularza");
            //jpkItem.Naglowek.WariantFormularza = Convert.ToSByte(xmlFile.ReadElementContentAsString());
            //xmlFile.ReadToFollowing("tns:CelZlozenia");
            //jpkItem.Naglowek.CelZlozenia = Convert.ToSByte(xmlFile.ReadElementContentAsString());
            //xmlFile.ReadToFollowing("tns:DataWytworzeniaJPK");
            //jpkItem.Naglowek.DataWytworzeniaJPK = xmlFile.ReadElementContentAsDateTime();
            //xmlFile.ReadToFollowing("tns:DataOd");
            //jpkItem.Naglowek.DataOd = xmlFile.ReadElementContentAsDateTime();
            //xmlFile.ReadToFollowing("tns:DataDo");
            //jpkItem.Naglowek.DataDo = xmlFile.ReadElementContentAsDateTime();
            //xmlFile.ReadToFollowing("tns:DomyslnyKodWaluty");
            //jpkItem.Naglowek.DomyslnyKodWaluty = (currCode_Type)Enum.Parse(typeof(currCode_Type), xmlFile.ReadElementContentAsString());
            //xmlFile.ReadToFollowing("tns:KodUrzedu");
            //jpkItem.Naglowek.KodUrzedu = (TKodUS)Enum.Parse(typeof(TKodUS), xmlFile.ReadElementContentAsString());
            #endregion

            ReadNaglowek(fileName);
            ReadPodmiot1(fileName);


            listaJPK.Add(jpkItem);
            jpkItem = null;
            MessageBox.Show(":)");

        }
        private void ReadNaglowek(string fileName)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(fileName);
            string kodSystemowy="";
            string wersjaSchemy = "";
            string kodFormularza = "";
            string WariantFormularza = "";
            string CelZlozenia = "";
            string DataWytworzeniaJPK = "";
            string DataOd = "";
            string DataDo = "";
            string DomyslnyKodWaluty = "";
            string KodUrzedu = "";
            using (xmlFile)
            {
                             
                while (xmlFile.Read())
                {
                    // Only detect start elements.
                    if (xmlFile.IsStartElement())
                    {
                        // Get element name and switch on it.
                        switch (xmlFile.Name)
                        {
                            case @"tns:JPK":
                                // Detect this element.
                                //MessageBox.Show("Czytam plik JPK");
                                break;
                            case @"tns:Naglowek":
                                // Detect this element.
                                //output += "Start <tns:Naglowek> element.\r\n";
                                break;
                            case @"tns:KodFormularza":
                                // Detect this article element.
                                //output += "Start <tns:KodFormularza> element.\r\n";
                                // Search for the attribute name on this current node.
                                string attribute = xmlFile["kodSystemowy"];
                                if (attribute != null)
                                {
                                    kodSystemowy = attribute;
                                }
                                attribute = xmlFile["wersjaSchemy"];
                                if (attribute != null)
                                {
                                    wersjaSchemy = attribute;
                                }
                                // Next read will contain text.
                                if (xmlFile.Read())
                                {
                                    kodFormularza =  xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:WariantFormularza":
                                if (xmlFile.Read())
                                {
                                    WariantFormularza = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:CelZlozenia":
                                if (xmlFile.Read())
                                {
                                    CelZlozenia = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:DataWytworzeniaJPK":
                                if (xmlFile.Read())
                                {
                                    DataWytworzeniaJPK = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:DataOd":
                                if (xmlFile.Read())
                                {
                                    DataOd = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:DataDo":
                                if (xmlFile.Read())
                                {
                                    DataDo = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:DomyslnyKodWaluty":
                                if (xmlFile.Read())
                                {
                                    DomyslnyKodWaluty = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:KodUrzedu":
                                if (xmlFile.Read())
                                {
                                    KodUrzedu = xmlFile.Value.Trim();
                                }
                                break;

                        }
                                               
                    }
                }
            }
            jpkItem.AddNaglowek(kodSystemowy,wersjaSchemy,kodFormularza,WariantFormularza,CelZlozenia,DataWytworzeniaJPK,DataOd,DataDo,DomyslnyKodWaluty,KodUrzedu);
        }
        private void ReadPodmiot1(string fileName)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(fileName);
            string nIP="";
            string pelnaNazwa = "";
            string rEGON = "";
            string kodKraju = "";
            string wojewodztwo = "";
            string powiat = "";
            string gmina = "";
            string ulica = "";
            string nrDomu = "";
            string nrLokalu = "";
            string miejscowosc = "";
            string kodPocztowy = "";
            string poczta = "";
            using (xmlFile)
            {

                while (xmlFile.Read())
                {
                    // Only detect start elements.
                    if (xmlFile.IsStartElement())
                    {
                        // Get element name and switch on it.
                        switch (xmlFile.Name)
                        {
                            case @"etd:NIP":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    nIP = xmlFile.Value.Trim();
                                }
                                break;
                            case @"etd:PelnaNazwa":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    pelnaNazwa = xmlFile.Value.Trim();
                                }
                                break;
                            case @"etd:REGON":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    rEGON = xmlFile.Value.Trim();
                                }
                                break;
                            case @"etd:KodKraju":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    kodKraju = xmlFile.Value.Trim();
                                }
                                break;
                            case @"etd:Wojewodztwo":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    wojewodztwo = xmlFile.Value.Trim();
                                }
                                break;
                            case @"etd:Powiat":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    powiat = xmlFile.Value.Trim();
                                }
                                break;
                            case @"etd:Gmina":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    gmina = xmlFile.Value.Trim();
                                }
                                break;
                            case @"etd:Ulica":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    ulica = xmlFile.Value.Trim();
                                }
                                break;
                            case @"etd:NrDomu":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    nrDomu = xmlFile.Value.Trim();
                                }
                                break;
                            case @"etd:NrLokalu":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    nrLokalu = xmlFile.Value.Trim();
                                }
                                break;
                            case @"etd:Miejscowosc":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    miejscowosc = xmlFile.Value.Trim();
                                }
                                break;
                            case @"etd:KodPocztowy":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    kodPocztowy = xmlFile.Value.Trim();
                                }
                                break;
                            case @"etd:Poczta":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    poczta = xmlFile.Value.Trim();
                                }
                                break;


                        }

                    }
                }
            }
        
             jpkItem.AddPodmiot1(nIP, pelnaNazwa, rEGON, kodKraju, wojewodztwo, powiat, gmina, ulica, nrDomu, nrLokalu, miejscowosc, kodPocztowy, poczta);
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

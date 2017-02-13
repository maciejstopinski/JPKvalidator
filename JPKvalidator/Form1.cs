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
using System.Xml.Linq;

namespace JPKvalidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<JPK> listaJPK= new List<JPK>();
        private JPK jpkItem;
        private ListViewItem jpkListViewItem;

        private void OpenFile()
        {
            OpenFileDialog openMyFile = new OpenFileDialog();

            //openMyFile.InitialDirectory = "c:\\";
            openMyFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|xml files (*.xml)|*.xml";
            openMyFile.FilterIndex = 2;
            openMyFile.RestoreDirectory = true;
            openMyFile.Multiselect = true;


            if (openMyFile.ShowDialog() == DialogResult.OK)
            {
                //string fileName = openMyFile.FileName;
                foreach (string fileName in openMyFile.FileNames)
                {
                    try
                    {
                        ReadXML(fileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
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
            jpkItem = new JPK();

            ReadNaglowek(fileName);
            ReadPodmiot1(fileName);
            ReadSprzedaz(fileName);
            ReadSprzedazCtrl(fileName);
            ReadZakupy(fileName);
            ReadZakupyCtrl(fileName);
            listaJPK.Add(jpkItem);
            jpkItem = null;
            listVievFill(listaJPK);
          

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
                            case @"tns:KodKraju":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    kodKraju = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:Wojewodztwo":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    wojewodztwo = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:Powiat":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    powiat = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:Gmina":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    gmina = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:Ulica":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    ulica = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:NrDomu":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    nrDomu = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:NrLokalu":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    nrLokalu = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:Miejscowosc":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    miejscowosc = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:KodPocztowy":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    kodPocztowy = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:Poczta":
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
        private void ReadSprzedaz(string fileName)
        {

           
            XElement root = XElement.Load(fileName);
            //XNamespace aw = "http://jpk.mf.gov.pl/wzor/2016/03/09/03094/";
            XNamespace aw = root.GetNamespaceOfPrefix("tns");
            IEnumerable<XElement> sprzedaz =
                from wiersz in root.Elements(aw+"SprzedazWiersz")
                select wiersz;
            foreach (XElement wiersz in sprzedaz)
            {
                string lpSprzedazy = (string)wiersz.Element(aw+"LpSprzedazy");
                string nrKontrahenta = (string)wiersz.Element(aw + "NrKontrahenta");
                string nazwaKontrahenta = (string)wiersz.Element(aw + "NazwaKontrahenta");
                string adresKontrahenta = (string)wiersz.Element(aw + "AdresKontrahenta");
                string dowodSprzedazy = (string)wiersz.Element(aw + "DowodSprzedazy");
                string dataWystawienia = (string)wiersz.Element(aw + "DataWystawienia");
                string dataSprzedazy = (string)wiersz.Element(aw + "DataSprzedazy");
                string k_10 = (string)wiersz.Element(aw + "K_10");
                string k_11 = (string)wiersz.Element(aw + "K_11");
                string k_12 = (string)wiersz.Element(aw + "K_12");
                string k_13 = (string)wiersz.Element(aw + "K_13");
                string k_14 = (string)wiersz.Element(aw + "K_14");
                string k_15 = (string)wiersz.Element(aw + "K_15");
                string k_16 = (string)wiersz.Element(aw + "K_16");
                string k_17 = (string)wiersz.Element(aw + "K_17");
                string k_18 = (string)wiersz.Element(aw + "K_18");
                string k_19 = (string)wiersz.Element(aw + "K_19");
                string k_20 = (string)wiersz.Element(aw + "K_20");
                string k_21 = (string)wiersz.Element(aw + "K_21");
                string k_22 = (string)wiersz.Element(aw + "K_22");
                string k_23 = (string)wiersz.Element(aw + "K_23");
                string k_24 = (string)wiersz.Element(aw + "K_24");
                string k_25 = (string)wiersz.Element(aw + "K_25");
                string k_26 = (string)wiersz.Element(aw + "K_26");
                string k_27 = (string)wiersz.Element(aw + "K_27");
                string k_28 = (string)wiersz.Element(aw + "K_28");
                string k_29 = (string)wiersz.Element(aw + "K_29");
                string k_30 = (string)wiersz.Element(aw + "K_30");
                string k_31 = (string)wiersz.Element(aw + "K_31");
                string k_32 = (string)wiersz.Element(aw + "K_32");
                string k_33 = (string)wiersz.Element(aw + "K_33");
                string k_34 = (string)wiersz.Element(aw + "K_34");
                string k_35 = (string)wiersz.Element(aw + "K_35");
                string k_36 = (string)wiersz.Element(aw + "K_36");
                string k_37 = (string)wiersz.Element(aw + "K_37");
                string k_38 = (string)wiersz.Element(aw + "K_38");
                string k_39 = (string)wiersz.Element(aw + "K_39");
                string typ=wiersz.Attribute("typ").Value;
                jpkItem.AddJPKSprzedazWiersz(
                                                lpSprzedazy, nrKontrahenta, nazwaKontrahenta, adresKontrahenta, dowodSprzedazy, dataWystawienia, dataSprzedazy, k_10, k_11, k_12, k_13, k_14,
                                                k_15, k_16, k_17, k_18, k_19, k_20, k_21, k_22, k_23, k_24, k_25, k_26, k_27, k_28, k_29, k_30, k_31, k_32, k_33, k_34, k_35, k_36, k_37, k_38, k_39, typ);
              

            }





        }
        private void ReadSprzedazCtrl(string fileName)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(fileName);
            string liczbaWierszySprzedazy = "";
            string podatekNalezny = "";
            using (xmlFile)
            {

                while (xmlFile.Read())
                {
                    // Only detect start elements.
                    if (xmlFile.IsStartElement())
                    {
                       switch (xmlFile.Name)
                       { 
                            case @"tns:LiczbaWierszySprzedazy":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    liczbaWierszySprzedazy = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:PodatekNalezny":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    podatekNalezny = xmlFile.Value.Trim();
                                }
                                break;


                        }

                    }
                }
            }
            jpkItem.AddJPKSprzedazCtrl(liczbaWierszySprzedazy, podatekNalezny);
        }
        private void ReadZakupy(string fileName)
        {
            XElement root = XElement.Load(fileName);
            XNamespace aw = root.GetNamespaceOfPrefix("tns");
            IEnumerable<XElement> sprzedaz =
                from wiersz in root.Elements(aw + "ZakupWiersz")
                select wiersz;
            foreach (XElement wiersz in sprzedaz)
            {
                string lpZakupu = (string)wiersz.Element(aw + "LpZakupu");
                string nrDostawcy = (string)wiersz.Element(aw + "NrDostawcy");
                string nazwaDostawcy = (string)wiersz.Element(aw + "NazwaDostawcy");
                string adresDostawcy = (string)wiersz.Element(aw + "AdresDostawcy");
                string dowodZakupu = (string)wiersz.Element(aw + "DowodZakupu");
                string dataZakupu = (string)wiersz.Element(aw + "DataZakupu");
                string dataWplywu = (string)wiersz.Element(aw + "DataWplywu");
                string k_43 = (string)wiersz.Element(aw + "K_43");
                string k_44 = (string)wiersz.Element(aw + "K_44");
                string k_45 = (string)wiersz.Element(aw + "K_45");
                string k_46 = (string)wiersz.Element(aw + "K_46");
                string k_47 = (string)wiersz.Element(aw + "K_47");
                string k_48 = (string)wiersz.Element(aw + "K_48");
                string k_49 = (string)wiersz.Element(aw + "K_49");
                string k_50 = (string)wiersz.Element(aw + "K_50");
                string typ = wiersz.Attribute("typ").Value;
                jpkItem.AddJPKZakupWiersz(lpZakupu,nrDostawcy,nazwaDostawcy,adresDostawcy,dowodZakupu,
                                        dataZakupu,dataWplywu,k_43,k_44,k_45,k_46,k_47,
                                        k_48,k_49,k_50,typ);
            }
        }
        private void ReadZakupyCtrl(string fileName)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(fileName);
            string liczbaWierszyZakupow = "";
            string podatekNaliczony = "";
            using (xmlFile)
            {

                while (xmlFile.Read())
                {
                    // Only detect start elements.
                    if (xmlFile.IsStartElement())
                    {
                        switch (xmlFile.Name)
                        {
                            case @"tns:LiczbaWierszyZakupow":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    liczbaWierszyZakupow = xmlFile.Value.Trim();
                                }
                                break;
                            case @"tns:PodatekNaliczony":
                                // Detect this element.
                                if (xmlFile.Read())
                                {
                                    podatekNaliczony = xmlFile.Value.Trim();
                                }
                                break;


                        }

                    }
                }
            }
            jpkItem.AddJPKZakupCtrl(liczbaWierszyZakupow,podatekNaliczony);
        }
        private void listVievFill(List<JPK> listaJPK)
        {
            listJPK.Items.Clear();
            int i = 0;
            foreach (var item in listaJPK)
            {
                i++;
                string[] arr = new string[16];
                arr[0] = i.ToString();
                arr[1] = item.Podmiot1.IdentyfikatorPodmiotu.PelnaNazwa;
                arr[2] = item.Podmiot1.IdentyfikatorPodmiotu.NIP;
                arr[3] = item.Podmiot1.IdentyfikatorPodmiotu.REGON;
                arr[4] = item.Naglowek.DataOd.ToShortDateString();
                arr[5] = item.Naglowek.DataDo.ToShortDateString();
                arr[6] = item.ZakupCtrl.LiczbaWierszyZakupow;
                arr[7] = item.ZakupCtrl.PodatekNaliczony.ToString();
                arr[8] = item.SprzedazCtrl.LiczbaWierszySprzedazy;
                arr[9] = item.SprzedazCtrl.PodatekNalezny.ToString();
                arr[10] = item.Naglowek.CelZlozenia.ToString();
                arr[11] = item.Naglowek.KodUrzedu.ToString();
                arr[12] = item.Naglowek.DataWytworzeniaJPK.ToShortDateString() + " " + item.Naglowek.DataWytworzeniaJPK.ToLongTimeString();
                arr[13] = item.Naglowek.KodFormularza.kodSystemowy.ToString()+" "+ item.Naglowek.KodFormularza.wersjaSchemy.ToString()+" "+ item.Naglowek.KodFormularza.Value.ToString();
                arr[14] = item.Naglowek.WariantFormularza.ToString();
                arr[15] = item.Naglowek.DomyslnyKodWaluty.ToString();
                jpkListViewItem = new ListViewItem(arr);
                listJPK.Items.Add(jpkListViewItem);
               
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
          

        private void btnUsun_Click(object sender, EventArgs e)
        {
             List<int> zaznaczenie=new List<int>();


            for (int i = 0; i < listJPK.Items.Count; i++)
            {
                if (listJPK.Items[i].Checked)
                {
                    zaznaczenie.Add(i);                   
                }
               
            }
            zaznaczenie.Sort();
            zaznaczenie.Reverse();
            for (int nr=0;nr< zaznaczenie.Count; nr++)
            {
                listaJPK.RemoveAt(zaznaczenie[nr]);
            }
            listVievFill(listaJPK);
        }
    }
}

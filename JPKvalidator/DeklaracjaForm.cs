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
    public partial class DeklaracjaForm : Form
    {
        public List<JPK> listaJPK = new List<JPK>();
        decimal[] sumy = new decimal[51];
        private ListViewItem jpkListViewItem;

        public DeklaracjaForm(List<JPK> input)
        {
            InitializeComponent();
            listaJPK = input;
            sumy = Sumuj();
            Wypelnij();
            
        }
        private decimal[] Sumuj()
        {
            decimal[] suma = new decimal[51];
            List<JPKSprzedazWiersz> listaSprzedazy = new List<JPKSprzedazWiersz>();
            List<JPKZakupWiersz> listaZakupow = new List<JPKZakupWiersz>();
            for (int nr = 0; nr < listaJPK.Count; nr++)
            {
                foreach (var item in listaJPK[nr].SprzedazWiersz)
                {
                    listaSprzedazy.Add(item);
                }
                foreach (var item in listaJPK[nr].ZakupWiersz)
                {
                    listaZakupow.Add(item);
                }
            }
            foreach (var item in listaSprzedazy)
            {
               
                suma[10] += item.K_10;
                suma[11] += item.K_11;
                suma[12] += item.K_12;
                suma[13] += item.K_13;
                suma[14] += item.K_14;
                suma[15] += item.K_15;
                suma[16] += item.K_16;
                suma[17] += item.K_17;
                suma[18] += item.K_18;
                suma[19] += item.K_19;
                suma[20] += item.K_20;
                suma[21] += item.K_21;
                suma[22] += item.K_22;
                suma[23] += item.K_23;
                suma[24] += item.K_24;
                suma[25] += item.K_25;
                suma[26] += item.K_26;
                suma[27] += item.K_27;
                suma[28] += item.K_28;
                suma[29] += item.K_29;
                suma[30] += item.K_30;
                suma[31] += item.K_31;
                suma[32] += item.K_32;
                suma[33] += item.K_33;
                suma[34] += item.K_34;
                suma[35] += item.K_35;
                suma[36] += item.K_36;
                suma[37] += item.K_37;
                suma[38] += item.K_38;
                suma[39] += item.K_39;
            }
            foreach (var item in listaZakupow)
            {

                suma[43] += item.K_43;
                suma[44] += item.K_44;
                suma[45] += item.K_45;
                suma[46] += item.K_46;
                suma[47] += item.K_47;
                suma[48] += item.K_48;
                suma[49] += item.K_49;
                suma[50] += item.K_50;
            }



                return suma;
        }
        private void listVievFill(List<JPK> listaJPK)
        {
            listJPK.Items.Clear();
            int i = 0;
            foreach (var item in listaJPK)
            {
                i++;
                string[] arr = new string[12];
                arr[0] = i.ToString();
                arr[1] = item.Podmiot1.IdentyfikatorPodmiotu.PelnaNazwa;
                arr[2] = item.Podmiot1.IdentyfikatorPodmiotu.NIP;
                arr[3] = item.Podmiot1.IdentyfikatorPodmiotu.REGON;
                arr[4] = item.Naglowek.DataOd.ToShortDateString();
                arr[5] = item.Naglowek.DataDo.ToShortDateString();
                arr[6] = item.Naglowek.CelZlozenia.ToString();
                arr[7] = item.Naglowek.KodUrzedu.ToString();
                arr[8] = item.Naglowek.DataWytworzeniaJPK.ToShortDateString() + " " + item.Naglowek.DataWytworzeniaJPK.ToLongTimeString();
                arr[9] = item.Naglowek.KodFormularza.kodSystemowy.ToString() + " " + item.Naglowek.KodFormularza.wersjaSchemy.ToString() + " " + item.Naglowek.KodFormularza.Value.ToString();
                arr[10] = item.Naglowek.WariantFormularza.ToString();
                arr[11] = item.Naglowek.DomyslnyKodWaluty.ToString();
                jpkListViewItem = new ListViewItem(arr);
                listJPK.Items.Add(jpkListViewItem);

            }
        }
        private void Wypelnij()
        {
            listVievFill(listaJPK);
            textk10.Text = sumy[10].ToString();
            textk11.Text = sumy[11].ToString();
            textk12.Text = sumy[12].ToString();
            textk13.Text = sumy[13].ToString();
            textk14.Text = sumy[14].ToString();
            textk15.Text = sumy[15].ToString();
            textk16.Text = sumy[16].ToString();
            textk17.Text = sumy[17].ToString();
            textk18.Text = sumy[18].ToString();
            textk19.Text = sumy[19].ToString();
            textk20.Text = sumy[20].ToString();
            textk21.Text = sumy[21].ToString();
            textk22.Text = sumy[22].ToString();
            textk23.Text = sumy[23].ToString();
            textk24.Text = sumy[24].ToString();
            textk25.Text = sumy[25].ToString();
            textk26.Text = sumy[26].ToString();
            textk27.Text = sumy[27].ToString();
            textk28.Text = sumy[28].ToString();
            textk29.Text = sumy[29].ToString();
            textk30.Text = sumy[30].ToString();
            textk31.Text = sumy[31].ToString();
            textk32.Text = sumy[32].ToString();
            textk33.Text = sumy[33].ToString();
            textk34.Text = sumy[34].ToString();
            textk35.Text = sumy[35].ToString();
            textk36.Text = sumy[36].ToString();
            textk37.Text = sumy[37].ToString();
            textk38.Text = sumy[38].ToString();
            textk39.Text = sumy[39].ToString();
            textk43.Text = sumy[43].ToString();
            textk44.Text = sumy[44].ToString();
            textk45.Text = sumy[45].ToString();
            textk46.Text = sumy[46].ToString();
            textk47.Text = sumy[47].ToString();
            textk48.Text = sumy[48].ToString();
            textk49.Text = sumy[49].ToString();
            textk50.Text = sumy[50].ToString();

        }


    }
}

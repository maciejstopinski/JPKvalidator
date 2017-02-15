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
    public partial class SprzedazForm : Form
    {
        public List<JPKSprzedazWiersz> listaSprzedazy = new List<JPKSprzedazWiersz>();
        private ListViewItem wierszSprzedazy = new ListViewItem();
        private decimal[] suma = new decimal[39]; 
        public SprzedazForm(List<JPKSprzedazWiersz>lista)
        {
            InitializeComponent();
            listaSprzedazy = lista;
        }

        private void SprzedazForm_Load(object sender, EventArgs e)
        {
            listVievFill(listaSprzedazy);
           
            
        }
        private void listVievFill(List<JPKSprzedazWiersz> listaSprzedazy)
        {
            //l.Items.Clear();
            int i = 0;
            foreach (var item in listaSprzedazy)
            {
                i++;
                string[] arr = new string[39];
                arr[0] = i.ToString();
                arr[1] = item.LpSprzedazy.ToString();
                arr[2] = item.NrKontrahenta.ToString();
                arr[3] = item.NazwaKontrahenta.ToString();
                arr[4] = item.AdresKontrahenta.ToString();
                arr[5] = item.DowodSprzedazy.ToString();
                arr[6] = item.DataWystawienia.ToShortDateString();
                arr[7] = item.DataSprzedazy.ToShortDateString();
                arr[8] = item.K_10.ToString(); suma[8] += item.K_10;
                arr[9] = item.K_11.ToString(); suma[9] += item.K_11;
                arr[10] = item.K_12.ToString(); suma[10] += item.K_12;
                arr[11] = item.K_13.ToString(); suma[11] += item.K_13;
                arr[12] = item.K_14.ToString(); suma[12] += item.K_14;
                arr[13] = item.K_15.ToString(); suma[13] += item.K_15;
                arr[14] = item.K_16.ToString(); suma[14] += item.K_16;
                arr[15] = item.K_17.ToString(); suma[15] += item.K_17;
                arr[16] = item.K_18.ToString(); suma[16] += item.K_18;
                arr[17] = item.K_19.ToString(); suma[17] += item.K_19;
                arr[18] = item.K_20.ToString(); suma[18] += item.K_20;
                arr[19] = item.K_21.ToString(); suma[19] += item.K_21;
                arr[20] = item.K_22.ToString(); suma[20] += item.K_22;
                arr[21] = item.K_23.ToString(); suma[21] += item.K_23;
                arr[22] = item.K_24.ToString(); suma[22] += item.K_24;
                arr[23] = item.K_25.ToString(); suma[23] += item.K_25;
                arr[24] = item.K_26.ToString(); suma[24] += item.K_26;
                arr[25] = item.K_27.ToString(); suma[25] += item.K_27;
                arr[26] = item.K_28.ToString(); suma[26] += item.K_28;
                arr[27] = item.K_29.ToString(); suma[26] += item.K_29;
                arr[28] = item.K_30.ToString(); suma[28] += item.K_30;
                arr[29] = item.K_31.ToString(); suma[27] += item.K_31;
                arr[30] = item.K_32.ToString(); suma[30] += item.K_32;
                arr[31] = item.K_33.ToString(); suma[31] += item.K_33;
                arr[32] = item.K_34.ToString(); suma[32] += item.K_34;
                arr[33] = item.K_35.ToString(); suma[33] += item.K_35;
                arr[34] = item.K_36.ToString(); suma[34] += item.K_36;
                arr[35] = item.K_37.ToString(); suma[35] += item.K_37;
                arr[36] = item.K_38.ToString(); suma[36] += item.K_38;
                arr[37] = item.K_39.ToString(); suma[37] += item.K_39;
                arr[38] = item.typ.ToString();

                wierszSprzedazy = new ListViewItem(arr);
                listViewSprzedaz.Items.Add(wierszSprzedazy);

            }
            string[] sumaS = new string[39];


           for (i=0;i<39;i++)
            {
                if (i > 7 && i < 38)
                {
                    sumaS[i] = suma[i].ToString();
                }
                else
                    sumaS[i] = "";
            }


            
            wierszSprzedazy = new ListViewItem(sumaS);
            
            listViewSprzedaz.Items.Add(wierszSprzedazy);
            int last = listViewSprzedaz.Items.Count-1;
            listViewSprzedaz.Items[last].Font = new Font(listViewSprzedaz.Font, FontStyle.Bold);


        }

    }
}

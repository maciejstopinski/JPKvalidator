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
    public partial class ZakupyForm : Form
    {
        private List<JPKZakupWiersz> listaZakupow = new List<JPKZakupWiersz>();
        private ListViewItem wierszZakupu = new ListViewItem();
        private decimal[] suma = new decimal[17];
        public ZakupyForm(List<JPKZakupWiersz> lista)
        {
            InitializeComponent();
            listaZakupow = lista;
        }

        private void ZakupyForm_Load(object sender, EventArgs e)
        {
            listVievFill(listaZakupow);
        }

        private void listVievFill(List<JPKZakupWiersz> listaZakupow)
        {
            int i = 0;
            foreach (var item in listaZakupow)
            {
                i++;
                string[] arr = new string[17];
                arr[0] = i.ToString();
                arr[1] = item.LpZakupu.ToString();
                arr[2] = item.NrDostawcy.ToString();
                arr[3] = item.NazwaDostawcy.ToString();
                arr[4] = item.AdresDostawcy.ToString();
                arr[5] = item.DowodZakupu.ToString();
                arr[6] = item.DataZakupu.ToShortDateString();
                arr[7] = item.DataWplywu.ToShortDateString();
                arr[8] = item.K_43.ToString(); suma[8] += item.K_43;
                arr[9] = item.K_44.ToString(); suma[9] += item.K_44;
                arr[10] = item.K_45.ToString(); suma[10] += item.K_45;
                arr[11] = item.K_46.ToString(); suma[11] += item.K_46;
                arr[12] = item.K_47.ToString(); suma[12] += item.K_47;
                arr[13] = item.K_48.ToString(); suma[13] += item.K_48;
                arr[14] = item.K_49.ToString(); suma[14] += item.K_49;
                arr[15] = item.K_50.ToString(); suma[15] += item.K_50;
                arr[16] = item.typ.ToString();


                wierszZakupu = new ListViewItem(arr);
                listViewZakupy.Items.Add(wierszZakupu);

            }
            string[] sumaS = new string[17];


            for (i = 0; i < 17; i++)
            {
                if (i > 7 && i < 16)
                {
                    sumaS[i] = suma[i].ToString();
                }
                else
                    sumaS[i] = "";
            }



            wierszZakupu = new ListViewItem(sumaS);

            listViewZakupy.Items.Add(wierszZakupu);
            int last = listViewZakupy.Items.Count - 1;
            listViewZakupy.Items[last].Font = new Font(listViewZakupy.Font, FontStyle.Bold);

        }
    }
}

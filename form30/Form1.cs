using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtArama.Text;
            int sayac = 0;
            for (int i = 0; i < lbİsimler.Items.Count; i++)
            {
                if (aranan == lbİsimler.Items[i].ToString())
                {
                    sayac++;
                }
            }
            if (sayac == 0)
            {
                lblSonuc.Text = "Kişi Bulunamadı";
            }
            else
            {
                lblSonuc.Text = sayac + "  Kişi Bulundu";
            }
        }
    }
}
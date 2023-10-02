using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taksitorn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat, taksitsayisi, taksittutari;
            fiyat=Convert.ToDouble(txtFiyat.Text);
            taksitsayisi = Convert.ToDouble(tbTaskitSayisi.Value);
            taksittutari = fiyat / taksitsayisi;

            lblTaksitTutari.Text = taksittutari.ToString();
        }
    }
}

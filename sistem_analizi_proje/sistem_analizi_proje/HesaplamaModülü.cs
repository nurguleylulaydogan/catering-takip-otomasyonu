using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistem_analizi_proje
{
    public partial class HesaplamaModülü : Form
    {
        public HesaplamaModülü()
        {
            InitializeComponent();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            if (radioButtonGram.Checked==true)
            {
                var tutar = Hesaplama.islem(int.Parse(textBoxMiktar.Text), int.Parse(textBoxFiyat.Text));
                labelyazdır.Text = tutar.ToString();
            }

            else if (radioButtonKg.Checked==true)
            {
                var tutar = Hesaplama.islem(int.Parse(textBoxMiktar.Text), int.Parse(textBoxFiyat.Text));
                labelyazdır.Text = tutar.ToString();
            }

           else if (radioButtonAdet.Checked==true)
            {
                var tutar = Hesaplama.islem(int.Parse(textBoxMiktar.Text), int.Parse(textBoxFiyat.Text));
                labelyazdır.Text = tutar.ToString();
            }

            else
            {
                MessageBox.Show("Yanlış seçim yapıldı.");
            }
        }

    private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSifirla_Click(object sender, EventArgs e)
        {
            textBoxMiktar.Text = "";
            textBoxFiyat.Text = "";
            labelyazdır.Text = "";
        }

        private void HesaplamaModülü_Load(object sender, EventArgs e)
        {
            this.Text = "Hesapla";
        }
    }
}

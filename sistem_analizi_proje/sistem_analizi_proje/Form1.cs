using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sistem_analizi_proje
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        public static string Id, Ad, Soyad, Yetki;

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGiris_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand komut = new SqlCommand("select * from YemekGiris", Con);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read() == true)
            {
                if (radioButtonPersonel.Checked == true)
                {
                    if (rdr["Ad"].ToString() == textBoxAd.Text && rdr["Sifre"].ToString() == textBoxSifre.Text && rdr["Yetki"].ToString() == "Personel")
                    {
                        durum = true;
                        FormGiris Giris = new FormGiris();
                        Giris.Show();
                        break;
                    }
                }

            }
            Con.Close();
        }

        bool durum = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "GİRİŞ MENÜSÜ";
            this.AcceptButton = buttonGiris;
            this.CancelButton = buttonKapat;
            radioButtonPersonel.Checked = true;

        }
    }
}

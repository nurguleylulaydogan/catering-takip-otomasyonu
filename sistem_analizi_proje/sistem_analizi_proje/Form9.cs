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
    public partial class Form9 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        private void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select*from Maliyet", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Con.Close();
        }
        public Form9()
        {
            InitializeComponent();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            var tutar = Hesaplama.islem(int.Parse(textBoxMiktar.Text), int.Parse(textBoxFiyat.Text));
            labelyazdır.Text = tutar.ToString();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.Text = "TEK KİŞİLİK MALİYET";
            verigoster();
            textBoxMiktar.Text = "1";
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            
            textBoxFiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

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
    public partial class Tahsilat : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        private void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select*from Tahsilat", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView3.DataSource = tablo;
            Con.Close();
        }
        public Tahsilat()
        {
            InitializeComponent();
        }

        private void Tahsilatcs_Load(object sender, EventArgs e)
        {
            this.Text = "TAHSİLAT BİLGİLERİ";
            verigoster();
        }

        private void buttonYTah_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tahsilat(FirmaAd, Tahsilatturu, Tarih, Tahsilat)values(@ad, @tur, @tarih, @tahsilat)", Con);
            komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
            komut.Parameters.AddWithValue("@tur", textBoxTur.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Parse(textBoxTarih.Text));
            komut.Parameters.AddWithValue("@tahsilat", (textBoxTahsilat.Text).ToString());


            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Tahsilat başarıyla kaydedildi");
            verigoster();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tahsilat set FirmaAd=@ad, Tahsilatturu=@tur, Tarih=@tarih, Tahsilat=@tahsilat where Id=@id", Con);
            komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
            komut.Parameters.AddWithValue("@tur", textBoxTur.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Parse(textBoxTarih.Text));
            komut.Parameters.AddWithValue("@tahsilat", (textBoxTahsilat.Text).ToString());
            komut.Parameters.AddWithValue("@id", (textBoxId.Text).ToString());

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from Tahsilat where Id=@id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@id", dataGridView3.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            textBoxId.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBoxTur.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            textBoxTarih.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            textBoxTahsilat.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
        }
    }
}

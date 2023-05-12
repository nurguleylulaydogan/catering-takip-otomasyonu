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
    public partial class Form12 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        private void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select*from Musteriler", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Con.Close();
        }
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

            this.Text = "MÜŞTERİ BİLGİLERİ";

            verigoster();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Musteriler(Ad, Soyad, Unvan, Telefon, Vergidairesi, Birimfiyat)values(@ad, @soyad, @unvan, @tel, @vergi, @fiyat)", Con);
            komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
            komut.Parameters.AddWithValue("@soyad", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@unvan", textBoxUnvan.Text);
            komut.Parameters.AddWithValue("@tel", (textBoxTelefon.Text).ToString());
            komut.Parameters.AddWithValue("@vergi", textBoxVergi.Text);
            komut.Parameters.AddWithValue("@fiyat", (textBoxFiyat.Text).ToString());
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Müşteri başarıyla kaydedildi");
            verigoster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from Musteriler where Id=@Id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Musteriler set Ad=@ad, Soyad=@soyad, Unvan=@unvan, Telefon=@tel, Vergidairesi=@vergi, Birimfiyat=@fiyat where Id=@id", Con);
            komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
            komut.Parameters.AddWithValue("@soyad", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@unvan", textBoxUnvan.Text);
            komut.Parameters.AddWithValue("@tel", (textBoxFiyat.Text).ToString());
            komut.Parameters.AddWithValue("@vergi", textBoxVergi.Text);
            komut.Parameters.AddWithValue("@fiyat", (textBoxFiyat.Text).ToString());
            komut.Parameters.AddWithValue("@id", (textBoxId.Text).ToString());

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxUnvan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxVergi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxFiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}

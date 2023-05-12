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
    public partial class Form10 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        public void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select*from YMlistele", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Con.Close();
        }
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.Text = "İHTİYAÇ LİSTESİ";
            verigoster();
        }

        private void buttonSifirla_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from YMListele where Id=@id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
           
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into YMlistele(Malzeme, Miktar, Birim, Birim_Fiyat, Maliyet)values(@malzeme, @miktar, @birim, @fiyat, @maliyet)", Con);
            komut.Parameters.AddWithValue("@malzeme", textBoxMalzeme.Text);
            komut.Parameters.AddWithValue("@miktar", (textBoxMiktar.Text).ToString());
            komut.Parameters.AddWithValue("@birim", textBoxBirim.Text);
            komut.Parameters.AddWithValue("@fiyat", (textBoxFiyat.Text).ToString());
            komut.Parameters.AddWithValue("@maliyet", (textBoxMaliyet.Text).ToString());


            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("İhtiyaç başarıyla kaydedildi");
            verigoster();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update YMlistele  set Malzeme=@malzeme, Miktar=@miktar, Birim=@birim, Birim_Fiyat=@fiyat, Maliyet=@maliyet where Id=@id", Con);
            komut.Parameters.AddWithValue("@malzeme", textBoxMalzeme.Text);
            komut.Parameters.AddWithValue("@miktar", (textBoxMiktar.Text).ToString());
            komut.Parameters.AddWithValue("@birim", textBoxBirim.Text);
            komut.Parameters.AddWithValue("@fiyat", (textBoxFiyat.Text).ToString());
            komut.Parameters.AddWithValue("@maliyet",(textBoxMaliyet.Text).ToString());
            komut.Parameters.AddWithValue("@id", (textBoxId.Text).ToString());


            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMalzeme.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxMiktar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxBirim.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxFiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxMaliyet.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

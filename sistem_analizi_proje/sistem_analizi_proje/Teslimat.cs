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
    public partial class Teslimat : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        private void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select*from Teslimat", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView2.DataSource = tablo;
            Con.Close();
        }
        public Teslimat()
        {
            InitializeComponent();
        }

        private void Teslimat_Load(object sender, EventArgs e)
        {
            this.Text = "TESLİMAT BİLGİLERİ";
            verigoster();
        }

        private void buttonYTeslimat_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Teslimat(FirmaAd, Adet, Tarih)values(@ad, @adet, @tarih)", Con);
            komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
            komut.Parameters.AddWithValue("@adet", (textBoxAdet.Text).ToString());
            komut.Parameters.AddWithValue("@tarih", DateTime.Parse(textBoxTarih.Text));
            

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Teslimat başarıyla kaydedildi");
            verigoster();
        }

        private void buttonTesDuzelt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Teslimat set FirmaAd=@ad, Adet=@adet, Tarih=@tarih where Id=@id", Con);
            komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
            komut.Parameters.AddWithValue("@adet", (textBoxAdet.Text).ToString());
            komut.Parameters.AddWithValue("@tarih", DateTime.Parse(textBoxTarih.Text));
            komut.Parameters.AddWithValue("@id", (textBoxId.Text).ToString());

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void buttonTesSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from Teslimat where Id=@id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@id", dataGridView2.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBoxAdet.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBoxTarih.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            
        }
    }
}

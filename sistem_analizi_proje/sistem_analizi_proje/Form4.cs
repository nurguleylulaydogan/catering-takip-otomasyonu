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
    public partial class Form4 : System.Windows.Forms.Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        private void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select*from MalzemeAd", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Con.Close();
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "MALZEME LİSTESİ";

            verigoster();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yenimalzeme_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into MalzemeAd(Malzeme_Ad, Birim, Birim_Fiyat, Kritik_Stok, Stok)values(@Malzeme_Ad, @birim, @fiyat, @krtk, @stok)", Con);
            komut.Parameters.AddWithValue("@Malzeme_Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@birim", (textBoxBirim.Text).ToString());
            komut.Parameters.AddWithValue("@fiyat", (textBoxFiyat.Text).ToString());
            komut.Parameters.AddWithValue("@krtk", (textBoxKrtk.Text).ToString());
            komut.Parameters.AddWithValue("@stok", (textBoxStok.Text).ToString());
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Malzeme adı başarıyla kaydedildi");
            verigoster();
        }

        private void duzelt_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("update MalzemeAd set Malzeme_Ad=@Malzeme_Ad, Birim=@birim, Birim_Fiyat=@fiyat, Kritik_Stok=@krtk, Stok=@stok where Malzeme_Id=@Malzeme_Id", Con);
            komut.Parameters.AddWithValue("@Malzeme_Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@Malzeme_Id", Convert.ToInt32(textBox2.Text));
            komut.Parameters.AddWithValue("@birim", textBoxBirim.Text);
            komut.Parameters.AddWithValue("@fiyat", Convert.ToInt32(textBoxFiyat.Text));
            komut.Parameters.AddWithValue("@krtk", Convert.ToInt32(textBoxKrtk.Text));
            komut.Parameters.AddWithValue("@stok", Convert.ToInt32(textBoxStok.Text));


            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void malzemesil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from MalzemeAd where Malzeme_Id=@Malzeme_Id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@Malzeme_Id", dataGridView1.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxBirim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxFiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxKrtk.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxStok.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void malzemegöster_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void hesaplamamodulu_Click(object sender, EventArgs e)
        {
            HesaplamaModülü M1 = new HesaplamaModülü();
            M1.Show();
        }
    }
}

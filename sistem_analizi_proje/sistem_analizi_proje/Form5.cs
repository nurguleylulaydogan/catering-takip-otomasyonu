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
    public partial class Form5 : System.Windows.Forms.Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        public void yemekgoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select*from YemekAd", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Con.Close();
        }


        public void malzemegoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select*from MalzemeAd", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView2.DataSource = tablo;
            Con.Close();
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Text = "YEMEK-MALZEME";

            yemekgoster();

            malzemegoster();
        }

        private void Yemeksil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from YemekAd where Yemek_Id=@Yemek_Id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@Yemek_Id", dataGridView1.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            yemekgoster();
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Malzemesil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from MalzemeAd where Malzeme_Id=@Malzeme_Id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@Malzeme_Id", dataGridView2.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            malzemegoster();
        }

        private void buttonMalzemeEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into MalzemeAd(Malzeme_Ad, Birim, Birim_Fiyat, Kritik_Stok, Stok)values(@Malzeme_Ad, @birim, @fiyat, @krtk, @stok)", Con);
            komut.Parameters.AddWithValue("@Malzeme_Ad", textBoxMalzeme.Text);
            komut.Parameters.AddWithValue("@birim", (textBoxBirim.Text).ToString());
            komut.Parameters.AddWithValue("@fiyat", (textBoxFiyat.Text).ToString());
            komut.Parameters.AddWithValue("@krtk", (textBoxKrtk.Text).ToString());
            komut.Parameters.AddWithValue("@stok", (textBoxStok.Text).ToString());
            

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Malzeme adı başarıyla kaydedildi");
            yemekgoster();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            textBoxMalzeme.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBoxId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBoxBirim.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBoxFiyat.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBoxKrtk.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBoxStok.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            textBoxMalzeme.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void buttonihtiyac_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }
    }
}

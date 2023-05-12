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
    public partial class Form3 : System.Windows.Forms.Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        private void verigoster()
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
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "YEMEK LİSTESİ";

            verigoster();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yeniyemek_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into YemekAd(Yemek_Ad)values(@Yemek_Ad)", Con);
            komut.Parameters.AddWithValue("@Yemek_Ad", textBox1.Text);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Yemek adı başarıyla kaydedildi");
            verigoster();
        }

        private void yemeksil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from YemekAd where Yemek_Id=@Yemek_Id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@Yemek_Id", dataGridView1.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void duzelt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update YemekAd set Yemek_Ad=@Yemek_Ad where Yemek_Id=@Yemek_Id", Con);
            komut.Parameters.AddWithValue("@Yemek_Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@Yemek_Id", Convert.ToInt32(textBox2.Text));

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}

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
    public partial class AylıkListe : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");

        private void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select*from Aylik", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Con.Close();
        }
        public AylıkListe()
        {
            InitializeComponent();
        }

        private void AylıkListe_Load(object sender, EventArgs e)
        {
            this.Text = "AYLIK YEMEK LİSTESİ";
            verigoster();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Aylik(Tarih, Yemek1, Yemek2, Yemek3, Yemek4, Yemek5)values(@tarih, @y1, @y2, @y3, @y4, @y5)", Con);
            komut.Parameters.AddWithValue("@tarih", DateTime.Parse(dateTimePicker1.Text));
            komut.Parameters.AddWithValue("@y1", textBoxY1.Text);
            komut.Parameters.AddWithValue("@y2", textBoxY2.Text);
            komut.Parameters.AddWithValue("@y3", textBoxY3.Text);
            komut.Parameters.AddWithValue("@y4", textBoxY4.Text);
            komut.Parameters.AddWithValue("@y5", textBoxY5.Text);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Yemek aylık listeye başarıyla kaydedildi");
            verigoster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from Aylik where Id=@id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Aylik set Tarih=@tarih, Yemek1=@y1, Yemek2=@y2, Yemek3=@y3, Yemek4=@y4, Yemek5=@y5 where Id=@id", Con);
            komut.Parameters.AddWithValue("@tarih", DateTime.Parse(dateTimePicker1.Text));
            komut.Parameters.AddWithValue("@id", (textBoxId.Text).ToString());
            komut.Parameters.AddWithValue("@y1", textBoxY1.Text);
            komut.Parameters.AddWithValue("@y2", textBoxY2.Text);
            komut.Parameters.AddWithValue("@y3", textBoxY3.Text);
            komut.Parameters.AddWithValue("@y4", textBoxY4.Text);
            komut.Parameters.AddWithValue("@y5", textBoxY5.Text);


            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxY1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxY2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxY3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxY4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxY5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            dateTimePicker1.Text = "";
            textBoxY1.Text = "";
            textBoxY2.Text = "";
            textBoxY3.Text = "";
            textBoxY4.Text = "";
            textBoxY5.Text = "";

        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

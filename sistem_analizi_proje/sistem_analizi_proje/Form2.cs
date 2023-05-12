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
    public partial class Form2 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        private void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select*from Birimler", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Con.Close();
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            verigoster();

        }

        private void yenibirim_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Birimler(Birim_Adi)values(@birim_adi)", Con);
            komut.Parameters.AddWithValue("@birim_adi", textBox1.Text);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Birim başarıyla kaydedildi");
            verigoster();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void birimisil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from Birimler where Birim_Id=@birim_id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@birim_id", dataGridView1.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            verigoster();
        }

        private void duzelt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Birimler set Birim_Adi=@birim_adi where Birim_Id=@birim_id", Con);
            komut.Parameters.AddWithValue("@birim_adi", textBox1.Text);
            komut.Parameters.AddWithValue("@birim_id", Convert.ToInt32(textBox2.Text));

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

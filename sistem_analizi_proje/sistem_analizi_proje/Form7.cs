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
    public partial class Form7 : System.Windows.Forms.Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        public void ygrupgoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select * from YKGGrup", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Con.Close();
        }

        public void kgrupgoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select * from YKGGrup", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView2.DataSource = tablo;
            Con.Close();
        }

        public void ggrupgoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select * from YKGGrup", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView3.DataSource = tablo;
            Con.Close();
        }
        public Form7()
        {
            InitializeComponent();
        }

        public void Form7_Load(object sender, EventArgs e)
        {
            this.Text = "STOK GİRİŞ-ÇIKIŞ";
            ygrupgoster();
            kgrupgoster();
            ggrupgoster();
            
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand komut = new SqlCommand("select * from YKGGrup where Malzeme like '%" + textBoxY.Text + "%'", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataSet tablo = new DataSet();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo.Tables[0];
            Con.Close();
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand komut = new SqlCommand("select * from YKGGrup where Malzeme like '%" + textBoxK.Text + "%'", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataSet tablo = new DataSet();
            adp.Fill(tablo);
            dataGridView2.DataSource = tablo.Tables[0];
            Con.Close();
        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand komut = new SqlCommand("select * from YKGGrup where Malzeme like '%" + textBoxG.Text + "%'", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataSet tablo = new DataSet();
            adp.Fill(tablo);
            dataGridView3.DataSource = tablo.Tables[0];
            Con.Close();

        }

        private void buttonS1_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from YKGGrup where Id=@id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            ygrupgoster();
        }

        private void buttonS2_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from YKGGrup where Id=@id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@id", dataGridView2.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            kgrupgoster();
        }

        private void buttonS3_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from YKGGrup where Id=@id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@id", dataGridView3.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            ggrupgoster();  
        }

        private void buttonY1_Click(object sender, EventArgs e)
        {
            EkleDuzelt E1 = new EkleDuzelt();
            E1.Show();
            this.Hide();
        }

        private void buttonD1_Click(object sender, EventArgs e)
        {
            EkleDuzelt E1 = new EkleDuzelt();
            E1.Show();
            this.Hide();
        }

        private void buttonY2_Click(object sender, EventArgs e)
        {
            EkleDuzelt E1 = new EkleDuzelt();
            E1.Show();
            this.Hide();
        }

        private void buttonD2_Click(object sender, EventArgs e)
        {
            EkleDuzelt E1 = new EkleDuzelt();
            E1.Show();
            this.Hide();
        }

        private void buttonY3_Click(object sender, EventArgs e)
        {
            EkleDuzelt E1 = new EkleDuzelt();
            E1.Show();
            this.Hide();
        }

        private void buttonD3_Click(object sender, EventArgs e)
        {
            EkleDuzelt E1 = new EkleDuzelt();
            E1.Show();
            this.Hide();
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

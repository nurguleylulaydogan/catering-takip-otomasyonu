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
    public partial class EkleDuzelt : Form
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
        public EkleDuzelt()
        {
            InitializeComponent();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EkleDuzelt_Load(object sender, EventArgs e)
        {
            this.Text = "STOK EKLE-DÜZELT";
            ygrupgoster();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into YKGGrup(Malzeme, Birim, Miktar, Kritik, Tarih, Grup)values(@malzeme, @birim, @miktar, @krtk, @tarih, @grup)", Con);
            komut.Parameters.AddWithValue("@malzeme", textBoxM.Text);
            komut.Parameters.AddWithValue("@birim", textBoxB.Text);
            komut.Parameters.AddWithValue("@miktar", (textBoxMiktar.Text).ToString());
            komut.Parameters.AddWithValue("@krtk", (textBoxKrtk.Text).ToString());
            komut.Parameters.AddWithValue("@tarih", DateTime.Parse(dateTimePicker1.Text));
            komut.Parameters.AddWithValue("@grup", (textBoxG.Text));
            
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Başarıyla Kaydedildi.");

           
            
            Form7 frm = new Form7();
            frm.Show();
            this.Hide();
        }

        private void buttonDuzelt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update YKGGrup set Malzeme=@malzeme, Birim=@birim, Miktar=@miktar, Kritik=@krtk, Tarih=@tarih, Grup=@grup where Id=@id", Con);
            komut.Parameters.AddWithValue("@id", textBoxId.Text);
            komut.Parameters.AddWithValue("@malzeme",textBoxM.Text);
            komut.Parameters.AddWithValue("@birim", textBoxB.Text);
            komut.Parameters.AddWithValue("@miktar", (textBoxMiktar.Text).ToString());
            komut.Parameters.AddWithValue("@krtk", (textBoxKrtk.Text).ToString());
            komut.Parameters.AddWithValue("@tarih", DateTime.Parse(dateTimePicker1.Text));
            komut.Parameters.AddWithValue("@grup", (textBoxG.Text));

        

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();
            Form7 frm = new Form7();
            frm.Show();
            this.Hide();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxM.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxMiktar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxKrtk.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxG.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        
    }
}

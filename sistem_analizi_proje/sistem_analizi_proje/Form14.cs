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
    public partial class Form14 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        public void musterigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select*from TahsilatTeslimat", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Con.Close();
        }
        public Form14()
        {
            InitializeComponent();
        }

       

        private void Form14_Load(object sender, EventArgs e)
        {
            this.Text = "TABLDOT-MÜŞTERİ SAYFASI";
            musterigoster();
        }

        private void buttonYTeslimat_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTeslim_Click(object sender, EventArgs e)
        {
            Teslimat T1 = new Teslimat();
            T1.Show();
        }

        private void buttonTahsil_Click(object sender, EventArgs e)
        {
            Tahsilat T2 = new Tahsilat();
            T2.Show();
        }
    }
}

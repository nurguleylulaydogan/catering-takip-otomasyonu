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
    public partial class FormGiris : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=sistemproje;Integrated Security=True");
        public FormGiris()
        {
            InitializeComponent();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void birimler_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void yemeklistesi_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.Show();
        }

        private void malzemelistesi_Click(object sender, EventArgs e)
        {

            Form4 f4 = new Form4();
            f4.Show();
        }

        private void yemekmalzeme_Click(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.Show();
        }

        private void hesapciktialma_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void stokgiriscikis_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            this.Text = "ANA MENÜ";
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMüşteri_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }
    }
}

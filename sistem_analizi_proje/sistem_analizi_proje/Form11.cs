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
    public partial class Form11 : Form
    {
       
       
        public Form11()
        {
            InitializeComponent();
        }

       
        private void Form11_Load(object sender, EventArgs e)
        {
            this.Text = "MÜŞTERİ MENÜSÜ";
        }

        private void buttonMusteri_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTbldt_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
        }

        private void buttonListe_Click(object sender, EventArgs e)
        {
            AylıkListe A1 = new AylıkListe();
            A1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rapor R1 = new Rapor();
            R1.Show();
        }
    }
}

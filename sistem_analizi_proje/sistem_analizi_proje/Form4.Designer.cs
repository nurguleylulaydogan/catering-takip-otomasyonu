
namespace sistem_analizi_proje
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yenimalzeme = new System.Windows.Forms.Button();
            this.duzelt = new System.Windows.Forms.Button();
            this.malzemesil = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.hesaplamamodulu = new System.Windows.Forms.Button();
            this.listeal = new System.Windows.Forms.Button();
            this.malzemegöster = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelMalzemeAd = new System.Windows.Forms.Label();
            this.textBoxBirim = new System.Windows.Forms.TextBox();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.textBoxKrtk = new System.Windows.Forms.TextBox();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.labelBirim = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelKrtk = new System.Windows.Forms.Label();
            this.labelStok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 389);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // yenimalzeme
            // 
            this.yenimalzeme.Location = new System.Drawing.Point(613, 283);
            this.yenimalzeme.Name = "yenimalzeme";
            this.yenimalzeme.Size = new System.Drawing.Size(73, 39);
            this.yenimalzeme.TabIndex = 1;
            this.yenimalzeme.Text = "Yeni Malzeme";
            this.yenimalzeme.UseVisualStyleBackColor = true;
            this.yenimalzeme.Click += new System.EventHandler(this.yenimalzeme_Click);
            // 
            // duzelt
            // 
            this.duzelt.Location = new System.Drawing.Point(613, 328);
            this.duzelt.Name = "duzelt";
            this.duzelt.Size = new System.Drawing.Size(73, 39);
            this.duzelt.TabIndex = 2;
            this.duzelt.Text = "Düzelt";
            this.duzelt.UseVisualStyleBackColor = true;
            this.duzelt.Click += new System.EventHandler(this.duzelt_Click);
            // 
            // malzemesil
            // 
            this.malzemesil.Location = new System.Drawing.Point(613, 373);
            this.malzemesil.Name = "malzemesil";
            this.malzemesil.Size = new System.Drawing.Size(73, 39);
            this.malzemesil.TabIndex = 3;
            this.malzemesil.Text = "Malzeme Sil";
            this.malzemesil.UseVisualStyleBackColor = true;
            this.malzemesil.Click += new System.EventHandler(this.malzemesil_Click);
            // 
            // kapat
            // 
            this.kapat.Location = new System.Drawing.Point(850, 506);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(73, 39);
            this.kapat.TabIndex = 4;
            this.kapat.Text = "Kapat";
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // hesaplamamodulu
            // 
            this.hesaplamamodulu.Location = new System.Drawing.Point(613, 418);
            this.hesaplamamodulu.Name = "hesaplamamodulu";
            this.hesaplamamodulu.Size = new System.Drawing.Size(82, 39);
            this.hesaplamamodulu.TabIndex = 5;
            this.hesaplamamodulu.Text = "Hesaplama Modülü";
            this.hesaplamamodulu.UseVisualStyleBackColor = true;
            this.hesaplamamodulu.Click += new System.EventHandler(this.hesaplamamodulu_Click);
            // 
            // listeal
            // 
            this.listeal.Location = new System.Drawing.Point(613, 463);
            this.listeal.Name = "listeal";
            this.listeal.Size = new System.Drawing.Size(73, 39);
            this.listeal.TabIndex = 6;
            this.listeal.Text = "Liste Al";
            this.listeal.UseVisualStyleBackColor = true;
            // 
            // malzemegöster
            // 
            this.malzemegöster.Location = new System.Drawing.Point(613, 508);
            this.malzemegöster.Name = "malzemegöster";
            this.malzemegöster.Size = new System.Drawing.Size(73, 39);
            this.malzemegöster.TabIndex = 7;
            this.malzemegöster.Text = "Malzeme Göster";
            this.malzemegöster.UseVisualStyleBackColor = true;
            this.malzemegöster.Click += new System.EventHandler(this.malzemegöster_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(709, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 26);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(709, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 26);
            this.textBox2.TabIndex = 9;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(667, 52);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 15);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "Id";
            // 
            // labelMalzemeAd
            // 
            this.labelMalzemeAd.AutoSize = true;
            this.labelMalzemeAd.Location = new System.Drawing.Point(607, 84);
            this.labelMalzemeAd.Name = "labelMalzemeAd";
            this.labelMalzemeAd.Size = new System.Drawing.Size(79, 15);
            this.labelMalzemeAd.TabIndex = 11;
            this.labelMalzemeAd.Text = "Malzeme ad";
            // 
            // textBoxBirim
            // 
            this.textBoxBirim.Location = new System.Drawing.Point(709, 105);
            this.textBoxBirim.Name = "textBoxBirim";
            this.textBoxBirim.Size = new System.Drawing.Size(184, 26);
            this.textBoxBirim.TabIndex = 12;
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Location = new System.Drawing.Point(709, 137);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(184, 26);
            this.textBoxFiyat.TabIndex = 13;
            // 
            // textBoxKrtk
            // 
            this.textBoxKrtk.Location = new System.Drawing.Point(709, 169);
            this.textBoxKrtk.Name = "textBoxKrtk";
            this.textBoxKrtk.Size = new System.Drawing.Size(184, 26);
            this.textBoxKrtk.TabIndex = 14;
            // 
            // textBoxStok
            // 
            this.textBoxStok.Location = new System.Drawing.Point(709, 201);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(184, 26);
            this.textBoxStok.TabIndex = 15;
            // 
            // labelBirim
            // 
            this.labelBirim.AutoSize = true;
            this.labelBirim.Location = new System.Drawing.Point(650, 116);
            this.labelBirim.Name = "labelBirim";
            this.labelBirim.Size = new System.Drawing.Size(36, 15);
            this.labelBirim.TabIndex = 16;
            this.labelBirim.Text = "Birim";
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Location = new System.Drawing.Point(618, 148);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(68, 15);
            this.labelFiyat.TabIndex = 17;
            this.labelFiyat.Text = "Birim Fiyat";
            // 
            // labelKrtk
            // 
            this.labelKrtk.AutoSize = true;
            this.labelKrtk.Location = new System.Drawing.Point(622, 180);
            this.labelKrtk.Name = "labelKrtk";
            this.labelKrtk.Size = new System.Drawing.Size(64, 15);
            this.labelKrtk.TabIndex = 18;
            this.labelKrtk.Text = "Kritik Stok";
            // 
            // labelStok
            // 
            this.labelStok.AutoSize = true;
            this.labelStok.Location = new System.Drawing.Point(656, 212);
            this.labelStok.Name = "labelStok";
            this.labelStok.Size = new System.Drawing.Size(30, 15);
            this.labelStok.TabIndex = 19;
            this.labelStok.Text = "Stok";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(935, 557);
            this.Controls.Add(this.labelStok);
            this.Controls.Add(this.labelKrtk);
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.labelBirim);
            this.Controls.Add(this.textBoxStok);
            this.Controls.Add(this.textBoxKrtk);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.textBoxBirim);
            this.Controls.Add(this.labelMalzemeAd);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.malzemegöster);
            this.Controls.Add(this.listeal);
            this.Controls.Add(this.hesaplamamodulu);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.malzemesil);
            this.Controls.Add(this.duzelt);
            this.Controls.Add(this.yenimalzeme);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button yenimalzeme;
        private System.Windows.Forms.Button duzelt;
        private System.Windows.Forms.Button malzemesil;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button hesaplamamodulu;
        private System.Windows.Forms.Button listeal;
        private System.Windows.Forms.Button malzemegöster;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelMalzemeAd;
        private System.Windows.Forms.TextBox textBoxBirim;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.TextBox textBoxKrtk;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.Label labelBirim;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelKrtk;
        private System.Windows.Forms.Label labelStok;
    }
}

namespace sistem_analizi_proje
{
    partial class AylıkListe
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxY3 = new System.Windows.Forms.TextBox();
            this.textBoxY4 = new System.Windows.Forms.TextBox();
            this.textBoxY5 = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelY3 = new System.Windows.Forms.Label();
            this.labelTarih = new System.Windows.Forms.Label();
            this.labelY4 = new System.Windows.Forms.Label();
            this.labelY5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aylık Yemek Listesi";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(819, 86);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 46);
            this.buttonKaydet.TabIndex = 2;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(819, 134);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 46);
            this.buttonSil.TabIndex = 3;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.Location = new System.Drawing.Point(819, 182);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(75, 46);
            this.buttonGüncelle.TabIndex = 4;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = true;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(819, 230);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(75, 46);
            this.buttonTemizle.TabIndex = 5;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(846, 461);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(75, 46);
            this.buttonKapat.TabIndex = 6;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(610, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(610, 150);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(141, 26);
            this.textBoxY1.TabIndex = 8;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(610, 86);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(141, 26);
            this.textBoxId.TabIndex = 9;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(610, 182);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(141, 26);
            this.textBoxY2.TabIndex = 10;
            // 
            // textBoxY3
            // 
            this.textBoxY3.Location = new System.Drawing.Point(610, 214);
            this.textBoxY3.Name = "textBoxY3";
            this.textBoxY3.Size = new System.Drawing.Size(141, 26);
            this.textBoxY3.TabIndex = 11;
            // 
            // textBoxY4
            // 
            this.textBoxY4.Location = new System.Drawing.Point(610, 246);
            this.textBoxY4.Name = "textBoxY4";
            this.textBoxY4.Size = new System.Drawing.Size(141, 26);
            this.textBoxY4.TabIndex = 12;
            // 
            // textBoxY5
            // 
            this.textBoxY5.Location = new System.Drawing.Point(610, 278);
            this.textBoxY5.Name = "textBoxY5";
            this.textBoxY5.Size = new System.Drawing.Size(141, 26);
            this.textBoxY5.TabIndex = 13;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(560, 97);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 15);
            this.labelId.TabIndex = 14;
            this.labelId.Text = "Id";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(527, 161);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(52, 15);
            this.labelY1.TabIndex = 15;
            this.labelY1.Text = "Yemek1";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(527, 193);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(52, 15);
            this.labelY2.TabIndex = 16;
            this.labelY2.Text = "Yemek2";
            // 
            // labelY3
            // 
            this.labelY3.AutoSize = true;
            this.labelY3.Location = new System.Drawing.Point(527, 225);
            this.labelY3.Name = "labelY3";
            this.labelY3.Size = new System.Drawing.Size(52, 15);
            this.labelY3.TabIndex = 17;
            this.labelY3.Text = "Yemek3";
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Location = new System.Drawing.Point(542, 129);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(37, 15);
            this.labelTarih.TabIndex = 18;
            this.labelTarih.Text = "Tarih";
            // 
            // labelY4
            // 
            this.labelY4.AutoSize = true;
            this.labelY4.Location = new System.Drawing.Point(527, 257);
            this.labelY4.Name = "labelY4";
            this.labelY4.Size = new System.Drawing.Size(52, 15);
            this.labelY4.TabIndex = 19;
            this.labelY4.Text = "Yemek4";
            // 
            // labelY5
            // 
            this.labelY5.AutoSize = true;
            this.labelY5.Location = new System.Drawing.Point(527, 289);
            this.labelY5.Name = "labelY5";
            this.labelY5.Size = new System.Drawing.Size(52, 15);
            this.labelY5.TabIndex = 20;
            this.labelY5.Text = "Yemek5";
            // 
            // AylıkListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.labelY5);
            this.Controls.Add(this.labelY4);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.labelY3);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxY5);
            this.Controls.Add(this.textBoxY4);
            this.Controls.Add(this.textBoxY3);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AylıkListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AylıkListe";
            this.Load += new System.EventHandler(this.AylıkListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxY3;
        private System.Windows.Forms.TextBox textBoxY4;
        private System.Windows.Forms.TextBox textBoxY5;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelY3;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Label labelY4;
        private System.Windows.Forms.Label labelY5;
    }
}
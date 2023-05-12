
namespace sistem_analizi_proje
{
    partial class Form5
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
            this.Yemeklistesi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Malzemelistesi = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Malzemesil = new System.Windows.Forms.Button();
            this.Yemeksil = new System.Windows.Forms.Button();
            this.Kapat = new System.Windows.Forms.Button();
            this.buttonMalzemeEkle = new System.Windows.Forms.Button();
            this.textBoxMalzeme = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxBirim = new System.Windows.Forms.TextBox();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.textBoxKrtk = new System.Windows.Forms.TextBox();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelMalzeme = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonihtiyac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Yemeklistesi
            // 
            this.Yemeklistesi.AutoSize = true;
            this.Yemeklistesi.Location = new System.Drawing.Point(104, 9);
            this.Yemeklistesi.Name = "Yemeklistesi";
            this.Yemeklistesi.Size = new System.Drawing.Size(81, 15);
            this.Yemeklistesi.TabIndex = 0;
            this.Yemeklistesi.Text = "Yemek Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(277, 350);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Malzemelistesi
            // 
            this.Malzemelistesi.AutoSize = true;
            this.Malzemelistesi.Location = new System.Drawing.Point(389, 9);
            this.Malzemelistesi.Name = "Malzemelistesi";
            this.Malzemelistesi.Size = new System.Drawing.Size(96, 15);
            this.Malzemelistesi.TabIndex = 2;
            this.Malzemelistesi.Text = "Malzeme Listesi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(321, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(273, 350);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter);
            // 
            // Malzemesil
            // 
            this.Malzemesil.Location = new System.Drawing.Point(698, 400);
            this.Malzemesil.Name = "Malzemesil";
            this.Malzemesil.Size = new System.Drawing.Size(101, 46);
            this.Malzemesil.TabIndex = 4;
            this.Malzemesil.Text = "Malzeme Sil";
            this.Malzemesil.UseVisualStyleBackColor = true;
            this.Malzemesil.Click += new System.EventHandler(this.Malzemesil_Click);
            // 
            // Yemeksil
            // 
            this.Yemeksil.Location = new System.Drawing.Point(98, 400);
            this.Yemeksil.Name = "Yemeksil";
            this.Yemeksil.Size = new System.Drawing.Size(75, 47);
            this.Yemeksil.TabIndex = 5;
            this.Yemeksil.Text = "Yemek Sİl";
            this.Yemeksil.UseVisualStyleBackColor = true;
            this.Yemeksil.Click += new System.EventHandler(this.Yemeksil_Click);
            // 
            // Kapat
            // 
            this.Kapat.Location = new System.Drawing.Point(846, 393);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(75, 48);
            this.Kapat.TabIndex = 6;
            this.Kapat.Text = "Kapat";
            this.Kapat.UseVisualStyleBackColor = true;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // buttonMalzemeEkle
            // 
            this.buttonMalzemeEkle.Location = new System.Drawing.Point(392, 400);
            this.buttonMalzemeEkle.Name = "buttonMalzemeEkle";
            this.buttonMalzemeEkle.Size = new System.Drawing.Size(119, 46);
            this.buttonMalzemeEkle.TabIndex = 8;
            this.buttonMalzemeEkle.Text = "Malzeme Ekle";
            this.buttonMalzemeEkle.UseVisualStyleBackColor = true;
            this.buttonMalzemeEkle.Click += new System.EventHandler(this.buttonMalzemeEkle_Click);
            // 
            // textBoxMalzeme
            // 
            this.textBoxMalzeme.Location = new System.Drawing.Point(768, 92);
            this.textBoxMalzeme.Name = "textBoxMalzeme";
            this.textBoxMalzeme.Size = new System.Drawing.Size(133, 26);
            this.textBoxMalzeme.TabIndex = 9;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(768, 60);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(133, 26);
            this.textBoxId.TabIndex = 10;
            // 
            // textBoxBirim
            // 
            this.textBoxBirim.Location = new System.Drawing.Point(768, 124);
            this.textBoxBirim.Name = "textBoxBirim";
            this.textBoxBirim.Size = new System.Drawing.Size(133, 26);
            this.textBoxBirim.TabIndex = 11;
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Location = new System.Drawing.Point(768, 156);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(133, 26);
            this.textBoxFiyat.TabIndex = 12;
            // 
            // textBoxKrtk
            // 
            this.textBoxKrtk.Location = new System.Drawing.Point(768, 188);
            this.textBoxKrtk.Name = "textBoxKrtk";
            this.textBoxKrtk.Size = new System.Drawing.Size(133, 26);
            this.textBoxKrtk.TabIndex = 13;
            // 
            // textBoxStok
            // 
            this.textBoxStok.Location = new System.Drawing.Point(768, 220);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(133, 26);
            this.textBoxStok.TabIndex = 14;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(698, 71);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 15);
            this.labelId.TabIndex = 15;
            this.labelId.Text = "Id";
            // 
            // labelMalzeme
            // 
            this.labelMalzeme.AutoSize = true;
            this.labelMalzeme.Location = new System.Drawing.Point(683, 103);
            this.labelMalzeme.Name = "labelMalzeme";
            this.labelMalzeme.Size = new System.Drawing.Size(79, 15);
            this.labelMalzeme.TabIndex = 16;
            this.labelMalzeme.Text = "Malzeme Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Birim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Birim Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kritik Stok";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Stok";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 46);
            this.button1.TabIndex = 21;
            this.button1.Text = "AYRINTILAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonihtiyac
            // 
            this.buttonihtiyac.Location = new System.Drawing.Point(583, 400);
            this.buttonihtiyac.Name = "buttonihtiyac";
            this.buttonihtiyac.Size = new System.Drawing.Size(87, 46);
            this.buttonihtiyac.TabIndex = 22;
            this.buttonihtiyac.Text = "ihtiyaç listersi";
            this.buttonihtiyac.UseVisualStyleBackColor = true;
            this.buttonihtiyac.Click += new System.EventHandler(this.buttonihtiyac_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(954, 459);
            this.Controls.Add(this.buttonihtiyac);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMalzeme);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxStok);
            this.Controls.Add(this.textBoxKrtk);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.textBoxBirim);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxMalzeme);
            this.Controls.Add(this.buttonMalzemeEkle);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.Yemeksil);
            this.Controls.Add(this.Malzemesil);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Malzemelistesi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Yemeklistesi);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Yemeklistesi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Malzemelistesi;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Malzemesil;
        private System.Windows.Forms.Button Yemeksil;
        private System.Windows.Forms.Button Kapat;
        private System.Windows.Forms.Button buttonMalzemeEkle;
        private System.Windows.Forms.TextBox textBoxMalzeme;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxBirim;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.TextBox textBoxKrtk;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelMalzeme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonihtiyac;
    }
}
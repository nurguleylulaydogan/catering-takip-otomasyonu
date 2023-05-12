
namespace sistem_analizi_proje
{
    partial class Teslimat
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
            this.textBoxTarih = new System.Windows.Forms.TextBox();
            this.textBoxAdet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonTesSil = new System.Windows.Forms.Button();
            this.buttonTesDuzelt = new System.Windows.Forms.Button();
            this.buttonYTeslimat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.labelAd = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTarih
            // 
            this.textBoxTarih.Location = new System.Drawing.Point(606, 187);
            this.textBoxTarih.Name = "textBoxTarih";
            this.textBoxTarih.Size = new System.Drawing.Size(142, 26);
            this.textBoxTarih.TabIndex = 33;
            // 
            // textBoxAdet
            // 
            this.textBoxAdet.Location = new System.Drawing.Point(606, 155);
            this.textBoxAdet.Name = "textBoxAdet";
            this.textBoxAdet.Size = new System.Drawing.Size(142, 26);
            this.textBoxAdet.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Adet";
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(159, 405);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(70, 15);
            this.labelTop.TabIndex = 29;
            this.labelTop.Text = "---------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Toplam:";
            // 
            // buttonTesSil
            // 
            this.buttonTesSil.Location = new System.Drawing.Point(430, 229);
            this.buttonTesSil.Name = "buttonTesSil";
            this.buttonTesSil.Size = new System.Drawing.Size(75, 47);
            this.buttonTesSil.TabIndex = 27;
            this.buttonTesSil.Text = "Teslimat Sil";
            this.buttonTesSil.UseVisualStyleBackColor = true;
            this.buttonTesSil.Click += new System.EventHandler(this.buttonTesSil_Click);
            // 
            // buttonTesDuzelt
            // 
            this.buttonTesDuzelt.Location = new System.Drawing.Point(430, 176);
            this.buttonTesDuzelt.Name = "buttonTesDuzelt";
            this.buttonTesDuzelt.Size = new System.Drawing.Size(75, 47);
            this.buttonTesDuzelt.TabIndex = 26;
            this.buttonTesDuzelt.Text = "Teslimat Düzenle";
            this.buttonTesDuzelt.UseVisualStyleBackColor = true;
            this.buttonTesDuzelt.Click += new System.EventHandler(this.buttonTesDuzelt_Click);
            // 
            // buttonYTeslimat
            // 
            this.buttonYTeslimat.Location = new System.Drawing.Point(430, 123);
            this.buttonYTeslimat.Name = "buttonYTeslimat";
            this.buttonYTeslimat.Size = new System.Drawing.Size(75, 47);
            this.buttonYTeslimat.TabIndex = 25;
            this.buttonYTeslimat.Text = "Yeni Teslimat";
            this.buttonYTeslimat.UseVisualStyleBackColor = true;
            this.buttonYTeslimat.Click += new System.EventHandler(this.buttonYTeslimat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Teslimat";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(34, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(310, 309);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter);
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(670, 412);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(78, 49);
            this.buttonKapat.TabIndex = 34;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(606, 123);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(142, 26);
            this.textBoxAd.TabIndex = 36;
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(530, 134);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(58, 15);
            this.labelAd.TabIndex = 35;
            this.labelAd.Text = "Firma Ad";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(606, 91);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(77, 26);
            this.textBoxId.TabIndex = 38;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(569, 102);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 15);
            this.labelId.TabIndex = 37;
            this.labelId.Text = "Id";
            // 
            // Teslimat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(774, 473);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.textBoxTarih);
            this.Controls.Add(this.textBoxAdet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonTesSil);
            this.Controls.Add(this.buttonTesDuzelt);
            this.Controls.Add(this.buttonYTeslimat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Teslimat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teslimat";
            this.Load += new System.EventHandler(this.Teslimat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTarih;
        private System.Windows.Forms.TextBox textBoxAdet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTesSil;
        private System.Windows.Forms.Button buttonTesDuzelt;
        private System.Windows.Forms.Button buttonYTeslimat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
    }
}
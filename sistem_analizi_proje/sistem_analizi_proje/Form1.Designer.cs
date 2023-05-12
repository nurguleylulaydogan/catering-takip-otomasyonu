
namespace sistem_analizi_proje
{
    partial class Form1
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
            this.buttonGiris = new System.Windows.Forms.Button();
            this.radioButtonPersonel = new System.Windows.Forms.RadioButton();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.labelYetki = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(543, 267);
            this.buttonGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(122, 50);
            this.buttonGiris.TabIndex = 15;
            this.buttonGiris.Text = "Giriş";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click_1);
            // 
            // radioButtonPersonel
            // 
            this.radioButtonPersonel.AutoSize = true;
            this.radioButtonPersonel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonPersonel.Location = new System.Drawing.Point(361, 267);
            this.radioButtonPersonel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonPersonel.Name = "radioButtonPersonel";
            this.radioButtonPersonel.Size = new System.Drawing.Size(111, 26);
            this.radioButtonPersonel.TabIndex = 14;
            this.radioButtonPersonel.TabStop = true;
            this.radioButtonPersonel.Text = "Personel";
            this.radioButtonPersonel.UseVisualStyleBackColor = true;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(361, 218);
            this.textBoxSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(304, 26);
            this.textBoxSifre.TabIndex = 13;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(361, 179);
            this.textBoxAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(304, 26);
            this.textBoxAd.TabIndex = 12;
            // 
            // labelYetki
            // 
            this.labelYetki.AutoSize = true;
            this.labelYetki.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYetki.Location = new System.Drawing.Point(269, 267);
            this.labelYetki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYetki.Name = "labelYetki";
            this.labelYetki.Size = new System.Drawing.Size(55, 22);
            this.labelYetki.TabIndex = 11;
            this.labelYetki.Text = "Yetki";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.Location = new System.Drawing.Point(269, 222);
            this.labelSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(53, 22);
            this.labelSifre.TabIndex = 10;
            this.labelSifre.Text = "Şifre";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.Location = new System.Drawing.Point(269, 183);
            this.labelAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(35, 22);
            this.labelAd.TabIndex = 9;
            this.labelAd.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(262, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "DÜZCE YEMEK";
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(775, 359);
            this.buttonKapat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(135, 62);
            this.buttonKapat.TabIndex = 16;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(920, 434);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.radioButtonPersonel);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelYetki);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NURGÜL EYLÜL AYDOĞAN 201103046";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.RadioButton radioButtonPersonel;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label labelYetki;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKapat;
    }
}


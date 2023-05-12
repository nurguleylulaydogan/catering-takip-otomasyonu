
namespace sistem_analizi_proje
{
    partial class Form11
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
            this.buttonMusteri = new System.Windows.Forms.Button();
            this.buttonTbldt = new System.Windows.Forms.Button();
            this.buttonRapor = new System.Windows.Forms.Button();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.buttonListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMusteri
            // 
            this.buttonMusteri.Location = new System.Drawing.Point(267, 123);
            this.buttonMusteri.Name = "buttonMusteri";
            this.buttonMusteri.Size = new System.Drawing.Size(78, 50);
            this.buttonMusteri.TabIndex = 0;
            this.buttonMusteri.Text = "Müşteriler";
            this.buttonMusteri.UseVisualStyleBackColor = true;
            this.buttonMusteri.Click += new System.EventHandler(this.buttonMusteri_Click);
            // 
            // buttonTbldt
            // 
            this.buttonTbldt.Location = new System.Drawing.Point(351, 123);
            this.buttonTbldt.Name = "buttonTbldt";
            this.buttonTbldt.Size = new System.Drawing.Size(107, 50);
            this.buttonTbldt.TabIndex = 1;
            this.buttonTbldt.Text = "Tabldot-Müşteri";
            this.buttonTbldt.UseVisualStyleBackColor = true;
            this.buttonTbldt.Click += new System.EventHandler(this.buttonTbldt_Click);
            // 
            // buttonRapor
            // 
            this.buttonRapor.Location = new System.Drawing.Point(464, 123);
            this.buttonRapor.Name = "buttonRapor";
            this.buttonRapor.Size = new System.Drawing.Size(78, 50);
            this.buttonRapor.TabIndex = 2;
            this.buttonRapor.Text = "Rapor İşlemleri";
            this.buttonRapor.UseVisualStyleBackColor = true;
            this.buttonRapor.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(638, 262);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(78, 50);
            this.buttonKapat.TabIndex = 3;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // buttonListe
            // 
            this.buttonListe.Location = new System.Drawing.Point(174, 123);
            this.buttonListe.Name = "buttonListe";
            this.buttonListe.Size = new System.Drawing.Size(87, 50);
            this.buttonListe.TabIndex = 4;
            this.buttonListe.Text = "Aylık Yemek Listesi";
            this.buttonListe.UseVisualStyleBackColor = true;
            this.buttonListe.Click += new System.EventHandler(this.buttonListe_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(750, 324);
            this.Controls.Add(this.buttonListe);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.buttonRapor);
            this.Controls.Add(this.buttonTbldt);
            this.Controls.Add(this.buttonMusteri);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMusteri;
        private System.Windows.Forms.Button buttonTbldt;
        private System.Windows.Forms.Button buttonRapor;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.Button buttonListe;
    }
}

namespace sistem_analizi_proje
{
    partial class Form2
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
            this.yenibirim = new System.Windows.Forms.Button();
            this.duzelt = new System.Windows.Forms.Button();
            this.birimisil = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // yenibirim
            // 
            this.yenibirim.Location = new System.Drawing.Point(511, 96);
            this.yenibirim.Name = "yenibirim";
            this.yenibirim.Size = new System.Drawing.Size(75, 44);
            this.yenibirim.TabIndex = 0;
            this.yenibirim.Text = "Yeni Birim";
            this.yenibirim.UseVisualStyleBackColor = true;
            this.yenibirim.Click += new System.EventHandler(this.yenibirim_Click);
            // 
            // duzelt
            // 
            this.duzelt.Location = new System.Drawing.Point(511, 146);
            this.duzelt.Name = "duzelt";
            this.duzelt.Size = new System.Drawing.Size(75, 44);
            this.duzelt.TabIndex = 1;
            this.duzelt.Text = "Düzelt";
            this.duzelt.UseVisualStyleBackColor = true;
            this.duzelt.Click += new System.EventHandler(this.duzelt_Click);
            // 
            // birimisil
            // 
            this.birimisil.Location = new System.Drawing.Point(511, 196);
            this.birimisil.Name = "birimisil";
            this.birimisil.Size = new System.Drawing.Size(75, 44);
            this.birimisil.TabIndex = 2;
            this.birimisil.Text = "Birimi Sil";
            this.birimisil.UseVisualStyleBackColor = true;
            this.birimisil.Click += new System.EventHandler(this.birimisil_Click);
            // 
            // kapat
            // 
            this.kapat.Location = new System.Drawing.Point(511, 246);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(75, 44);
            this.kapat.TabIndex = 3;
            this.kapat.Text = "Kapat";
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 267);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(469, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(469, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 26);
            this.textBox2.TabIndex = 6;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(444, 32);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 15);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yemek Ad";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(646, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.birimisil);
            this.Controls.Add(this.duzelt);
            this.Controls.Add(this.yenibirim);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yenibirim;
        private System.Windows.Forms.Button duzelt;
        private System.Windows.Forms.Button birimisil;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label2;
    }
}
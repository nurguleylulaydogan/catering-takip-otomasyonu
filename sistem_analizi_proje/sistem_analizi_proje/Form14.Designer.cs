﻿
namespace sistem_analizi_proje
{
    partial class Form14
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
            this.buttonKapat = new System.Windows.Forms.Button();
            this.buttonTeslim = new System.Windows.Forms.Button();
            this.buttonTahsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 309);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri Listesi";
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(857, 317);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(75, 46);
            this.buttonKapat.TabIndex = 4;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // buttonTeslim
            // 
            this.buttonTeslim.Location = new System.Drawing.Point(857, 72);
            this.buttonTeslim.Name = "buttonTeslim";
            this.buttonTeslim.Size = new System.Drawing.Size(75, 46);
            this.buttonTeslim.TabIndex = 5;
            this.buttonTeslim.Text = "Teslimat";
            this.buttonTeslim.UseVisualStyleBackColor = true;
            this.buttonTeslim.Click += new System.EventHandler(this.buttonTeslim_Click);
            // 
            // buttonTahsil
            // 
            this.buttonTahsil.Location = new System.Drawing.Point(857, 143);
            this.buttonTahsil.Name = "buttonTahsil";
            this.buttonTahsil.Size = new System.Drawing.Size(75, 46);
            this.buttonTahsil.TabIndex = 6;
            this.buttonTahsil.Text = "Tahsilat";
            this.buttonTahsil.UseVisualStyleBackColor = true;
            this.buttonTahsil.Click += new System.EventHandler(this.buttonTahsil_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(979, 418);
            this.Controls.Add(this.buttonTahsil);
            this.Controls.Add(this.buttonTeslim);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.Button buttonTeslim;
        private System.Windows.Forms.Button buttonTahsil;
    }
}

namespace GameCenter
{
    partial class SatisListele
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
            this.SatisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcilisTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKazanc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SatisID,
            this.MasaID,
            this.AcilisTuru,
            this.Baslangic,
            this.Bitis,
            this.Sure,
            this.Tutar,
            this.Aciklama,
            this.Tarih});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // SatisID
            // 
            this.SatisID.DataPropertyName = "SatisID";
            this.SatisID.HeaderText = "SatisID";
            this.SatisID.Name = "SatisID";
            this.SatisID.ReadOnly = true;
            // 
            // MasaID
            // 
            this.MasaID.DataPropertyName = "MasaID";
            this.MasaID.HeaderText = "MasaID";
            this.MasaID.Name = "MasaID";
            this.MasaID.ReadOnly = true;
            // 
            // AcilisTuru
            // 
            this.AcilisTuru.DataPropertyName = "AcilisTuru";
            this.AcilisTuru.HeaderText = "AcilisTuru";
            this.AcilisTuru.Name = "AcilisTuru";
            this.AcilisTuru.ReadOnly = true;
            // 
            // Baslangic
            // 
            this.Baslangic.DataPropertyName = "BaslangicSaat";
            this.Baslangic.HeaderText = "Başlangıç Saati";
            this.Baslangic.Name = "Baslangic";
            this.Baslangic.ReadOnly = true;
            // 
            // Bitis
            // 
            this.Bitis.DataPropertyName = "BitisSaat";
            this.Bitis.HeaderText = "Bitiş Saati";
            this.Bitis.Name = "Bitis";
            this.Bitis.ReadOnly = true;
            // 
            // Sure
            // 
            this.Sure.DataPropertyName = "Sure";
            this.Sure.HeaderText = "Süre ";
            this.Sure.Name = "Sure";
            this.Sure.ReadOnly = true;
            // 
            // Tutar
            // 
            this.Tutar.DataPropertyName = "Tutar";
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama ";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGeriAl.Location = new System.Drawing.Point(633, 366);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(167, 84);
            this.btnGeriAl.TabIndex = 1;
            this.btnGeriAl.Text = "İşlemi Geri Al";
            this.btnGeriAl.UseVisualStyleBackColor = true;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(0, 373);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(168, 77);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Satışları Sıfırla";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplam Kazanç : ";
            // 
            // tbKazanc
            // 
            this.tbKazanc.Location = new System.Drawing.Point(389, 405);
            this.tbKazanc.Name = "tbKazanc";
            this.tbKazanc.Size = new System.Drawing.Size(191, 20);
            this.tbKazanc.TabIndex = 4;
            // 
            // SatisListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKazanc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SatisListele";
            this.Text = "SatisListele";
            this.Load += new System.EventHandler(this.SatisListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcilisTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKazanc;
    }
}
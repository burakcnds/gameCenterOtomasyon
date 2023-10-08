
namespace GameCenter
{
    partial class CihazKiralaForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KiralaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcKimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSil = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KiralaID,
            this.Ad,
            this.Soyad,
            this.TcKimlik,
            this.Basla,
            this.Bitis,
            this.Fiyat});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(922, 466);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // KiralaID
            // 
            this.KiralaID.DataPropertyName = "KiralaID";
            this.KiralaID.HeaderText = "KiralaID";
            this.KiralaID.Name = "KiralaID";
            this.KiralaID.ReadOnly = true;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            // 
            // TcKimlik
            // 
            this.TcKimlik.DataPropertyName = "TcKimlik";
            this.TcKimlik.HeaderText = "TcKimlik";
            this.TcKimlik.Name = "TcKimlik";
            this.TcKimlik.ReadOnly = true;
            // 
            // Basla
            // 
            this.Basla.DataPropertyName = "Baslaa";
            this.Basla.HeaderText = "Kira Başlangıcı";
            this.Basla.Name = "Basla";
            this.Basla.ReadOnly = true;
            // 
            // Bitis
            // 
            this.Bitis.DataPropertyName = "Bitiss";
            this.Bitis.HeaderText = "Kira Bitişi";
            this.Bitis.Name = "Bitis";
            this.Bitis.ReadOnly = true;
            // 
            // Fiyat
            // 
            this.Fiyat.DataPropertyName = "Fiyat";
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // btnSil
            // 
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(180, 22);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(0, 473);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(894, 44);
            this.btnGeriDon.TabIndex = 30;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            // 
            // CihazKiralaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 517);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CihazKiralaForm";
            this.Text = "CihazKiralaForm";
            this.Load += new System.EventHandler(this.CihazKiralaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSil;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiralaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcKimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
    }
}
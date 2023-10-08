
namespace GameCenter
{
    partial class KiralamaYapForm
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
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.tbTc = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtBasla = new System.Windows.Forms.DateTimePicker();
            this.dtBit = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbFiyat
            // 
            this.tbFiyat.Location = new System.Drawing.Point(101, 227);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.Size = new System.Drawing.Size(141, 20);
            this.tbFiyat.TabIndex = 40;
            // 
            // tbTc
            // 
            this.tbTc.Location = new System.Drawing.Point(101, 129);
            this.tbTc.Name = "tbTc";
            this.tbTc.Size = new System.Drawing.Size(200, 20);
            this.tbTc.TabIndex = 39;
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(101, 85);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(200, 20);
            this.tbSoyad.TabIndex = 38;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(101, 37);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(200, 20);
            this.tbAd.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Fiyat : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tc Kimlik : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Soyadı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Adı : ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::GameCenter.Properties.Resources.kaydet;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(261, 221);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(40, 33);
            this.btnKaydet.TabIndex = 41;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Kira Başlangıcı : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Kira Bitişi : ";
            // 
            // dtBasla
            // 
            this.dtBasla.Location = new System.Drawing.Point(99, 159);
            this.dtBasla.Name = "dtBasla";
            this.dtBasla.Size = new System.Drawing.Size(200, 20);
            this.dtBasla.TabIndex = 46;
            // 
            // dtBit
            // 
            this.dtBit.Location = new System.Drawing.Point(99, 195);
            this.dtBit.Name = "dtBit";
            this.dtBit.Size = new System.Drawing.Size(200, 20);
            this.dtBit.TabIndex = 47;
            // 
            // KiralamaYapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 265);
            this.Controls.Add(this.dtBit);
            this.Controls.Add(this.dtBasla);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tbFiyat);
            this.Controls.Add(this.tbTc);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KiralamaYapForm";
            this.Text = "KiralamaYapForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFiyat;
        private System.Windows.Forms.TextBox tbTc;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtBasla;
        private System.Windows.Forms.DateTimePicker dtBit;
    }
}
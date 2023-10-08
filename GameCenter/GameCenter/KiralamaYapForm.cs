using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCenter
{
    public partial class KiralamaYapForm : Form
    {
        public KiralamaYapForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tbAd.Text.Trim()!="" & tbSoyad.Text.Trim() != "" &  tbTc.Text.Trim() != "" & tbFiyat.Text.Trim() != "" )
            {
                string sqlsorgu = "insert into Kirala(Ad,Soyad,TcKimlik,Fiyat,Baslaa,Bitiss) " +
                       "values('" + tbAd.Text + "','" + tbSoyad.Text + "','" + tbTc.Text + "','" + tbFiyat.Text + "','" + dtBasla.Value.ToString("yyyy-MM-dd") + "','" + dtBit.Value.ToString("yyyy-MM-dd") +"')";
                SqlCommand komut = new SqlCommand();


               
                Veritabanı.EkleSilGuncelle(komut, sqlsorgu);
                MessageBox.Show("Kayıt Ekleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                GameCenter afrm = (GameCenter)Application.OpenForms["GameCenter"]; 
            }
            else
            {
                MessageBox.Show("Veri Alanlarını \nKontrol Ediniz", "Bilgi",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }
    }
}

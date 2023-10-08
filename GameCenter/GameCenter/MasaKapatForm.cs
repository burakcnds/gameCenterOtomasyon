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
    
    public partial class MasaKapatForm : Form
        
    {
        public MasaKapatForm()
        {
            InitializeComponent();
        }

        private void btnMasaKapat_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Satis(MasaID,AcilisTuru,BaslangicSaat,BitisSaat,Sure,Tutar,Aciklama,Tarih) " +
                "Values('" + int.Parse(tbMasaID.Text) + "','" + tbTur.Text + "',@Baslangic,@Bitis,@Sure,@Tutar,'Açıklama Yapılmadı',@Tarih)";

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Baslangic", DateTime.Parse(tbBaslaSaat.Text));
            cmd.Parameters.AddWithValue("@Bitis", DateTime.Parse(tbBitisSaat.Text));
            cmd.Parameters.AddWithValue("@Sure", decimal.Parse(tbSure.Text));
            cmd.Parameters.AddWithValue("@Tutar", decimal.Parse(tbTutar.Text));
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Parse(tbTarih.Text));
            Veritabanı.EkleSilGuncelle(cmd, sorgu);

            //string sqlsorgu = "update Masalar set Durumu='BOŞ' where MasaID='" + tbMasaID.Text + "'";
            //SqlCommand komut = new SqlCommand();
            //Veritabanı.EkleSilGuncelle(komut, sqlsorgu);
            //string sqlsorgu2 = "delete from Sepet where SepetID='" + tbID.Text + "'";
            //SqlCommand komut2 = new SqlCommand();
            //Veritabanı.EkleSilGuncelle(komut2, sqlsorgu2);
            this.Close();
            GameCenter afrm = (GameCenter)Application.OpenForms["GameCenter"];
            afrm.Yenile();
            
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

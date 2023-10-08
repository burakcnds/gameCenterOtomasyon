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
    public partial class SatisListele : Form
    {
        public SatisListele()
        {
            InitializeComponent();
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            int MasaID = int.Parse(dataGridView1.CurrentRow.Cells["MasaID"].Value.ToString());
            string Masa = "MASA-" + MasaID;
            string AcilisTuru=dataGridView1.CurrentRow.Cells["AcilisTuru"].Value.ToString();
            DateTime baslangic= DateTime.Parse(dataGridView1.CurrentRow.Cells["Baslangic"].Value.ToString());
            DateTime tarih = DateTime.Parse(dataGridView1.CurrentRow.Cells["Tarih"].Value.ToString());
            string sql = "Insert into Sepet(MasaID,Masa,AcilisTuru,Baslangic,Tarih) values ('"+MasaID+"','"+Masa+"','"+AcilisTuru+"',@Baslangic,@Tarih)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Baslangic",baslangic);
            cmd.Parameters.AddWithValue("@Tarih", tarih);
          
            Veritabanı.EkleSilGuncelle(cmd,sql);
            ///////////////////
            string sql2 = "Delete from Satis where SatisID='"+int.Parse(dataGridView1.CurrentRow.Cells["SatisID"].Value.ToString())+"'";
            SqlCommand cmd2 = new SqlCommand();
            Veritabanı.EkleSilGuncelle(cmd2, sql2);
            this.Close();
            GameCenter afrm = (GameCenter)Application.OpenForms["GameCenter"];
            afrm.Yenile();

        }

        private void SatisListele_Load(object sender, EventArgs e)
        {
            Veritabanı.Listele(dataGridView1,"select *from Satis");
            /////////
            ///
            double toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);

            }
            tbKazanc.Text = toplam.ToString() + " TL";
        
    }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            string sql2 = "Delete from Satis";
            SqlCommand cmd2 = new SqlCommand();
            Veritabanı.EkleSilGuncelle(cmd2, sql2);
            MessageBox.Show("Tüm Kayıtlar Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Veritabanı.Listele(dataGridView1, "select *from Satis");
            tbKazanc.Clear();

        }
    }
}

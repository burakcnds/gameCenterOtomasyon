using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCenter
{
    class Veritabanı
    {
      public static  SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = GameCenterDB; User ID = sa; Password=mmyo;Pooling=False");
        public static DataTable SepetListele(DataGridView dgv)
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select *from Sepet" , Baglanti);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            return tbl;
            
        }
        public static DataTable Listele(DataGridView dgv,string sorgu)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, Baglanti);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            return tbl;

        }
        public static DataTable BosMasaGetir(ComboBox combo)
        {
            Baglanti.Open();
            SqlDataAdapter adp = new SqlDataAdapter("Select *From Masalar where Durumu='BOŞ'", Baglanti);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            combo.DataSource = tbl;
            combo.DisplayMember = "Masalar";
            combo.ValueMember = "MasaID";
            Baglanti.Close();
            return tbl; 
        }
        public static void EkleSilGuncelle(SqlCommand command , string sorgu)
        {
            Baglanti.Open();
            command.Connection = Baglanti;
            command.CommandText = sorgu;
            command.ExecuteNonQuery();
            Baglanti.Close();
        }
        
       

    }
}

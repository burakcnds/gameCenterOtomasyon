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
    
    
    public partial class GameCenter : Form
        
    {
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = GameCenterDB; User ID = sa; Password=mmyo;Pooling=False");
        public GameCenter()
        {
            InitializeComponent();
        }
        //Button btn;
        //private void SecileneGore(object sender, MouseEventArgs e)
        //{
        //    btn = sender as Button;
        //    if (btn.BackColor==Color.OrangeRed)
        //    {
        //        süreliMasaAçToolStripMenuItem.Visible = false;
        //        süresizMasaAçToolStripMenuItem.Visible = false;
                
        //    }

        //    if (btn.BackColor == Color.LightGreen) 
        //    {
        //        süreliMasaAçToolStripMenuItem.Visible = true;
        //        süresizMasaAçToolStripMenuItem.Visible = true;
        //    }
        //}
        RadioButton radio;
        private void RadioButtonSecilen(object sender, EventArgs e)
        {
            radio = sender as RadioButton;
        }
        private void VeriCek()
        {
            
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM SaatUcreti";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SaatUcret.Items.Add(dr["SaatUcreti"]);
            }
            baglanti.Close();
        }
        public void DoluMasaGetir()
        {
            baglanti.Open();
            SqlDataAdapter adp = new SqlDataAdapter("Select MasaID From Masalar where Durumu='DOLU'", baglanti);
            DataTable tbldolu = new DataTable();
            adp.Fill(tbldolu);

            for (int k = 0; k < tbldolu.Rows.Count; k++)
            {
                int konum = Convert.ToInt32(tbldolu.Rows[k].ItemArray[0].ToString());
                panel2.Controls[konum - 1].BackColor = Color.OrangeRed;
            }


            

            baglanti.Close();

        }
        public void BossMasaGetir()
        {
            baglanti.Open();
            SqlDataAdapter adp = new SqlDataAdapter("Select MasaID From Masalar where Durumu='BOŞ'", baglanti);
            DataTable tbldolu = new DataTable();
            adp.Fill(tbldolu);

            for (int k = 0; k < tbldolu.Rows.Count; k++)
            {
                int konum = Convert.ToInt32(tbldolu.Rows[k].ItemArray[0].ToString());
                panel2.Controls[konum - 1].BackColor = Color.LimeGreen;
            }




            baglanti.Close();

        }



        public void Yenile()
        {
            Veritabanı.SepetListele(dataGridView1);
            Veritabanı.BosMasaGetir(cbBosMasalar);
            DoluMasaGetir();
            BossMasaGetir();




            //foreach (Control Button in Controls)
            //{
            //    if (Button is Button)
            //    {
            //        if (Button.Name != btnMasaAc.Name)
            //        {
            //            Veritabanı.Baglanti.Open();
            //            SqlCommand komut = new SqlCommand("select *from Masalar", Veritabanı.Baglanti);
            //            SqlDataReader dr = komut.ExecuteReader();
            //            while (dr.Read())
            //            {
            //                if (dr["Durumu"].ToString() == "BOŞ" && dr["Masalar"].ToString() == Button.Text)
            //                {
            //                    Button.BackColor = Color.LightGreen;
            //                }
            //                if (dr["Durumu"].ToString() == "DOLU" && dr["Masalar"].ToString() == Button.Text)
            //                {
            //                    Button.BackColor = Color.OrangeRed;
            //                }
            //            }
            //            Veritabanı.Baglanti.Close();
            //        }
            //    }
            //}

            //foreach (Control item in Controls)
            //{
            //    if (item is Button)
            //    {
            //        if (item.Name != cbBosMasalar.Name)
            //        {
            //            Veritabanı.Baglanti.Open();
            //            SqlCommand komut = new SqlCommand("select *from Masalar", Veritabanı.Baglanti);
            //            SqlDataReader dr = komut.ExecuteReader();
            //            while (dr.Read())
            //            {
            //                if (dr["Durumu"].ToString() == "BOŞ" && dr["Masalar"].ToString() == item.Text)
            //                {

            //                    item.BackColor = Color.LightGreen;
            //                }
            //                if (dr["Durumu"].ToString() == "DOLU" && dr["Masalar"].ToString() == item.Text)
            //                {

            //                    item.BackColor = Color.OrangeRed;
            //                }
            //            }
            //            Veritabanı.Baglanti.Close();
            //        }
            //    }

            //}


        }
        
        private void GameCenter_Load(object sender, EventArgs e)
        {
           
            rbSuresiz.Checked = true;
            Yenile();
            cbBosMasalar.Text = "";
            VeriCek();
            timer1.Start();
            SaatUcret.SelectedIndex = 0;
            cbBosMasalar.SelectedIndex = 1;

            //string sql2 = "Delete from Sepet where SepetID";
            //SqlCommand cmd2 = new SqlCommand();
            //Veritabanı.EkleSilGuncelle(cmd2, sql2);


        }
        
        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            string sqlsorgu = "insert into Sepet(MasaID,Masa,AcilisTuru,Baslangic,Tarih) " + "values('" + cbBosMasalar.Text.Substring(5) + "','" + cbBosMasalar.Text + "'" +
                       ",'" + radio.Text + "',@Baslangic,@Bitis)";
            SqlCommand komut = new SqlCommand();
           

            komut.Parameters.AddWithValue("@Baslangic", DateTime.Now);
            komut.Parameters.AddWithValue("@Bitis", DateTime.Now);

            Veritabanı.EkleSilGuncelle(komut, sqlsorgu);
            MessageBox.Show(cbBosMasalar.Text.Substring(5) + " nolu masa açıldı..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Yenile();
            rbSuresiz.Checked = true;
            


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hesapla"].Index)
            {
                if (SaatUcret.Text!="")
                {
                    DateTime BitisTarihi = DateTime.Now;
                    DateTime BaslangicTarihi = DateTime.Parse(dataGridView1.CurrentRow.Cells["Baslangic"].Value.ToString());
                    TimeSpan saatfarki = BitisTarihi - BaslangicTarihi;
                    double saatfarki2 = saatfarki.TotalHours;
                    dataGridView1.CurrentRow.Cells["Sure1"].Value = saatfarki2.ToString("0.00");
                    double toplamtutar = saatfarki2 * double.Parse(SaatUcret.Text);
                    dataGridView1.CurrentRow.Cells["Tutar"].Value = toplamtutar.ToString("0.00");
                    dataGridView1.CurrentRow.Cells["Bitis"].Value = BitisTarihi;

                }
                if (SaatUcret.Text=="")
                {
                    MessageBox.Show("Saat Ücreti Belirtiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (e.ColumnIndex == dataGridView1.Columns["MasaKapat"].Index)
            {
                if (dataGridView1.CurrentRow.Cells["Bitis"].Value !=null)
                {
                    MasaKapatForm frm = new MasaKapatForm();
                    frm.tbID.Text = dataGridView1.CurrentRow.Cells["SepetID"].Value.ToString();
                    frm.tbMasaID.Text = dataGridView1.CurrentRow.Cells["MasaID"].Value.ToString();
                    frm.tbMasa.Text = dataGridView1.CurrentRow.Cells["Masa"].Value.ToString();
                    frm.tbTur.Text = dataGridView1.CurrentRow.Cells["AcilisTuru"].Value.ToString();
                    frm.tbBaslaSaat.Text = dataGridView1.CurrentRow.Cells["Baslangic"].Value.ToString();
                    frm.tbBitisSaat.Text = dataGridView1.CurrentRow.Cells["Bitis"].Value.ToString();
                    frm.tbUcret.Text = SaatUcret.Text;
                    frm.tbSure.Text = dataGridView1.CurrentRow.Cells["Sure1"].Value.ToString();
                    frm.tbTutar.Text = dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
                    frm.tbTarih.Text = dataGridView1.CurrentRow.Cells["Tarih"].Value.ToString();
                    

                    frm.ShowDialog(); 
                }
               else if (dataGridView1.CurrentRow.Cells["Bitis"].Value==null)
                {
                    MessageBox.Show("Önce Hesaplama Yapılmalıdır ! ","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            

        }

        private void SureliIstek(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac>29)
            {
                if (SaatUcret.Text != "")
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DateTime BitisTarihi = DateTime.Now;
                        DateTime BaslangicTarihi = DateTime.Parse(dataGridView1.Rows[i].Cells["Baslangic"].Value.ToString());
                        TimeSpan saatfarki = BitisTarihi - BaslangicTarihi;
                        double saatfarki2 = saatfarki.TotalHours;
                        dataGridView1.Rows[i].Cells["Sure1"].Value = saatfarki2.ToString("0.00");
                        double toplamtutar = saatfarki2 * double.Parse(SaatUcret.Text);
                        dataGridView1.Rows[i].Cells["Tutar"].Value = toplamtutar.ToString("0.00");
                        dataGridView1.Rows[i].Cells["Bitis"].Value = BitisTarihi; 
                    }

                }
                if (SaatUcret.Text == "")
                {
                    MessageBox.Show("Saat Ücreti Belirtiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btMasaDegistir_Click(object sender, EventArgs e)
        {
            int SepetID = int.Parse(dataGridView1.CurrentRow.Cells["SepetID"].Value.ToString());
            int MasaID = int.Parse(dataGridView1.CurrentRow.Cells["MasaID"].Value.ToString());
            string sqlsorgu = "update Sepet set MasaID='"+int.Parse(cbBosMasalar.Text.Substring(5))+"',Masa='"+cbBosMasalar.Text+"' where SepetID='"+SepetID+"'";
            SqlCommand cmd = new SqlCommand();
            Veritabanı.EkleSilGuncelle(cmd, sqlsorgu);
            ///////
            string sqlsorgu2 = "Update Masalar set Durumu='BOŞ' where MasaID='"+MasaID+"'";
            SqlCommand cmd2 = new SqlCommand();
            Veritabanı.EkleSilGuncelle(cmd2, sqlsorgu2);
            /////
            string sqlsorgu3 = "update Masalar set Durumu='DOLU' where MasaID='"+int.Parse(cbBosMasalar.Text.Substring(5))+"'";
            SqlCommand cmd3 = new SqlCommand();
            Veritabanı.EkleSilGuncelle(cmd3, sqlsorgu3);
            Yenile();
            MessageBox.Show("Masa Değiştirme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["Sure1"].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString() != "Süresiz")
                    {
                        double sure = double.Parse(dataGridView1.Rows[i].Cells["Sure1"].Value.ToString()) * 60;
                        double AcilisTuru = double.Parse(dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString());
                        if (AcilisTuru - sure <= 5.0)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            

                        }
                    }
                }
            }
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            SatisListele sfrm = new SatisListele();
            sfrm.Enabled = true;
            sfrm.ShowDialog();
        }

        private void btnKayıtGoster_Click(object sender, EventArgs e)
        {
            CihazKiralaForm kfrm = new CihazKiralaForm();
            kfrm.Enabled = true;
            kfrm.ShowDialog();
        }

        private void btnKayıtEkle_Click(object sender, EventArgs e)
        {
            KiralamaYapForm kirafrm = new KiralamaYapForm();
            kirafrm.Enabled = true;
            kirafrm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

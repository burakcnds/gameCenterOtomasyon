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
    public partial class CihazKiralaForm : Form
    {
        public CihazKiralaForm()
        {
            InitializeComponent();
        }


        private void CihazKiralaForm_Load(object sender, EventArgs e)
        {
            Veritabanı.Listele(dataGridView1, "select *from Kirala");

          

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sql2 = "Delete from Kirala where KiralaID='" + int.Parse(dataGridView1.CurrentRow.Cells["KiralaID"].Value.ToString()) + "'";
            SqlCommand cmd2 = new SqlCommand();
            Veritabanı.EkleSilGuncelle(cmd2, sql2);
            MessageBox.Show("Kayıt Başarıyla Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Veritabanı.Listele(dataGridView1, "select *from Kirala");





        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dataGridView1.Columns["Hesapla"].Index)
            //{
            //    dataGridView1.CurrentRow.Cells["Sure"].Value = 7;
            //    DateTime.Now.AddDays(7);
            //}
           
        }
        }
    }


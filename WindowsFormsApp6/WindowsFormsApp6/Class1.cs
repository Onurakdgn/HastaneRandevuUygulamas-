using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    class Class1
    {
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=hastanerandevu;Integrated Security=True");
        public void listboxyukle(string sql, ListBox lb)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lb.DataSource = dt;
            lb.DisplayMember = dt.Columns[1].ColumnName;
            lb.ValueMember = dt.Columns[0].ColumnName;
        }

        public void randevu_al(string hasta, string tc, int doktorno, string tarih, int saatno)
        {
            string sql = "insert into randevular (hasta,tc,doktorno,tarih,saatno) values ('" + hasta + "',@tc,@doktorno,@tarih,@saatno)";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@tc", tc);
            komut.Parameters.AddWithValue("@doktorno", doktorno);
            komut.Parameters.AddWithValue("@tarih", tarih);
            komut.Parameters.AddWithValue("@saatno", saatno);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Randevunuz Kaydedildi", "Randevu");
        }

        public void dgv_yukle(DataGridView dgv)
        {
            //bag.Open();
            //string kayit = "SELECT * from randevular";
            //SqlCommand komut = new SqlCommand(kayit,bag);
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dgV.DataSource = dt;
            //bag.Close();

            //Mahmut Hocanın Attığı kısımdan aldım burada :D
            string sql = "select * from randevular";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgv.DataSource = tablo;
            //dgv.Columns[3].HeaderText = "TARİH";
            //dgv.Columns[2].HeaderText = "DOKTOR ADI";
            //dgv.Columns[4].HeaderText = "SAAT";
            //dgv.Columns[1].HeaderText = "HASTA ADI";
            //dgv.Columns[0].HeaderText = "R.NO";
            //dgv.Columns[4].Width = 60;
            //dgv.Columns[0].Width = 60;
        }
            public void sil(int randevuno)
            {
                string sql = "delete from randevular where randevuno = @prm1 ";
                SqlCommand komut = new SqlCommand(sql, bag);
                komut.Parameters.AddWithValue("@prm1", randevuno);
                bag.Open();
                komut.ExecuteNonQuery();
                bag.Close();
            }
        }
    }
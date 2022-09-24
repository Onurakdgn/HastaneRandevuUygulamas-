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

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 cl = new Class1();
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from poller";
            cl.listboxyukle(sql,lbpol);
            cl.dgv_yukle(dataGridView1);

        }

        private void lbpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int polno = (int)lbpol.SelectedValue;
            string sql = "select * from doktorlar where polno ='"+polno+"'";
            cl.listboxyukle(sql , lbdoktor);

        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            int doktoro = (int)lbdoktor.SelectedValue;
            string tarih = dtTarih.Value.ToShortDateString();
            string sql = "Select * from saatler where saatno not in (select saatno from randevular where doktorno='"+doktoro+"' and tarih ='"+tarih+"')";
            cl.listboxyukle(sql ,lbsaatler);
        }

        private void btrandevu_Click(object sender, EventArgs e)
        {
            string hasta = textBox1.Text;
            string tc = textBox2.Text;
            int doktorno = (int)lbdoktor.SelectedValue;
            string tarih = dtTarih.Value.ToShortDateString();
            int saatno = (int)lbsaatler.SelectedValue;
            cl.randevu_al(hasta,tc,doktorno,tarih,saatno);
            cl.dgv_yukle(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randevuno = Convert.ToInt32(textBox3.Text);
            cl.sil(randevuno);
            MessageBox.Show("Silindi");
            cl.dgv_yukle(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

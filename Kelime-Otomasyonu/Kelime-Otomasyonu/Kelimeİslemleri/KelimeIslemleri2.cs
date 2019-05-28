using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Kelime_Otomasyonu.Kelimeİslemleri
{
    public partial class KelimeIslemleri2 : DevExpress.XtraEditors.XtraForm
    {
        
        public KelimeIslemleri2()
        {
            InitializeComponent();
        }

        private void Btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection baglinti = new SqlConnection("Data Source=BEYZATAS;Initial Catalog=KelimeOtomasyonu;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        private void KelimeIslemleri2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(785, 200);
            cbSilIngilizce.Properties.Items.Clear();
            SqlDataReader oku;
            baglinti.Open();
            komut.Connection = baglinti;
            komut.CommandText = "select *from tbl_Kelime";
            oku = komut.ExecuteReader();
            while(oku.Read())
            {
                cbSilIngilizce.Properties.Items.Add(oku["Ingilizce"].ToString());
                cbSilTurkce.Properties.Items.Add(oku["Turkce"].ToString());
            }
            baglinti.Close();
        }

        private void BtnSilGetir_Click(object sender, EventArgs e)
        {
            baglinti.Open();
            SqlCommand komut = new SqlCommand("select *from tbl_Kelime where Ingilizce Like '" + cbSilIngilizce.Text + "'", baglinti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                cbSilTurkce.Text = read["Turkce"].ToString();
                txtSilincekCumle.Text = read["Cumle"].ToString();
            }
            baglinti.Close();
            baglinti.Open();
            SqlCommand kmt = new SqlCommand("select *from tbl_Kelime where Turkce Like '" + cbSilTurkce.Text + "'", baglinti);
            SqlDataReader rd = kmt.ExecuteReader();
            while (rd.Read())
            {
                cbSilIngilizce.Text = rd["Ingilizce"].ToString();
                txtSilincekCumle.Text = rd["Cumle"].ToString();
            }
            baglinti.Close();
        }
        void Temizle2()
        {
            cbSilIngilizce.Text = "";
            cbSilTurkce.Text = "";
            txtSilincekCumle.Text = "";
            Refresh();
        }

        private void BtnKSil_Click(object sender, EventArgs e)
        {
            baglinti.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_Kelime where Ingilizce='" + cbSilIngilizce.Text + "'", baglinti);
            cmd.ExecuteNonQuery();
            
            baglinti.Close();
            // MessageBox.Show("Kelime Başarıyla Silindi.");
            Temizle2();
        }
    }
}
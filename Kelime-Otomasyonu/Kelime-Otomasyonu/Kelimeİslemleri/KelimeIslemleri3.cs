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

namespace Kelime_Otomasyonu.Kelimeİslemleri
{
    public partial class KelimeIslemleri3 : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglinti = new SqlConnection("Data Source=BEYZATAS;Initial Catalog=KelimeOtomasyonu;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        public KelimeIslemleri3()
        {
            InitializeComponent();
        }

        private void Btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void KelimeIslemleri3_Load(object sender, EventArgs e)
        {
            this.Location = new Point(765, 185);
            cbGüncelleIngilizce.Properties.Items.Clear();
            SqlDataReader oku;
            baglinti.Open();
            komut.Connection = baglinti;
            komut.CommandText = "select *from tbl_Kelime";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbGüncelleIngilizce.Properties.Items.Add(oku["Ingilizce"].ToString());
                cbGuncelleTurkce.Properties.Items.Add(oku["Turkce"].ToString());
            }
            baglinti.Close();
        }

        private void BtnGuncelleGetir_Click(object sender, EventArgs e)
        {
            baglinti.Open();
            SqlCommand komut = new SqlCommand("select *from tbl_Kelime where Ingilizce Like '" + cbGüncelleIngilizce.Text + "'", baglinti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cbGuncelleTurkce.Text = read["Turkce"].ToString();
                txtGuncelleCumle.Text = read["Cumle"].ToString();
                txtGuncelleTurkce.Text = read["Turkce"].ToString();
                txtGuncelleIngilizce.Text = read["Ingilizce"].ToString();
                txtGuncelleCumle2.Text = read["Cumle"].ToString();
                
            }baglinti.Close();

            baglinti.Open();
            SqlCommand kmt = new SqlCommand("select *from tbl_Kelime where Turkce Like '" + cbGuncelleTurkce.Text + "'", baglinti);
            SqlDataReader rd = kmt.ExecuteReader();
            while (rd.Read())
            {
                cbGüncelleIngilizce.Text = rd["Ingilizce"].ToString();
                txtGuncelleCumle.Text = rd["Cumle"].ToString();
                txtGuncelleTurkce.Text = rd["Turkce"].ToString();
                txtGuncelleIngilizce.Text = rd["Ingilizce"].ToString();
                txtGuncelleCumle2.Text = rd["Cumle"].ToString();
            }
            baglinti.Close();
        }

        private void BtnKGuncelle_Click(object sender, EventArgs e)
        {
            Güncelle();
            
        }
        Kelime kelimeler = new Kelime();
        Fonksiyonlar.DataClasses1DataContext DB = new Fonksiyonlar.DataClasses1DataContext();
       
        void Güncelle()
        {
           
            Fonksiyonlar.tbl_Kelime klm = DB.tbl_Kelime.First(s => s.Ingilizce == cbGüncelleIngilizce.Text );
            kelimeler.Ingilizce = txtGuncelleIngilizce.Text;
            kelimeler.Turkce = txtGuncelleTurkce.Text;
            kelimeler.Cumle = txtGuncelleCumle2.Text;
            klm.Ingilizce = kelimeler.Ingilizce;
            klm.Turkce = kelimeler.Turkce;
            klm.Cumle = kelimeler.Cumle;
            klm.Tarih = DateTime.Now;
            klm.DogruBilme = 0;

           
            DB.SubmitChanges();
            MessageBox.Show("Kelime Başarıyla Güncellendi.");
            temizle3();                 
          
        }
        void temizle3()
        {
            cbGuncelleTurkce.Text = "";
            cbGüncelleIngilizce.Text = "";
            txtGuncelleCumle.Text = "";
            txtGuncelleCumle2.Text = "";
            txtGuncelleIngilizce.Text = "";
            txtGuncelleTurkce.Text = "";
        }
    }
}
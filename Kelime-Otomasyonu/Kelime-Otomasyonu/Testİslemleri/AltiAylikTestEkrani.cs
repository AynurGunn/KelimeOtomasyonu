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

namespace Kelime_Otomasyonu.Testİslemleri
{
    public partial class AltiAylikTestEkrani : DevExpress.XtraEditors.XtraForm
    {
        public AltiAylikTestEkrani()
        {
            InitializeComponent();
        }
        Fonksiyonlar.DataClasses1DataContext DB = new Fonksiyonlar.DataClasses1DataContext();
        Kelime_Otomasyonu.Kelime kelimeler = new Kelime_Otomasyonu.Kelime();
        SqlConnection baglinti = new SqlConnection("Data Source=BEYZATAS;Initial Catalog=KelimeOtomasyonu;Integrated Security=True");

        private void AltiAylikTestEkrani_Load(object sender, EventArgs e)
        {
            {
                this.Location = new Point(785, 178);
                Random rastgele = new Random();
                pbSiradaki.Enabled = false;
                String[] dizi = { "cbtnA", "cbtnB", "cbtnC", "cbtnD" };


                int sayi2 = 0, rdogru = 0;
                int a = 0, b = 0, c = 0, d = 0;
                sayi2 = rastgele.Next(31, 100);





                baglinti.Open();
                SqlCommand komut = new SqlCommand("select *from tbl_Kelime where ID Like '" + sayi2 + "' and DogruBilme>5", baglinti);
                SqlDataReader read = komut.ExecuteReader();

                while (read.Read())
                {


                    if ((read["Ingilizce"].ToString() == " ") && (read["Ingilizce"].ToString() == null))
                    {
                        Testİslemleri.TestEkranı tst = new Testİslemleri.TestEkranı();
                        tst.Show();
                    }
                    else
                        txtIngilizceSoru.Text = read["Ingilizce"].ToString();

                    rdogru = rastgele.Next(0, 3);

                    if (cbtnA.Name == dizi[rdogru])
                    {
                        cbtnA.Text = read["Turkce"].ToString();
                    }
                    if (cbtnB.Name == dizi[rdogru])
                    {
                        cbtnB.Text = read["Turkce"].ToString();
                    }
                    if (cbtnC.Name == dizi[rdogru])
                    {
                        cbtnC.Text = read["Turkce"].ToString();
                    }
                    if (cbtnD.Name == dizi[rdogru])
                    {
                        cbtnD.Text = read["Turkce"].ToString();
                    }

                }
                baglinti.Close();
                a = rastgele.Next(31, 100);
                baglinti.Open();
                SqlCommand komut2 = new SqlCommand("select *from tbl_Kelime where ID Like '" + a + "'", baglinti);
                SqlDataReader read2 = komut2.ExecuteReader();
                while (read2.Read())
                {


                    if (cbtnA.Text == " ")
                    {
                        cbtnA.Text = read2["Turkce"].ToString();

                    }


                }
                baglinti.Close();
                b = rastgele.Next(31, 100);
                baglinti.Open();
                SqlCommand komut3 = new SqlCommand("select *from tbl_Kelime where ID Like '" + b + "'", baglinti);
                SqlDataReader read3 = komut3.ExecuteReader();
                while (read3.Read())
                {


                    if (cbtnB.Text == " ")
                    {
                        cbtnB.Text = read3["Turkce"].ToString();
                    }


                }
                baglinti.Close();
                c = rastgele.Next(31, 100);
                baglinti.Open();
                SqlCommand komut4 = new SqlCommand("select *from tbl_Kelime where ID Like '" + c + "'", baglinti);
                SqlDataReader read4 = komut4.ExecuteReader();
                while (read4.Read())
                {


                    if (cbtnC.Text == " ")
                    {
                        cbtnC.Text = read4["Turkce"].ToString();
                    }


                }
                baglinti.Close();
                d = rastgele.Next(31, 100);
                baglinti.Open();
                SqlCommand komut5 = new SqlCommand("select *from tbl_Kelime where ID Like '" + d + "'", baglinti);
                SqlDataReader read5 = komut5.ExecuteReader();
                while (read5.Read())
                {


                    if (cbtnD.Text == " ")
                    {
                        cbtnD.Text = read5["Turkce"].ToString();
                    }


                }
                baglinti.Close();


            }
        }

        private void CbtnA_CheckedChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            int ay = dt.Month;

           
            cbtnA.Enabled = false;
            cbtnB.Enabled = false;
            cbtnC.Enabled = false;
            cbtnD.Enabled = false;
            pbSiradaki.Enabled = true;



            Fonksiyonlar.tbl_Kelime klm = DB.tbl_Kelime.First(s => s.Turkce == cbtnA.Text);
            Fonksiyonlar.tbl_Istatistik Ist = DB.tbl_Istatistik.First(s => s.AyTarih == ay);



            string btnA = " ";
            baglinti.Open();
            SqlCommand komut = new SqlCommand("select *from tbl_Kelime where Ingilizce Like '" + txtIngilizceSoru.Text + "'", baglinti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                btnA = read["Turkce"].ToString();
            }
            baglinti.Close();
            if (btnA == cbtnA.Text)
            {
                pbDogru.Visible = true;
                klm.DogruBilme++;
                DB.SubmitChanges();

                if (klm.DogruBilme == 4)
                {

                    Ist.BilinenKelimeSayisi++;
                    DB.SubmitChanges();
                }
            }
            else
                pbYanlis.Visible = true;
        }

        private void CbtnB_CheckedChanged(object sender, EventArgs e)
        {
            cbtnA.Enabled = false;
            cbtnB.Enabled = false;
            cbtnC.Enabled = false;
            cbtnD.Enabled = false;
            pbSiradaki.Enabled = true;

            DateTime dt = DateTime.Today;
            int ay = dt.Month;


            Fonksiyonlar.tbl_Kelime klm = DB.tbl_Kelime.First(s => s.Turkce == cbtnB.Text);
            Fonksiyonlar.tbl_Istatistik Ist = DB.tbl_Istatistik.First(s => s.AyTarih == ay);



            string btnB = " ";
            baglinti.Open();
            SqlCommand komut = new SqlCommand("select *from tbl_Kelime where Ingilizce Like '" + txtIngilizceSoru.Text + "'", baglinti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {


                btnB = read["Turkce"].ToString();


            }
            baglinti.Close();
            if (btnB == cbtnB.Text)
            {
                pbDogru.Visible = true;
                klm.DogruBilme++;
                DB.SubmitChanges();

                if (klm.DogruBilme == 4)
                {

                    Ist.BilinenKelimeSayisi++;
                    DB.SubmitChanges();

                }

            }
            else
                pbYanlis.Visible = true;
        }

        private void CbtnC_CheckedChanged(object sender, EventArgs e)
        {
            cbtnA.Enabled = false;
            cbtnB.Enabled = false;
            cbtnC.Enabled = false;
            cbtnD.Enabled = false;
            pbSiradaki.Enabled = true;

            DateTime dt = DateTime.Today;
            int ay = dt.Month;


            Fonksiyonlar.tbl_Kelime klm = DB.tbl_Kelime.First(s => s.Turkce == cbtnC.Text);
            Fonksiyonlar.tbl_Istatistik Ist = DB.tbl_Istatistik.First(s => s.AyTarih == ay);



            string btnC = " ";
            baglinti.Open();
            SqlCommand komut = new SqlCommand("select *from tbl_Kelime where Ingilizce Like '" + txtIngilizceSoru.Text + "'", baglinti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {


                btnC = read["Turkce"].ToString();


            }
            baglinti.Close();
            if (btnC == cbtnC.Text)
            {
                pbDogru.Visible = true;
                klm.DogruBilme++;
                DB.SubmitChanges();

                if (klm.DogruBilme == 4)
                {

                    Ist.BilinenKelimeSayisi++;
                    DB.SubmitChanges();

                }

            }
            else
                pbYanlis.Visible = true;
        }

        private void CbtnD_CheckedChanged(object sender, EventArgs e)
        {
            cbtnA.Enabled = false;
            cbtnB.Enabled = false;
            cbtnC.Enabled = false;
            cbtnD.Enabled = false;
            pbSiradaki.Enabled = true;

            DateTime dt = DateTime.Today;
            int ay = dt.Month;


            Fonksiyonlar.tbl_Kelime klm = DB.tbl_Kelime.First(s => s.Turkce == cbtnD.Text);
            Fonksiyonlar.tbl_Istatistik Ist = DB.tbl_Istatistik.First(s => s.AyTarih == ay);



            string btnD = " ";
            baglinti.Open();
            SqlCommand komut = new SqlCommand("select *from tbl_Kelime where Ingilizce Like '" + txtIngilizceSoru.Text + "'", baglinti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {


                btnD = read["Turkce"].ToString();


            }
            baglinti.Close();
            if (btnD == cbtnD.Text)
            {
                pbDogru.Visible = true;
                klm.DogruBilme++;
                DB.SubmitChanges();

                if (klm.DogruBilme == 4)
                {

                    Ist.BilinenKelimeSayisi++;
                    DB.SubmitChanges();

                }

            }
            else
                pbYanlis.Visible = true;
        }

        private void Sbtntestibitir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbSiradaki_Click(object sender, EventArgs e)
        {
            Testİslemleri.AltiAylikTestEkrani tst = new Testİslemleri.AltiAylikTestEkrani();
            this.Close();
            tst.Show();
        }
    }
}
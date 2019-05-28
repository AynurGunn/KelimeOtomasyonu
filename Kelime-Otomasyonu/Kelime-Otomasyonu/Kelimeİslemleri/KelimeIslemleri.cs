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
    public partial class KelimeIslemleri : DevExpress.XtraEditors.XtraForm
    {
      
        Kelime kelimeler = new Kelime();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.DataClasses1DataContext DB = new Fonksiyonlar.DataClasses1DataContext();
        public KelimeIslemleri()
        {
            InitializeComponent();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Temizle()
        {
            txtKingilizce.Text = "";
            txtKtürkce.Text = "";
            txtKcümle.Text = "";
        }
        void KelimeEkle()
        {
            try
            {
                Fonksiyonlar.tbl_Kelime klm = new Fonksiyonlar.tbl_Kelime();
               
                kelimeler.Ingilizce = txtKingilizce.Text;
                kelimeler.Turkce = txtKtürkce.Text;
                kelimeler.Cumle = txtKcümle.Text;
                klm.Ingilizce = kelimeler.Ingilizce;
                klm.Turkce = kelimeler.Turkce;
                klm.Cumle = kelimeler.Cumle;
                klm.Tarih = DateTime.Now;
                klm.DogruBilme = 8;
               
              
             
              
                DB.tbl_Kelime.InsertOnSubmit(klm);
                DB.SubmitChanges();
               // MessageBox.Show("Kelime Başarıyla Eklendi.");
                Temizle();
            }
            catch(Exception)
            {

            }
        }       
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            KelimeEkle();
            
        }

        private void KelimeIslemleri_Load(object sender, EventArgs e)
        {
            this.Location = new Point(795, 200);
        }
    }
    
}
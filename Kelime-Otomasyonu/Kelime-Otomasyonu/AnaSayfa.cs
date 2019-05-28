using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Kelime_Otomasyonu
{
    public partial class AnaSayfa : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        public AnaSayfa()
        {
            InitializeComponent();

        }

        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {

            Kelimeİslemleri.KelimeIslemleri klm = new Kelimeİslemleri.KelimeIslemleri();
            klm.Show();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kelime Otomasyonu sistemi 2018-2019 ikinci yarıyıl yazılım yapımı ödevi.", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRenk1_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.BackColor = Color.CadetBlue;
        }

        private void BtnRenk2_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.BackColor = Color.BurlyWood;
        }

        private void BtnRenk3_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.BackColor = Color.Tomato;
        }

        private void BtnRenk4_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.BackColor = Color.Plum;
        }

        private void BtnRenk5_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.BackColor = Color.SlateBlue;
        }

        private void BtnRenk6_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.BackColor = Color.SlateGray;
        }

        private void BtnKelimeSilme_Click(object sender, EventArgs e)
        {
            Kelimeİslemleri.KelimeIslemleri2 klm = new Kelimeİslemleri.KelimeIslemleri2();
            klm.Show();
        }

        private void BtnKelimeGuncelle_Click(object sender, EventArgs e)
        {
            Kelimeİslemleri.KelimeIslemleri3 klm = new Kelimeİslemleri.KelimeIslemleri3();
            klm.Show();
        }

        private void BtnOgrenillenKelimeler_Click(object sender, EventArgs e)
        {
            Kelimeİslemleri.ÖgrenilenKelimeler klm = new Kelimeİslemleri.ÖgrenilenKelimeler();
            klm.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 140);
        }



        private void BtnYillikGrafik_Click(object sender, EventArgs e)
        {
            Istatistikİslemleri.Istatistik Ist = new Istatistikİslemleri.Istatistik();
            Ist.Show();
        }

        private void BtnOgrenmeYuzdesi_Click(object sender, EventArgs e)
        {
            Istatistikİslemleri.YüzdeIstatistik Ist = new Istatistikİslemleri.YüzdeIstatistik();
            Ist.Show();
        }

        private void BtnYeniTest_Click(object sender, EventArgs e)
        {
            Testİslemleri.TestEkranı tst = new Testİslemleri.TestEkranı();
            tst.Show();
        }

        private void BtnHaftalikTest_Click(object sender, EventArgs e)
        {
            Testİslemleri.HaftalikTestEkrani tst = new Testİslemleri.HaftalikTestEkrani();
            tst.Show();
        }

        private void BtnAylikTest_Click(object sender, EventArgs e)
        {
            Testİslemleri.AylikTestEkranıi tst = new Testİslemleri.AylikTestEkranıi();
            tst.Show();
        }

        private void Btn6AylilTest_Click(object sender, EventArgs e)
        {
            Testİslemleri.AltiAylikTestEkrani tst = new Testİslemleri.AltiAylikTestEkrani();
            tst.Show();
        }

        private void FluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }
    }
}

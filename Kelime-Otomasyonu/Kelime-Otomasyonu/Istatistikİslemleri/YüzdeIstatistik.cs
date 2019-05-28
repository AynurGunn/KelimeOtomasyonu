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
namespace Kelime_Otomasyonu.Istatistikİslemleri
{
    public partial class YüzdeIstatistik : DevExpress.XtraEditors.XtraForm
    {
        public YüzdeIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglinti = new SqlConnection("Data Source=BEYZATAS;Initial Catalog=KelimeOtomasyonu;Integrated Security=True");
        private void YüzdeIstatistik_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 140);
            int dBilme = 0,ogrenilen=0,ogrenilecek=0;

            baglinti.Open();
            SqlCommand komutg = new SqlCommand("Select DogruBilme from tbl_Kelime", baglinti);
            SqlDataReader read = komutg.ExecuteReader();

            while (read.Read())
            {
                dBilme = int.Parse(read["DogruBilme"].ToString());
                if (dBilme >= 4)
                {
                    ogrenilen++;
                }
                else ogrenilecek++;

            }
            baglinti.Close();

            cYuzdelik.Titles.Add("ÖĞRENİLEN KELİMELERİN YÜZDELERİ");
            cYuzdelik.Series["sYuzdelik"].IsValueShownAsLabel = true;
            cYuzdelik.Series["sYuzdelik"].Points.AddXY("Öğrenilen", ogrenilen);
            cYuzdelik.Series["sYuzdelik"].Points.AddXY("Öğrenilecek", ogrenilecek);                       
        }

      
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneBilgiYonetim
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TC;
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            TxtTcKimlik.Text = TC;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtTcKimlik.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                TxtTcKimlik.Text = dr[3].ToString();
                TxtTelefon.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
                CmbBoxCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();

        }

        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text.Trim());
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text.Trim());
            komut2.Parameters.AddWithValue("@p3", TxtTelefon.Text.Trim());
            komut2.Parameters.AddWithValue("@p4", TxtSifre.Text.Trim());
            komut2.Parameters.AddWithValue("@p5", CmbBoxCinsiyet.Text.Trim());
            komut2.Parameters.AddWithValue("@p6", TxtTcKimlik.Text.Trim());
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

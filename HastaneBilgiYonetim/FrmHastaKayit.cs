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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            var conn = bgl.baglanti();
            using (SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", conn))
            {
                komut.Parameters.AddWithValue("@p1", TxtAd.Text.Trim());
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text.Trim());
                komut.Parameters.AddWithValue("@p3", TxtTcKimlik.Text.Trim());
                komut.Parameters.AddWithValue("@p4", TxtTelefon.Text.Trim());
                komut.Parameters.AddWithValue("@p5", TxtSifre.Text.Trim());
                komut.Parameters.AddWithValue("@p6", CmbBoxCinsiyet.Text.Trim());

                try
                {
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt işleminiz başarıyla gerçekleşmiştir. Şifreniz: " + TxtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    try { conn.Close(); } catch { }
                }
            }
        }

        private bool ValidateForm()
        {
            var missing = new List<string>();

            if (string.IsNullOrWhiteSpace(TxtAd.Text))
                missing.Add("Ad");
            if (string.IsNullOrWhiteSpace(TxtSoyad.Text))
                missing.Add("Soyad");
            if (string.IsNullOrWhiteSpace(TxtTcKimlik.Text))
                missing.Add("TC Kimlik");
            if (string.IsNullOrWhiteSpace(TxtTelefon.Text))
                missing.Add("Telefon");
            if (string.IsNullOrWhiteSpace(TxtSifre.Text))
                missing.Add("Şifre");
            if (string.IsNullOrWhiteSpace(CmbBoxCinsiyet.Text))
                missing.Add("Cinsiyet");

            if (missing.Any())
            {
                var msg = "Lütfen aşağıdaki alanları doldurun:\n- " + string.Join("\n- ", missing);
                MessageBox.Show(msg, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            TxtAd.Clear();
            TxtSoyad.Clear();
            TxtTcKimlik.Clear();
            TxtTelefon.Clear();
            TxtSifre.Clear();
            CmbBoxCinsiyet.SelectedIndex = -1;
        }

    }
}


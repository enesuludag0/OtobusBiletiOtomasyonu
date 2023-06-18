using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTextSharp.awt.geom.Point2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OtobusBiletiOtomasyonu
{
    public partial class UyeOl : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=otobusdb;Uid=root;Pwd=enes123");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public static string adSoyad = "";
        public static string tcKimlikNo = "";
        public static string dogumTarihi = "";
        public static string cinsiyet = "";
        public static string telefonNo = "";
        public static string eMail = "";
        public static string sifre = "";
        public static int id;
        public static string formAdi = "";
        public UyeOl()
        {
            InitializeComponent();
        }

        private void bttnUyeOl_Click(object sender, EventArgs e)
        {
            bul();
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanicilar WHERE email='" + textBoxEmail.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    id = dr.GetInt32("id");
                }
            }
            con.Close();
        }

        private void kaydet()
        {
            string kaydetSorgu = "INSERT INTO kullanicilar (ad_soyad,tc_kimlik,dogum_tarihi,cinsiyet,cep_telefonu,email,sifre) VALUES " +
                "(@ad_soyad,@tc_kimlik,@dogum_tarihi,@cinsiyet,@cep_telefonu,@email,@sifre)";
            cmd = new MySqlCommand(kaydetSorgu, con);
            cmd.Parameters.AddWithValue("@ad_soyad", textBoxAdSoyad.Text);
            cmd.Parameters.AddWithValue("@tc_kimlik", maskedTextBoxTcKimlikNo.Text);
            cmd.Parameters.AddWithValue("@dogum_tarihi", maskedTextBoxDogumTarihi.Text);
            if (radioBttnErkek.Checked)
            {
                cmd.Parameters.AddWithValue("@cinsiyet", radioBttnErkek.Text);
            }
            else if (radioBttnKadin.Checked)
            {
                cmd.Parameters.AddWithValue("@cinsiyet", radioBttnKadin.Text);
            }
            cmd.Parameters.AddWithValue("@cep_telefonu", maskedTextBoxTelefonNo.Text);
            cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("@sifre", textBoxSifre.Text);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Üyeliğiniz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            adSoyad = textBoxAdSoyad.Text;
            tcKimlikNo = maskedTextBoxTcKimlikNo.Text;
            dogumTarihi = maskedTextBoxDogumTarihi.Text;
            if (radioBttnErkek.Checked)
            {
                cinsiyet = radioBttnErkek.Text;
            }
            else if (this.radioBttnKadin.Checked)
            {
                cinsiyet = radioBttnKadin.Text;
            }
            telefonNo = maskedTextBoxTelefonNo.Text;
            eMail = textBoxEmail.Text;
            sifre = textBoxSifre.Text;

            ProfilGuncelle profil = new ProfilGuncelle(adSoyad, tcKimlikNo, dogumTarihi, cinsiyet, telefonNo, eMail, sifre, id);
            formAdi = "Üye Ol";

            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
            con.Close();
        }

        private void bul()
        {
            string email = textBoxEmail.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanicilar WHERE email='" + email + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                 MessageBox.Show("Girmiş olduğunuz e-mail adresi ile üyeliğiniz bulunmaktadır.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 con.Close();
            }
            else
            {
                con.Close();
                kaydet();
            }
        }

        private void bttnGiris_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
            ProfilGuncelle profil = new ProfilGuncelle(adSoyad, tcKimlikNo, dogumTarihi, cinsiyet, telefonNo, eMail, sifre, id);
        }

        private void checkBoxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifreGoster.Checked)
            {
                textBoxSifre.PasswordChar = '\0';
            }
            else
            {
                textBoxSifre.PasswordChar = '●';
            }
        }
    }
}

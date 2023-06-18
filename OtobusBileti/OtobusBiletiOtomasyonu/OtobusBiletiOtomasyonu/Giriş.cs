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
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;

namespace OtobusBiletiOtomasyonu
{
    public partial class Giris : Form
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
        public Giris()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanicilar WHERE email='" + textBoxEmail.Text + "' AND sifre='" + textBoxSifre.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    id = dr.GetInt32("id");
                    adSoyad = dr.GetString("ad_soyad");
                    tcKimlikNo = dr.GetString("tc_kimlik");
                    dogumTarihi = dr.GetString("dogum_tarihi");
                    cinsiyet = dr.GetString("cinsiyet");
                    telefonNo = dr.GetString("cep_telefonu");
                    eMail = dr.GetString("email");
                    sifre = dr.GetString("sifre");
                    formAdi = "Giriş";
                    AnaMenu anaMenu = new AnaMenu();
                    anaMenu.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("E-mail adresi ve şifrenizi kontrol ederek tekrar deneyiniz.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void bttnHemenUyeOl_Click(object sender, EventArgs e)
        {
            UyeOl uyeOl = new UyeOl();
            uyeOl.Show();
            this.Hide();
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

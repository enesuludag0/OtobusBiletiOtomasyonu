using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OtobusBiletiOtomasyonu
{
    public partial class ProfilGuncelle : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=otobusdb;Uid=root;Pwd=enes123");
        MySqlCommand cmd;

        public ProfilGuncelle(string adSoyad, string tcKimlikNo, string dogumTarihi, string cinsiyet, string telefonNo, string eMail, string sifre, int id)
        {
            InitializeComponent();

            textBoxAdSoyad.Text = adSoyad;
            maskedTextBoxTcKimlikNo.Text = tcKimlikNo;
            maskedTextBoxDogumTarihi.Text = dogumTarihi.ToString();
            if (cinsiyet == "Erkek")
            {
                radioBttnErkek.Checked = true;
            }
            else if (cinsiyet == "Kadın")
            {
                radioBttnKadin.Checked = true;
            }
            maskedTextBoxTelefonNo.Text = telefonNo;
            textBoxEmail.Text = eMail;
            textBoxSifre.Text = sifre;
            lblid.Text = id.ToString();
        }

        private void bttnBilgilerimiGuncelle_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE kullanicilar SET ad_soyad=@ad_soyad,tc_kimlik=@tc_kimlik,dogum_tarihi=@dogum_tarihi," +
               "cinsiyet=@cinsiyet,cep_telefonu=@cep_telefonu,email=@email,sifre=@sifre WHERE id=@id";
            con.Open();
            cmd = new MySqlCommand(sql, con);
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
            cmd.Parameters.AddWithValue("@id", lblid.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz başarılı bir şekilde güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
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

        private void bttnGeri_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
        }
    }
}

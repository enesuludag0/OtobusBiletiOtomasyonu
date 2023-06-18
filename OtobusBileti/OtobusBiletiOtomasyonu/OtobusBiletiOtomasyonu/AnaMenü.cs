using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletiOtomasyonu
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
        private void bttnOtobusBiletiBul_Click(object sender, EventArgs e)
        {
            if (comboBoxNereden.Text == comboBoxNereye.Text)
            {
                if (comboBoxNereden.Text.Equals("Seçiniz"))
                {
                    MessageBox.Show("Lütfen lokasyon seçiniz.", "Geçersiz Arama", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!comboBoxNereden.Text.Equals("Seçiniz"))
                {
                    MessageBox.Show("Gidiş ve dönüş için aynı lokasyonu seçtiniz.\n        Lütfen farklı bir lokasyon seçiniz.", "Geçersiz Arama", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (comboBoxNereden.Text != comboBoxNereye.Text)
            {
                if (comboBoxNereden.Text.Equals("Seçiniz") && !comboBoxNereye.Text.Equals("Seçiniz"))
                {
                    MessageBox.Show("Lütfen nereden kalkacağınızı seçiniz.", "Geçersiz Arama", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!comboBoxNereden.Text.Equals("Seçiniz") && comboBoxNereye.Text.Equals("Seçiniz"))
                {
                    MessageBox.Show("Lütfen nereye varacağınızı seçiniz.", "Geçersiz Arama", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (radioBttnBugun.Checked == true || radioBttnYarin.Checked == true)
                {
                    OtobusBiletiBul otobusBiletiBul = new OtobusBiletiBul();
                    otobusBiletiBul.lblKalkis.Text = comboBoxNereden.Text;
                    otobusBiletiBul.lblVaris.Text = comboBoxNereye.Text;
                    if (radioBttnBugun.Checked)
                    {
                        otobusBiletiBul.lblTarih.Text = radioBttnBugun.Text;
                        otobusBiletiBul.bttnOnceki.Enabled = false;
                    }
                    else if (radioBttnYarin.Checked)
                    {
                        otobusBiletiBul.lblTarih.Text = radioBttnYarin.Text;
                        otobusBiletiBul.bttnSonraki.Enabled = false;
                    }
                    otobusBiletiBul.Show();
                    this.Hide();
                }
                else if (radioBttnBugun.Checked == false && radioBttnYarin.Checked == false)
                {
                    MessageBox.Show("Lütfen gidiş tarihi seçiniz.", "Geçersiz Arama", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bttnDegistir_Click(object sender, EventArgs e)
        {
            string txt = comboBoxNereden.Text;
            comboBoxNereden.Text = comboBoxNereye.Text;
            comboBoxNereye.Text = txt;
        }

        private void radioBttnBugun_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttnBugun.Checked)
            {
                radioBttnBugun.BackColor = Color.YellowGreen;
                radioBttnBugun.ForeColor = Color.White;
            }
            else
            {
                radioBttnBugun.BackColor = Color.White;
                radioBttnBugun.ForeColor = Color.Black;
            }
        }

        private void radioBttnYarin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttnYarin.Checked)
            {
                radioBttnYarin.BackColor = Color.YellowGreen;
                radioBttnYarin.ForeColor = Color.White;
            }
            else
            {
                radioBttnYarin.BackColor = Color.White;
                radioBttnYarin.ForeColor = Color.Black;
            }
        }

        private void bttnProfilim_Click(object sender, EventArgs e)
        {
            if (UyeOl.formAdi == "Üye Ol")
            {
                ProfilGuncelle profil1 = new ProfilGuncelle(UyeOl.adSoyad, UyeOl.tcKimlikNo, UyeOl.dogumTarihi, UyeOl.cinsiyet, UyeOl.telefonNo, UyeOl.eMail, UyeOl.sifre, UyeOl.id);
                profil1.Show();
                this.Hide();
            }
            else if (Giris.formAdi == "Giriş")
            {
                ProfilGuncelle profil2 = new ProfilGuncelle(Giris.adSoyad, Giris.tcKimlikNo, Giris.dogumTarihi, Giris.cinsiyet, Giris.telefonNo, Giris.eMail, Giris.sifre, Giris.id);
                profil2.Show();
                this.Hide();
            }
        }

        private void bttnPnrSorgula_Click(object sender, EventArgs e)
        {
            PnrBiletSorgula pnrBiletSorgula = new PnrBiletSorgula();
            pnrBiletSorgula.Show();
            this.Hide();
        }

        private void bttnCikis_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}

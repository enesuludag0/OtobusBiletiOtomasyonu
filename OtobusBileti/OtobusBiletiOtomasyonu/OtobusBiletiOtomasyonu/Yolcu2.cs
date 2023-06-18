using MySql.Data.MySqlClient;
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
    public partial class Yolcu2 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=otobusdb;Uid=root;Pwd=enes123");
        MySqlCommand cmd;
        public Yolcu2()
        {
            InitializeComponent();
        }

        private void bttnFiyat_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int min = 100000, max = 999999;
            int pnr = random.Next(max - min) + min;
            con.Open();
            string kaydetSorgu = "INSERT INTO biletler (turizm,pnr_no,kalkis,varis,tarih,saat,tahmini_sure,yolcu1,yolcu2,koltuk_no1,koltuk_no2,alinan_koltuk_sayisi,fiyat) " +
                "VALUES (@turizm,@pnr_no,@kalkis,@varis,@tarih,@saat,@tahmini_sure,@yolcu1,@yolcu2,@koltuk_no1,@koltuk_no2,@alinan_koltuk_sayisi,@fiyat)";
            cmd = new MySqlCommand(kaydetSorgu, con);
            cmd.Parameters.AddWithValue("@turizm", OtobusBiletiBul.turizm);
            cmd.Parameters.AddWithValue("@pnr_no", pnr);
            cmd.Parameters.AddWithValue("@kalkis", OtobusBiletiBul.kalkis);
            cmd.Parameters.AddWithValue("@varis", OtobusBiletiBul.varis);
            cmd.Parameters.AddWithValue("@tarih", OtobusBiletiBul.tarih);
            cmd.Parameters.AddWithValue("@saat", OtobusBiletiBul.saat);
            cmd.Parameters.AddWithValue("@tahmini_sure", OtobusBiletiBul.tahminiSure);
            cmd.Parameters.AddWithValue("@yolcu1", textBoxAdSoyad1.Text);
            cmd.Parameters.AddWithValue("@yolcu2", textBoxAdSoyad2.Text);
            cmd.Parameters.AddWithValue("@koltuk_no1", lblKoltukNo1.Text);
            cmd.Parameters.AddWithValue("@koltuk_no2", lblKoltukNo2.Text);
            cmd.Parameters.AddWithValue("@alinan_koltuk_sayisi", KoltukSecim.secilenKoltukSayisi);
            cmd.Parameters.AddWithValue("@fiyat", OtobusBiletiBul.fiyat.ToString());
            cmd.ExecuteNonQuery();

            MessageBox.Show("Ödemeniz başarıyla gerçekleşti!\nBiletinizi " + pnr + " PNR no. ile sorgulatabilirsiniz.", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Question);
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
            con.Close();
        }
    }
}

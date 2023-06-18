using iTextSharp.text;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class PnrBiletSorgula : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=otobusdb;Uid=root;Pwd=enes123");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader dr;
        DataTable dt;
        public string koltukSayisi = "";
        public int fiyat;
        public PnrBiletSorgula()
        {
            InitializeComponent();
        }

        private void bttnBiletSorgula_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM biletler WHERE pnr_no='" + textBoxPnr.Text + "'", con);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    koltukSayisi = dr["alinan_koltuk_sayisi"].ToString();
                    fiyat = Convert.ToInt32(dr["fiyat"].ToString());
                    this.Size = new Size(1170, 335);
                }
            }
            else
            {
                MessageBox.Show("Geçersiz PNR kodu", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            if (koltukSayisi == "1")
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT turizm,pnr_no,kalkis,varis,tarih,saat,tahmini_sure,yolcu1,koltuk_no1,fiyat FROM biletler WHERE pnr_no='" + textBoxPnr.Text + "'", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgwListe.DataSource = dt;
                con.Close();
                lblToplamTutar.Text = fiyat.ToString();
            }
            else if (koltukSayisi == "2")
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT turizm,pnr_no,kalkis,varis,tarih,saat,tahmini_sure,yolcu1,yolcu2,koltuk_no1,koltuk_no2,fiyat FROM biletler WHERE pnr_no='" + textBoxPnr.Text + "'", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgwListe.DataSource = dt;
                con.Close();
                lblToplamTutar.Text = (fiyat * 2).ToString();
            }
            else if (koltukSayisi == "3")
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT turizm,pnr_no,kalkis,varis,tarih,saat,tahmini_sure,yolcu1,yolcu2,yolcu3,koltuk_no1,koltuk_no2,koltuk_no3,fiyat FROM biletler WHERE pnr_no='" + textBoxPnr.Text + "'", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgwListe.DataSource = dt;
                con.Close();
                lblToplamTutar.Text = (fiyat * 3).ToString();
            }
            else if (koltukSayisi == "4")
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT turizm,pnr_no,kalkis,varis,tarih,saat,tahmini_sure,yolcu1,yolcu2,yolcu3,yolcu4,koltuk_no1,koltuk_no2,koltuk_no3,koltuk_no4,fiyat FROM biletler WHERE pnr_no='" + textBoxPnr.Text + "'", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgwListe.DataSource = dt;
                con.Close();
                lblToplamTutar.Text = (fiyat * 4).ToString();
            }
        }

        private void bttnGeri_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
        }

        private void bttnBiletIptal_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM biletler WHERE pnr_no='" + dgwListe.SelectedRows[0].Cells["pnr_no"].Value.ToString() + "'";
            con.Open();
            cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Biletiniz iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

            if (koltukSayisi == "1")
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT turizm,pnr_no,kalkis,varis,tarih,saat,tahmini_sure,yolcu1,koltuk_no1,fiyat FROM biletler WHERE pnr_no='" + textBoxPnr.Text + "'", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgwListe.DataSource = dt;
                con.Close();
                label1.Text = "";
                lblToplamTutar.Text = ""; 
            }
            else if (koltukSayisi == "2")
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT turizm,pnr_no,kalkis,varis,tarih,saat,tahmini_sure,yolcu1,yolcu2,koltuk_no1,koltuk_no2,fiyat FROM biletler WHERE pnr_no='" + textBoxPnr.Text + "'", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgwListe.DataSource = dt;
                con.Close();
                label1.Text = "";
                lblToplamTutar.Text = "";
            }
            else if (koltukSayisi == "3")
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT turizm,pnr_no,kalkis,varis,tarih,saat,tahmini_sure,yolcu1,yolcu2,yolcu3,koltuk_no1,koltuk_no2,koltuk_no3,fiyat FROM biletler WHERE pnr_no='" + textBoxPnr.Text + "'", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgwListe.DataSource = dt;
                con.Close();
                label1.Text = "";
                lblToplamTutar.Text = "";
            }
            else if (koltukSayisi == "4")
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT turizm,pnr_no,kalkis,varis,tarih,saat,tahmini_sure,yolcu1,yolcu2,yolcu3,yolcu4,koltuk_no1,koltuk_no2,koltuk_no3,koltuk_no4,fiyat FROM biletler WHERE pnr_no='" + textBoxPnr.Text + "'", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgwListe.DataSource = dt;
                con.Close();
                label1.Text = "";
                lblToplamTutar.Text = "";
            }
        }
    }
}

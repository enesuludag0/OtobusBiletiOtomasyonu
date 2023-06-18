using MySql.Data.MySqlClient;
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

namespace OtobusBiletiOtomasyonu
{
    public partial class OtobusBiletiBul : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        public static string turizm;
        public static string kalkis;
        public static string varis;
        public static string tarih;
        public static string saat;
        public static string tahminiSure;
        public static int fiyat;
        public OtobusBiletiBul()
        {
            InitializeComponent();
        }

        public void OtobusBiletiBul_Load(object sender, EventArgs e)
        {
            veriGetir(); 
        }
        public void veriGetir()
        {
            con = new MySqlConnection("Server=localhost;Database=otobusdb;Uid=root;Pwd=enes123");
            con.Open();
            string query = "SELECT turizm,kalkis,varis,tarih,saat,tahmini_sure,fiyat FROM seferler WHERE kalkis='" + lblKalkis.Text + "' AND varis='" + lblVaris.Text + "' AND tarih='" + lblTarih.Text + "' ORDER BY saat ASC";
            cmd = new MySqlCommand(query, con);
            adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgwListe.DataSource = dt;
            con.Close();
        }

        public void bttnDegistir_Click(object sender, EventArgs e)
        {
            string txt = lblKalkis.Text;
            lblKalkis.Text = lblVaris.Text;
            lblVaris.Text = txt;
            veriGetir();
        }

        public void bttnSonraki_Click(object sender, EventArgs e)
        {
            lblTarih.Text = "Yarın";
            bttnOnceki.Enabled = true;
            bttnSonraki.Enabled = false;
            veriGetir();
        }

        public void bttnOnceki_Click(object sender, EventArgs e)
        {
            lblTarih.Text = "Bugün";
            bttnOnceki.Enabled = false;
            bttnSonraki.Enabled = true;
            veriGetir();
        }

        private void dgwListe_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            KoltukSecim koltukSecimi = new KoltukSecim();
            koltukSecimi.Show();
            turizm = dgwListe.CurrentRow.Cells[0].Value.ToString();
            kalkis = dgwListe.CurrentRow.Cells[1].Value.ToString();
            varis = dgwListe.CurrentRow.Cells[2].Value.ToString();
            tarih = dgwListe.CurrentRow.Cells[3].Value.ToString();
            saat = dgwListe.CurrentRow.Cells[4].Value.ToString();
            tahminiSure = dgwListe.CurrentRow.Cells[5].Value.ToString();
            fiyat = Convert.ToInt32(dgwListe.CurrentRow.Cells[6].Value);
        }   
        private void bttnGeri_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
        }
    }
}

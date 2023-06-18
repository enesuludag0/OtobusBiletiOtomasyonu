using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WECPOFLogic;

namespace OtobusBiletiOtomasyonu
{
    public partial class KoltukSecim : Form
    {
        public Button[] koltuk;
        public int koltukNoErkek;
        public int koltukNoKadin;
        public static int secilenKoltukSayisi = 0;
        public List<string> secilenKoltukNolari = new List<string>();
        public string[] cinsiyet;
        public KoltukSecim()
        {
            InitializeComponent();
        }

        public void KoltukSecimi_Load(object sender, EventArgs e)
        {
            koltuk = new Button[40] {button1,button2,button3,button4,button5,button6,button7,button8,button9,button10,
            button11,button12,button13,button14,button15,button16,button17,button18,button19,button20,
            button21,button22,button23,button24,button25,button26,button27,button28,button29,button30,
            button31,button32,button33,button34,button35,button36,button37,button38,button39,button40};
            
            Random random = new Random();
            int doluKoltukSayısıErkek = random.Next(1, 41);
            int dolukoltukSayısıKadin = random.Next(1, 41);

            while (doluKoltukSayısıErkek + dolukoltukSayısıKadin > 40)
            {
                doluKoltukSayısıErkek = random.Next(1, 41);
                dolukoltukSayısıKadin = random.Next(1, 41);
            }
            
            for (int i = 0; i < doluKoltukSayısıErkek; i++)
            {
                koltukNoErkek = random.Next(1, 41);
                if (koltuk[koltukNoErkek - 1].Text == koltukNoErkek.ToString())
                {
                    koltuk[koltukNoErkek - 1].BackColor = Color.DeepSkyBlue;
                    koltuk[koltukNoErkek - 1].Enabled = false;
                }
            }

            for (int i = 0; i < dolukoltukSayısıKadin; i++)
            {
                koltukNoKadin = random.Next(1, 41);
                if (koltuk[koltukNoKadin - 1].Text == koltukNoKadin.ToString())
                {
                    koltuk[koltukNoKadin - 1].BackColor = Color.HotPink;
                    koltuk[koltukNoKadin - 1].Enabled = false;
                }
            }
        }

        private void bttnKoltukNo_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button buton = (System.Windows.Forms.Button)sender;
            MessageBoxManager.Yes = "Erkek";
            MessageBoxManager.No = "Kadın";
            MessageBoxManager.Cancel = "Kaldır";
            MessageBoxManager.Register_OnceOnly();
            DialogResult result = MessageBox.Show("Cinsiyet seçiniz.", "Seçim", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
 
            if (result == DialogResult.Yes)
            {
                if (secilenKoltukSayisi == 4)
                {
                    MessageBox.Show("En Fazla 4 adet koltuk seçilebilir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                buton.BackColor = Color.DeepSkyBlue;
                secilenKoltukSayisi++;
                textBoxSecilenKoltuklar.Text += buton.Text + " ";
                secilenKoltukNolari.Add(buton.Text);
            }
            else if (result == DialogResult.No)
            {
                if (secilenKoltukSayisi == 4)
                {
                    MessageBox.Show("En Fazla 4 adet koltuk seçilebilir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                buton.BackColor = Color.HotPink;
                secilenKoltukSayisi++;
                textBoxSecilenKoltuklar.Text += buton.Text + " ";
                secilenKoltukNolari.Add(buton.Text);
            }
            else if (result == DialogResult.Cancel)
            {
                buton.BackColor = Color.White;
                secilenKoltukSayisi--;
                int index = textBoxSecilenKoltuklar.Text.IndexOf(buton.Text);
                textBoxSecilenKoltuklar.Text = textBoxSecilenKoltuklar.Text.Substring(0, index) + textBoxSecilenKoltuklar.Text.Substring(index + buton.Text.Length);
                secilenKoltukNolari.Remove(buton.Text);
            }

            cinsiyet = new string[secilenKoltukNolari.Count];
            for (int i = 0; i < secilenKoltukNolari.Count; i++)
            {
                for (int j = 0; j < koltuk.Length; j++)
                {
                    if (koltuk[j].Text == secilenKoltukNolari[i])
                    {
                        if (koltuk[j].BackColor == Color.DeepSkyBlue)
                        {
                            cinsiyet[i] = "Erkek";
                        }
                        else if (koltuk[j].BackColor == Color.HotPink)
                        {
                            cinsiyet[i] = "Kadın";
                        }
                    }
                }
            }
        }
        
        private void bttnOnayla_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (secilenKoltukSayisi == 1)
            {
                Yolcu1 yolcu1 = new Yolcu1();
                yolcu1.lblYolcu1.Text = (i + 1) + ". Yolcu - " + cinsiyet[i] + " - Koltuk No :";
                yolcu1.lblKoltukNo1.Text = secilenKoltukNolari[i];
                yolcu1.bttnFiyat.Text = OtobusBiletiBul.fiyat.ToString();
                yolcu1.Show();
            }
            else if (secilenKoltukSayisi == 2)
            {
                Yolcu2 yolcu2 = new Yolcu2();
                yolcu2.lblYolcu1.Text = (i + 1) + ". Yolcu - " + cinsiyet[i] + " - Koltuk No :";
                yolcu2.lblYolcu2.Text = (i + 2) + ". Yolcu - " + cinsiyet[i + 1] + " - Koltuk No :";
                yolcu2.lblKoltukNo1.Text = secilenKoltukNolari[i];
                yolcu2.lblKoltukNo2.Text = secilenKoltukNolari[i + 1];
                yolcu2.bttnFiyat.Text = (OtobusBiletiBul.fiyat * 2).ToString();
                yolcu2.Show();
            }
            else if (secilenKoltukSayisi == 3)
            {
                Yolcu3 yolcu3 = new Yolcu3();
                yolcu3.lblYolcu1.Text = (i + 1) + ". Yolcu - " + cinsiyet[i] + " - Koltuk No :";
                yolcu3.lblYolcu2.Text = (i + 2) + ". Yolcu - " + cinsiyet[i + 1] + " - Koltuk No :";
                yolcu3.lblYolcu3.Text = (i + 3) + ". Yolcu - " + cinsiyet[i + 2] + " - Koltuk No :";
                yolcu3.lblKoltukNo1.Text = secilenKoltukNolari[i];
                yolcu3.lblKoltukNo2.Text = secilenKoltukNolari[i + 1];
                yolcu3.lblKoltukNo3.Text = secilenKoltukNolari[i + 2];
                yolcu3.bttnFiyat.Text = (OtobusBiletiBul.fiyat * 3).ToString();
                yolcu3.Show();
            }
            else if (secilenKoltukSayisi == 4)
            {
                Yolcu4 yolcu4 = new Yolcu4();
                yolcu4.lblYolcu1.Text = (i + 1) + ". Yolcu - " + cinsiyet[i] + " - Koltuk No :";
                yolcu4.lblYolcu2.Text = (i + 2) + ". Yolcu - " + cinsiyet[i + 1] + " - Koltuk No :";
                yolcu4.lblYolcu3.Text = (i + 3) + ". Yolcu - " + cinsiyet[i + 2] + " - Koltuk No :";
                yolcu4.lblYolcu4.Text = (i + 4) + ". Yolcu - " + cinsiyet[i + 3] + " - Koltuk No :";
                yolcu4.lblKoltukNo1.Text = secilenKoltukNolari[i];
                yolcu4.lblKoltukNo2.Text = secilenKoltukNolari[i + 1];
                yolcu4.lblKoltukNo3.Text = secilenKoltukNolari[i + 2];
                yolcu4.lblKoltukNo4.Text = secilenKoltukNolari[i + 3];
                yolcu4.bttnFiyat.Text = (OtobusBiletiBul.fiyat * 4).ToString();
                yolcu4.Show();
            }
        }
    }
}

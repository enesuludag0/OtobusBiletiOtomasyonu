namespace OtobusBiletiOtomasyonu
{
    partial class Yolcu2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnFiyat = new System.Windows.Forms.Button();
            this.maskedTextBoxTcKimlikNo1 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxAdSoyad1 = new System.Windows.Forms.TextBox();
            this.lblAdSoyad1 = new System.Windows.Forms.Label();
            this.lblTcKimlikNo1 = new System.Windows.Forms.Label();
            this.lblYolcu1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTcKimlikNo2 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxAdSoyad2 = new System.Windows.Forms.TextBox();
            this.lblAdSoyad2 = new System.Windows.Forms.Label();
            this.lblTcKimlikNo2 = new System.Windows.Forms.Label();
            this.lblYolcu2 = new System.Windows.Forms.Label();
            this.lblKoltukNo1 = new System.Windows.Forms.Label();
            this.lblKoltukNo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnFiyat
            // 
            this.bttnFiyat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bttnFiyat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnFiyat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnFiyat.ForeColor = System.Drawing.Color.White;
            this.bttnFiyat.Location = new System.Drawing.Point(162, 339);
            this.bttnFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.bttnFiyat.Name = "bttnFiyat";
            this.bttnFiyat.Size = new System.Drawing.Size(129, 36);
            this.bttnFiyat.TabIndex = 59;
            this.bttnFiyat.Text = "Fiyat";
            this.bttnFiyat.UseVisualStyleBackColor = false;
            this.bttnFiyat.Click += new System.EventHandler(this.bttnFiyat_Click);
            // 
            // maskedTextBoxTcKimlikNo1
            // 
            this.maskedTextBoxTcKimlikNo1.Location = new System.Drawing.Point(194, 161);
            this.maskedTextBoxTcKimlikNo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxTcKimlikNo1.Mask = "00000000000";
            this.maskedTextBoxTcKimlikNo1.Name = "maskedTextBoxTcKimlikNo1";
            this.maskedTextBoxTcKimlikNo1.Size = new System.Drawing.Size(184, 22);
            this.maskedTextBoxTcKimlikNo1.TabIndex = 58;
            this.maskedTextBoxTcKimlikNo1.ValidatingType = typeof(int);
            // 
            // textBoxAdSoyad1
            // 
            this.textBoxAdSoyad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdSoyad1.Location = new System.Drawing.Point(194, 121);
            this.textBoxAdSoyad1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdSoyad1.Name = "textBoxAdSoyad1";
            this.textBoxAdSoyad1.Size = new System.Drawing.Size(184, 23);
            this.textBoxAdSoyad1.TabIndex = 57;
            // 
            // lblAdSoyad1
            // 
            this.lblAdSoyad1.AutoSize = true;
            this.lblAdSoyad1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad1.Location = new System.Drawing.Point(63, 123);
            this.lblAdSoyad1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad1.Name = "lblAdSoyad1";
            this.lblAdSoyad1.Size = new System.Drawing.Size(80, 21);
            this.lblAdSoyad1.TabIndex = 56;
            this.lblAdSoyad1.Text = "AD SOYAD";
            // 
            // lblTcKimlikNo1
            // 
            this.lblTcKimlikNo1.AutoSize = true;
            this.lblTcKimlikNo1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcKimlikNo1.Location = new System.Drawing.Point(63, 162);
            this.lblTcKimlikNo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTcKimlikNo1.Name = "lblTcKimlikNo1";
            this.lblTcKimlikNo1.Size = new System.Drawing.Size(111, 21);
            this.lblTcKimlikNo1.TabIndex = 55;
            this.lblTcKimlikNo1.Text = "T.C. KİMLİK NO";
            // 
            // lblYolcu1
            // 
            this.lblYolcu1.AutoSize = true;
            this.lblYolcu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYolcu1.ForeColor = System.Drawing.Color.Red;
            this.lblYolcu1.Location = new System.Drawing.Point(64, 88);
            this.lblYolcu1.Name = "lblYolcu1";
            this.lblYolcu1.Size = new System.Drawing.Size(200, 18);
            this.lblYolcu1.TabIndex = 54;
            this.lblYolcu1.Text = "1. Yolcu - Erkek - Koltuk No :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(148, 36);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 28);
            this.textBox2.TabIndex = 53;
            this.textBox2.Text = "YOLCU BİLGİLERİ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxTcKimlikNo2
            // 
            this.maskedTextBoxTcKimlikNo2.Location = new System.Drawing.Point(194, 289);
            this.maskedTextBoxTcKimlikNo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxTcKimlikNo2.Mask = "00000000000";
            this.maskedTextBoxTcKimlikNo2.Name = "maskedTextBoxTcKimlikNo2";
            this.maskedTextBoxTcKimlikNo2.Size = new System.Drawing.Size(184, 22);
            this.maskedTextBoxTcKimlikNo2.TabIndex = 64;
            this.maskedTextBoxTcKimlikNo2.ValidatingType = typeof(int);
            // 
            // textBoxAdSoyad2
            // 
            this.textBoxAdSoyad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdSoyad2.Location = new System.Drawing.Point(194, 249);
            this.textBoxAdSoyad2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdSoyad2.Name = "textBoxAdSoyad2";
            this.textBoxAdSoyad2.Size = new System.Drawing.Size(184, 23);
            this.textBoxAdSoyad2.TabIndex = 63;
            // 
            // lblAdSoyad2
            // 
            this.lblAdSoyad2.AutoSize = true;
            this.lblAdSoyad2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad2.Location = new System.Drawing.Point(63, 251);
            this.lblAdSoyad2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad2.Name = "lblAdSoyad2";
            this.lblAdSoyad2.Size = new System.Drawing.Size(80, 21);
            this.lblAdSoyad2.TabIndex = 62;
            this.lblAdSoyad2.Text = "AD SOYAD";
            // 
            // lblTcKimlikNo2
            // 
            this.lblTcKimlikNo2.AutoSize = true;
            this.lblTcKimlikNo2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcKimlikNo2.Location = new System.Drawing.Point(63, 290);
            this.lblTcKimlikNo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTcKimlikNo2.Name = "lblTcKimlikNo2";
            this.lblTcKimlikNo2.Size = new System.Drawing.Size(111, 21);
            this.lblTcKimlikNo2.TabIndex = 61;
            this.lblTcKimlikNo2.Text = "T.C. KİMLİK NO";
            // 
            // lblYolcu2
            // 
            this.lblYolcu2.AutoSize = true;
            this.lblYolcu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYolcu2.ForeColor = System.Drawing.Color.Red;
            this.lblYolcu2.Location = new System.Drawing.Point(64, 215);
            this.lblYolcu2.Name = "lblYolcu2";
            this.lblYolcu2.Size = new System.Drawing.Size(200, 18);
            this.lblYolcu2.TabIndex = 60;
            this.lblYolcu2.Text = "1. Yolcu - Erkek - Koltuk No :";
            // 
            // lblKoltukNo1
            // 
            this.lblKoltukNo1.AutoSize = true;
            this.lblKoltukNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoltukNo1.ForeColor = System.Drawing.Color.Red;
            this.lblKoltukNo1.Location = new System.Drawing.Point(270, 88);
            this.lblKoltukNo1.Name = "lblKoltukNo1";
            this.lblKoltukNo1.Size = new System.Drawing.Size(16, 18);
            this.lblKoltukNo1.TabIndex = 65;
            this.lblKoltukNo1.Text = "8";
            // 
            // lblKoltukNo2
            // 
            this.lblKoltukNo2.AutoSize = true;
            this.lblKoltukNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoltukNo2.ForeColor = System.Drawing.Color.Red;
            this.lblKoltukNo2.Location = new System.Drawing.Point(270, 215);
            this.lblKoltukNo2.Name = "lblKoltukNo2";
            this.lblKoltukNo2.Size = new System.Drawing.Size(16, 18);
            this.lblKoltukNo2.TabIndex = 66;
            this.lblKoltukNo2.Text = "8";
            // 
            // Yolcu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 408);
            this.Controls.Add(this.lblKoltukNo2);
            this.Controls.Add(this.lblKoltukNo1);
            this.Controls.Add(this.maskedTextBoxTcKimlikNo2);
            this.Controls.Add(this.textBoxAdSoyad2);
            this.Controls.Add(this.lblAdSoyad2);
            this.Controls.Add(this.lblTcKimlikNo2);
            this.Controls.Add(this.lblYolcu2);
            this.Controls.Add(this.bttnFiyat);
            this.Controls.Add(this.maskedTextBoxTcKimlikNo1);
            this.Controls.Add(this.textBoxAdSoyad1);
            this.Controls.Add(this.lblAdSoyad1);
            this.Controls.Add(this.lblTcKimlikNo1);
            this.Controls.Add(this.lblYolcu1);
            this.Controls.Add(this.textBox2);
            this.Name = "Yolcu2";
            this.Text = "Ödeme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTcKimlikNo1;
        private System.Windows.Forms.TextBox textBoxAdSoyad1;
        private System.Windows.Forms.Label lblAdSoyad1;
        private System.Windows.Forms.Label lblTcKimlikNo1;
        public System.Windows.Forms.Label lblYolcu1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTcKimlikNo2;
        private System.Windows.Forms.TextBox textBoxAdSoyad2;
        private System.Windows.Forms.Label lblAdSoyad2;
        private System.Windows.Forms.Label lblTcKimlikNo2;
        public System.Windows.Forms.Label lblYolcu2;
        public System.Windows.Forms.Label lblKoltukNo1;
        public System.Windows.Forms.Label lblKoltukNo2;
        public System.Windows.Forms.Button bttnFiyat;
    }
}
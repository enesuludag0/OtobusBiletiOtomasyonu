namespace OtobusBiletiOtomasyonu
{
    partial class Giris
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.checkBoxSifreGoster = new System.Windows.Forms.CheckBox();
            this.bttnGiris = new System.Windows.Forms.Button();
            this.bttnHemenUyeOl = new System.Windows.Forms.Button();
            this.lblUyeDegilMisiniz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(69, 53);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 18);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-MAİL";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(69, 92);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(51, 18);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "ŞİFRE";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxEmail.Location = new System.Drawing.Point(140, 49);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(184, 23);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(140, 89);
            this.textBoxSifre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '●';
            this.textBoxSifre.Size = new System.Drawing.Size(184, 23);
            this.textBoxSifre.TabIndex = 3;
            // 
            // checkBoxSifreGoster
            // 
            this.checkBoxSifreGoster.AutoSize = true;
            this.checkBoxSifreGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxSifreGoster.Location = new System.Drawing.Point(140, 126);
            this.checkBoxSifreGoster.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSifreGoster.Name = "checkBoxSifreGoster";
            this.checkBoxSifreGoster.Size = new System.Drawing.Size(104, 20);
            this.checkBoxSifreGoster.TabIndex = 4;
            this.checkBoxSifreGoster.Text = "Şifreyi göster";
            this.checkBoxSifreGoster.UseVisualStyleBackColor = true;
            this.checkBoxSifreGoster.CheckedChanged += new System.EventHandler(this.checkBoxSifreGoster_CheckedChanged);
            // 
            // bttnGiris
            // 
            this.bttnGiris.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bttnGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnGiris.ForeColor = System.Drawing.Color.White;
            this.bttnGiris.Location = new System.Drawing.Point(125, 165);
            this.bttnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.bttnGiris.Name = "bttnGiris";
            this.bttnGiris.Size = new System.Drawing.Size(129, 36);
            this.bttnGiris.TabIndex = 5;
            this.bttnGiris.Text = "Giriş Yap";
            this.bttnGiris.UseVisualStyleBackColor = false;
            this.bttnGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // bttnHemenUyeOl
            // 
            this.bttnHemenUyeOl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bttnHemenUyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnHemenUyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnHemenUyeOl.ForeColor = System.Drawing.Color.White;
            this.bttnHemenUyeOl.Location = new System.Drawing.Point(211, 226);
            this.bttnHemenUyeOl.Margin = new System.Windows.Forms.Padding(4);
            this.bttnHemenUyeOl.Name = "bttnHemenUyeOl";
            this.bttnHemenUyeOl.Size = new System.Drawing.Size(115, 28);
            this.bttnHemenUyeOl.TabIndex = 6;
            this.bttnHemenUyeOl.Text = "HEMEN ÜYE OL";
            this.bttnHemenUyeOl.UseVisualStyleBackColor = false;
            this.bttnHemenUyeOl.Click += new System.EventHandler(this.bttnHemenUyeOl_Click);
            // 
            // lblUyeDegilMisiniz
            // 
            this.lblUyeDegilMisiniz.AutoSize = true;
            this.lblUyeDegilMisiniz.Location = new System.Drawing.Point(69, 231);
            this.lblUyeDegilMisiniz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyeDegilMisiniz.Name = "lblUyeDegilMisiniz";
            this.lblUyeDegilMisiniz.Size = new System.Drawing.Size(115, 16);
            this.lblUyeDegilMisiniz.TabIndex = 7;
            this.lblUyeDegilMisiniz.Text = "Üye değil misiniz?";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 315);
            this.Controls.Add(this.lblUyeDegilMisiniz);
            this.Controls.Add(this.bttnHemenUyeOl);
            this.Controls.Add(this.bttnGiris);
            this.Controls.Add(this.checkBoxSifreGoster);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblEmail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.CheckBox checkBoxSifreGoster;
        private System.Windows.Forms.Button bttnGiris;
        private System.Windows.Forms.Button bttnHemenUyeOl;
        private System.Windows.Forms.Label lblUyeDegilMisiniz;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.TextBox textBoxSifre;
    }
}


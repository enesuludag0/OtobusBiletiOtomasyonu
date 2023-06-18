namespace OtobusBiletiOtomasyonu
{
    partial class PnrBiletSorgula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PnrBiletSorgula));
            this.lblPnr = new System.Windows.Forms.Label();
            this.textBoxPnr = new System.Windows.Forms.TextBox();
            this.bttnBiletSorgula = new System.Windows.Forms.Button();
            this.dgwListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.bttnBiletIptal = new System.Windows.Forms.Button();
            this.bttnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPnr
            // 
            this.lblPnr.AutoSize = true;
            this.lblPnr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPnr.Location = new System.Drawing.Point(61, 45);
            this.lblPnr.Name = "lblPnr";
            this.lblPnr.Size = new System.Drawing.Size(44, 24);
            this.lblPnr.TabIndex = 0;
            this.lblPnr.Text = "PNR";
            // 
            // textBoxPnr
            // 
            this.textBoxPnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPnr.Location = new System.Drawing.Point(127, 45);
            this.textBoxPnr.Name = "textBoxPnr";
            this.textBoxPnr.Size = new System.Drawing.Size(115, 27);
            this.textBoxPnr.TabIndex = 1;
            // 
            // bttnBiletSorgula
            // 
            this.bttnBiletSorgula.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bttnBiletSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnBiletSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnBiletSorgula.ForeColor = System.Drawing.Color.White;
            this.bttnBiletSorgula.Location = new System.Drawing.Point(285, 38);
            this.bttnBiletSorgula.Name = "bttnBiletSorgula";
            this.bttnBiletSorgula.Size = new System.Drawing.Size(136, 40);
            this.bttnBiletSorgula.TabIndex = 2;
            this.bttnBiletSorgula.Text = "Bilet Sorgula";
            this.bttnBiletSorgula.UseVisualStyleBackColor = false;
            this.bttnBiletSorgula.Click += new System.EventHandler(this.bttnBiletSorgula_Click);
            // 
            // dgwListe
            // 
            this.dgwListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.Location = new System.Drawing.Point(12, 121);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.RowHeadersWidth = 51;
            this.dgwListe.RowTemplate.Height = 24;
            this.dgwListe.Size = new System.Drawing.Size(1513, 87);
            this.dgwListe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(667, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplam Tutar :";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(803, 240);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(19, 24);
            this.lblToplamTutar.TabIndex = 6;
            this.lblToplamTutar.Text = "x";
            // 
            // bttnBiletIptal
            // 
            this.bttnBiletIptal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bttnBiletIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnBiletIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnBiletIptal.ForeColor = System.Drawing.Color.White;
            this.bttnBiletIptal.Location = new System.Drawing.Point(695, 291);
            this.bttnBiletIptal.Name = "bttnBiletIptal";
            this.bttnBiletIptal.Size = new System.Drawing.Size(133, 40);
            this.bttnBiletIptal.TabIndex = 8;
            this.bttnBiletIptal.Text = "Bilet İptal Et";
            this.bttnBiletIptal.UseVisualStyleBackColor = false;
            this.bttnBiletIptal.Click += new System.EventHandler(this.bttnBiletIptal_Click);
            // 
            // bttnGeri
            // 
            this.bttnGeri.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGeri.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnGeri.ForeColor = System.Drawing.Color.Red;
            this.bttnGeri.Image = ((System.Drawing.Image)(resources.GetObject("bttnGeri.Image")));
            this.bttnGeri.Location = new System.Drawing.Point(0, -1);
            this.bttnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.bttnGeri.Name = "bttnGeri";
            this.bttnGeri.Size = new System.Drawing.Size(31, 38);
            this.bttnGeri.TabIndex = 19;
            this.bttnGeri.Text = "<";
            this.bttnGeri.UseVisualStyleBackColor = true;
            this.bttnGeri.Click += new System.EventHandler(this.bttnGeri_Click);
            // 
            // PnrBiletSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 116);
            this.Controls.Add(this.bttnGeri);
            this.Controls.Add(this.bttnBiletIptal);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwListe);
            this.Controls.Add(this.bttnBiletSorgula);
            this.Controls.Add(this.textBoxPnr);
            this.Controls.Add(this.lblPnr);
            this.Name = "PnrBiletSorgula";
            this.Text = "Pnr Bilet Sorgula";
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPnr;
        private System.Windows.Forms.TextBox textBoxPnr;
        private System.Windows.Forms.Button bttnBiletSorgula;
        private System.Windows.Forms.DataGridView dgwListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button bttnBiletIptal;
        private System.Windows.Forms.Button bttnGeri;
    }
}
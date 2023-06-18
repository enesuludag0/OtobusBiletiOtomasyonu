namespace OtobusBiletiOtomasyonu
{
    partial class OtobusBiletiBul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtobusBiletiBul));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblKalkis = new System.Windows.Forms.Label();
            this.lblVaris = new System.Windows.Forms.Label();
            this.bttnDegistir = new System.Windows.Forms.Button();
            this.bttnGeri = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.bttnOnceki = new System.Windows.Forms.Button();
            this.bttnSonraki = new System.Windows.Forms.Button();
            this.dgwListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKalkis
            // 
            this.lblKalkis.AutoSize = true;
            this.lblKalkis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalkis.Location = new System.Drawing.Point(325, 36);
            this.lblKalkis.Name = "lblKalkis";
            this.lblKalkis.Size = new System.Drawing.Size(61, 24);
            this.lblKalkis.TabIndex = 0;
            this.lblKalkis.Text = "label1";
            // 
            // lblVaris
            // 
            this.lblVaris.AutoSize = true;
            this.lblVaris.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVaris.Location = new System.Drawing.Point(440, 36);
            this.lblVaris.Name = "lblVaris";
            this.lblVaris.Size = new System.Drawing.Size(61, 24);
            this.lblVaris.TabIndex = 1;
            this.lblVaris.Text = "label2";
            // 
            // bttnDegistir
            // 
            this.bttnDegistir.FlatAppearance.BorderSize = 0;
            this.bttnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDegistir.Image = ((System.Drawing.Image)(resources.GetObject("bttnDegistir.Image")));
            this.bttnDegistir.Location = new System.Drawing.Point(403, 34);
            this.bttnDegistir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnDegistir.Name = "bttnDegistir";
            this.bttnDegistir.Size = new System.Drawing.Size(33, 30);
            this.bttnDegistir.TabIndex = 9;
            this.bttnDegistir.UseVisualStyleBackColor = true;
            this.bttnDegistir.Click += new System.EventHandler(this.bttnDegistir_Click);
            // 
            // bttnGeri
            // 
            this.bttnGeri.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGeri.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnGeri.ForeColor = System.Drawing.Color.Red;
            this.bttnGeri.Image = ((System.Drawing.Image)(resources.GetObject("bttnGeri.Image")));
            this.bttnGeri.Location = new System.Drawing.Point(47, 27);
            this.bttnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.bttnGeri.Name = "bttnGeri";
            this.bttnGeri.Size = new System.Drawing.Size(31, 38);
            this.bttnGeri.TabIndex = 18;
            this.bttnGeri.Text = "<";
            this.bttnGeri.UseVisualStyleBackColor = true;
            this.bttnGeri.Click += new System.EventHandler(this.bttnGeri_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(391, 76);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(61, 24);
            this.lblTarih.TabIndex = 19;
            this.lblTarih.Text = "label3";
            // 
            // bttnOnceki
            // 
            this.bttnOnceki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnOnceki.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnOnceki.Location = new System.Drawing.Point(248, 75);
            this.bttnOnceki.Margin = new System.Windows.Forms.Padding(4);
            this.bttnOnceki.Name = "bttnOnceki";
            this.bttnOnceki.Size = new System.Drawing.Size(93, 28);
            this.bttnOnceki.TabIndex = 20;
            this.bttnOnceki.Text = "< Önceki";
            this.bttnOnceki.UseVisualStyleBackColor = true;
            this.bttnOnceki.Click += new System.EventHandler(this.bttnOnceki_Click);
            // 
            // bttnSonraki
            // 
            this.bttnSonraki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSonraki.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnSonraki.Location = new System.Drawing.Point(487, 76);
            this.bttnSonraki.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSonraki.Name = "bttnSonraki";
            this.bttnSonraki.Size = new System.Drawing.Size(93, 28);
            this.bttnSonraki.TabIndex = 21;
            this.bttnSonraki.Text = "Sonraki >";
            this.bttnSonraki.UseVisualStyleBackColor = true;
            this.bttnSonraki.Click += new System.EventHandler(this.bttnSonraki_Click);
            // 
            // dgwListe
            // 
            this.dgwListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwListe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwListe.Location = new System.Drawing.Point(33, 128);
            this.dgwListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.RowHeadersWidth = 51;
            this.dgwListe.RowTemplate.Height = 24;
            this.dgwListe.Size = new System.Drawing.Size(729, 226);
            this.dgwListe.TabIndex = 22;
            this.dgwListe.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwListe_CellMouseDoubleClick);
            // 
            // OtobusBiletiBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 386);
            this.Controls.Add(this.dgwListe);
            this.Controls.Add(this.bttnSonraki);
            this.Controls.Add(this.bttnOnceki);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.bttnGeri);
            this.Controls.Add(this.bttnDegistir);
            this.Controls.Add(this.lblVaris);
            this.Controls.Add(this.lblKalkis);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OtobusBiletiBul";
            this.Text = "Otobüs Bileti Bul";
            this.Load += new System.EventHandler(this.OtobusBiletiBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnDegistir;
        public System.Windows.Forms.Label lblKalkis;
        public System.Windows.Forms.Label lblVaris;
        private System.Windows.Forms.Button bttnGeri;
        public System.Windows.Forms.Label lblTarih;
        public System.Windows.Forms.Button bttnOnceki;
        public System.Windows.Forms.Button bttnSonraki;
        private System.Windows.Forms.DataGridView dgwListe;
    }
}
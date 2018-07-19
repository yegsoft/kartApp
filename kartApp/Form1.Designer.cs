namespace kartApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAdi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblUnvani = new System.Windows.Forms.Label();
            this.lblTelefonu = new System.Windows.Forms.Label();
            this.tbAdi = new System.Windows.Forms.MaskedTextBox();
            this.tbSoyadi = new System.Windows.Forms.MaskedTextBox();
            this.tbUnvani = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefonu = new System.Windows.Forms.MaskedTextBox();
            this.tbMail = new System.Windows.Forms.MaskedTextBox();
            this.tbFaks = new System.Windows.Forms.MaskedTextBox();
            this.tbWebSitesi = new System.Windows.Forms.MaskedTextBox();
            this.lblWebSitesi = new System.Windows.Forms.Label();
            this.tbAdresi = new System.Windows.Forms.MaskedTextBox();
            this.lblAdresi = new System.Windows.Forms.Label();
            this.tbSirketAdi = new System.Windows.Forms.MaskedTextBox();
            this.lblSirketAdi = new System.Windows.Forms.Label();
            this.lblKayitBasarili = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblFaks = new System.Windows.Forms.Label();
            this.grdOgrenci = new System.Windows.Forms.DataGridView();
            this.lblTarih = new System.Windows.Forms.Label();
            this.tbTarih = new System.Windows.Forms.MaskedTextBox();
            this.lblUzanti = new System.Windows.Forms.Label();
            this.tbUzanti = new System.Windows.Forms.MaskedTextBox();
            this.btnIslem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdi
            // 
            this.lblAdi.BackColor = System.Drawing.Color.Firebrick;
            this.lblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.ForeColor = System.Drawing.Color.Black;
            this.lblAdi.Location = new System.Drawing.Point(367, 44);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(170, 36);
            this.lblAdi.TabIndex = 0;
            this.lblAdi.Text = "ADI";
            this.lblAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.BackColor = System.Drawing.Color.Firebrick;
            this.lblSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyadi.ForeColor = System.Drawing.Color.Black;
            this.lblSoyadi.Location = new System.Drawing.Point(543, 44);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(170, 36);
            this.lblSoyadi.TabIndex = 11;
            this.lblSoyadi.Text = "SOYADI";
            this.lblSoyadi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnvani
            // 
            this.lblUnvani.BackColor = System.Drawing.Color.Firebrick;
            this.lblUnvani.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvani.ForeColor = System.Drawing.Color.Black;
            this.lblUnvani.Location = new System.Drawing.Point(719, 44);
            this.lblUnvani.Name = "lblUnvani";
            this.lblUnvani.Size = new System.Drawing.Size(170, 36);
            this.lblUnvani.TabIndex = 12;
            this.lblUnvani.Text = "UNVANI";
            this.lblUnvani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelefonu
            // 
            this.lblTelefonu.BackColor = System.Drawing.Color.Firebrick;
            this.lblTelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefonu.ForeColor = System.Drawing.Color.Black;
            this.lblTelefonu.Location = new System.Drawing.Point(895, 44);
            this.lblTelefonu.Name = "lblTelefonu";
            this.lblTelefonu.Size = new System.Drawing.Size(170, 36);
            this.lblTelefonu.TabIndex = 13;
            this.lblTelefonu.Text = "TELEFONU";
            this.lblTelefonu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAdi
            // 
            this.tbAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdi.Location = new System.Drawing.Point(371, 93);
            this.tbAdi.Mask = "?????????????????????????????????????????????????????????????";
            this.tbAdi.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(166, 31);
            this.tbAdi.TabIndex = 19;
            this.tbAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSoyadi
            // 
            this.tbSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSoyadi.Location = new System.Drawing.Point(547, 93);
            this.tbSoyadi.Mask = "??????????????????????????????????????????????????????";
            this.tbSoyadi.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbSoyadi.Name = "tbSoyadi";
            this.tbSoyadi.Size = new System.Drawing.Size(166, 31);
            this.tbSoyadi.TabIndex = 20;
            this.tbSoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUnvani
            // 
            this.tbUnvani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUnvani.Location = new System.Drawing.Point(723, 93);
            this.tbUnvani.Mask = "?????????????????????????????????????????????????????????";
            this.tbUnvani.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbUnvani.Name = "tbUnvani";
            this.tbUnvani.Size = new System.Drawing.Size(166, 31);
            this.tbUnvani.TabIndex = 21;
            this.tbUnvani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTelefonu
            // 
            this.tbTelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTelefonu.Location = new System.Drawing.Point(899, 93);
            this.tbTelefonu.Mask = "(999) 000-0000";
            this.tbTelefonu.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbTelefonu.Name = "tbTelefonu";
            this.tbTelefonu.Size = new System.Drawing.Size(166, 31);
            this.tbTelefonu.TabIndex = 22;
            this.tbTelefonu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMail.Location = new System.Drawing.Point(1075, 93);
            this.tbMail.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.tbMail.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(166, 31);
            this.tbMail.TabIndex = 23;
            this.tbMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMail.ValidatingType = typeof(System.DateTime);
            // 
            // tbFaks
            // 
            this.tbFaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFaks.Location = new System.Drawing.Point(371, 205);
            this.tbFaks.Mask = "0000000000000000000000";
            this.tbFaks.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbFaks.Name = "tbFaks";
            this.tbFaks.Size = new System.Drawing.Size(166, 31);
            this.tbFaks.TabIndex = 25;
            this.tbFaks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFaks.ValidatingType = typeof(int);
            // 
            // tbWebSitesi
            // 
            this.tbWebSitesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbWebSitesi.Location = new System.Drawing.Point(547, 205);
            this.tbWebSitesi.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.tbWebSitesi.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbWebSitesi.Name = "tbWebSitesi";
            this.tbWebSitesi.Size = new System.Drawing.Size(166, 31);
            this.tbWebSitesi.TabIndex = 26;
            this.tbWebSitesi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWebSitesi
            // 
            this.lblWebSitesi.BackColor = System.Drawing.Color.Firebrick;
            this.lblWebSitesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWebSitesi.ForeColor = System.Drawing.Color.Black;
            this.lblWebSitesi.Location = new System.Drawing.Point(543, 156);
            this.lblWebSitesi.Name = "lblWebSitesi";
            this.lblWebSitesi.Size = new System.Drawing.Size(170, 36);
            this.lblWebSitesi.TabIndex = 26;
            this.lblWebSitesi.Text = "WEB SİTESİ";
            this.lblWebSitesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAdresi
            // 
            this.tbAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdresi.Location = new System.Drawing.Point(723, 205);
            this.tbAdresi.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC" +
    "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.tbAdresi.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbAdresi.Name = "tbAdresi";
            this.tbAdresi.Size = new System.Drawing.Size(166, 31);
            this.tbAdresi.TabIndex = 27;
            this.tbAdresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAdresi
            // 
            this.lblAdresi.BackColor = System.Drawing.Color.Firebrick;
            this.lblAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdresi.ForeColor = System.Drawing.Color.Black;
            this.lblAdresi.Location = new System.Drawing.Point(719, 156);
            this.lblAdresi.Name = "lblAdresi";
            this.lblAdresi.Size = new System.Drawing.Size(170, 36);
            this.lblAdresi.TabIndex = 28;
            this.lblAdresi.Text = "ADRESİ";
            this.lblAdresi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSirketAdi
            // 
            this.tbSirketAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSirketAdi.Location = new System.Drawing.Point(899, 205);
            this.tbSirketAdi.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.tbSirketAdi.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbSirketAdi.Name = "tbSirketAdi";
            this.tbSirketAdi.Size = new System.Drawing.Size(166, 31);
            this.tbSirketAdi.TabIndex = 28;
            this.tbSirketAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSirketAdi
            // 
            this.lblSirketAdi.BackColor = System.Drawing.Color.Firebrick;
            this.lblSirketAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSirketAdi.ForeColor = System.Drawing.Color.Black;
            this.lblSirketAdi.Location = new System.Drawing.Point(895, 156);
            this.lblSirketAdi.Name = "lblSirketAdi";
            this.lblSirketAdi.Size = new System.Drawing.Size(170, 36);
            this.lblSirketAdi.TabIndex = 30;
            this.lblSirketAdi.Text = "ŞİRKET ADI";
            this.lblSirketAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKayitBasarili
            // 
            this.lblKayitBasarili.BackColor = System.Drawing.Color.Chartreuse;
            this.lblKayitBasarili.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitBasarili.ForeColor = System.Drawing.Color.Red;
            this.lblKayitBasarili.Location = new System.Drawing.Point(65, 189);
            this.lblKayitBasarili.Name = "lblKayitBasarili";
            this.lblKayitBasarili.Size = new System.Drawing.Size(209, 36);
            this.lblKayitBasarili.TabIndex = 34;
            this.lblKayitBasarili.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKayitBasarili.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Khaki;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(1252, 306);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(166, 44);
            this.btnSil.TabIndex = 31;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblMail
            // 
            this.lblMail.BackColor = System.Drawing.Color.Firebrick;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.Color.Black;
            this.lblMail.Location = new System.Drawing.Point(1071, 44);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(170, 36);
            this.lblMail.TabIndex = 37;
            this.lblMail.Text = "MAİL";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFaks
            // 
            this.lblFaks.BackColor = System.Drawing.Color.Firebrick;
            this.lblFaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaks.ForeColor = System.Drawing.Color.Black;
            this.lblFaks.Location = new System.Drawing.Point(367, 156);
            this.lblFaks.Name = "lblFaks";
            this.lblFaks.Size = new System.Drawing.Size(170, 36);
            this.lblFaks.TabIndex = 38;
            this.lblFaks.Text = "FAKS";
            this.lblFaks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdOgrenci
            // 
            this.grdOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOgrenci.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOgrenci.Location = new System.Drawing.Point(12, 256);
            this.grdOgrenci.Name = "grdOgrenci";
            this.grdOgrenci.ReadOnly = true;
            this.grdOgrenci.Size = new System.Drawing.Size(1229, 539);
            this.grdOgrenci.TabIndex = 40;
            this.grdOgrenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOgrenci_CellClick_1);
            // 
            // lblTarih
            // 
            this.lblTarih.BackColor = System.Drawing.Color.Firebrick;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.Black;
            this.lblTarih.Location = new System.Drawing.Point(1071, 156);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(170, 36);
            this.lblTarih.TabIndex = 41;
            this.lblTarih.Text = "TARİH";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTarih
            // 
            this.tbTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTarih.Location = new System.Drawing.Point(1076, 205);
            this.tbTarih.Mask = "00/00/0000";
            this.tbTarih.Name = "tbTarih";
            this.tbTarih.Size = new System.Drawing.Size(165, 31);
            this.tbTarih.TabIndex = 29;
            this.tbTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTarih.ValidatingType = typeof(System.DateTime);
            // 
            // lblUzanti
            // 
            this.lblUzanti.BackColor = System.Drawing.Color.Firebrick;
            this.lblUzanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzanti.ForeColor = System.Drawing.Color.Black;
            this.lblUzanti.Location = new System.Drawing.Point(1247, 44);
            this.lblUzanti.Name = "lblUzanti";
            this.lblUzanti.Size = new System.Drawing.Size(170, 36);
            this.lblUzanti.TabIndex = 44;
            this.lblUzanti.Text = "UZANTISI";
            this.lblUzanti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUzanti
            // 
            this.tbUzanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUzanti.Location = new System.Drawing.Point(1252, 93);
            this.tbUzanti.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.tbUzanti.Name = "tbUzanti";
            this.tbUzanti.Size = new System.Drawing.Size(165, 31);
            this.tbUzanti.TabIndex = 24;
            // 
            // btnIslem
            // 
            this.btnIslem.BackColor = System.Drawing.Color.Khaki;
            this.btnIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslem.Location = new System.Drawing.Point(1252, 256);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(166, 44);
            this.btnIslem.TabIndex = 30;
            this.btnIslem.Text = "KAYDET";
            this.btnIslem.UseVisualStyleBackColor = false;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 825);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.tbUzanti);
            this.Controls.Add(this.lblUzanti);
            this.Controls.Add(this.tbTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.grdOgrenci);
            this.Controls.Add(this.lblFaks);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblKayitBasarili);
            this.Controls.Add(this.tbSirketAdi);
            this.Controls.Add(this.lblSirketAdi);
            this.Controls.Add(this.tbAdresi);
            this.Controls.Add(this.lblAdresi);
            this.Controls.Add(this.tbWebSitesi);
            this.Controls.Add(this.lblWebSitesi);
            this.Controls.Add(this.tbFaks);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbTelefonu);
            this.Controls.Add(this.tbUnvani);
            this.Controls.Add(this.tbSoyadi);
            this.Controls.Add(this.tbAdi);
            this.Controls.Add(this.lblTelefonu);
            this.Controls.Add(this.lblUnvani);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAdi);
            this.Name = "Form1";
            this.Text = "Kart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblUnvani;
        private System.Windows.Forms.Label lblTelefonu;
        private System.Windows.Forms.MaskedTextBox tbAdi;
        private System.Windows.Forms.MaskedTextBox tbSoyadi;
        private System.Windows.Forms.MaskedTextBox tbUnvani;
        private System.Windows.Forms.MaskedTextBox tbTelefonu;
        private System.Windows.Forms.MaskedTextBox tbMail;
        private System.Windows.Forms.MaskedTextBox tbFaks;
        private System.Windows.Forms.MaskedTextBox tbWebSitesi;
        private System.Windows.Forms.Label lblWebSitesi;
        private System.Windows.Forms.MaskedTextBox tbAdresi;
        private System.Windows.Forms.Label lblAdresi;
        private System.Windows.Forms.MaskedTextBox tbSirketAdi;
        private System.Windows.Forms.Label lblSirketAdi;
        private System.Windows.Forms.Label lblKayitBasarili;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblFaks;
        private System.Windows.Forms.DataGridView grdOgrenci;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.MaskedTextBox tbTarih;
        private System.Windows.Forms.Label lblUzanti;
        private System.Windows.Forms.MaskedTextBox tbUzanti;
        private System.Windows.Forms.Button btnIslem;
    }
}


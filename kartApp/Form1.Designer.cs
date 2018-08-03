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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.lblWebSitesi = new System.Windows.Forms.Label();
            this.tbWebSitesi = new System.Windows.Forms.MaskedTextBox();
            this.lblAdresi = new System.Windows.Forms.Label();
            this.tbAdresi = new System.Windows.Forms.MaskedTextBox();
            this.lblSirketAdi = new System.Windows.Forms.Label();
            this.tbSirketAdi = new System.Windows.Forms.MaskedTextBox();
            this.lblKayitBasarili = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblFaks = new System.Windows.Forms.Label();
            this.grdOgrenci = new System.Windows.Forms.DataGridView();
            this.lblTarih = new System.Windows.Forms.Label();
            this.tbTarih = new System.Windows.Forms.MaskedTextBox();
            this.lblUzanti = new System.Windows.Forms.Label();
            this.tbUzanti = new System.Windows.Forms.MaskedTextBox();
            this.btnIslem = new System.Windows.Forms.Button();
            this.btnIslem2 = new System.Windows.Forms.Button();
            this.tbArama = new System.Windows.Forms.TextBox();
            this.lblGsm = new System.Windows.Forms.Label();
            this.tbGsm = new System.Windows.Forms.MaskedTextBox();
            this.menuSecim = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.checkGenis = new System.Windows.Forms.CheckBox();
            this.btnKaliciSil = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCift = new System.Windows.Forms.Label();
            this.btnKatSil = new System.Windows.Forms.Button();
            this.btnKatEkle2 = new System.Windows.Forms.Button();
            this.tbKategori = new System.Windows.Forms.MaskedTextBox();
            this.grdKategori = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnyenile3 = new System.Windows.Forms.Button();
            this.lblAramaRapor2 = new System.Windows.Forms.Label();
            this.tbAramaRapor2 = new System.Windows.Forms.TextBox();
            this.checkKatAdi = new System.Windows.Forms.CheckBox();
            this.checkAktifPasif = new System.Windows.Forms.CheckBox();
            this.checkTumunu = new System.Windows.Forms.CheckBox();
            this.lblAramaRapor = new System.Windows.Forms.Label();
            this.tbAramaRapor = new System.Windows.Forms.TextBox();
            this.btnCikti = new System.Windows.Forms.Button();
            this.checkID = new System.Windows.Forms.CheckBox();
            this.grdOgrenciRapor = new System.Windows.Forms.DataGridView();
            this.checkFaks = new System.Windows.Forms.CheckBox();
            this.checkTarih = new System.Windows.Forms.CheckBox();
            this.checkSirket = new System.Windows.Forms.CheckBox();
            this.checkAdres = new System.Windows.Forms.CheckBox();
            this.checkWeb = new System.Windows.Forms.CheckBox();
            this.checkMail = new System.Windows.Forms.CheckBox();
            this.checkGsm = new System.Windows.Forms.CheckBox();
            this.checkTelefon = new System.Windows.Forms.CheckBox();
            this.checkUnvan = new System.Windows.Forms.CheckBox();
            this.checkSoyad = new System.Windows.Forms.CheckBox();
            this.checkAd = new System.Windows.Forms.CheckBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnYenile2 = new System.Windows.Forms.Button();
            this.btnYenile1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOgrenci)).BeginInit();
            this.menuSecim.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKategori)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOgrenciRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdi
            // 
            this.lblAdi.BackColor = System.Drawing.Color.Firebrick;
            this.lblAdi.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdi.ForeColor = System.Drawing.Color.Black;
            this.lblAdi.Location = new System.Drawing.Point(19, 245);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(170, 45);
            this.lblAdi.TabIndex = 0;
            this.lblAdi.Text = "ADI";
            this.lblAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.BackColor = System.Drawing.Color.Firebrick;
            this.lblSoyadi.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyadi.ForeColor = System.Drawing.Color.Black;
            this.lblSoyadi.Location = new System.Drawing.Point(19, 296);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(170, 45);
            this.lblSoyadi.TabIndex = 11;
            this.lblSoyadi.Text = "SOYADI";
            this.lblSoyadi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnvani
            // 
            this.lblUnvani.BackColor = System.Drawing.Color.Firebrick;
            this.lblUnvani.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvani.ForeColor = System.Drawing.Color.Black;
            this.lblUnvani.Location = new System.Drawing.Point(19, 347);
            this.lblUnvani.Name = "lblUnvani";
            this.lblUnvani.Size = new System.Drawing.Size(170, 45);
            this.lblUnvani.TabIndex = 12;
            this.lblUnvani.Text = "UNVANI";
            this.lblUnvani.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelefonu
            // 
            this.lblTelefonu.BackColor = System.Drawing.Color.Firebrick;
            this.lblTelefonu.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefonu.ForeColor = System.Drawing.Color.Black;
            this.lblTelefonu.Location = new System.Drawing.Point(19, 398);
            this.lblTelefonu.Name = "lblTelefonu";
            this.lblTelefonu.Size = new System.Drawing.Size(170, 45);
            this.lblTelefonu.TabIndex = 13;
            this.lblTelefonu.Text = "TELEFONU";
            this.lblTelefonu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAdi
            // 
            this.tbAdi.BackColor = System.Drawing.SystemColors.Info;
            this.tbAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdi.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdi.Location = new System.Drawing.Point(195, 245);
            this.tbAdi.Mask = "?????????????????????????????????????????????????????????????";
            this.tbAdi.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(477, 38);
            this.tbAdi.TabIndex = 19;
            this.tbAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSoyadi
            // 
            this.tbSoyadi.BackColor = System.Drawing.SystemColors.Info;
            this.tbSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSoyadi.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSoyadi.Location = new System.Drawing.Point(195, 296);
            this.tbSoyadi.Mask = "??????????????????????????????????????????????????????";
            this.tbSoyadi.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbSoyadi.Name = "tbSoyadi";
            this.tbSoyadi.Size = new System.Drawing.Size(477, 38);
            this.tbSoyadi.TabIndex = 20;
            this.tbSoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUnvani
            // 
            this.tbUnvani.BackColor = System.Drawing.SystemColors.Info;
            this.tbUnvani.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUnvani.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUnvani.Location = new System.Drawing.Point(195, 347);
            this.tbUnvani.Mask = "?????????????????????????????????????????????????????????";
            this.tbUnvani.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbUnvani.Name = "tbUnvani";
            this.tbUnvani.Size = new System.Drawing.Size(477, 38);
            this.tbUnvani.TabIndex = 21;
            this.tbUnvani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTelefonu
            // 
            this.tbTelefonu.BackColor = System.Drawing.SystemColors.Info;
            this.tbTelefonu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTelefonu.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTelefonu.Location = new System.Drawing.Point(195, 398);
            this.tbTelefonu.Mask = "(0000) 000-0000";
            this.tbTelefonu.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbTelefonu.Name = "tbTelefonu";
            this.tbTelefonu.Size = new System.Drawing.Size(477, 38);
            this.tbTelefonu.TabIndex = 22;
            this.tbTelefonu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.SystemColors.Info;
            this.tbMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMail.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMail.Location = new System.Drawing.Point(195, 449);
            this.tbMail.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.tbMail.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(477, 38);
            this.tbMail.TabIndex = 23;
            this.tbMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMail.ValidatingType = typeof(System.DateTime);
            // 
            // tbFaks
            // 
            this.tbFaks.BackColor = System.Drawing.SystemColors.Info;
            this.tbFaks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFaks.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFaks.Location = new System.Drawing.Point(194, 551);
            this.tbFaks.Mask = "0000000000000000000000";
            this.tbFaks.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbFaks.Name = "tbFaks";
            this.tbFaks.Size = new System.Drawing.Size(477, 38);
            this.tbFaks.TabIndex = 25;
            this.tbFaks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFaks.ValidatingType = typeof(int);
            // 
            // lblWebSitesi
            // 
            this.lblWebSitesi.BackColor = System.Drawing.Color.Firebrick;
            this.lblWebSitesi.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWebSitesi.ForeColor = System.Drawing.Color.Black;
            this.lblWebSitesi.Location = new System.Drawing.Point(19, 602);
            this.lblWebSitesi.Name = "lblWebSitesi";
            this.lblWebSitesi.Size = new System.Drawing.Size(170, 45);
            this.lblWebSitesi.TabIndex = 26;
            this.lblWebSitesi.Text = "WEB SİTESİ";
            this.lblWebSitesi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbWebSitesi
            // 
            this.tbWebSitesi.BackColor = System.Drawing.SystemColors.Info;
            this.tbWebSitesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWebSitesi.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbWebSitesi.Location = new System.Drawing.Point(194, 602);
            this.tbWebSitesi.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.tbWebSitesi.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbWebSitesi.Name = "tbWebSitesi";
            this.tbWebSitesi.Size = new System.Drawing.Size(477, 38);
            this.tbWebSitesi.TabIndex = 26;
            this.tbWebSitesi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAdresi
            // 
            this.lblAdresi.BackColor = System.Drawing.Color.Firebrick;
            this.lblAdresi.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdresi.ForeColor = System.Drawing.Color.Black;
            this.lblAdresi.Location = new System.Drawing.Point(19, 653);
            this.lblAdresi.Name = "lblAdresi";
            this.lblAdresi.Size = new System.Drawing.Size(170, 45);
            this.lblAdresi.TabIndex = 28;
            this.lblAdresi.Text = "ADRESİ";
            this.lblAdresi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAdresi
            // 
            this.tbAdresi.BackColor = System.Drawing.SystemColors.Info;
            this.tbAdresi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdresi.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdresi.Location = new System.Drawing.Point(195, 653);
            this.tbAdresi.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC" +
    "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.tbAdresi.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbAdresi.Name = "tbAdresi";
            this.tbAdresi.Size = new System.Drawing.Size(477, 38);
            this.tbAdresi.TabIndex = 27;
            this.tbAdresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSirketAdi
            // 
            this.lblSirketAdi.BackColor = System.Drawing.Color.Firebrick;
            this.lblSirketAdi.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSirketAdi.ForeColor = System.Drawing.Color.Black;
            this.lblSirketAdi.Location = new System.Drawing.Point(19, 704);
            this.lblSirketAdi.Name = "lblSirketAdi";
            this.lblSirketAdi.Size = new System.Drawing.Size(170, 45);
            this.lblSirketAdi.TabIndex = 30;
            this.lblSirketAdi.Text = "ŞİRKET ADI";
            this.lblSirketAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSirketAdi
            // 
            this.tbSirketAdi.BackColor = System.Drawing.SystemColors.Info;
            this.tbSirketAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSirketAdi.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSirketAdi.Location = new System.Drawing.Point(195, 704);
            this.tbSirketAdi.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.tbSirketAdi.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbSirketAdi.Name = "tbSirketAdi";
            this.tbSirketAdi.Size = new System.Drawing.Size(477, 38);
            this.tbSirketAdi.TabIndex = 28;
            this.tbSirketAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKayitBasarili
            // 
            this.lblKayitBasarili.BackColor = System.Drawing.Color.Chartreuse;
            this.lblKayitBasarili.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitBasarili.ForeColor = System.Drawing.Color.Red;
            this.lblKayitBasarili.Location = new System.Drawing.Point(443, 23);
            this.lblKayitBasarili.Name = "lblKayitBasarili";
            this.lblKayitBasarili.Size = new System.Drawing.Size(229, 36);
            this.lblKayitBasarili.TabIndex = 34;
            this.lblKayitBasarili.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKayitBasarili.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Khaki;
            this.btnSil.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(1206, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(166, 45);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "PASİF YAP";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblMail
            // 
            this.lblMail.BackColor = System.Drawing.Color.Firebrick;
            this.lblMail.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.Color.Black;
            this.lblMail.Location = new System.Drawing.Point(19, 449);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(170, 45);
            this.lblMail.TabIndex = 37;
            this.lblMail.Text = "MAİL";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFaks
            // 
            this.lblFaks.BackColor = System.Drawing.Color.Firebrick;
            this.lblFaks.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaks.ForeColor = System.Drawing.Color.Black;
            this.lblFaks.Location = new System.Drawing.Point(19, 551);
            this.lblFaks.Name = "lblFaks";
            this.lblFaks.Size = new System.Drawing.Size(170, 45);
            this.lblFaks.TabIndex = 38;
            this.lblFaks.Text = "FAKS";
            this.lblFaks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdOgrenci
            // 
            this.grdOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOgrenci.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOgrenci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOgrenci.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdOgrenci.Location = new System.Drawing.Point(707, 79);
            this.grdOgrenci.Name = "grdOgrenci";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOgrenci.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdOgrenci.Size = new System.Drawing.Size(1108, 772);
            this.grdOgrenci.TabIndex = 40;
            this.grdOgrenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOgrenci_CellClick_1);
            // 
            // lblTarih
            // 
            this.lblTarih.BackColor = System.Drawing.Color.Firebrick;
            this.lblTarih.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.Black;
            this.lblTarih.Location = new System.Drawing.Point(19, 755);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(170, 45);
            this.lblTarih.TabIndex = 41;
            this.lblTarih.Text = "TARİH";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTarih
            // 
            this.tbTarih.BackColor = System.Drawing.SystemColors.Info;
            this.tbTarih.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTarih.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTarih.Location = new System.Drawing.Point(194, 755);
            this.tbTarih.Mask = "00/00/0000";
            this.tbTarih.Name = "tbTarih";
            this.tbTarih.Size = new System.Drawing.Size(476, 38);
            this.tbTarih.TabIndex = 29;
            this.tbTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTarih.ValidatingType = typeof(System.DateTime);
            // 
            // lblUzanti
            // 
            this.lblUzanti.BackColor = System.Drawing.Color.Firebrick;
            this.lblUzanti.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzanti.ForeColor = System.Drawing.Color.Black;
            this.lblUzanti.Location = new System.Drawing.Point(19, 501);
            this.lblUzanti.Name = "lblUzanti";
            this.lblUzanti.Size = new System.Drawing.Size(170, 45);
            this.lblUzanti.TabIndex = 44;
            this.lblUzanti.Text = "UZANTISI";
            this.lblUzanti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUzanti
            // 
            this.tbUzanti.BackColor = System.Drawing.SystemColors.Info;
            this.tbUzanti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUzanti.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUzanti.Location = new System.Drawing.Point(195, 500);
            this.tbUzanti.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.tbUzanti.Name = "tbUzanti";
            this.tbUzanti.Size = new System.Drawing.Size(476, 38);
            this.tbUzanti.TabIndex = 24;
            // 
            // btnIslem
            // 
            this.btnIslem.BackColor = System.Drawing.Color.Khaki;
            this.btnIslem.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslem.Location = new System.Drawing.Point(443, 194);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(227, 45);
            this.btnIslem.TabIndex = 31;
            this.btnIslem.Text = "KAYDET";
            this.btnIslem.UseVisualStyleBackColor = false;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // btnIslem2
            // 
            this.btnIslem2.BackColor = System.Drawing.Color.Khaki;
            this.btnIslem2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslem2.Location = new System.Drawing.Point(1378, 25);
            this.btnIslem2.Name = "btnIslem2";
            this.btnIslem2.Size = new System.Drawing.Size(166, 44);
            this.btnIslem2.TabIndex = 33;
            this.btnIslem2.Text = "PASİFLER";
            this.btnIslem2.UseVisualStyleBackColor = false;
            this.btnIslem2.Click += new System.EventHandler(this.btnIslem2_Click);
            // 
            // tbArama
            // 
            this.tbArama.BackColor = System.Drawing.Color.Khaki;
            this.tbArama.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArama.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbArama.Location = new System.Drawing.Point(884, 24);
            this.tbArama.Multiline = true;
            this.tbArama.Name = "tbArama";
            this.tbArama.Size = new System.Drawing.Size(316, 45);
            this.tbArama.TabIndex = 34;
            this.tbArama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbArama.TextChanged += new System.EventHandler(this.tbArama_TextChanged);
            // 
            // lblGsm
            // 
            this.lblGsm.BackColor = System.Drawing.Color.Firebrick;
            this.lblGsm.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGsm.ForeColor = System.Drawing.Color.Black;
            this.lblGsm.Location = new System.Drawing.Point(19, 806);
            this.lblGsm.Name = "lblGsm";
            this.lblGsm.Size = new System.Drawing.Size(170, 45);
            this.lblGsm.TabIndex = 49;
            this.lblGsm.Text = "GSM";
            this.lblGsm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbGsm
            // 
            this.tbGsm.BackColor = System.Drawing.SystemColors.Info;
            this.tbGsm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGsm.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbGsm.Location = new System.Drawing.Point(193, 806);
            this.tbGsm.Mask = "(0000) 000-0000";
            this.tbGsm.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbGsm.Name = "tbGsm";
            this.tbGsm.Size = new System.Drawing.Size(477, 38);
            this.tbGsm.TabIndex = 30;
            this.tbGsm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuSecim
            // 
            this.menuSecim.Controls.Add(this.tabPage1);
            this.menuSecim.Controls.Add(this.tabPage2);
            this.menuSecim.Controls.Add(this.tabPage3);
            this.menuSecim.Cursor = System.Windows.Forms.Cursors.Default;
            this.menuSecim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuSecim.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuSecim.Location = new System.Drawing.Point(0, 0);
            this.menuSecim.Name = "menuSecim";
            this.menuSecim.SelectedIndex = 0;
            this.menuSecim.Size = new System.Drawing.Size(1842, 907);
            this.menuSecim.TabIndex = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage1.Controls.Add(this.btnYenile1);
            this.tabPage1.Controls.Add(this.btnTemizle);
            this.tabPage1.Controls.Add(this.checkGenis);
            this.tabPage1.Controls.Add(this.btnKaliciSil);
            this.tabPage1.Controls.Add(this.cmbKategori);
            this.tabPage1.Controls.Add(this.lblArama);
            this.tabPage1.Controls.Add(this.lblAdi);
            this.tabPage1.Controls.Add(this.tbArama);
            this.tabPage1.Controls.Add(this.tbGsm);
            this.tabPage1.Controls.Add(this.lblSoyadi);
            this.tabPage1.Controls.Add(this.btnIslem2);
            this.tabPage1.Controls.Add(this.lblGsm);
            this.tabPage1.Controls.Add(this.btnIslem);
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.lblUnvani);
            this.tabPage1.Controls.Add(this.lblTelefonu);
            this.tabPage1.Controls.Add(this.tbAdi);
            this.tabPage1.Controls.Add(this.tbSoyadi);
            this.tabPage1.Controls.Add(this.tbUnvani);
            this.tabPage1.Controls.Add(this.tbTarih);
            this.tabPage1.Controls.Add(this.tbUzanti);
            this.tabPage1.Controls.Add(this.lblTarih);
            this.tabPage1.Controls.Add(this.tbTelefonu);
            this.tabPage1.Controls.Add(this.lblFaks);
            this.tabPage1.Controls.Add(this.grdOgrenci);
            this.tabPage1.Controls.Add(this.tbSirketAdi);
            this.tabPage1.Controls.Add(this.lblUzanti);
            this.tabPage1.Controls.Add(this.lblSirketAdi);
            this.tabPage1.Controls.Add(this.tbMail);
            this.tabPage1.Controls.Add(this.tbAdresi);
            this.tabPage1.Controls.Add(this.lblMail);
            this.tabPage1.Controls.Add(this.lblAdresi);
            this.tabPage1.Controls.Add(this.lblKayitBasarili);
            this.tabPage1.Controls.Add(this.tbWebSitesi);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.lblWebSitesi);
            this.tabPage1.Controls.Add(this.tbFaks);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1834, 866);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ana Menü";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Khaki;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(443, 143);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(227, 45);
            this.btnTemizle.TabIndex = 54;
            this.btnTemizle.Text = "Kategori Değiştir";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // checkGenis
            // 
            this.checkGenis.AutoSize = true;
            this.checkGenis.Location = new System.Drawing.Point(1663, 857);
            this.checkGenis.Name = "checkGenis";
            this.checkGenis.Size = new System.Drawing.Size(131, 32);
            this.checkGenis.TabIndex = 53;
            this.checkGenis.Text = "Geniş Göster";
            this.checkGenis.UseVisualStyleBackColor = true;
            this.checkGenis.CheckedChanged += new System.EventHandler(this.checkGenis_CheckedChanged);
            // 
            // btnKaliciSil
            // 
            this.btnKaliciSil.BackColor = System.Drawing.Color.Khaki;
            this.btnKaliciSil.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaliciSil.Location = new System.Drawing.Point(1597, 24);
            this.btnKaliciSil.Name = "btnKaliciSil";
            this.btnKaliciSil.Size = new System.Drawing.Size(218, 44);
            this.btnKaliciSil.TabIndex = 52;
            this.btnKaliciSil.Text = "SİL (dikkatli olun)";
            this.btnKaliciSil.UseVisualStyleBackColor = false;
            this.btnKaliciSil.Click += new System.EventHandler(this.btnKaliciSil_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(444, 62);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(227, 24);
            this.cmbKategori.TabIndex = 51;
            // 
            // lblArama
            // 
            this.lblArama.BackColor = System.Drawing.Color.Firebrick;
            this.lblArama.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.ForeColor = System.Drawing.Color.Black;
            this.lblArama.Location = new System.Drawing.Point(708, 25);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(170, 45);
            this.lblArama.TabIndex = 50;
            this.lblArama.Text = "ARAMA";
            this.lblArama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage2.Controls.Add(this.btnYenile2);
            this.tabPage2.Controls.Add(this.lblCift);
            this.tabPage2.Controls.Add(this.btnKatSil);
            this.tabPage2.Controls.Add(this.btnKatEkle2);
            this.tabPage2.Controls.Add(this.tbKategori);
            this.tabPage2.Controls.Add(this.grdKategori);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1834, 866);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Koleksiyon";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblCift
            // 
            this.lblCift.Location = new System.Drawing.Point(6, 128);
            this.lblCift.Name = "lblCift";
            this.lblCift.Size = new System.Drawing.Size(1822, 47);
            this.lblCift.TabIndex = 34;
            this.lblCift.Text = "Kategoriye ait verileri görmek için çift tıklatın.";
            this.lblCift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKatSil
            // 
            this.btnKatSil.BackColor = System.Drawing.Color.Khaki;
            this.btnKatSil.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKatSil.Location = new System.Drawing.Point(1155, 79);
            this.btnKatSil.Name = "btnKatSil";
            this.btnKatSil.Size = new System.Drawing.Size(477, 45);
            this.btnKatSil.TabIndex = 33;
            this.btnKatSil.Text = "SİL";
            this.btnKatSil.UseVisualStyleBackColor = false;
            this.btnKatSil.Click += new System.EventHandler(this.btnKatSil_Click);
            // 
            // btnKatEkle2
            // 
            this.btnKatEkle2.BackColor = System.Drawing.Color.Khaki;
            this.btnKatEkle2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKatEkle2.Location = new System.Drawing.Point(672, 80);
            this.btnKatEkle2.Name = "btnKatEkle2";
            this.btnKatEkle2.Size = new System.Drawing.Size(477, 45);
            this.btnKatEkle2.TabIndex = 32;
            this.btnKatEkle2.Text = "EKLE";
            this.btnKatEkle2.UseVisualStyleBackColor = false;
            this.btnKatEkle2.Click += new System.EventHandler(this.btnKatEkle_Click);
            // 
            // tbKategori
            // 
            this.tbKategori.BackColor = System.Drawing.Color.Khaki;
            this.tbKategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKategori.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKategori.Location = new System.Drawing.Point(189, 85);
            this.tbKategori.MinimumSize = new System.Drawing.Size(166, 44);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(477, 38);
            this.tbKategori.TabIndex = 21;
            this.tbKategori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grdKategori
            // 
            this.grdKategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdKategori.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdKategori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdKategori.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdKategori.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdKategori.Location = new System.Drawing.Point(3, 79);
            this.grdKategori.Name = "grdKategori";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdKategori.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdKategori.Size = new System.Drawing.Size(1828, 784);
            this.grdKategori.TabIndex = 12;
            this.grdKategori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdKategori_CellClick);
            this.grdKategori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdKategori_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage3.Controls.Add(this.btnyenile3);
            this.tabPage3.Controls.Add(this.lblAramaRapor2);
            this.tabPage3.Controls.Add(this.tbAramaRapor2);
            this.tabPage3.Controls.Add(this.checkKatAdi);
            this.tabPage3.Controls.Add(this.checkAktifPasif);
            this.tabPage3.Controls.Add(this.checkTumunu);
            this.tabPage3.Controls.Add(this.lblAramaRapor);
            this.tabPage3.Controls.Add(this.tbAramaRapor);
            this.tabPage3.Controls.Add(this.btnCikti);
            this.tabPage3.Controls.Add(this.checkID);
            this.tabPage3.Controls.Add(this.grdOgrenciRapor);
            this.tabPage3.Controls.Add(this.checkFaks);
            this.tabPage3.Controls.Add(this.checkTarih);
            this.tabPage3.Controls.Add(this.checkSirket);
            this.tabPage3.Controls.Add(this.checkAdres);
            this.tabPage3.Controls.Add(this.checkWeb);
            this.tabPage3.Controls.Add(this.checkMail);
            this.tabPage3.Controls.Add(this.checkGsm);
            this.tabPage3.Controls.Add(this.checkTelefon);
            this.tabPage3.Controls.Add(this.checkUnvan);
            this.tabPage3.Controls.Add(this.checkSoyad);
            this.tabPage3.Controls.Add(this.checkAd);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1834, 866);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rapor";
            // 
            // btnyenile3
            // 
            this.btnyenile3.BackColor = System.Drawing.Color.Khaki;
            this.btnyenile3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyenile3.Location = new System.Drawing.Point(280, 787);
            this.btnyenile3.Name = "btnyenile3";
            this.btnyenile3.Size = new System.Drawing.Size(227, 45);
            this.btnyenile3.TabIndex = 58;
            this.btnyenile3.Text = "YENİLE";
            this.btnyenile3.UseVisualStyleBackColor = false;
            this.btnyenile3.Click += new System.EventHandler(this.btnyenile3_Click);
            // 
            // lblAramaRapor2
            // 
            this.lblAramaRapor2.BackColor = System.Drawing.Color.Firebrick;
            this.lblAramaRapor2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAramaRapor2.ForeColor = System.Drawing.Color.Black;
            this.lblAramaRapor2.Location = new System.Drawing.Point(513, 787);
            this.lblAramaRapor2.Name = "lblAramaRapor2";
            this.lblAramaRapor2.Size = new System.Drawing.Size(507, 45);
            this.lblAramaRapor2.TabIndex = 57;
            this.lblAramaRapor2.Text = "KATEGORİ ADINA GÖRE ARAMA";
            this.lblAramaRapor2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAramaRapor2
            // 
            this.tbAramaRapor2.BackColor = System.Drawing.Color.Khaki;
            this.tbAramaRapor2.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAramaRapor2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbAramaRapor2.Location = new System.Drawing.Point(1026, 787);
            this.tbAramaRapor2.Multiline = true;
            this.tbAramaRapor2.Name = "tbAramaRapor2";
            this.tbAramaRapor2.Size = new System.Drawing.Size(791, 45);
            this.tbAramaRapor2.TabIndex = 56;
            this.tbAramaRapor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAramaRapor2.TextChanged += new System.EventHandler(this.tbAramaRapor2_TextChanged);
            // 
            // checkKatAdi
            // 
            this.checkKatAdi.AutoSize = true;
            this.checkKatAdi.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkKatAdi.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkKatAdi.Location = new System.Drawing.Point(49, 578);
            this.checkKatAdi.Name = "checkKatAdi";
            this.checkKatAdi.Size = new System.Drawing.Size(155, 51);
            this.checkKatAdi.TabIndex = 55;
            this.checkKatAdi.Text = "Kategori";
            this.checkKatAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkKatAdi.UseVisualStyleBackColor = true;
            this.checkKatAdi.CheckedChanged += new System.EventHandler(this.checkKatAdi_CheckedChanged);
            // 
            // checkAktifPasif
            // 
            this.checkAktifPasif.AutoSize = true;
            this.checkAktifPasif.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkAktifPasif.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkAktifPasif.Location = new System.Drawing.Point(49, 624);
            this.checkAktifPasif.Name = "checkAktifPasif";
            this.checkAktifPasif.Size = new System.Drawing.Size(182, 51);
            this.checkAktifPasif.TabIndex = 54;
            this.checkAktifPasif.Text = "Aktif Pasif";
            this.checkAktifPasif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkAktifPasif.UseVisualStyleBackColor = true;
            this.checkAktifPasif.CheckedChanged += new System.EventHandler(this.checkAktifPasif_CheckedChanged);
            // 
            // checkTumunu
            // 
            this.checkTumunu.AutoSize = true;
            this.checkTumunu.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkTumunu.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkTumunu.Location = new System.Drawing.Point(175, 715);
            this.checkTumunu.Name = "checkTumunu";
            this.checkTumunu.Size = new System.Drawing.Size(99, 32);
            this.checkTumunu.TabIndex = 53;
            this.checkTumunu.Text = "Tümünü";
            this.checkTumunu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkTumunu.UseVisualStyleBackColor = true;
            this.checkTumunu.CheckedChanged += new System.EventHandler(this.checkTumunu_CheckedChanged);
            // 
            // lblAramaRapor
            // 
            this.lblAramaRapor.BackColor = System.Drawing.Color.Firebrick;
            this.lblAramaRapor.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAramaRapor.ForeColor = System.Drawing.Color.Black;
            this.lblAramaRapor.Location = new System.Drawing.Point(280, 38);
            this.lblAramaRapor.Name = "lblAramaRapor";
            this.lblAramaRapor.Size = new System.Drawing.Size(740, 45);
            this.lblAramaRapor.TabIndex = 52;
            this.lblAramaRapor.Text = "AD, SOYAD, TARİH VEYA ŞİRKET ADINA GÖRE ARAMA";
            this.lblAramaRapor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAramaRapor
            // 
            this.tbAramaRapor.BackColor = System.Drawing.Color.Khaki;
            this.tbAramaRapor.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAramaRapor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbAramaRapor.Location = new System.Drawing.Point(1026, 38);
            this.tbAramaRapor.Multiline = true;
            this.tbAramaRapor.Name = "tbAramaRapor";
            this.tbAramaRapor.Size = new System.Drawing.Size(791, 45);
            this.tbAramaRapor.TabIndex = 51;
            this.tbAramaRapor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAramaRapor.TextChanged += new System.EventHandler(this.tbAramaRapor_TextChanged);
            // 
            // btnCikti
            // 
            this.btnCikti.BackColor = System.Drawing.Color.Khaki;
            this.btnCikti.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikti.Location = new System.Drawing.Point(29, 787);
            this.btnCikti.Name = "btnCikti";
            this.btnCikti.Size = new System.Drawing.Size(227, 45);
            this.btnCikti.TabIndex = 32;
            this.btnCikti.Text = "YAZDIR";
            this.btnCikti.UseVisualStyleBackColor = false;
            this.btnCikti.Click += new System.EventHandler(this.btnCikti_Click);
            // 
            // checkID
            // 
            this.checkID.AutoSize = true;
            this.checkID.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkID.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkID.Location = new System.Drawing.Point(49, 670);
            this.checkID.Name = "checkID";
            this.checkID.Size = new System.Drawing.Size(151, 51);
            this.checkID.TabIndex = 12;
            this.checkID.Text = "Numara";
            this.checkID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkID.UseVisualStyleBackColor = true;
            this.checkID.CheckedChanged += new System.EventHandler(this.checkID_CheckedChanged);
            // 
            // grdOgrenciRapor
            // 
            this.grdOgrenciRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOgrenciRapor.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOgrenciRapor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdOgrenciRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOgrenciRapor.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdOgrenciRapor.Location = new System.Drawing.Point(280, 102);
            this.grdOgrenciRapor.Name = "grdOgrenciRapor";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOgrenciRapor.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdOgrenciRapor.Size = new System.Drawing.Size(1537, 682);
            this.grdOgrenciRapor.TabIndex = 11;
            // 
            // checkFaks
            // 
            this.checkFaks.AutoSize = true;
            this.checkFaks.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkFaks.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkFaks.Location = new System.Drawing.Point(49, 317);
            this.checkFaks.Name = "checkFaks";
            this.checkFaks.Size = new System.Drawing.Size(146, 51);
            this.checkFaks.TabIndex = 10;
            this.checkFaks.Text = "Faks No";
            this.checkFaks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkFaks.UseVisualStyleBackColor = true;
            this.checkFaks.CheckedChanged += new System.EventHandler(this.checkFaks_CheckedChanged);
            // 
            // checkTarih
            // 
            this.checkTarih.AutoSize = true;
            this.checkTarih.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkTarih.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkTarih.Location = new System.Drawing.Point(49, 446);
            this.checkTarih.Name = "checkTarih";
            this.checkTarih.Size = new System.Drawing.Size(112, 51);
            this.checkTarih.TabIndex = 9;
            this.checkTarih.Text = "Tarih";
            this.checkTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkTarih.UseVisualStyleBackColor = true;
            this.checkTarih.CheckedChanged += new System.EventHandler(this.checkTarih_CheckedChanged);
            // 
            // checkSirket
            // 
            this.checkSirket.AutoSize = true;
            this.checkSirket.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkSirket.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkSirket.Location = new System.Drawing.Point(49, 489);
            this.checkSirket.Name = "checkSirket";
            this.checkSirket.Size = new System.Drawing.Size(179, 51);
            this.checkSirket.TabIndex = 8;
            this.checkSirket.Text = "Şirket Adı";
            this.checkSirket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkSirket.UseVisualStyleBackColor = true;
            this.checkSirket.CheckedChanged += new System.EventHandler(this.checkSirket_CheckedChanged);
            // 
            // checkAdres
            // 
            this.checkAdres.AutoSize = true;
            this.checkAdres.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkAdres.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkAdres.Location = new System.Drawing.Point(49, 403);
            this.checkAdres.Name = "checkAdres";
            this.checkAdres.Size = new System.Drawing.Size(117, 51);
            this.checkAdres.TabIndex = 7;
            this.checkAdres.Text = "Adres";
            this.checkAdres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkAdres.UseVisualStyleBackColor = true;
            this.checkAdres.CheckedChanged += new System.EventHandler(this.checkAdres_CheckedChanged);
            // 
            // checkWeb
            // 
            this.checkWeb.AutoSize = true;
            this.checkWeb.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkWeb.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkWeb.Location = new System.Drawing.Point(49, 532);
            this.checkWeb.Name = "checkWeb";
            this.checkWeb.Size = new System.Drawing.Size(172, 51);
            this.checkWeb.TabIndex = 6;
            this.checkWeb.Text = "Web sitesi";
            this.checkWeb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkWeb.UseVisualStyleBackColor = true;
            this.checkWeb.CheckedChanged += new System.EventHandler(this.checkWeb_CheckedChanged);
            // 
            // checkMail
            // 
            this.checkMail.AutoSize = true;
            this.checkMail.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkMail.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkMail.Location = new System.Drawing.Point(49, 360);
            this.checkMail.Name = "checkMail";
            this.checkMail.Size = new System.Drawing.Size(97, 51);
            this.checkMail.TabIndex = 5;
            this.checkMail.Text = "Mail";
            this.checkMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkMail.UseVisualStyleBackColor = true;
            this.checkMail.CheckedChanged += new System.EventHandler(this.checkMail_CheckedChanged);
            // 
            // checkGsm
            // 
            this.checkGsm.AutoSize = true;
            this.checkGsm.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkGsm.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkGsm.Location = new System.Drawing.Point(49, 231);
            this.checkGsm.Name = "checkGsm";
            this.checkGsm.Size = new System.Drawing.Size(103, 51);
            this.checkGsm.TabIndex = 4;
            this.checkGsm.Text = "GSM";
            this.checkGsm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkGsm.UseVisualStyleBackColor = true;
            this.checkGsm.CheckedChanged += new System.EventHandler(this.checkGsm_CheckedChanged);
            // 
            // checkTelefon
            // 
            this.checkTelefon.AutoSize = true;
            this.checkTelefon.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkTelefon.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkTelefon.Location = new System.Drawing.Point(49, 274);
            this.checkTelefon.Name = "checkTelefon";
            this.checkTelefon.Size = new System.Drawing.Size(136, 51);
            this.checkTelefon.TabIndex = 3;
            this.checkTelefon.Text = "Telefon";
            this.checkTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkTelefon.UseVisualStyleBackColor = true;
            this.checkTelefon.CheckedChanged += new System.EventHandler(this.checkTelefon_CheckedChanged);
            // 
            // checkUnvan
            // 
            this.checkUnvan.AutoSize = true;
            this.checkUnvan.Checked = true;
            this.checkUnvan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUnvan.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkUnvan.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkUnvan.Location = new System.Drawing.Point(49, 188);
            this.checkUnvan.Name = "checkUnvan";
            this.checkUnvan.Size = new System.Drawing.Size(127, 51);
            this.checkUnvan.TabIndex = 2;
            this.checkUnvan.Text = "Unvan";
            this.checkUnvan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkUnvan.UseVisualStyleBackColor = true;
            this.checkUnvan.CheckedChanged += new System.EventHandler(this.checkUnvan_CheckedChanged);
            // 
            // checkSoyad
            // 
            this.checkSoyad.AutoSize = true;
            this.checkSoyad.Checked = true;
            this.checkSoyad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSoyad.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkSoyad.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkSoyad.Location = new System.Drawing.Point(49, 145);
            this.checkSoyad.Name = "checkSoyad";
            this.checkSoyad.Size = new System.Drawing.Size(121, 51);
            this.checkSoyad.TabIndex = 1;
            this.checkSoyad.Text = "Soyad";
            this.checkSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkSoyad.UseVisualStyleBackColor = true;
            this.checkSoyad.CheckedChanged += new System.EventHandler(this.checkSoyad_CheckedChanged);
            // 
            // checkAd
            // 
            this.checkAd.AutoSize = true;
            this.checkAd.Checked = true;
            this.checkAd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAd.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkAd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkAd.Location = new System.Drawing.Point(49, 102);
            this.checkAd.Name = "checkAd";
            this.checkAd.Size = new System.Drawing.Size(78, 51);
            this.checkAd.TabIndex = 0;
            this.checkAd.Text = "Ad";
            this.checkAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkAd.UseVisualStyleBackColor = true;
            this.checkAd.CheckedChanged += new System.EventHandler(this.checkAd_CheckedChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnYenile2
            // 
            this.btnYenile2.BackColor = System.Drawing.Color.Khaki;
            this.btnYenile2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile2.Location = new System.Drawing.Point(672, 28);
            this.btnYenile2.Name = "btnYenile2";
            this.btnYenile2.Size = new System.Drawing.Size(477, 45);
            this.btnYenile2.TabIndex = 35;
            this.btnYenile2.Text = "YENİLE";
            this.btnYenile2.UseVisualStyleBackColor = false;
            this.btnYenile2.Click += new System.EventHandler(this.btnYenile2_Click);
            // 
            // btnYenile1
            // 
            this.btnYenile1.BackColor = System.Drawing.Color.Khaki;
            this.btnYenile1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile1.Location = new System.Drawing.Point(443, 92);
            this.btnYenile1.Name = "btnYenile1";
            this.btnYenile1.Size = new System.Drawing.Size(227, 45);
            this.btnYenile1.TabIndex = 55;
            this.btnYenile1.Text = "YENİLE";
            this.btnYenile1.UseVisualStyleBackColor = false;
            this.btnYenile1.Click += new System.EventHandler(this.btnYenile1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1842, 907);
            this.Controls.Add(this.menuSecim);
            this.Name = "Form1";
            this.Text = "Kart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOgrenci)).EndInit();
            this.menuSecim.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKategori)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOgrenciRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
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
        private System.Windows.Forms.Label lblWebSitesi;
        private System.Windows.Forms.MaskedTextBox tbWebSitesi;
        private System.Windows.Forms.Label lblAdresi;
        private System.Windows.Forms.MaskedTextBox tbAdresi;
        private System.Windows.Forms.Label lblSirketAdi;
        private System.Windows.Forms.MaskedTextBox tbSirketAdi;
        private System.Windows.Forms.Label lblKayitBasarili;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblFaks;
        private System.Windows.Forms.DataGridView grdOgrenci;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.MaskedTextBox tbTarih;
        private System.Windows.Forms.Label lblUzanti;
        private System.Windows.Forms.MaskedTextBox tbUzanti;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Button btnIslem2;
        private System.Windows.Forms.TextBox tbArama;
        private System.Windows.Forms.Label lblGsm;
        private System.Windows.Forms.MaskedTextBox tbGsm;
        private System.Windows.Forms.TabControl menuSecim;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkAd;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.CheckBox checkWeb;
        private System.Windows.Forms.CheckBox checkMail;
        private System.Windows.Forms.CheckBox checkGsm;
        private System.Windows.Forms.CheckBox checkTelefon;
        private System.Windows.Forms.CheckBox checkUnvan;
        private System.Windows.Forms.CheckBox checkSoyad;
        private System.Windows.Forms.CheckBox checkFaks;
        private System.Windows.Forms.CheckBox checkTarih;
        private System.Windows.Forms.CheckBox checkSirket;
        private System.Windows.Forms.CheckBox checkAdres;
        private System.Windows.Forms.DataGridView grdOgrenciRapor;
        private System.Windows.Forms.CheckBox checkID;
        private System.Windows.Forms.Button btnKaliciSil;
        private System.Windows.Forms.CheckBox checkGenis;
        private System.Windows.Forms.Button btnCikti;
        private System.Windows.Forms.Label lblAramaRapor;
        private System.Windows.Forms.TextBox tbAramaRapor;
        private System.Windows.Forms.CheckBox checkTumunu;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView grdKategori;
        private System.Windows.Forms.Button btnKatEkle2;
        private System.Windows.Forms.MaskedTextBox tbKategori;
        private System.Windows.Forms.Button btnKatSil;
        private System.Windows.Forms.CheckBox checkAktifPasif;
        private System.Windows.Forms.CheckBox checkKatAdi;
        private System.Windows.Forms.Label lblAramaRapor2;
        private System.Windows.Forms.TextBox tbAramaRapor2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblCift;
        private System.Windows.Forms.Button btnyenile3;
        private System.Windows.Forms.Button btnYenile2;
        private System.Windows.Forms.Button btnYenile1;
    }
}


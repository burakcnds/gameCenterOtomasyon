
namespace GameCenter
{
    partial class GameCenter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCenter));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbBosMasalar = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rbSuresiz = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cihazKiralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKayıtEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKayıtGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGeriAl = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.SaatUcret = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btMasaDegistir = new System.Windows.Forms.Button();
            this.btnMasaAc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.MASA7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SepetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcilisTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hesapla = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MasaKapat = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "MasaIkon.png");
            this.ımageList1.Images.SetKeyName(1, "urunEkle.png");
            this.ımageList1.Images.SetKeyName(2, "masaAc.png");
            // 
            // cbBosMasalar
            // 
            this.cbBosMasalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBosMasalar.FormattingEnabled = true;
            this.cbBosMasalar.Location = new System.Drawing.Point(1336, 62);
            this.cbBosMasalar.Name = "cbBosMasalar";
            this.cbBosMasalar.Size = new System.Drawing.Size(200, 21);
            this.cbBosMasalar.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SepetID,
            this.MasaID,
            this.Masa,
            this.Baslangic,
            this.Bitis,
            this.AcilisTuru,
            this.Sure1,
            this.Tutar,
            this.Tarih,
            this.Hesapla,
            this.MasaKapat});
            this.dataGridView1.Location = new System.Drawing.Point(31, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1278, 354);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1333, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Boş Masalar : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.radioButton8);
            this.panel1.Controls.Add(this.radioButton10);
            this.panel1.Controls.Add(this.radioButton11);
            this.panel1.Controls.Add(this.radioButton12);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.rbSuresiz);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Location = new System.Drawing.Point(1338, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 149);
            this.panel1.TabIndex = 17;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(120, 86);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(43, 17);
            this.radioButton7.TabIndex = 28;
            this.radioButton7.Text = "210";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.RadioButtonSecilen);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(120, 109);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(43, 17);
            this.radioButton8.TabIndex = 29;
            this.radioButton8.Text = "300";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.RadioButtonSecilen);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(120, 17);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(31, 17);
            this.radioButton10.TabIndex = 25;
            this.radioButton10.Text = "1";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.RadioButtonSecilen);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(120, 40);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(37, 17);
            this.radioButton11.TabIndex = 26;
            this.radioButton11.Text = "90";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.RadioButtonSecilen);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(120, 63);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(43, 17);
            this.radioButton12.TabIndex = 27;
            this.radioButton12.Text = "150";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.RadioButtonSecilen);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(14, 86);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(43, 17);
            this.radioButton4.TabIndex = 22;
            this.radioButton4.Text = "180";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButtonSecilen);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(14, 109);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(43, 17);
            this.radioButton5.TabIndex = 23;
            this.radioButton5.Text = "240";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButtonSecilen);
            // 
            // rbSuresiz
            // 
            this.rbSuresiz.AutoSize = true;
            this.rbSuresiz.Location = new System.Drawing.Point(14, 17);
            this.rbSuresiz.Name = "rbSuresiz";
            this.rbSuresiz.Size = new System.Drawing.Size(59, 17);
            this.rbSuresiz.TabIndex = 19;
            this.rbSuresiz.Text = "Süresiz";
            this.rbSuresiz.UseVisualStyleBackColor = true;
            this.rbSuresiz.CheckedChanged += new System.EventHandler(this.RadioButtonSecilen);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.Text = "60";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButtonSecilen);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(14, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 17);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.Text = "120";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButtonSecilen);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cihazKiralaToolStripMenuItem,
            this.yönetimToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1565, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cihazKiralaToolStripMenuItem
            // 
            this.cihazKiralaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKayıtEkle,
            this.btnKayıtGoster});
            this.cihazKiralaToolStripMenuItem.Name = "cihazKiralaToolStripMenuItem";
            this.cihazKiralaToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.cihazKiralaToolStripMenuItem.Text = "Cihaz Kirala";
            // 
            // btnKayıtEkle
            // 
            this.btnKayıtEkle.Name = "btnKayıtEkle";
            this.btnKayıtEkle.Size = new System.Drawing.Size(153, 22);
            this.btnKayıtEkle.Text = "Kayıt Ekle";
            this.btnKayıtEkle.Click += new System.EventHandler(this.btnKayıtEkle_Click);
            // 
            // btnKayıtGoster
            // 
            this.btnKayıtGoster.Name = "btnKayıtGoster";
            this.btnKayıtGoster.Size = new System.Drawing.Size(153, 22);
            this.btnKayıtGoster.Text = "Kayıtları Göster";
            this.btnKayıtGoster.Click += new System.EventHandler(this.btnKayıtGoster_Click);
            // 
            // yönetimToolStripMenuItem
            // 
            this.yönetimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGeriAl});
            this.yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            this.yönetimToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.yönetimToolStripMenuItem.Text = "Yönetim";
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(180, 22);
            this.btnGeriAl.Text = "Kapatılan Masalar";
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1335, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Saat Ücreti";
            // 
            // SaatUcret
            // 
            this.SaatUcret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaatUcret.FormattingEnabled = true;
            this.SaatUcret.Location = new System.Drawing.Point(1336, 131);
            this.SaatUcret.Name = "SaatUcret";
            this.SaatUcret.Size = new System.Drawing.Size(200, 21);
            this.SaatUcret.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btMasaDegistir
            // 
            this.btMasaDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMasaDegistir.Image = global::GameCenter.Properties.Resources.degistir;
            this.btMasaDegistir.Location = new System.Drawing.Point(1336, 484);
            this.btMasaDegistir.Name = "btMasaDegistir";
            this.btMasaDegistir.Size = new System.Drawing.Size(200, 105);
            this.btMasaDegistir.TabIndex = 27;
            this.btMasaDegistir.Text = "Masa Değiştir";
            this.btMasaDegistir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btMasaDegistir.UseVisualStyleBackColor = true;
            this.btMasaDegistir.Click += new System.EventHandler(this.btMasaDegistir_Click);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.ImageKey = "masaAc.png";
            this.btnMasaAc.ImageList = this.ımageList1;
            this.btnMasaAc.Location = new System.Drawing.Point(1336, 356);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(200, 105);
            this.btnMasaAc.TabIndex = 18;
            this.btnMasaAc.Text = "Masa Aç";
            this.btnMasaAc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMasaAc.UseVisualStyleBackColor = true;
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.MASA7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(31, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 194);
            this.panel2.TabIndex = 28;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ImageKey = "MasaIkon.png";
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(32, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 68);
            this.button8.TabIndex = 21;
            this.button8.Text = "MASA 1";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ImageKey = "MasaIkon.png";
            this.button9.ImageList = this.ımageList1;
            this.button9.Location = new System.Drawing.Point(220, 10);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(134, 68);
            this.button9.TabIndex = 19;
            this.button9.Text = "MASA 2";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ImageKey = "MasaIkon.png";
            this.button10.ImageList = this.ımageList1;
            this.button10.Location = new System.Drawing.Point(396, 10);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(134, 68);
            this.button10.TabIndex = 18;
            this.button10.Text = "MASA 3";
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ImageKey = "MasaIkon.png";
            this.button11.ImageList = this.ımageList1;
            this.button11.Location = new System.Drawing.Point(586, 10);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(134, 68);
            this.button11.TabIndex = 17;
            this.button11.Text = "MASA 4";
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ImageKey = "MasaIkon.png";
            this.button12.ImageList = this.ımageList1;
            this.button12.Location = new System.Drawing.Point(776, 10);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(134, 68);
            this.button12.TabIndex = 16;
            this.button12.Text = "MASA 5";
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ImageKey = "MasaIkon.png";
            this.button13.ImageList = this.ımageList1;
            this.button13.Location = new System.Drawing.Point(953, 10);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(134, 68);
            this.button13.TabIndex = 15;
            this.button13.Text = "MASA 6";
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ImageKey = "MasaIkon.png";
            this.button14.ImageList = this.ımageList1;
            this.button14.Location = new System.Drawing.Point(1130, 10);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(134, 68);
            this.button14.TabIndex = 14;
            this.button14.Text = "MASA 7";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // MASA7
            // 
            this.MASA7.FlatAppearance.BorderSize = 0;
            this.MASA7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MASA7.ImageKey = "MasaIkon.png";
            this.MASA7.ImageList = this.ımageList1;
            this.MASA7.Location = new System.Drawing.Point(32, 112);
            this.MASA7.Name = "MASA7";
            this.MASA7.Size = new System.Drawing.Size(134, 68);
            this.MASA7.TabIndex = 13;
            this.MASA7.Text = "MASA 8";
            this.MASA7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MASA7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageKey = "MasaIkon.png";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(220, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 68);
            this.button6.TabIndex = 12;
            this.button6.Text = "MASA 9";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageKey = "MasaIkon.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(396, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 68);
            this.button5.TabIndex = 11;
            this.button5.Text = "MASA 10";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageKey = "MasaIkon.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(586, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 68);
            this.button4.TabIndex = 10;
            this.button4.Text = "MASA 11";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "MasaIkon.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(776, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 68);
            this.button3.TabIndex = 9;
            this.button3.Text = "MASA 12";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "MasaIkon.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(953, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 68);
            this.button2.TabIndex = 8;
            this.button2.Text = "MASA 13";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AccessibleName = "";
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "MasaIkon.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(1130, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "MASA 14";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SepetID
            // 
            this.SepetID.DataPropertyName = "SepetID";
            this.SepetID.HeaderText = "ID";
            this.SepetID.Name = "SepetID";
            this.SepetID.ReadOnly = true;
            // 
            // MasaID
            // 
            this.MasaID.DataPropertyName = "MasaID";
            this.MasaID.HeaderText = "Masa ID";
            this.MasaID.Name = "MasaID";
            this.MasaID.ReadOnly = true;
            // 
            // Masa
            // 
            this.Masa.DataPropertyName = "Masa";
            this.Masa.HeaderText = "Masa";
            this.Masa.Name = "Masa";
            this.Masa.ReadOnly = true;
            // 
            // Baslangic
            // 
            this.Baslangic.DataPropertyName = "Baslangic";
            this.Baslangic.HeaderText = "Başlangıç Saati";
            this.Baslangic.Name = "Baslangic";
            this.Baslangic.ReadOnly = true;
            // 
            // Bitis
            // 
            this.Bitis.HeaderText = "Bitiş Saati";
            this.Bitis.Name = "Bitis";
            this.Bitis.ReadOnly = true;
            // 
            // AcilisTuru
            // 
            this.AcilisTuru.DataPropertyName = "AcilisTuru";
            this.AcilisTuru.HeaderText = "Açılış Türü";
            this.AcilisTuru.Name = "AcilisTuru";
            this.AcilisTuru.ReadOnly = true;
            // 
            // Sure1
            // 
            this.Sure1.HeaderText = "Süre";
            this.Sure1.Name = "Sure1";
            this.Sure1.ReadOnly = true;
            // 
            // Tutar
            // 
            this.Tutar.DataPropertyName = "Tutar";
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            // 
            // Hesapla
            // 
            this.Hesapla.HeaderText = "Hesapla";
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.ReadOnly = true;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.ToolTipText = "Hesapla";
            this.Hesapla.UseColumnTextForButtonValue = true;
            // 
            // MasaKapat
            // 
            this.MasaKapat.HeaderText = "Masa Kapat";
            this.MasaKapat.Name = "MasaKapat";
            this.MasaKapat.ReadOnly = true;
            this.MasaKapat.Text = "Masa Kapat";
            this.MasaKapat.UseColumnTextForButtonValue = true;
            // 
            // GameCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btMasaDegistir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaatUcret);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnMasaAc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbBosMasalar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameCenter";
            this.Text = "GameCenter";
            this.Load += new System.EventHandler(this.GameCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbBosMasalar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton rbSuresiz;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnMasaAc;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cihazKiralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnGeriAl;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SaatUcret;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btMasaDegistir;
        private System.Windows.Forms.ToolStripMenuItem btnKayıtEkle;
        private System.Windows.Forms.ToolStripMenuItem btnKayıtGoster;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MASA7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SepetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcilisTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewButtonColumn Hesapla;
        private System.Windows.Forms.DataGridViewButtonColumn MasaKapat;
    }
}


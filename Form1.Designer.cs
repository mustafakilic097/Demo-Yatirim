namespace demo_yatirim
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fakeCard = new MaterialSkin.Controls.MaterialCard();
            this.btn_ayarlar = new MaterialSkin.Controls.MaterialButton();
            this.realCard = new MaterialSkin.Controls.MaterialCard();
            this.realMoney = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_al = new MaterialSkin.Controls.MaterialButton();
            this.btn_sat = new MaterialSkin.Controls.MaterialButton();
            this.alimSatimEkrani = new MaterialSkin.Controls.MaterialCard();
            this.txt_secilenHisse = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.alim_fiyat = new System.Windows.Forms.TextBox();
            this.sonucLabel = new System.Windows.Forms.Label();
            this.txt_miktar = new System.Windows.Forms.NumericUpDown();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.performans_ekrani = new MaterialSkin.Controls.MaterialCard();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.portfoyEkrani = new MaterialSkin.Controls.MaterialCard();
            this.portfoyRefresh = new MaterialSkin.Controls.MaterialButton();
            this.portfoyList = new MaterialSkin.Controls.MaterialListView();
            this.isim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maliyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guncel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_analiz = new MaterialSkin.Controls.MaterialButton();
            this.refreshState = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cleanFilter = new System.Windows.Forms.Button();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshList = new MaterialSkin.Controls.MaterialButton();
            this.fiyatList = new System.Windows.Forms.ListView();
            this.İsim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Oran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fakeCard.SuspendLayout();
            this.realCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.alimSatimEkrani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_miktar)).BeginInit();
            this.performans_ekrani.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.portfoyEkrani.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fakeCard
            // 
            this.fakeCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fakeCard.Controls.Add(this.btn_ayarlar);
            this.fakeCard.Depth = 0;
            this.fakeCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fakeCard.Location = new System.Drawing.Point(735, 6);
            this.fakeCard.Margin = new System.Windows.Forms.Padding(14);
            this.fakeCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.fakeCard.Name = "fakeCard";
            this.fakeCard.Padding = new System.Windows.Forms.Padding(14);
            this.fakeCard.Size = new System.Drawing.Size(66, 35);
            this.fakeCard.TabIndex = 0;
            // 
            // btn_ayarlar
            // 
            this.btn_ayarlar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ayarlar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_ayarlar.Depth = 0;
            this.btn_ayarlar.HighEmphasis = true;
            this.btn_ayarlar.Icon = global::demo_yatirim.Properties.Resources.icons8_settings_67;
            this.btn_ayarlar.Location = new System.Drawing.Point(12, 3);
            this.btn_ayarlar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ayarlar.MaximumSize = new System.Drawing.Size(40, 30);
            this.btn_ayarlar.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_ayarlar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ayarlar.Name = "btn_ayarlar";
            this.btn_ayarlar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_ayarlar.Size = new System.Drawing.Size(40, 30);
            this.btn_ayarlar.TabIndex = 2;
            this.btn_ayarlar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ayarlar.UseAccentColor = false;
            this.btn_ayarlar.UseVisualStyleBackColor = true;
            this.btn_ayarlar.Click += new System.EventHandler(this.btn_ayarlar_Click);
            // 
            // realCard
            // 
            this.realCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.realCard.Controls.Add(this.realMoney);
            this.realCard.Controls.Add(this.pictureBox1);
            this.realCard.Depth = 0;
            this.realCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.realCard.Location = new System.Drawing.Point(575, 6);
            this.realCard.Margin = new System.Windows.Forms.Padding(14);
            this.realCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.realCard.Name = "realCard";
            this.realCard.Padding = new System.Windows.Forms.Padding(14);
            this.realCard.Size = new System.Drawing.Size(154, 35);
            this.realCard.TabIndex = 1;
            // 
            // realMoney
            // 
            this.realMoney.AutoSize = true;
            this.realMoney.Depth = 0;
            this.realMoney.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.realMoney.Location = new System.Drawing.Point(39, 8);
            this.realMoney.MouseState = MaterialSkin.MouseState.HOVER;
            this.realMoney.Name = "realMoney";
            this.realMoney.Size = new System.Drawing.Size(10, 19);
            this.realMoney.TabIndex = 2;
            this.realMoney.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::demo_yatirim.Properties.Resources.realMoney;
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_al
            // 
            this.btn_al.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_al.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_al.Depth = 0;
            this.btn_al.HighEmphasis = true;
            this.btn_al.Icon = null;
            this.btn_al.Location = new System.Drawing.Point(231, 12);
            this.btn_al.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_al.MaximumSize = new System.Drawing.Size(100, 30);
            this.btn_al.MinimumSize = new System.Drawing.Size(100, 30);
            this.btn_al.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_al.Name = "btn_al";
            this.btn_al.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_al.Size = new System.Drawing.Size(100, 30);
            this.btn_al.TabIndex = 4;
            this.btn_al.Text = "Al";
            this.btn_al.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_al.UseAccentColor = false;
            this.btn_al.UseVisualStyleBackColor = true;
            this.btn_al.Click += new System.EventHandler(this.btn_al_Click);
            // 
            // btn_sat
            // 
            this.btn_sat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_sat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_sat.Depth = 0;
            this.btn_sat.HighEmphasis = true;
            this.btn_sat.Icon = null;
            this.btn_sat.Location = new System.Drawing.Point(339, 12);
            this.btn_sat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_sat.MaximumSize = new System.Drawing.Size(100, 30);
            this.btn_sat.MinimumSize = new System.Drawing.Size(100, 30);
            this.btn_sat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_sat.Name = "btn_sat";
            this.btn_sat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_sat.Size = new System.Drawing.Size(100, 30);
            this.btn_sat.TabIndex = 5;
            this.btn_sat.Text = "Sat";
            this.btn_sat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_sat.UseAccentColor = true;
            this.btn_sat.UseVisualStyleBackColor = false;
            this.btn_sat.Click += new System.EventHandler(this.btn_sat_Click);
            // 
            // alimSatimEkrani
            // 
            this.alimSatimEkrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alimSatimEkrani.Controls.Add(this.txt_secilenHisse);
            this.alimSatimEkrani.Controls.Add(this.materialLabel6);
            this.alimSatimEkrani.Controls.Add(this.alim_fiyat);
            this.alimSatimEkrani.Controls.Add(this.sonucLabel);
            this.alimSatimEkrani.Controls.Add(this.txt_miktar);
            this.alimSatimEkrani.Controls.Add(this.materialLabel5);
            this.alimSatimEkrani.Controls.Add(this.materialLabel4);
            this.alimSatimEkrani.Controls.Add(this.materialLabel3);
            this.alimSatimEkrani.Controls.Add(this.materialLabel2);
            this.alimSatimEkrani.Controls.Add(this.materialLabel1);
            this.alimSatimEkrani.Depth = 0;
            this.alimSatimEkrani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.alimSatimEkrani.Location = new System.Drawing.Point(238, 46);
            this.alimSatimEkrani.Margin = new System.Windows.Forms.Padding(14);
            this.alimSatimEkrani.MouseState = MaterialSkin.MouseState.HOVER;
            this.alimSatimEkrani.Name = "alimSatimEkrani";
            this.alimSatimEkrani.Padding = new System.Windows.Forms.Padding(14);
            this.alimSatimEkrani.Size = new System.Drawing.Size(282, 221);
            this.alimSatimEkrani.TabIndex = 6;
            // 
            // txt_secilenHisse
            // 
            this.txt_secilenHisse.Location = new System.Drawing.Point(69, 35);
            this.txt_secilenHisse.Name = "txt_secilenHisse";
            this.txt_secilenHisse.ReadOnly = true;
            this.txt_secilenHisse.Size = new System.Drawing.Size(196, 32);
            this.txt_secilenHisse.TabIndex = 14;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(17, 120);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(33, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Adet";
            // 
            // alim_fiyat
            // 
            this.alim_fiyat.Location = new System.Drawing.Point(69, 73);
            this.alim_fiyat.Name = "alim_fiyat";
            this.alim_fiyat.ReadOnly = true;
            this.alim_fiyat.Size = new System.Drawing.Size(196, 32);
            this.alim_fiyat.TabIndex = 12;
            // 
            // sonucLabel
            // 
            this.sonucLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucLabel.Location = new System.Drawing.Point(134, 146);
            this.sonucLabel.Name = "sonucLabel";
            this.sonucLabel.Size = new System.Drawing.Size(125, 66);
            this.sonucLabel.TabIndex = 10;
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(69, 111);
            this.txt_miktar.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txt_miktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(196, 32);
            this.txt_miktar.TabIndex = 9;
            this.txt_miktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_miktar.ValueChanged += new System.EventHandler(this.txt_miktar_ValueChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(66, 146);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(68, 66);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Hisse:\r\nAdet:\r\nDurum:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(9, 151);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(50, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Sonuç:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(17, 83);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(36, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Fiyat";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(9, 44);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Hisse";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(9, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(125, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Hisse Alım/Satım";
            // 
            // performans_ekrani
            // 
            this.performans_ekrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.performans_ekrani.Controls.Add(this.tabControl1);
            this.performans_ekrani.Depth = 0;
            this.performans_ekrani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.performans_ekrani.Location = new System.Drawing.Point(523, 46);
            this.performans_ekrani.Margin = new System.Windows.Forms.Padding(14);
            this.performans_ekrani.MouseState = MaterialSkin.MouseState.HOVER;
            this.performans_ekrani.Name = "performans_ekrani";
            this.performans_ekrani.Padding = new System.Windows.Forms.Padding(14);
            this.performans_ekrani.Size = new System.Drawing.Size(278, 221);
            this.performans_ekrani.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Helvetica Rounded", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(275, 217);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(267, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel Durum";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(267, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Takiplerim";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(267, 189);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Geçmiş";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // portfoyEkrani
            // 
            this.portfoyEkrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.portfoyEkrani.Controls.Add(this.portfoyRefresh);
            this.portfoyEkrani.Controls.Add(this.portfoyList);
            this.portfoyEkrani.Depth = 0;
            this.portfoyEkrani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.portfoyEkrani.Location = new System.Drawing.Point(238, 268);
            this.portfoyEkrani.Margin = new System.Windows.Forms.Padding(14);
            this.portfoyEkrani.MouseState = MaterialSkin.MouseState.HOVER;
            this.portfoyEkrani.Name = "portfoyEkrani";
            this.portfoyEkrani.Padding = new System.Windows.Forms.Padding(14);
            this.portfoyEkrani.Size = new System.Drawing.Size(563, 141);
            this.portfoyEkrani.TabIndex = 8;
            // 
            // portfoyRefresh
            // 
            this.portfoyRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.portfoyRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.portfoyRefresh.Depth = 0;
            this.portfoyRefresh.HighEmphasis = true;
            this.portfoyRefresh.Icon = ((System.Drawing.Image)(resources.GetObject("portfoyRefresh.Icon")));
            this.portfoyRefresh.Location = new System.Drawing.Point(527, 1);
            this.portfoyRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.portfoyRefresh.MaximumSize = new System.Drawing.Size(40, 30);
            this.portfoyRefresh.MinimumSize = new System.Drawing.Size(30, 30);
            this.portfoyRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.portfoyRefresh.Name = "portfoyRefresh";
            this.portfoyRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.portfoyRefresh.Size = new System.Drawing.Size(40, 30);
            this.portfoyRefresh.TabIndex = 1;
            this.portfoyRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.portfoyRefresh.UseAccentColor = false;
            this.portfoyRefresh.UseVisualStyleBackColor = true;
            this.portfoyRefresh.Click += new System.EventHandler(this.portfoyRefresh_Click);
            // 
            // portfoyList
            // 
            this.portfoyList.AutoSizeTable = false;
            this.portfoyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.portfoyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portfoyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.isim,
            this.adet,
            this.maliyet,
            this.tarih,
            this.guncel});
            this.portfoyList.Depth = 0;
            this.portfoyList.FullRowSelect = true;
            this.portfoyList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.portfoyList.HideSelection = false;
            this.portfoyList.Location = new System.Drawing.Point(0, 1);
            this.portfoyList.MinimumSize = new System.Drawing.Size(200, 100);
            this.portfoyList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.portfoyList.MouseState = MaterialSkin.MouseState.OUT;
            this.portfoyList.Name = "portfoyList";
            this.portfoyList.OwnerDraw = true;
            this.portfoyList.Size = new System.Drawing.Size(567, 140);
            this.portfoyList.TabIndex = 0;
            this.portfoyList.UseCompatibleStateImageBehavior = false;
            this.portfoyList.View = System.Windows.Forms.View.Details;
            this.portfoyList.SelectedIndexChanged += new System.EventHandler(this.portfoyList_SelectedIndexChanged);
            // 
            // isim
            // 
            this.isim.Text = "İsim";
            // 
            // adet
            // 
            this.adet.Text = "Adet";
            this.adet.Width = 100;
            // 
            // maliyet
            // 
            this.maliyet.Text = "Maliyet";
            this.maliyet.Width = 100;
            // 
            // tarih
            // 
            this.tarih.Text = "Tarih";
            this.tarih.Width = 105;
            // 
            // guncel
            // 
            this.guncel.Text = "Güncel Fiyat";
            this.guncel.Width = 114;
            // 
            // btn_analiz
            // 
            this.btn_analiz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_analiz.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_analiz.Depth = 0;
            this.btn_analiz.HighEmphasis = true;
            this.btn_analiz.Icon = null;
            this.btn_analiz.Location = new System.Drawing.Point(447, 11);
            this.btn_analiz.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_analiz.MaximumSize = new System.Drawing.Size(120, 30);
            this.btn_analiz.MinimumSize = new System.Drawing.Size(100, 30);
            this.btn_analiz.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_analiz.Name = "btn_analiz";
            this.btn_analiz.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_analiz.Size = new System.Drawing.Size(100, 30);
            this.btn_analiz.TabIndex = 9;
            this.btn_analiz.Text = "Analiz";
            this.btn_analiz.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_analiz.UseAccentColor = false;
            this.btn_analiz.UseVisualStyleBackColor = true;
            this.btn_analiz.Click += new System.EventHandler(this.btn_analiz_Click);
            // 
            // refreshState
            // 
            this.refreshState.AutoSize = true;
            this.refreshState.Location = new System.Drawing.Point(51, 197);
            this.refreshState.Name = "refreshState";
            this.refreshState.Size = new System.Drawing.Size(130, 25);
            this.refreshState.TabIndex = 10;
            this.refreshState.Text = "Yükleniyor...";
            this.refreshState.Visible = false;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Search.Location = new System.Drawing.Point(4, 12);
            this.txt_Search.MaximumSize = new System.Drawing.Size(105, 30);
            this.txt_Search.MinimumSize = new System.Drawing.Size(105, 30);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(105, 30);
            this.txt_Search.TabIndex = 11;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Search.TextChanged += new System.EventHandler(this.listFilter_TextChanged);
            // 
            // cleanFilter
            // 
            this.cleanFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleanFilter.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cleanFilter.Location = new System.Drawing.Point(109, 12);
            this.cleanFilter.Name = "cleanFilter";
            this.cleanFilter.Size = new System.Drawing.Size(24, 30);
            this.cleanFilter.TabIndex = 12;
            this.cleanFilter.Text = "X";
            this.cleanFilter.UseVisualStyleBackColor = true;
            this.cleanFilter.Click += new System.EventHandler(this.cleanFilter_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(6, 386);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(229, 26);
            this.materialCard1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Veriler 15dk gecikmelidir.";
            // 
            // refreshList
            // 
            this.refreshList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.refreshList.Depth = 0;
            this.refreshList.HighEmphasis = true;
            this.refreshList.Icon = ((System.Drawing.Image)(resources.GetObject("refreshList.Icon")));
            this.refreshList.Location = new System.Drawing.Point(133, 12);
            this.refreshList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.refreshList.MaximumSize = new System.Drawing.Size(85, 30);
            this.refreshList.MinimumSize = new System.Drawing.Size(90, 30);
            this.refreshList.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshList.Name = "refreshList";
            this.refreshList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.refreshList.Size = new System.Drawing.Size(90, 30);
            this.refreshList.TabIndex = 2;
            this.refreshList.Text = "Yenile";
            this.refreshList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.refreshList.UseAccentColor = false;
            this.refreshList.UseVisualStyleBackColor = true;
            this.refreshList.Click += new System.EventHandler(this.refreshList_Click);
            // 
            // fiyatList
            // 
            this.fiyatList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fiyatList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.İsim,
            this.Fiyat,
            this.Oran});
            this.fiyatList.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatList.FullRowSelect = true;
            this.fiyatList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.fiyatList.HideSelection = false;
            this.fiyatList.Location = new System.Drawing.Point(6, 46);
            this.fiyatList.MultiSelect = false;
            this.fiyatList.Name = "fiyatList";
            this.fiyatList.Size = new System.Drawing.Size(229, 340);
            this.fiyatList.TabIndex = 0;
            this.fiyatList.UseCompatibleStateImageBehavior = false;
            this.fiyatList.View = System.Windows.Forms.View.Details;
            this.fiyatList.SelectedIndexChanged += new System.EventHandler(this.fiyatList_SelectedIndexChanged);
            // 
            // İsim
            // 
            this.İsim.Text = "İsim";
            this.İsim.Width = 75;
            // 
            // Fiyat
            // 
            this.Fiyat.Text = "Fiyat";
            this.Fiyat.Width = 67;
            // 
            // Oran
            // 
            this.Oran.Text = "Oran%";
            this.Oran.Width = 68;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(810, 421);
            this.Controls.Add(this.refreshState);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.cleanFilter);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.refreshList);
            this.Controls.Add(this.btn_analiz);
            this.Controls.Add(this.portfoyEkrani);
            this.Controls.Add(this.performans_ekrani);
            this.Controls.Add(this.alimSatimEkrani);
            this.Controls.Add(this.btn_sat);
            this.Controls.Add(this.btn_al);
            this.Controls.Add(this.realCard);
            this.Controls.Add(this.fakeCard);
            this.Controls.Add(this.fiyatList);
            this.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yatırım Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fakeCard.ResumeLayout(false);
            this.fakeCard.PerformLayout();
            this.realCard.ResumeLayout(false);
            this.realCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.alimSatimEkrani.ResumeLayout(false);
            this.alimSatimEkrani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_miktar)).EndInit();
            this.performans_ekrani.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.portfoyEkrani.ResumeLayout(false);
            this.portfoyEkrani.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard fakeCard;
        private MaterialSkin.Controls.MaterialCard realCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btn_al;
        private MaterialSkin.Controls.MaterialButton btn_sat;
        private MaterialSkin.Controls.MaterialCard alimSatimEkrani;
        private MaterialSkin.Controls.MaterialCard performans_ekrani;
        private MaterialSkin.Controls.MaterialCard portfoyEkrani;
        private MaterialSkin.Controls.MaterialButton btn_analiz;
        private MaterialSkin.Controls.MaterialListView portfoyList;
        private System.Windows.Forms.ColumnHeader isim;
        private System.Windows.Forms.ColumnHeader adet;
        private System.Windows.Forms.ColumnHeader maliyet;
        private System.Windows.Forms.ColumnHeader tarih;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton portfoyRefresh;
        private MaterialSkin.Controls.MaterialButton refreshList;
        private System.Windows.Forms.Label refreshState;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button cleanFilter;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_miktar;
        private System.Windows.Forms.Label sonucLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox alim_fiyat;
        private System.Windows.Forms.TextBox txt_secilenHisse;
        private System.Windows.Forms.ColumnHeader guncel;
        private MaterialSkin.Controls.MaterialButton btn_ayarlar;
        public MaterialSkin.Controls.MaterialLabel realMoney;
        private System.Windows.Forms.ListView fiyatList;
        private System.Windows.Forms.ColumnHeader İsim;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.ColumnHeader Oran;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}


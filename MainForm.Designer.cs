namespace FiloKiralama
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tanimlarRibbonTab = new System.Windows.Forms.RibbonTab();
            this.tanimlarRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.musteriTanimButton = new System.Windows.Forms.RibbonButton();
            this.kullaniciTanimButton = new System.Windows.Forms.RibbonButton();
            this.modelTanimButton = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.sigortaFirmaTanimButton = new System.Windows.Forms.RibbonButton();
            this.bankaTanimButton = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.yedekAracTanimButton = new System.Windows.Forms.RibbonButton();
            this.avukatTanimButton = new System.Windows.Forms.RibbonButton();
            this.genelRibbonTab = new System.Windows.Forms.RibbonTab();
            this.genelRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.aracRibbonButton = new System.Windows.Forms.RibbonButton();
            this.teklifRibbonButton = new System.Windows.Forms.RibbonButton();
            this.lastikRibbonButton = new System.Windows.Forms.RibbonButton();
            this.hukukRibbonButton = new System.Windows.Forms.RibbonButton();
            this.finansRibbonButton = new System.Windows.Forms.RibbonButton();
            this.mainRibbon = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbRecentItem1 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tanimlarRibbonTab
            // 
            this.tanimlarRibbonTab.Name = "tanimlarRibbonTab";
            this.tanimlarRibbonTab.Panels.Add(this.tanimlarRibbonPanel);
            this.tanimlarRibbonTab.Text = "Tanımlar";
            // 
            // tanimlarRibbonPanel
            // 
            this.tanimlarRibbonPanel.ButtonMoreEnabled = false;
            this.tanimlarRibbonPanel.ButtonMoreVisible = false;
            this.tanimlarRibbonPanel.Items.Add(this.musteriTanimButton);
            this.tanimlarRibbonPanel.Items.Add(this.kullaniciTanimButton);
            this.tanimlarRibbonPanel.Items.Add(this.modelTanimButton);
            this.tanimlarRibbonPanel.Items.Add(this.sigortaFirmaTanimButton);
            this.tanimlarRibbonPanel.Items.Add(this.bankaTanimButton);
            this.tanimlarRibbonPanel.Items.Add(this.yedekAracTanimButton);
            this.tanimlarRibbonPanel.Items.Add(this.avukatTanimButton);
            this.tanimlarRibbonPanel.Name = "tanimlarRibbonPanel";
            this.tanimlarRibbonPanel.Text = "";
            // 
            // musteriTanimButton
            // 
            this.musteriTanimButton.Image = global::FiloKiralama.Properties.Resources.customers;
            this.musteriTanimButton.LargeImage = global::FiloKiralama.Properties.Resources.customers;
            this.musteriTanimButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.musteriTanimButton.Name = "musteriTanimButton";
            this.musteriTanimButton.SmallImage = global::FiloKiralama.Properties.Resources.customers;
            this.musteriTanimButton.Text = "Müşteriler";
            this.musteriTanimButton.Click += new System.EventHandler(this.musteriTanimButton_Click);
            // 
            // kullaniciTanimButton
            // 
            this.kullaniciTanimButton.Image = global::FiloKiralama.Properties.Resources.kullanicilar;
            this.kullaniciTanimButton.LargeImage = global::FiloKiralama.Properties.Resources.kullanicilar;
            this.kullaniciTanimButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.kullaniciTanimButton.Name = "kullaniciTanimButton";
            this.kullaniciTanimButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("kullaniciTanimButton.SmallImage")));
            this.kullaniciTanimButton.Text = "Kullanıcılar";
            this.kullaniciTanimButton.Click += new System.EventHandler(this.kullaniciTanimButton_Click);
            // 
            // modelTanimButton
            // 
            this.modelTanimButton.DropDownItems.Add(this.ribbonButton3);
            this.modelTanimButton.Image = global::FiloKiralama.Properties.Resources.carmodels;
            this.modelTanimButton.LargeImage = global::FiloKiralama.Properties.Resources.carmodels;
            this.modelTanimButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.modelTanimButton.Name = "modelTanimButton";
            this.modelTanimButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("modelTanimButton.SmallImage")));
            this.modelTanimButton.Text = "Araç Modelleri";
            this.modelTanimButton.Click += new System.EventHandler(this.modelTanimButton_Click);
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.LargeImage")));
            this.ribbonButton3.Name = "ribbonButton3";
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "ribbonButton3";
            // 
            // sigortaFirmaTanimButton
            // 
            this.sigortaFirmaTanimButton.Image = global::FiloKiralama.Properties.Resources.sigorta;
            this.sigortaFirmaTanimButton.LargeImage = global::FiloKiralama.Properties.Resources.sigorta;
            this.sigortaFirmaTanimButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.sigortaFirmaTanimButton.Name = "sigortaFirmaTanimButton";
            this.sigortaFirmaTanimButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("sigortaFirmaTanimButton.SmallImage")));
            this.sigortaFirmaTanimButton.Text = "Sigorta Firmaları";
            this.sigortaFirmaTanimButton.Click += new System.EventHandler(this.sigortaFirmaTanimButton_Click);
            // 
            // bankaTanimButton
            // 
            this.bankaTanimButton.DropDownItems.Add(this.ribbonButton2);
            this.bankaTanimButton.Image = global::FiloKiralama.Properties.Resources.bank;
            this.bankaTanimButton.LargeImage = global::FiloKiralama.Properties.Resources.bank;
            this.bankaTanimButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.bankaTanimButton.Name = "bankaTanimButton";
            this.bankaTanimButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("bankaTanimButton.SmallImage")));
            this.bankaTanimButton.Text = "Bankalar";
            this.bankaTanimButton.Click += new System.EventHandler(this.bankaTanimButton_Click);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // yedekAracTanimButton
            // 
            this.yedekAracTanimButton.Image = global::FiloKiralama.Properties.Resources.yedekarac;
            this.yedekAracTanimButton.LargeImage = global::FiloKiralama.Properties.Resources.yedekarac;
            this.yedekAracTanimButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.yedekAracTanimButton.Name = "yedekAracTanimButton";
            this.yedekAracTanimButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("yedekAracTanimButton.SmallImage")));
            this.yedekAracTanimButton.Text = "Yedek Araçlar";
            this.yedekAracTanimButton.Click += new System.EventHandler(this.yedekAracTanimButton_Click);
            // 
            // avukatTanimButton
            // 
            this.avukatTanimButton.Image = global::FiloKiralama.Properties.Resources.avukatlar;
            this.avukatTanimButton.LargeImage = global::FiloKiralama.Properties.Resources.avukatlar;
            this.avukatTanimButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.avukatTanimButton.Name = "avukatTanimButton";
            this.avukatTanimButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("avukatTanimButton.SmallImage")));
            this.avukatTanimButton.Text = "Avukatlar";
            this.avukatTanimButton.Click += new System.EventHandler(this.avukatTanimButton_Click);
            // 
            // genelRibbonTab
            // 
            this.genelRibbonTab.Name = "genelRibbonTab";
            this.genelRibbonTab.Panels.Add(this.genelRibbonPanel);
            this.genelRibbonTab.Text = "Genel";
            // 
            // genelRibbonPanel
            // 
            this.genelRibbonPanel.ButtonMoreEnabled = false;
            this.genelRibbonPanel.ButtonMoreVisible = false;
            this.genelRibbonPanel.Items.Add(this.aracRibbonButton);
            this.genelRibbonPanel.Items.Add(this.teklifRibbonButton);
            this.genelRibbonPanel.Items.Add(this.lastikRibbonButton);
            this.genelRibbonPanel.Items.Add(this.hukukRibbonButton);
            this.genelRibbonPanel.Items.Add(this.finansRibbonButton);
            this.genelRibbonPanel.Name = "genelRibbonPanel";
            this.genelRibbonPanel.Text = "";
            // 
            // aracRibbonButton
            // 
            this.aracRibbonButton.Image = global::FiloKiralama.Properties.Resources.car32;
            this.aracRibbonButton.LargeImage = global::FiloKiralama.Properties.Resources.car32;
            this.aracRibbonButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.aracRibbonButton.Name = "aracRibbonButton";
            this.aracRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("aracRibbonButton.SmallImage")));
            this.aracRibbonButton.Text = "Araçlar";
            this.aracRibbonButton.Click += new System.EventHandler(this.aracRibbonButton_Click);
            // 
            // teklifRibbonButton
            // 
            this.teklifRibbonButton.Image = global::FiloKiralama.Properties.Resources.contract32;
            this.teklifRibbonButton.LargeImage = global::FiloKiralama.Properties.Resources.contract32;
            this.teklifRibbonButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.teklifRibbonButton.Name = "teklifRibbonButton";
            this.teklifRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("teklifRibbonButton.SmallImage")));
            this.teklifRibbonButton.Text = "Teklif Sözleşme";
            this.teklifRibbonButton.Click += new System.EventHandler(this.teklifRibbonButton_Click);
            // 
            // lastikRibbonButton
            // 
            this.lastikRibbonButton.Image = global::FiloKiralama.Properties.Resources.tire32;
            this.lastikRibbonButton.LargeImage = global::FiloKiralama.Properties.Resources.tire32;
            this.lastikRibbonButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.lastikRibbonButton.Name = "lastikRibbonButton";
            this.lastikRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("lastikRibbonButton.SmallImage")));
            this.lastikRibbonButton.Text = "Lastik Deposu";
            this.lastikRibbonButton.Click += new System.EventHandler(this.lastikRibbonButton_Click);
            // 
            // hukukRibbonButton
            // 
            this.hukukRibbonButton.Image = global::FiloKiralama.Properties.Resources.court32;
            this.hukukRibbonButton.LargeImage = global::FiloKiralama.Properties.Resources.court32;
            this.hukukRibbonButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.hukukRibbonButton.Name = "hukukRibbonButton";
            this.hukukRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("hukukRibbonButton.SmallImage")));
            this.hukukRibbonButton.Text = "Hukuki Süreçler";
            this.hukukRibbonButton.Click += new System.EventHandler(this.hukukRibbonButton_Click);
            // 
            // finansRibbonButton
            // 
            this.finansRibbonButton.Image = global::FiloKiralama.Properties.Resources.finance32;
            this.finansRibbonButton.LargeImage = global::FiloKiralama.Properties.Resources.finance32;
            this.finansRibbonButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.finansRibbonButton.Name = "finansRibbonButton";
            this.finansRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("finansRibbonButton.SmallImage")));
            this.finansRibbonButton.Text = "Finansal Bilgiler";
            this.finansRibbonButton.Click += new System.EventHandler(this.finansRibbonButton_Click);
            // 
            // mainRibbon
            // 
            this.mainRibbon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.Minimized = false;
            this.mainRibbon.Name = "mainRibbon";
            // 
            // 
            // 
            this.mainRibbon.OrbDropDown.BorderRoundness = 8;
            this.mainRibbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.mainRibbon.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem2);
            this.mainRibbon.OrbDropDown.MenuItems.Add(this.ribbonSeparator1);
            this.mainRibbon.OrbDropDown.Name = "";
            this.mainRibbon.OrbDropDown.RecentItems.Add(this.ribbonOrbRecentItem1);
            this.mainRibbon.OrbDropDown.Size = new System.Drawing.Size(527, 166);
            this.mainRibbon.OrbDropDown.TabIndex = 0;
            this.mainRibbon.OrbDropDown.Text = "ASD";
            this.mainRibbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.mainRibbon.OrbVisible = false;
            // 
            // 
            // 
            this.mainRibbon.QuickAccessToolbar.DropDownButtonVisible = false;
            this.mainRibbon.QuickAccessToolbar.Enabled = false;
            this.mainRibbon.QuickAccessToolbar.Visible = false;
            this.mainRibbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.mainRibbon.Size = new System.Drawing.Size(1362, 128);
            this.mainRibbon.TabIndex = 0;
            this.mainRibbon.Tabs.Add(this.genelRibbonTab);
            this.mainRibbon.Tabs.Add(this.tanimlarRibbonTab);
            this.mainRibbon.TabsMargin = new System.Windows.Forms.Padding(6, 26, 20, 0);
            this.mainRibbon.TabSpacing = 3;
            this.mainRibbon.Text = "ribbon1";
            this.mainRibbon.Click += new System.EventHandler(this.mainRibbon_Click);
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.LargeImage")));
            this.ribbonOrbMenuItem1.Name = "ribbonOrbMenuItem1";
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "ribbonOrbMenuItem1";
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.LargeImage")));
            this.ribbonOrbMenuItem2.Name = "ribbonOrbMenuItem2";
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Text = "ribbonOrbMenuItem2";
            // 
            // ribbonOrbRecentItem1
            // 
            this.ribbonOrbRecentItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.Image")));
            this.ribbonOrbRecentItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.LargeImage")));
            this.ribbonOrbRecentItem1.Name = "ribbonOrbRecentItem1";
            this.ribbonOrbRecentItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.SmallImage")));
            this.ribbonOrbRecentItem1.Text = "ribbonOrbRecentItem1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1362, 327);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(495, 308);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Description";
            this.Column6.FillWeight = 250F;
            this.Column6.HeaderText = "Hatırlatma";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 250;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Day";
            this.Column7.HeaderText = "Kalan Gün";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(986, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 308);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(298, 120);
            this.label8.MinimumSize = new System.Drawing.Size(30, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "11";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(298, 82);
            this.label7.MinimumSize = new System.Drawing.Size(30, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "86";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(298, 49);
            this.label6.MinimumSize = new System.Drawing.Size(30, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(292, 16);
            this.label5.MinimumSize = new System.Drawing.Size(30, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(29, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Boştaki Araç Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(29, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müşterideki Araç Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yedek Araç Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Araç Sayısı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(591, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(268, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Kur";
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Döviz";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 25F;
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 25;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Alis";
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Alış";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Satis";
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Satış";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Göral Filo Kiralama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RibbonTab tanimlarRibbonTab;
        private System.Windows.Forms.RibbonPanel tanimlarRibbonPanel;
        private System.Windows.Forms.RibbonButton musteriTanimButton;
        private System.Windows.Forms.RibbonButton kullaniciTanimButton;
        private System.Windows.Forms.RibbonButton modelTanimButton;
        private System.Windows.Forms.RibbonButton sigortaFirmaTanimButton;
        private System.Windows.Forms.RibbonButton bankaTanimButton;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton yedekAracTanimButton;
        private System.Windows.Forms.RibbonButton avukatTanimButton;
        private System.Windows.Forms.RibbonTab genelRibbonTab;
        private System.Windows.Forms.RibbonPanel genelRibbonPanel;
        private System.Windows.Forms.RibbonButton aracRibbonButton;
        private System.Windows.Forms.RibbonButton teklifRibbonButton;
        private System.Windows.Forms.RibbonButton lastikRibbonButton;
        private System.Windows.Forms.RibbonButton hukukRibbonButton;
        private System.Windows.Forms.RibbonButton finansRibbonButton;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonOrbRecentItem ribbonOrbRecentItem1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem2;
        private System.Windows.Forms.Ribbon mainRibbon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
    }
}


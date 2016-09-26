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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
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
            this.musteriTanimButton.Image = ((System.Drawing.Image)(resources.GetObject("musteriTanimButton.Image")));
            this.musteriTanimButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("musteriTanimButton.LargeImage")));
            this.musteriTanimButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.musteriTanimButton.Name = "musteriTanimButton";
            this.musteriTanimButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("musteriTanimButton.SmallImage")));
            this.musteriTanimButton.Text = "Müşteriler";
            this.musteriTanimButton.Click += new System.EventHandler(this.musteriTanimButton_Click);
            // 
            // kullaniciTanimButton
            // 
            this.kullaniciTanimButton.Image = ((System.Drawing.Image)(resources.GetObject("kullaniciTanimButton.Image")));
            this.kullaniciTanimButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("kullaniciTanimButton.LargeImage")));
            this.kullaniciTanimButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.kullaniciTanimButton.Name = "kullaniciTanimButton";
            this.kullaniciTanimButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("kullaniciTanimButton.SmallImage")));
            this.kullaniciTanimButton.Text = "Kullanıcılar";
            this.kullaniciTanimButton.Click += new System.EventHandler(this.kullaniciTanimButton_Click);
            // 
            // modelTanimButton
            // 
            this.modelTanimButton.DropDownItems.Add(this.ribbonButton3);
            this.modelTanimButton.Image = ((System.Drawing.Image)(resources.GetObject("modelTanimButton.Image")));
            this.modelTanimButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("modelTanimButton.LargeImage")));
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
            this.sigortaFirmaTanimButton.Image = ((System.Drawing.Image)(resources.GetObject("sigortaFirmaTanimButton.Image")));
            this.sigortaFirmaTanimButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("sigortaFirmaTanimButton.LargeImage")));
            this.sigortaFirmaTanimButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.sigortaFirmaTanimButton.Name = "sigortaFirmaTanimButton";
            this.sigortaFirmaTanimButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("sigortaFirmaTanimButton.SmallImage")));
            this.sigortaFirmaTanimButton.Text = "Sigorta Firmaları";
            this.sigortaFirmaTanimButton.Click += new System.EventHandler(this.sigortaFirmaTanimButton_Click);
            // 
            // bankaTanimButton
            // 
            this.bankaTanimButton.DropDownItems.Add(this.ribbonButton2);
            this.bankaTanimButton.Image = ((System.Drawing.Image)(resources.GetObject("bankaTanimButton.Image")));
            this.bankaTanimButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("bankaTanimButton.LargeImage")));
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
            this.yedekAracTanimButton.Image = ((System.Drawing.Image)(resources.GetObject("yedekAracTanimButton.Image")));
            this.yedekAracTanimButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("yedekAracTanimButton.LargeImage")));
            this.yedekAracTanimButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.yedekAracTanimButton.Name = "yedekAracTanimButton";
            this.yedekAracTanimButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("yedekAracTanimButton.SmallImage")));
            this.yedekAracTanimButton.Text = "Yedek Araçlar";
            this.yedekAracTanimButton.Click += new System.EventHandler(this.yedekAracTanimButton_Click);
            // 
            // avukatTanimButton
            // 
            this.avukatTanimButton.Image = ((System.Drawing.Image)(resources.GetObject("avukatTanimButton.Image")));
            this.avukatTanimButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("avukatTanimButton.LargeImage")));
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
            this.mainRibbon.OrbDropDown.Name = "";
            this.mainRibbon.OrbDropDown.RecentItems.Add(this.ribbonOrbRecentItem1);
            this.mainRibbon.OrbDropDown.Size = new System.Drawing.Size(527, 160);
            this.mainRibbon.OrbDropDown.TabIndex = 0;
            this.mainRibbon.OrbDropDown.Text = "ASD";
            this.mainRibbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            // 
            // 
            // 
            this.mainRibbon.QuickAccessToolbar.DropDownButtonVisible = false;
            this.mainRibbon.QuickAccessToolbar.Enabled = false;
            this.mainRibbon.QuickAccessToolbar.Visible = false;
            this.mainRibbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.mainRibbon.Size = new System.Drawing.Size(886, 128);
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
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 327);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(270, 150);
            this.dataGridView1.TabIndex = 2;
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
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Alış";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Satış";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainRibbon);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Göral Filo Kiralama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
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
    }
}


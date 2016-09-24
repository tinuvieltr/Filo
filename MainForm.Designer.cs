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
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbRecentItem1 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.mainRibbon = new System.Windows.Forms.Ribbon();
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
            this.aracRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("aracRibbonButton.Image")));
            this.aracRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("aracRibbonButton.LargeImage")));
            this.aracRibbonButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.aracRibbonButton.Name = "aracRibbonButton";
            this.aracRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("aracRibbonButton.SmallImage")));
            this.aracRibbonButton.Text = "Araçlar";
            this.aracRibbonButton.Click += new System.EventHandler(this.aracRibbonButton_Click);
            // 
            // teklifRibbonButton
            // 
            this.teklifRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("teklifRibbonButton.Image")));
            this.teklifRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("teklifRibbonButton.LargeImage")));
            this.teklifRibbonButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.teklifRibbonButton.Name = "teklifRibbonButton";
            this.teklifRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("teklifRibbonButton.SmallImage")));
            this.teklifRibbonButton.Text = "Teklif Sözleşme";
            this.teklifRibbonButton.Click += new System.EventHandler(this.teklifRibbonButton_Click);
            // 
            // lastikRibbonButton
            // 
            this.lastikRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("lastikRibbonButton.Image")));
            this.lastikRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("lastikRibbonButton.LargeImage")));
            this.lastikRibbonButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.lastikRibbonButton.Name = "lastikRibbonButton";
            this.lastikRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("lastikRibbonButton.SmallImage")));
            this.lastikRibbonButton.Text = "Lastik Deposu";
            this.lastikRibbonButton.Click += new System.EventHandler(this.lastikRibbonButton_Click);
            // 
            // hukukRibbonButton
            // 
            this.hukukRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("hukukRibbonButton.Image")));
            this.hukukRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("hukukRibbonButton.LargeImage")));
            this.hukukRibbonButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.hukukRibbonButton.Name = "hukukRibbonButton";
            this.hukukRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("hukukRibbonButton.SmallImage")));
            this.hukukRibbonButton.Text = "Hukuki Süreçler";
            this.hukukRibbonButton.Click += new System.EventHandler(this.hukukRibbonButton_Click);
            // 
            // finansRibbonButton
            // 
            this.finansRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("finansRibbonButton.Image")));
            this.finansRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("finansRibbonButton.LargeImage")));
            this.finansRibbonButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.finansRibbonButton.Name = "finansRibbonButton";
            this.finansRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("finansRibbonButton.SmallImage")));
            this.finansRibbonButton.Text = "Finansal Bilgiler";
            this.finansRibbonButton.Click += new System.EventHandler(this.finansRibbonButton_Click);
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
            // ribbonOrbRecentItem1
            // 
            this.ribbonOrbRecentItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.Image")));
            this.ribbonOrbRecentItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.LargeImage")));
            this.ribbonOrbRecentItem1.Name = "ribbonOrbRecentItem1";
            this.ribbonOrbRecentItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.SmallImage")));
            this.ribbonOrbRecentItem1.Text = "ribbonOrbRecentItem1";
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
            // mainRibbon
            // 
            this.mainRibbon.Font = new System.Drawing.Font("Segoe UI", 11.25F);
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
            this.mainRibbon.Size = new System.Drawing.Size(886, 153);
            this.mainRibbon.TabIndex = 0;
            this.mainRibbon.Tabs.Add(this.genelRibbonTab);
            this.mainRibbon.Tabs.Add(this.tanimlarRibbonTab);
            this.mainRibbon.TabsMargin = new System.Windows.Forms.Padding(6, 26, 20, 0);
            this.mainRibbon.TabSpacing = 3;
            this.mainRibbon.Text = "ribbon1";
            this.mainRibbon.Click += new System.EventHandler(this.mainRibbon_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 455);
            this.Controls.Add(this.mainRibbon);
            this.KeyPreview = true;
            this.Name = "mainForm";
            this.Text = "Göral Filo Kiralama";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}


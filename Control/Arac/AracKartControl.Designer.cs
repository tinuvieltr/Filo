namespace FiloKiralama.Control
{
    partial class AracKartControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.aracBilgiTab = new System.Windows.Forms.TabPage();
            this.aracEditControl1 = new FiloKiralama.Control.AracEditControl();
            this.bakimTabPage = new System.Windows.Forms.TabPage();
            this.lastikTab = new System.Windows.Forms.TabPage();
            this.hasarTab = new System.Windows.Forms.TabPage();
            this.odemeTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.aracBilgiTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.aracBilgiTab);
            this.tabControl1.Controls.Add(this.bakimTabPage);
            this.tabControl1.Controls.Add(this.lastikTab);
            this.tabControl1.Controls.Add(this.hasarTab);
            this.tabControl1.Controls.Add(this.odemeTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // aracBilgiTab
            // 
            this.aracBilgiTab.Controls.Add(this.aracEditControl1);
            this.aracBilgiTab.Location = new System.Drawing.Point(4, 22);
            this.aracBilgiTab.Name = "aracBilgiTab";
            this.aracBilgiTab.Padding = new System.Windows.Forms.Padding(3);
            this.aracBilgiTab.Size = new System.Drawing.Size(560, 442);
            this.aracBilgiTab.TabIndex = 0;
            this.aracBilgiTab.Text = "Araç Bilgileri";
            this.aracBilgiTab.UseVisualStyleBackColor = true;
            // 
            // aracEditControl1
            // 
            this.aracEditControl1.AracId = 0;
            this.aracEditControl1.Location = new System.Drawing.Point(6, 6);
            this.aracEditControl1.Name = "aracEditControl1";
            this.aracEditControl1.Size = new System.Drawing.Size(272, 430);
            this.aracEditControl1.TabIndex = 0;
            // 
            // bakimTabPage
            // 
            this.bakimTabPage.Location = new System.Drawing.Point(4, 22);
            this.bakimTabPage.Name = "bakimTabPage";
            this.bakimTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bakimTabPage.Size = new System.Drawing.Size(560, 442);
            this.bakimTabPage.TabIndex = 1;
            this.bakimTabPage.Text = "Bakımlar";
            this.bakimTabPage.UseVisualStyleBackColor = true;
            // 
            // lastikTab
            // 
            this.lastikTab.Location = new System.Drawing.Point(4, 22);
            this.lastikTab.Name = "lastikTab";
            this.lastikTab.Size = new System.Drawing.Size(560, 442);
            this.lastikTab.TabIndex = 2;
            this.lastikTab.Text = "Lastik";
            this.lastikTab.UseVisualStyleBackColor = true;
            // 
            // hasarTab
            // 
            this.hasarTab.Location = new System.Drawing.Point(4, 22);
            this.hasarTab.Name = "hasarTab";
            this.hasarTab.Size = new System.Drawing.Size(560, 442);
            this.hasarTab.TabIndex = 3;
            this.hasarTab.Text = "Hasar";
            this.hasarTab.UseVisualStyleBackColor = true;
            // 
            // odemeTab
            // 
            this.odemeTab.Location = new System.Drawing.Point(4, 22);
            this.odemeTab.Name = "odemeTab";
            this.odemeTab.Size = new System.Drawing.Size(560, 442);
            this.odemeTab.TabIndex = 4;
            this.odemeTab.Text = "Ödemeler";
            this.odemeTab.UseVisualStyleBackColor = true;
            // 
            // AracKartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "AracKartControl";
            this.Size = new System.Drawing.Size(568, 468);
            this.tabControl1.ResumeLayout(false);
            this.aracBilgiTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage aracBilgiTab;
        private System.Windows.Forms.TabPage bakimTabPage;
        private System.Windows.Forms.TabPage lastikTab;
        private System.Windows.Forms.TabPage hasarTab;
        private System.Windows.Forms.TabPage odemeTab;
        private AracEditControl aracEditControl1;
    }
}

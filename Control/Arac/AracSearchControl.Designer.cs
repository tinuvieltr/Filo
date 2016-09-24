namespace FiloKiralama.Control
{
    partial class AracSearchControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.musteriCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saseTextbox = new System.Windows.Forms.TextBox();
            this.plakaTextbox = new System.Windows.Forms.TextBox();
            this.aracListControl1 = new FiloKiralama.Control.AracListControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.musteriCombo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.saseTextbox);
            this.groupBox1.Controls.Add(this.plakaTextbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Kriterleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Müşteri";
            // 
            // musteriCombo
            // 
            this.musteriCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.musteriCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.musteriCombo.FormattingEnabled = true;
            this.musteriCombo.Location = new System.Drawing.Point(143, 18);
            this.musteriCombo.Name = "musteriCombo";
            this.musteriCombo.Size = new System.Drawing.Size(204, 21);
            this.musteriCombo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şase No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaka";
            // 
            // saseTextbox
            // 
            this.saseTextbox.Location = new System.Drawing.Point(143, 71);
            this.saseTextbox.Name = "saseTextbox";
            this.saseTextbox.Size = new System.Drawing.Size(204, 20);
            this.saseTextbox.TabIndex = 1;
            // 
            // plakaTextbox
            // 
            this.plakaTextbox.Location = new System.Drawing.Point(143, 45);
            this.plakaTextbox.Name = "plakaTextbox";
            this.plakaTextbox.Size = new System.Drawing.Size(204, 20);
            this.plakaTextbox.TabIndex = 0;
            // 
            // aracListControl1
            // 
            this.aracListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aracListControl1.Location = new System.Drawing.Point(0, 108);
            this.aracListControl1.Name = "aracListControl1";
            this.aracListControl1.Size = new System.Drawing.Size(556, 213);
            this.aracListControl1.TabIndex = 1;
            // 
            // AracSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aracListControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AracSearchControl";
            this.Size = new System.Drawing.Size(556, 321);
            this.Load += new System.EventHandler(this.AracSearchControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox plakaTextbox;
        private System.Windows.Forms.TextBox saseTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox musteriCombo;
        private AracListControl aracListControl1;
    }
}

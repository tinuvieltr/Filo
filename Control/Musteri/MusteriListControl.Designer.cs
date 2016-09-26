namespace FiloKiralama.Control.Musteri
{
    partial class MusteriListControl
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
            this.musteriListControl1 = new System.Windows.Forms.DataGridView();
            this.FirmaAdiTextbox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.musteriListControl1)).BeginInit();
            this.FirmaAdiTextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriListControl1
            // 
            this.musteriListControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.musteriListControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musteriListControl1.Location = new System.Drawing.Point(0, 106);
            this.musteriListControl1.Name = "musteriListControl1";
            this.musteriListControl1.Size = new System.Drawing.Size(949, 399);
            this.musteriListControl1.TabIndex = 5;
            this.musteriListControl1.Visible = false;
            // 
            // FirmaAdiTextbox
            // 
            this.FirmaAdiTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.FirmaAdiTextbox.Controls.Add(this.button2);
            this.FirmaAdiTextbox.Controls.Add(this.textBox2);
            this.FirmaAdiTextbox.Controls.Add(this.label1);
            this.FirmaAdiTextbox.Controls.Add(this.textBox1);
            this.FirmaAdiTextbox.Controls.Add(this.label3);
            this.FirmaAdiTextbox.Controls.Add(this.button1);
            this.FirmaAdiTextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirmaAdiTextbox.Location = new System.Drawing.Point(0, 0);
            this.FirmaAdiTextbox.Name = "FirmaAdiTextbox";
            this.FirmaAdiTextbox.Size = new System.Drawing.Size(949, 106);
            this.FirmaAdiTextbox.TabIndex = 4;
            this.FirmaAdiTextbox.TabStop = false;
            this.FirmaAdiTextbox.Text = "Arama Kriterleri";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Müşteri";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FiloKiralama.Properties.Resources.find;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(380, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 73);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Yetkili Kişi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::FiloKiralama.Properties.Resources.add;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(470, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 73);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MusteriListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.musteriListControl1);
            this.Controls.Add(this.FirmaAdiTextbox);
            this.Name = "MusteriListControl";
            this.Size = new System.Drawing.Size(949, 505);
            ((System.ComponentModel.ISupportInitialize)(this.musteriListControl1)).EndInit();
            this.FirmaAdiTextbox.ResumeLayout(false);
            this.FirmaAdiTextbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView musteriListControl1;
        private System.Windows.Forms.GroupBox FirmaAdiTextbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

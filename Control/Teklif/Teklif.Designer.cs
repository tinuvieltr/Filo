namespace FiloKiralama.Control.Teklif
{
    partial class Teklif
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
            this.FirmaAdiTextbox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teklifListControl1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.FirmaAdiTextbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teklifListControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirmaAdiTextbox
            // 
            this.FirmaAdiTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.FirmaAdiTextbox.Controls.Add(this.textBox1);
            this.FirmaAdiTextbox.Controls.Add(this.dateTimePicker2);
            this.FirmaAdiTextbox.Controls.Add(this.dateTimePicker1);
            this.FirmaAdiTextbox.Controls.Add(this.label3);
            this.FirmaAdiTextbox.Controls.Add(this.button1);
            this.FirmaAdiTextbox.Controls.Add(this.label1);
            this.FirmaAdiTextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirmaAdiTextbox.Location = new System.Drawing.Point(0, 0);
            this.FirmaAdiTextbox.Name = "FirmaAdiTextbox";
            this.FirmaAdiTextbox.Size = new System.Drawing.Size(869, 106);
            this.FirmaAdiTextbox.TabIndex = 2;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(374, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Firma Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teklif Tarihi";
            // 
            // teklifListControl1
            // 
            this.teklifListControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.teklifListControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teklifListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teklifListControl1.Location = new System.Drawing.Point(0, 106);
            this.teklifListControl1.Name = "teklifListControl1";
            this.teklifListControl1.Size = new System.Drawing.Size(869, 246);
            this.teklifListControl1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FiloKiralama.Properties.Resources.find;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(642, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 73);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Teklif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.teklifListControl1);
            this.Controls.Add(this.FirmaAdiTextbox);
            this.Name = "Teklif";
            this.Size = new System.Drawing.Size(869, 352);
            this.FirmaAdiTextbox.ResumeLayout(false);
            this.FirmaAdiTextbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teklifListControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FirmaAdiTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DataGridView teklifListControl1;
    }
}

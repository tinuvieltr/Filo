namespace FiloKiralama.Dialog.Musteri
{
    partial class MusteriEditDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEditDialog));
            this.musteriEditControl1 = new FiloKiralama.Control.Musteri.MusteriEditControl();
            this.SuspendLayout();
            // 
            // musteriEditControl1
            // 
            this.musteriEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musteriEditControl1.Location = new System.Drawing.Point(0, 0);
            this.musteriEditControl1.Musteri = null;
            this.musteriEditControl1.Name = "musteriEditControl1";
            this.musteriEditControl1.Size = new System.Drawing.Size(345, 396);
            this.musteriEditControl1.TabIndex = 0;
            // 
            // MusteriEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 396);
            this.Controls.Add(this.musteriEditControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusteriEditDialog";
            this.Text = "Müşteri Ekle / Düzenle";
            this.ResumeLayout(false);

        }

        #endregion

        private Control.Musteri.MusteriEditControl musteriEditControl1;
    }
}
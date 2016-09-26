namespace FiloKiralama.Dialog.Teklif
{
    partial class TeklifLSearchDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeklifLSearchDialog));
            this.teklif1 = new FiloKiralama.Control.Teklif.Teklif();
            this.SuspendLayout();
            // 
            // teklif1
            // 
            this.teklif1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.teklif1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teklif1.Location = new System.Drawing.Point(0, 0);
            this.teklif1.Name = "teklif1";
            this.teklif1.Size = new System.Drawing.Size(907, 382);
            this.teklif1.TabIndex = 0;
            // 
            // TeklifLSearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 382);
            this.Controls.Add(this.teklif1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeklifLSearchDialog";
            this.Text = "Teklif Sorgula";
            this.ResumeLayout(false);

        }

        #endregion

        private Control.Teklif.Teklif teklif1;

    }
}
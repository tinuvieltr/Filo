namespace FiloKiralama.Dialog.Musteri
{
    partial class MusteriSearchDialog
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
            this.musteriListControl1 = new FiloKiralama.Control.Musteri.MusteriListControl();
            this.SuspendLayout();
            // 
            // musteriListControl1
            // 
            this.musteriListControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.musteriListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musteriListControl1.Location = new System.Drawing.Point(0, 0);
            this.musteriListControl1.Name = "musteriListControl1";
            this.musteriListControl1.Size = new System.Drawing.Size(808, 401);
            this.musteriListControl1.TabIndex = 0;
            // 
            // MusteriSearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 401);
            this.Controls.Add(this.musteriListControl1);
            this.Name = "MusteriSearchDialog";
            this.Text = "Müşteriler";
            this.ResumeLayout(false);

        }

        #endregion

        private Control.Musteri.MusteriListControl musteriListControl1;
    }
}
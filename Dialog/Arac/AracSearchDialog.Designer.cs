﻿namespace FiloKiralama.Dialog.Arac
{
    partial class AracSearchDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracSearchDialog));
            this.aracSearchControl1 = new FiloKiralama.Control.AracSearchControl();
            this.SuspendLayout();
            // 
            // aracSearchControl1
            // 
            this.aracSearchControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aracSearchControl1.Location = new System.Drawing.Point(0, 0);
            this.aracSearchControl1.Name = "aracSearchControl1";
            this.aracSearchControl1.Size = new System.Drawing.Size(876, 321);
            this.aracSearchControl1.TabIndex = 0;
            this.aracSearchControl1.Load += new System.EventHandler(this.aracSearchControl1_Load);
            // 
            // AracSearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 321);
            this.Controls.Add(this.aracSearchControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AracSearchDialog";
            this.Text = "Araç Sorgula";
            this.Load += new System.EventHandler(this.AracSearchDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.AracSearchControl aracSearchControl1;
    }
}
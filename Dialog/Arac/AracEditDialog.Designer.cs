namespace FiloKiralama.Dialog.Arac
{
    partial class AracEditDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracEditDialog));
            this.aracEditControl = new FiloKiralama.Control.AracEditControl();
            this.SuspendLayout();
            // 
            // aracEditControl
            // 
            this.aracEditControl.Arac = null;
            this.aracEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aracEditControl.Location = new System.Drawing.Point(0, 0);
            this.aracEditControl.Name = "aracEditControl";
            this.aracEditControl.Size = new System.Drawing.Size(369, 440);
            this.aracEditControl.TabIndex = 0;
            // 
            // AracEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 440);
            this.Controls.Add(this.aracEditControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AracEditDialog";
            this.Load += new System.EventHandler(this.AracEditDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.AracEditControl aracEditControl;
    }
}
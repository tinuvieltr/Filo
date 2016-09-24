namespace FiloKiralama.Control
{
    partial class AracListControl
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
            this.aracGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.aracGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // aracGrid
            // 
            this.aracGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aracGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aracGrid.Location = new System.Drawing.Point(0, 0);
            this.aracGrid.Name = "aracGrid";
            this.aracGrid.Size = new System.Drawing.Size(507, 263);
            this.aracGrid.TabIndex = 0;
            this.aracGrid.Visible = false;
            // 
            // AracListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aracGrid);
            this.Name = "AracListControl";
            this.Size = new System.Drawing.Size(507, 263);
            ((System.ComponentModel.ISupportInitialize)(this.aracGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView aracGrid;

    }
}

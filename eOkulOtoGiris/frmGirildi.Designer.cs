namespace eOkulOtoGiris
{
    partial class frmGirildi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGirildi));
            this.webEOkul = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webEOkul
            // 
            this.webEOkul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webEOkul.Location = new System.Drawing.Point(0, 0);
            this.webEOkul.MinimumSize = new System.Drawing.Size(20, 20);
            this.webEOkul.Name = "webEOkul";
            this.webEOkul.Size = new System.Drawing.Size(972, 473);
            this.webEOkul.TabIndex = 0;
            this.webEOkul.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webEOkul_DocumentCompleted);
            // 
            // frmGirildi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 473);
            this.Controls.Add(this.webEOkul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGirildi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Okul Giriş Yapıldı!";
            this.Load += new System.EventHandler(this.frmGirildi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webEOkul;
    }
}
namespace eOkulOtoGiris
{
    partial class frmAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAna));
            this.menuAna = new System.Windows.Forms.MenuStrip();
            this.yeniÖğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÖğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGiris = new System.Windows.Forms.Button();
            this.cbOgrenciler = new System.Windows.Forms.ComboBox();
            this.txtGuvenlikKodu = new System.Windows.Forms.TextBox();
            this.btnKodGirildi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbGuvenlikKodu = new System.Windows.Forms.PictureBox();
            this.menuAna.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuvenlikKodu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAna
            // 
            this.menuAna.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAna.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÖğrenciToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuAna.Location = new System.Drawing.Point(0, 0);
            this.menuAna.Name = "menuAna";
            this.menuAna.Size = new System.Drawing.Size(779, 28);
            this.menuAna.TabIndex = 0;
            this.menuAna.Text = "menuStrip1";
            // 
            // yeniÖğrenciToolStripMenuItem
            // 
            this.yeniÖğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÖğrenciEkleToolStripMenuItem,
            this.öğrencilerToolStripMenuItem});
            this.yeniÖğrenciToolStripMenuItem.Name = "yeniÖğrenciToolStripMenuItem";
            this.yeniÖğrenciToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.yeniÖğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // yeniÖğrenciEkleToolStripMenuItem
            // 
            this.yeniÖğrenciEkleToolStripMenuItem.Name = "yeniÖğrenciEkleToolStripMenuItem";
            this.yeniÖğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.yeniÖğrenciEkleToolStripMenuItem.Text = "Yeni Öğrenci Ekle";
            this.yeniÖğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniÖğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.öğrencilerToolStripMenuItem.Text = "Kayıtlı Öğrenciler";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.hakkındaToolStripMenuItem.Text = "Program Hakkında";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.IndianRed;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiris.Location = new System.Drawing.Point(481, 55);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(127, 37);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // cbOgrenciler
            // 
            this.cbOgrenciler.BackColor = System.Drawing.SystemColors.Info;
            this.cbOgrenciler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOgrenciler.FormattingEnabled = true;
            this.cbOgrenciler.Location = new System.Drawing.Point(238, 62);
            this.cbOgrenciler.Name = "cbOgrenciler";
            this.cbOgrenciler.Size = new System.Drawing.Size(237, 24);
            this.cbOgrenciler.TabIndex = 2;
            // 
            // txtGuvenlikKodu
            // 
            this.txtGuvenlikKodu.BackColor = System.Drawing.Color.IndianRed;
            this.txtGuvenlikKodu.ForeColor = System.Drawing.SystemColors.Info;
            this.txtGuvenlikKodu.Location = new System.Drawing.Point(218, 31);
            this.txtGuvenlikKodu.Name = "txtGuvenlikKodu";
            this.txtGuvenlikKodu.Size = new System.Drawing.Size(221, 22);
            this.txtGuvenlikKodu.TabIndex = 4;
            // 
            // btnKodGirildi
            // 
            this.btnKodGirildi.Location = new System.Drawing.Point(229, 59);
            this.btnKodGirildi.Name = "btnKodGirildi";
            this.btnKodGirildi.Size = new System.Drawing.Size(196, 33);
            this.btnKodGirildi.TabIndex = 5;
            this.btnKodGirildi.Text = "Kod Gir";
            this.btnKodGirildi.UseVisualStyleBackColor = true;
            this.btnKodGirildi.Click += new System.EventHandler(this.btnKodGirildi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Öğrenci Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yandaki Kodu Giriniz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbGuvenlikKodu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGuvenlikKodu);
            this.groupBox1.Controls.Add(this.btnKodGirildi);
            this.groupBox1.Location = new System.Drawing.Point(55, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            this.groupBox1.Visible = false;
            // 
            // pbGuvenlikKodu
            // 
            this.pbGuvenlikKodu.Location = new System.Drawing.Point(467, 22);
            this.pbGuvenlikKodu.Name = "pbGuvenlikKodu";
            this.pbGuvenlikKodu.Size = new System.Drawing.Size(131, 70);
            this.pbGuvenlikKodu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuvenlikKodu.TabIndex = 8;
            this.pbGuvenlikKodu.TabStop = false;
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(779, 224);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOgrenciler);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.menuAna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuAna;
            this.MaximizeBox = false;
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eOkul Otomatik Giriş Programı";
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.menuAna.ResumeLayout(false);
            this.menuAna.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuvenlikKodu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAna;
        private System.Windows.Forms.ToolStripMenuItem yeniÖğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÖğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.ComboBox cbOgrenciler;
        private System.Windows.Forms.TextBox txtGuvenlikKodu;
        private System.Windows.Forms.Button btnKodGirildi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbGuvenlikKodu;
    }
}


namespace eOkulOtoGiris
{
    partial class frmOgrenciEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOkulNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDogumGunu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNufusIlce = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNufusIl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCiltNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAileSiraNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDogumYili = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSinifHarf = new System.Windows.Forms.TextBox();
            this.txtSinifNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtDogumAyi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOkulNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerekli Bilgiler";
            this.toolTip.SetToolTip(this.groupBox1, "Olmazsa olmaz bilgiler");
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(287, 60);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(170, 22);
            this.txtAdSoyad.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtAdSoyad, "Anasayfada listede gözükecek olan isim");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad Soyad:";
            this.toolTip.SetToolTip(this.label3, "Anasayfada listede gözükecek olan isim");
            // 
            // txtOkulNo
            // 
            this.txtOkulNo.Location = new System.Drawing.Point(453, 22);
            this.txtOkulNo.Name = "txtOkulNo";
            this.txtOkulNo.Size = new System.Drawing.Size(170, 22);
            this.txtOkulNo.TabIndex = 3;
            this.toolTip.SetToolTip(this.txtOkulNo, "E-Okul\'a girerken istenen okul numarası");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Okul Numarası:";
            this.toolTip.SetToolTip(this.label2, "E-Okul\'a girerken istenen okul numarası");
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(116, 22);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(170, 22);
            this.txtTc.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtTc, "Öğrencinin TC Kimlik Numarası");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            this.toolTip.SetToolTip(this.label1, "Öğrencinin TC Kimlik Numarası");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDogumAyi);
            this.groupBox2.Controls.Add(this.txtDogumGunu);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtNufusIlce);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNufusIl);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCiltNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtAileSiraNo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDogumYili);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSinifHarf);
            this.groupBox2.Controls.Add(this.txtSinifNo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgiler - En Az İki Tane -";
            this.toolTip.SetToolTip(this.groupBox2, "Aşağıdaki bilgilerden en az iki tanesini doldurmanız gerekmektedir.");
            // 
            // txtDogumGunu
            // 
            this.txtDogumGunu.Location = new System.Drawing.Point(101, 80);
            this.txtDogumGunu.Name = "txtDogumGunu";
            this.txtDogumGunu.Size = new System.Drawing.Size(32, 22);
            this.txtDogumGunu.TabIndex = 21;
            this.toolTip.SetToolTip(this.txtDogumGunu, "Doğduğu Gün");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Doğum Günü:";
            // 
            // txtNufusIlce
            // 
            this.txtNufusIlce.Location = new System.Drawing.Point(486, 125);
            this.txtNufusIlce.Name = "txtNufusIlce";
            this.txtNufusIlce.Size = new System.Drawing.Size(136, 22);
            this.txtNufusIlce.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nüfustaki İlçe:";
            // 
            // txtNufusIl
            // 
            this.txtNufusIl.Location = new System.Drawing.Point(486, 78);
            this.txtNufusIl.Name = "txtNufusIl";
            this.txtNufusIl.Size = new System.Drawing.Size(136, 22);
            this.txtNufusIl.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nüfustaki İl:";
            // 
            // txtCiltNo
            // 
            this.txtCiltNo.Location = new System.Drawing.Point(486, 35);
            this.txtCiltNo.Name = "txtCiltNo";
            this.txtCiltNo.Size = new System.Drawing.Size(58, 22);
            this.txtCiltNo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cilt No:";
            // 
            // txtAileSiraNo
            // 
            this.txtAileSiraNo.Location = new System.Drawing.Point(101, 128);
            this.txtAileSiraNo.Name = "txtAileSiraNo";
            this.txtAileSiraNo.Size = new System.Drawing.Size(58, 22);
            this.txtAileSiraNo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Aile Sıra No:";
            // 
            // txtDogumYili
            // 
            this.txtDogumYili.Location = new System.Drawing.Point(202, 80);
            this.txtDogumYili.Name = "txtDogumYili";
            this.txtDogumYili.Size = new System.Drawing.Size(58, 22);
            this.txtDogumYili.TabIndex = 11;
            this.toolTip.SetToolTip(this.txtDogumYili, "Doğduğu Yıl");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "/";
            // 
            // txtSinifHarf
            // 
            this.txtSinifHarf.Location = new System.Drawing.Point(109, 38);
            this.txtSinifHarf.Name = "txtSinifHarf";
            this.txtSinifHarf.Size = new System.Drawing.Size(35, 22);
            this.txtSinifHarf.TabIndex = 8;
            // 
            // txtSinifNo
            // 
            this.txtSinifNo.Location = new System.Drawing.Point(61, 38);
            this.txtSinifNo.Name = "txtSinifNo";
            this.txtSinifNo.Size = new System.Drawing.Size(34, 22);
            this.txtSinifNo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sınıf:";
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(213, 332);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(239, 48);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Öğrenciyi Ekle";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtDogumAyi
            // 
            this.txtDogumAyi.Location = new System.Drawing.Point(151, 80);
            this.txtDogumAyi.Name = "txtDogumAyi";
            this.txtDogumAyi.Size = new System.Drawing.Size(35, 22);
            this.txtDogumAyi.TabIndex = 22;
            this.toolTip.SetToolTip(this.txtDogumAyi, "Doğduğu Ay");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(188, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "/";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(94, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(482, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Bilmediğiniz bilgileri yanlış bilgilerle doldurmayın, giriş yapmak zorlaşacaktır." +
    "";
            // 
            // frmOgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(671, 409);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOgrenciEkle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOkulNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNufusIlce;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNufusIl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCiltNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAileSiraNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDogumYili;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSinifHarf;
        private System.Windows.Forms.TextBox txtSinifNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtDogumGunu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDogumAyi;
        private System.Windows.Forms.Label label13;

    }
}
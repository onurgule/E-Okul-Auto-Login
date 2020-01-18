using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eOkulOtoGiris
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\db.accdb");
        private void frmAna_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void yeniÖğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciEkle ogrenci = new frmOgrenciEkle();
            ogrenci.ShowDialog();
            Yenile();
        }

        void Yenile()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Ogrenciler", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbOgrenciler.DataSource = dt;
            cbOgrenciler.ValueMember = "OgrenciID";
            cbOgrenciler.DisplayMember = "AdSoyad";
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            frmGirildi gir = new frmGirildi();
            gir.OgrenciID = cbOgrenciler.SelectedValue.ToString();
            gir.Show();
            gir.Hide();
        }

        public void GuvenlikKodu(Image img)
        {
            groupBox1.Visible = true;
            pbGuvenlikKodu.Image = img;
        }

        private void btnKodGirildi_Click(object sender, EventArgs e)
        {
            frmGirildi girildi = (frmGirildi)Application.OpenForms["frmGirildi"];
            girildi.GuvenlikKodluGiris(txtGuvenlikKodu.Text);

        }
    }
}

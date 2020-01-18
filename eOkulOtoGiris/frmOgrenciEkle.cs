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
    public partial class frmOgrenciEkle : Form
    {
        public frmOgrenciEkle()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\db.accdb");
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtTc.Text != "" && txtOkulNo.Text != "" && txtAdSoyad.Text != "")
            {
                int dolusayisi = 0;
                if (txtDogumYili.Text != "") dolusayisi++;
                if (txtSinifHarf.Text != "") dolusayisi++;
                if (txtAileSiraNo.Text != "") dolusayisi++;
                if (txtCiltNo.Text != "") dolusayisi++;
                if (txtNufusIl.Text != "") dolusayisi++;
                if (txtNufusIlce.Text != "") dolusayisi++;
                if (txtDogumAyi.Text != "") dolusayisi++;
                if (txtDogumGunu.Text != "") dolusayisi++;

                if(dolusayisi >= 2)
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Ogrenciler(OkulNo,AdSoyad,SinifNumara,SinifHarf,TCKimlikNo,DogumYili,AileSiraNo,CiltNo,NufusIl,NufusIlce,DogumGunu,DogumAyi) VALUES(@OkulNo,@AdSoyad,@SinifNumara,@SinifHarf,@TCKimlikNo,@DogumYili,@AileSiraNo,@CiltNo,@NufusIl,@NufusIlce,@DogumGunu,@DogumAyi)", conn);
                    cmd.Parameters.Add("@OkulNo",OleDbType.VarChar).Value = txtOkulNo.Text;
                    cmd.Parameters.Add("@AdSoyad",OleDbType.VarChar).Value = txtAdSoyad.Text;
                    cmd.Parameters.Add("@SinifNumara",OleDbType.VarChar).Value = txtSinifNo.Text;
                    cmd.Parameters.Add("@SinifHarf",OleDbType.VarChar).Value = txtSinifHarf.Text.ToUpper();
                    cmd.Parameters.Add("@TCKimlikNo",OleDbType.VarChar).Value = txtTc.Text;
                    cmd.Parameters.Add("@DogumYili",OleDbType.VarChar).Value = txtDogumYili.Text;
                    cmd.Parameters.Add("@AileSiraNo",OleDbType.VarChar).Value = txtAileSiraNo.Text;
                    cmd.Parameters.Add("@CiltNo",OleDbType.VarChar).Value = txtCiltNo.Text;
                    cmd.Parameters.Add("@NufusIl", OleDbType.VarChar).Value = txtNufusIl.Text.ToUpper();
                    cmd.Parameters.Add("@NufusIlce", OleDbType.VarChar).Value = txtNufusIlce.Text.ToUpper();
                    cmd.Parameters.Add("@DogumGunu",OleDbType.VarChar).Value = txtDogumGunu.Text;
                    cmd.Parameters.Add("@DogumAyi", OleDbType.VarChar).Value = DogumAyAdi(txtDogumAyi.Text);
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    cmd.ExecuteNonQuery();
                    if (conn.State == ConnectionState.Open) conn.Close();
                    MessageBox.Show("Öğrenci başarıyla eklendi!","Öğrenci Eklendi!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("İstenen bilgilerden en az iki bilgi doldurulması gerekmektedir!","İstenen Bilgi Eksikliği!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen yukarıdaki Gerekli Bilgiler bölümünü doldurun.", "Gerekli Bilgi Eksikliği!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string DogumAyAdi(string ayNo)
        {
            switch (ayNo)
            {
                case "1":
                    return "Ocak".ToUpper();
                case "2":
                    return "Şubat".ToUpper();
                case "3":
                    return "Mart".ToUpper();
                case "4":
                    return "Nisan".ToUpper();
                case "5":
                    return "Mayıs".ToUpper();
                case "6":
                    return "Haziran".ToUpper();
                case "7":
                    return "Temmuz".ToUpper();
                case "8":
                    return "Ağustos".ToUpper();
                case "9":
                    return "Eylül".ToUpper();
                case "10":
                    return "Ekim".ToUpper();
                case "11":
                    return "Kasım".ToUpper();
                case "12":
                    return "Aralık".ToUpper();
            }
            return "";
        }
    }
}

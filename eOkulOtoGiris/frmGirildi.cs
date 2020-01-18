using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace eOkulOtoGiris
{
    public partial class frmGirildi : Form
    {
        public frmGirildi()
        {
            InitializeComponent();
            
        }
        IECache iec = new IECache();
        public string OgrenciID = "-1";
        bool ilkdefa = true;
        bool guvenlikli = false;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\db.accdb");
        string okulno, adsoyad, sinifnumara, sinifharf, tc, dogumyili, ailesirano, ciltno, nufusil, nufusilce, dogumgunu, dogumayi;
        private void frmGirildi_Load(object sender, EventArgs e)
        {
            this.Hide();
            if(OgrenciID != "-1")
            {
                OgrenciyiAl();
            }
            else
            {
                MessageBox.Show("Programda beklenmedik bir hata oluştu!","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }


            ///
            try
            {
                webEOkul.Navigate("https://e-okul.meb.gov.tr/");
            }
            catch (Exception a)
            {
            }
        }
        void OgrenciyiAl()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Ogrenciler WHERE OgrenciID=@id", conn);
            cmd.Parameters.Add("@id", OleDbType.VarChar).Value = OgrenciID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                okulno = dr["OkulNo"].ToString();
                adsoyad = dr["AdSoyad"].ToString();
                sinifnumara = dr["SinifNumara"].ToString();
                sinifharf = dr["SinifHarf"].ToString();
                tc = dr["TCKimlikNo"].ToString();
                dogumyili = dr["DogumYili"].ToString();
                dogumgunu = dr["DogumGunu"].ToString();
                ailesirano = dr["AileSiraNo"].ToString();
                ciltno = dr["CiltNo"].ToString();
                nufusil = dr["NufusIl"].ToString();
                nufusilce = dr["NufusIlce"].ToString();
                dogumayi = dr["DogumAyi"].ToString();
            }
            else
            {
                MessageBox.Show("Programda beklenmedik bir hata oluştu!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            dr.Close();
            if (conn.State == ConnectionState.Open) conn.Close();
        }
        private void webEOkul_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                if (ilkdefa == true)
                {
                    IlkYanlisGirisiYap();
                }
                else if (webEOkul.Url.ToString() == "https://e-okul.meb.gov.tr/" && ilkdefa == false)
                {
                    if (webEOkul.Document.GetElementById("lblVbsSorun").OuterText == "Girdiğiniz Giriş Kodu yanlış!" && guvenlikli == false)
                    {
                        AnaFormaGuvenlikKodunuGonder();
                    }
                }
                if (guvenlikli == true)
                {
                    BilinenBilgilerleDoldur();
                    BilgiKontrolu();
                }
            }
            catch (Exception a)
            {
            MessageBox.Show(a.ToString());
            }
        }
        public void GuvenlikKodluGiris(string guvenlikkodu)
        {
            guvenlikli = true;
            this.Show();
            webEOkul.Document.GetElementById("txtVBSImage").InnerText = guvenlikkodu;
            webEOkul.Document.GetElementById("btnTamamvbs").InvokeMember("click");

        }

        void AnaFormaGuvenlikKodunuGonder()
        {
            IHTMLDocument2 doc = (IHTMLDocument2)webEOkul.Document.DomDocument; // gets the dom document of our object WebBrowser1
            IHTMLControlRange imgRange = (IHTMLControlRange)((HTMLBody)doc.body).createControlRange(); // setting up the controls so we can copy/paste the HTML image objects 

            foreach (IHTMLImgElement img in doc.images) // walk through all the images inside the dom document
            {
                imgRange.add((IHTMLControlElement)img); // set up which image (the current one) we are controlling
                imgRange.execCommand("Copy", false, null); // copy the current controlled image
                Bitmap bmp = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap); // create a bitmap object
                {
                    if (img.src.Contains("https://e-okul.meb.gov.tr/guvenlikkod.aspx?id="))
                    {
                        frmAna ana = (frmAna)Application.OpenForms["frmAna"];
                        ana.GuvenlikKodu(bmp);// save the bitmap object to this path on our harddrive
                        break;
                    }
                }
            }
        }

        void IlkYanlisGirisiYap()
        {
            webEOkul.Document.GetElementById("VBSKullanici").InnerText = tc;
            webEOkul.Document.GetElementById("VBSpassword").InnerText = okulno;
            webEOkul.Document.GetElementById("txtVBSImage").InnerText = "3141";
            webEOkul.Document.GetElementById("btnTamamvbs").InvokeMember("click");
            ilkdefa = false;
        }

        void CombodanSec(string comboid, string deger)
        {
            HtmlElement ee = this.webEOkul.Document.GetElementById(comboid);
            foreach (HtmlElement item in ee.Children)
            {
                if(item.OuterHtml.ToLower().IndexOf(deger.ToLower()) >= 0)
                {
                    item.SetAttribute("selected", "selected");
                    item.InvokeMember("onChange");

                }
                else
                {
                    item.SetAttribute("selected", "");
                }
            }
            ee = this.webEOkul.Document.GetElementById(comboid + "-input");
            ee.InnerText = deger;
        }

        void ComboluDegerGir(string comboid,string labelid, string olay, string deger)
        {
            try
            {
                if (webEOkul.Document.GetElementById(labelid).OuterText.Contains(olay))
                {
                    CombodanSec(comboid, deger);
                }
            }
            catch (Exception) { }
        }
        void TextliDegerGir(string textid, string labelid, string olay, string deger)
        {
            try
            {
                if (webEOkul.Document.GetElementById(labelid).OuterText.Contains(olay))
                {
                    webEOkul.Document.GetElementById(textid).InnerText = deger;
                }
            }
            catch (Exception) { }
        }

        void BilinenBilgilerleDoldur()
        {
            if (dogumgunu != "")
            {
                ComboluDegerGir("ddlS1C1", "lblS1C1", "doğum günü", dogumgunu);
                ComboluDegerGir("ddlS2C1", "lblS2C1", "doğum günü", dogumgunu);
            }
             if (dogumayi != "")
            {
            ComboluDegerGir("ddlS1C1", "lblS1C1", "doğum ayı", dogumayi.ToUpper());
            ComboluDegerGir("ddlS2C1", "lblS2C1", "doğum ayı", dogumayi.ToUpper());
             }
                  if (sinifharf != "")
            {
            ComboluDegerGir("ddlS1C1", "lblS1C1", "şube", sinifharf.ToUpper() + " ŞUBESİ");
            ComboluDegerGir("ddlS2C1", "lblS2C1", "şube", sinifharf.ToUpper() + " ŞUBESİ");
                  }
                       if (nufusil != "")
            {
            ComboluDegerGir("ddlS1C1", "lblS1C1", "il hangisidir?", nufusil.ToUpper());
            ComboluDegerGir("ddlS2C1", "lblS2C1", "il hangisidir?", nufusil.ToUpper());
                       }
                            if (nufusilce != "")
            {
            ComboluDegerGir("ddlS1C1", "lblS1C1", "ilçe hangisidir?", nufusilce.ToUpper());
            ComboluDegerGir("ddlS2C1", "lblS2C1", "ilçe hangisidir?", nufusilce.ToUpper());
                            }
                                 if (dogumyili != "")
            {
            TextliDegerGir("txtS1T1", "lblS1T1", "doğum yılı", dogumyili);
            TextliDegerGir("txtS2T1", "lblS2T1", "doğum yılı", dogumyili);
                                 }
             if (ciltno != "")
             {
             TextliDegerGir("txtS1T1", "lblS1T1", "cilt numarası", ciltno);
             TextliDegerGir("txtS2T1", "lblS2T1", "cilt numarası", ciltno);
             }
              if (ailesirano != "")
            {
            TextliDegerGir("txtS1T1", "lblS1T1", "aile sıra numarası", ailesirano);
            TextliDegerGir("txtS2T1", "lblS2T1", "aile sıra numarası", ailesirano);
                                           }
        }

        void BilgiKontrolu()
        {
            try { 
            if (webEOkul.Document.GetElementById("ddlS1C1").OuterText != "")
            {
                if (webEOkul.Document.GetElementById("ddlS1C1").Children[(int)webEOkul.Document.GetElementById("ddlS1C1").DomElement.GetType().InvokeMember("selectedIndex", BindingFlags.GetProperty, null, webEOkul.Document.GetElementById("ddlS1C1").DomElement, null)].InnerText == "" || webEOkul.Document.GetElementById("ddlS1C1").Children[(int)webEOkul.Document.GetElementById("ddlS1C1").DomElement.GetType().InvokeMember("selectedIndex", BindingFlags.GetProperty, null, webEOkul.Document.GetElementById("ddlS1C1").DomElement, null)].InnerText == null)
                {
                    BosAlanVar();
                    return;
                }
            }
                } catch(Exception){}
                try { 
            if (webEOkul.Document.GetElementById("ddlS2C1").OuterText != "")
            {
                if(webEOkul.Document.GetElementById("ddlS2C1").Children[(int)webEOkul.Document.GetElementById("ddlS2C1").DomElement.GetType().InvokeMember("selectedIndex", BindingFlags.GetProperty, null, webEOkul.Document.GetElementById("ddlS2C1").DomElement, null)].InnerText == "" || webEOkul.Document.GetElementById("ddlS2C1").Children[(int)webEOkul.Document.GetElementById("ddlS2C1").DomElement.GetType().InvokeMember("selectedIndex", BindingFlags.GetProperty, null, webEOkul.Document.GetElementById("ddlS2C1").DomElement, null)].InnerText == null)
                {
                    BosAlanVar();
                    return;
                }
            }
                } catch(Exception){}
                    try { 
            if (webEOkul.Document.GetElementById("txtS1T1").OuterText != "")
            {
                if(webEOkul.Document.GetElementById("txtS1T1").GetAttribute("value") == "")
                {
                    BosAlanVar();
                    return;
                }
            }
                } catch(Exception){}
                        try { 
            if (webEOkul.Document.GetElementById("txtS2T1").OuterText != "")
            {
                if(webEOkul.Document.GetElementById("txtS2T1").GetAttribute("value") == "")
                {
                    BosAlanVar();
                    return;
                }
            }
                } catch (Exception) { }
        }

        void BosAlanVar()
        {
            webEOkul.GoBack();
        }
        void AlanlarDolu()
        {
            MessageBox.Show("Alanlar Dolu!");
        }
        
    }
}

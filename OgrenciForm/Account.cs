using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Fintek.Facade.fOtomasyon;


namespace OgrenciForm
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string Kullanici;
            string sifre;

         
            Kullanici = txtKullanıcıAdı.Text;
            sifre = txtParola.Text;

            if (Kullanici == "admin" && sifre == "123456")
            {
                MessageBox.Show("Giriş Başarılı!...");
                MdiForm m1 = new MdiForm();
                m1.Show();
                Account mm = new Account();
                mm.Close();
                
            }
            else
                MessageBox.Show("Hatalı Giriş!...");
            
        }

        #region ertac
        //private void btnGiris_Click(object sender, EventArgs e)
        //{
        //    // Girilen verilerin kontrolü
        //    if (string.IsNullOrEmpty(txtKullanıcıAdı.Text) || string.IsNullOrEmpty(txtParola.Text))
        //    {
        //        // hta mesajı alanlar boş oolamaz
        //        return;
        //    }

        //    string Kullanici;
        //    string Parola;
        //    fOtomasyon otomasyon = new fOtomasyon();
        //    Kullanici = txtKullanıcıAdı.Text;
        //    DataSet dsKullanici = otomasyon.HesapGetir(txtKullanıcıAdı.Text);

        //    // Kullanıcı kontrol işlemleri
        //    {
        //        DataTable dtKullanici = dsKullanici.Tables[0];


        //        if (dtKullanici == null || dtKullanici.Rows.Count == 0)
        //        {  
        //            if (parolaAsil == txtParola.Text)
        //        {
        //            MdiForm m1 = new MdiForm();
        //            m1.Show();
        //        }
        //        }
        #endregion
    }
    }


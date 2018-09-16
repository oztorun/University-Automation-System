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
    public partial class OgrenciDers : Form
    {
        bool m_InsertButtonPressed;

        public OgrenciDers()
        {
            InitializeComponent();
        }

        public void loadOgrenciDers(int ogrenciNo,int dersId)
        {
            fiilDataOgrenci();
            fillDataDers();

            fOtomasyon otomasyon = new fOtomasyon();
            try
            {
                DataSet ds = otomasyon.NotAllGetir(ogrenciNo,dersId);

                dataNot.AutoGenerateColumns = true;
                dataNot.DataSource = ds;
                dataNot.DataMember = "Table";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void OgrenciDers_Load(object sender, EventArgs e)
        {
            loadOgrenciDers(0,0);
            processInputControlsEnbility(false);
        }

        private void dataNot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataNot.Rows[e.RowIndex];
                comboBox1.Text = row.Cells[1].Value.ToString();
                comboBox2.Text = row.Cells[3].Value.ToString();
                txtVize.Text = row.Cells[4].Value.ToString();
                txtFinal.Text = row.Cells[5].Value.ToString();
                txtBasariNotu.Text = row.Cells[6].Value.ToString();
                txtDersDurumu.Text = row.Cells[7].Value.ToString();
            }
        }

        private void copyAlltoClipboard()
        {
           dataNot.SelectAll();
            DataObject dataObj = dataNot.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void processInputControlsEnbility(bool enable)
        {
            comboBox1.Enabled = enable;
            comboBox2.Enabled = enable;
            txtVize.Enabled = enable;
            txtFinal.Enabled = enable;
            txtDersDurumu.Enabled = enable;
            txtBasariNotu.Enabled = enable;
        }

        private void clearAllTextBox()
        {
            txtBasariNotu.Clear();
            txtDersDurumu.Clear();
            txtFinal.Clear();
            txtVize.Clear();
            toolSFinal.Text = string.Empty;
            toolSDersId.Text = string.Empty;
            toolStrip1.Text = string.Empty;
            toolSOgrenciNo.Text = string.Empty;
            toolSVize.Text = string.Empty;
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
        }

        private void tsEkle_Click(object sender, EventArgs e)
        {
            processInputControlsEnbility(true);
            clearAllTextBox();
            m_InsertButtonPressed = true;
            fiilDataOgrenci();
            fillDataDers();
        }
        private int NotEkle()
        {
            int OgrenciNo = Convert.ToInt32(((System.Data.DataRowView)(comboBox1.SelectedValue)).Row.ItemArray[0]);
            int DersId = Convert.ToInt32(comboBox2.SelectedValue);
            int OVize = Convert.ToInt32(txtVize.Text);
            int OFinal = Convert.ToInt32(txtFinal.Text);
            double OBasariNotu = Convert.ToDouble(txtBasariNotu.Text);
            string DersDurumu = txtDersDurumu.Text;

            DialogResult dialogresult = MessageBox.Show(string.Format("{0} isimli öğrencinin notu girilsin mi ?", OgrenciNo), "Not ekleme Onayı", MessageBoxButtons.YesNo);
            if (dialogresult == System.Windows.Forms.DialogResult.Yes)
            {
                fOtomasyon otomasyon = new fOtomasyon();
                return otomasyon.NotEkle(OgrenciNo, DersId, OVize, OFinal, OBasariNotu, DersDurumu);
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi", "Not ekleme işlemi");
                return 0;
            }
        }
        private void NotSil()
        {
            int OgrenciNo = Convert.ToInt32(((System.Data.DataRowView)(comboBox1.SelectedValue)).Row.ItemArray[0]);
            int dersId = Convert.ToInt32(comboBox2.SelectedValue);

            DialogResult dialogresult = MessageBox.Show(string.Format("{0} nolu öğrencinin {1} Dersin notu silinsin mi ?", OgrenciNo,dersId), "Not silme Onayı", MessageBoxButtons.YesNo);

            if (dialogresult == System.Windows.Forms.DialogResult.Yes)
            {
                fOtomasyon otomasyon = new fOtomasyon();
                otomasyon.NotSil(OgrenciNo,dersId);
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi", "Not silme iptali");
            }
        }

        private void NotGuncelle()
        {
            int ogrenciNo = Convert.ToInt32(((System.Data.DataRowView)(comboBox1.SelectedValue)).Row.ItemArray[0]);
            int dersId = Convert.ToInt32(comboBox2.SelectedValue);
            int oVize = Convert.ToInt32(txtVize.Text);
            int oFinal = Convert.ToInt32(txtFinal.Text);
            double oBasariNotu = Convert.ToDouble(txtBasariNotu.Text);
            string dersDurumu = txtDersDurumu.Text;

            DialogResult dialogresult = MessageBox.Show(string.Format("{0} nolu öğrencinin notu güncellensin mi ?", ogrenciNo), "Not Güncelleme Onayı", MessageBoxButtons.YesNo);

            if (dialogresult == System.Windows.Forms.DialogResult.Yes)
            {
                fOtomasyon otomasyon = new fOtomasyon();
                otomasyon.NotGuncelle(ogrenciNo, dersId, oVize, oFinal, oBasariNotu, dersDurumu);
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi", "Not Güncelleme İptali");
            }
        }

        private void tsKaydet_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;

            if (m_InsertButtonPressed)
            {
                
                comboBox1.Text = NotEkle().ToString();
            }
            else
            {
                NotGuncelle();
            }
            loadOgrenciDers(0,0);
            m_InsertButtonPressed = false;
            processInputControlsEnbility(false);
        }

        private void tsTemizle_Click(object sender, EventArgs e)
        {
            clearAllTextBox();
        }                                                                                  

        private void tsEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Bu bölümde sadece not düzenleme yapılabilir. Lütfen ilk önce düzenlenecek öğrenciyi seçiniz.Yeni kayıt için lütfen öğrenci ekle butonunu kullanınız", MessageBoxButtons.OK));
            processInputControlsEnbility(true);
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            NotSil();
            clearAllTextBox();
            loadOgrenciDers(0, 0);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToDouble(txtVize.Text);
            double final = Convert.ToDouble(txtFinal.Text);

            double basarinotu = vize * 0.3 + final * 0.7;
            txtBasariNotu.Text = basarinotu.ToString();

            if (basarinotu >= 60)
            {
                txtDersDurumu.Text = "GEÇTİ".ToString();
            }
            else
            {
                txtDersDurumu.Text = "KALDI".ToString();
            }
        }

        #region Kontrol
        private bool Validate()
        {
        //    if (txtOgrenciNo == null || string.IsNullOrWhiteSpace(txtOgrenciNo.Text))
        //    {
        //        toolSOgrenciNo.Text = "Öğrenci Numarasını Giriniz";
        //        txtOgrenciNo.Focus();
        //        return false;
        //    }

        //    if(txtDersId==null || string.IsNullOrWhiteSpace(txtDersId.Text))
        //    {
        //        toolSDersId.Text="Ders Id'sini giriniz";
        //        txtDersId.Focus();
        //        return false;
        //    }

            if (txtVize == null || string.IsNullOrWhiteSpace(txtVize.Text))
            {
                toolSVize.Text = "Vize Notu Giriniz";
                txtVize.Focus();
                return false;
            }

            if (txtFinal == null || string.IsNullOrWhiteSpace(txtFinal.Text))
            {
                toolSFinal.Text = "Final Notu Giriniz";
                txtFinal.Focus();
                return false;
            }
            if (txtBasariNotu == null || string.IsNullOrWhiteSpace(txtBasariNotu.Text))
            {
                toolsBasari.Text = "Hesapla Butonunu Kullanın";
                return false;
            }
            if (txtDersDurumu == null || string.IsNullOrWhiteSpace(txtDersDurumu.Text))
            {
                toolSDersDurumu.Text = "Hesapla butonunu Kullanın";
                return false;
            }
            return true;
        }

        //private bool ValidateSil()
        //{
        //    //if (txtOgrenciNo == null || string.IsNullOrWhiteSpace(txtOgrenciNo.Text))
        //    //{
        //    //    toolSOgrenciNo.Text = "Öğrenci Seçiniz";
        //    //    return false;
        //    //}
        //    //if (txtDersId == null || string.IsNullOrWhiteSpace(txtDersId.Text))
        //    //{
        //    //    toolSFinal.Text = "Öğreci Seçiniz";
        //    //    return false;
        //    //}
        //    //return true;
        //}

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OgrenciForm o1 = new OgrenciForm();
            o1.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DersForm d1 = new DersForm();
            d1.Show();
        }

        //private void txtOgrenciNo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
        //    {
        //    }
        //    else
        //    {
        //        MessageBox.Show("Lütfen Numerik Değer Girin", "Numerik");
        //        e.Handled = e.KeyChar != (char)Keys.Back;
        //    }
        //}

        private void txtDersId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
            }
            else
            {
                MessageBox.Show("Lütfen Numerik Değer Girin", "Numerik");
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtVize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
            }
            else
            {
                MessageBox.Show("Lütfen Numerik Değer Girin", "Numerik");
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
            }
            else
            {
                MessageBox.Show("Lütfen Numerik Değer Girin", "Numerik");
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        #endregion

        private void fiilDataOgrenci()
        { 
            fOtomasyon otomasyon=new fOtomasyon();
       
            DataSet dsOgrenci  = otomasyon.OgrenciAllGetir();
            comboBox1.DataSource = dsOgrenci.Tables[0];
        }

        private void fillDataDers()
        {
            fOtomasyon otomasyon = new fOtomasyon();
            DataSet dsDers = otomasyon.DersAllGetir();
            comboBox2.DataSource = dsDers.Tables[0];
        }
    }
}
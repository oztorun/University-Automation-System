using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fintek.Facade.fOtomasyon;


namespace OgrenciForm
{
    public partial class DersForm : Form
    {
        bool m_InsertButtonPressed;

        public DersForm()
        {
            InitializeComponent();
        }

        public void loadDers()
        {
            fOtomasyon Ders = new fOtomasyon();

            DataSet ds = Ders.DersAllGetir();

            dataders.AutoGenerateColumns = true;
            dataders.DataSource = ds;
            dataders.DataMember = "Table";
        }

        private void DersForm_load(object sender, EventArgs e)
        {
            loadDers();
            processInputControlsEnbility(false);
        }

        private void dataDers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataders.Rows[e.RowIndex];
                txtDersId.Text = row.Cells[0].Value.ToString();
                txtDersKodu.Text = row.Cells[1].Value.ToString();
                txtDersAdı.Text = row.Cells[2].Value.ToString();
                txtDersKredi.Text = row.Cells[3].Value.ToString();
                cbSınıf.Text = row.Cells[4].Value.ToString();
                cbDersDonemi.Text = row.Cells[5].Value.ToString();
            }
        }

        private int DersEkle()
        {
            string dersKodu = txtDersKodu.Text;
            string dersAdı = txtDersAdı.Text;
            int dersKredi = Convert.ToInt32(txtDersKredi.Text);
            string sınıf = cbSınıf.Text;
            string dersDonemi = cbDersDonemi.Text;

            DialogResult dialogresult = MessageBox.Show(string.Format("{0} 'kodlu Ders Ekleme İşlemi Onaylansın mı?", dersKodu), "Ders Ekleme Onayı", MessageBoxButtons.YesNo);

            if (dialogresult == System.Windows.Forms.DialogResult.Yes)
            {
                fOtomasyon otomasyon = new fOtomasyon();
                return otomasyon.DersEkle(dersKodu, dersAdı, dersKredi,sınıf, dersDonemi);
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi", "Ders ekleme iptali");
                return 0; 
            }
        }

        private void DersSil()
        {
            int dersId = Convert.ToInt32(txtDersId.Text);
            DialogResult dialogresult = MessageBox.Show(string.Format("{0} Id'li Ders Silme İşlemi Onaylansın mı?", dersId), "Ders Ekleme Onayı", MessageBoxButtons.YesNo);

            if (dialogresult == System.Windows.Forms.DialogResult.Yes)
            {
                fOtomasyon otomasyon = new fOtomasyon();
                otomasyon.DersSil(dersId);
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi", "Ders silme iptali");
            }
        }

        private void DersGuncelle()
        {
            int dersId = Convert.ToInt32(txtDersId.Text);
            string dersKodu = txtDersKodu.Text;
            string dersAdı = txtDersAdı.Text;
            int dersKredi = Convert.ToInt32(txtDersKredi.Text);
            string sınıf = cbSınıf.Text;
            string dersDonemi = cbDersDonemi.Text;
            
            DialogResult dialogResult=MessageBox.Show(string.Format("{0} Ders Güncelleme İşlemi Onaylansın mı ? ",dersId),"Güncelleme Onayı",MessageBoxButtons.YesNo);

            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                fOtomasyon otomasyon = new fOtomasyon();
                otomasyon.DersGuncelle(dersId, dersKodu, dersAdı, dersKredi,sınıf, dersDonemi);
            }
            else
            {
                MessageBox.Show("İşlemini iptal edildi", "Güncelleme İptali");
            }
        }
        private void tsDersEkle_Click(object sender, EventArgs e)
        {
            processInputControlsEnbility(true);
            ClearAllTextBox();
            m_InsertButtonPressed = true;
        }

        private void tsDersSil_Click(object sender, EventArgs e)
        {
            if (!ValidateSil()) return;
            DersSil();
            loadDers();
            ClearAllTextBox();
        }

        private void tsDersKaydet_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            if (m_InsertButtonPressed)
            {
                txtDersId.Text = DersEkle().ToString();
            }
            else
            {
                DersGuncelle();
            }
            loadDers();
            m_InsertButtonPressed = false;
            processInputControlsEnbility(false);
        }
        public void ClearAllTextBox()
        {
            txtDersId.Clear();
            txtDersAdı.Clear();
            txtDersKodu.Clear();
            txtDersKredi.Clear();
            txtDersKodu.Select();
        }
        private void tsDersTemizle_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
            ToolStripClear();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            OgrenciForm o1 = new OgrenciForm();
            o1.Show();
        }

        private void processInputControlsEnbility(bool enable)
        {
            txtDersId.Enabled = enable;
            txtDersAdı.Enabled = enable;
            txtDersKodu.Enabled = enable;
            txtDersKredi.Enabled = enable;
            cbDersDonemi.Enabled = enable;
            cbSınıf.Enabled = enable;
        }
        private void ToolStripClear()
        {
            tsDersAdı.Text = string.Empty;
            tsDersKodu.Text = string.Empty;
            tsDersKredi.Text = string.Empty;
        }

        private bool Validate()
        {
            if (txtDersKodu == null || string.IsNullOrWhiteSpace(txtDersKodu.Text))
            {
                tsDersKodu.Text = "Ders Kodu Bilgisini Giriniz";
                txtDersKodu.Focus();
                return false;
            }

            if (txtDersAdı == null || string.IsNullOrWhiteSpace(txtDersAdı.Text))
            {
                tsDersAdı.Text = "Ders Adı Giriniz";
                txtDersAdı.Focus();
                return false;
            }
            if (txtDersKredi == null || string.IsNullOrWhiteSpace(txtDersKredi.Text))
            {
                tsDersKredi.Text = "Ders Kredi Bilgisi Giriniz";
                txtDersKredi.Focus();
                return false;
            }
           tsDersKredi.Text = string.Empty;
            return true;
        }

        private bool ValidateSil()
        {
            if (txtDersId == null || string.IsNullOrWhiteSpace(txtDersId.Text))
            {
                tsDersNo.Text = "Silinecek Ders Seçiniz";
                return false;
            }
            tsDersNo.Text = string.Empty;
            return true;
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Bu bölümde sadece öğrenci düzenleme yapılabilir. Lütfen ilk önce düzenlenecek öğrenciyi seçiniz.Yeni kayıt için lütfen öğrenci ekle butonunu kullanınız", MessageBoxButtons.OK));
            processInputControlsEnbility(true);
        }

        private void txtDersKredi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OgrenciDers od1 = new OgrenciDers();
            od1.Show();
        }
       
    }
}

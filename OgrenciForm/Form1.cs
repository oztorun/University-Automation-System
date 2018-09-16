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
    public partial class OgrenciForm : Form
    {
        bool m_InsertButtonPressed;

        public OgrenciForm()
        {
            InitializeComponent();
        }

        public void loadOgrenci()
        {
            fOtomasyon OtomasyonFacade = new fOtomasyon();

            DataSet ds = OtomasyonFacade.OgrenciAllGetir();

            dataOgrenci.AutoGenerateColumns = true;
            dataOgrenci.DataSource = ds;
            dataOgrenci.DataMember = "Table";

        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {

            loadOgrenci();
        }

        private void ToolStripClear()
        {
            tslblOgrenciSoyadi.Text = string.Empty;
            tslblOgrenciNo.Text = string.Empty;
            tslblOgrenciAdi.Text = string.Empty;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;
            if (m_InsertButtonPressed)
            {
                txtOgrenciNo.Clear();
            }
            else
            {
                OgrenciEkle();
            }
                loadOgrenci();
                ToolStripClear();
                m_InsertButtonPressed = false;
        }

        private int OgrenciEkle()
        {
            int ogrencino = Convert.ToInt32(txtOgrenciNo.Text);
            string ogrenciadi = txtOgrenciAdi.Text;
            string ogrencisoyadi = txtOgrenciSoyadi.Text;

            DialogResult dialogresult = MessageBox.Show(string.Format("{0} Numaralı Öğrenci Ekleme İşlemi onaylansın mı ? ", ogrencino), "Ogrenci Ekleme Onayı", MessageBoxButtons.YesNo);

            if (dialogresult == System.Windows.Forms.DialogResult.Yes)
            {
                fOtomasyon otomasyon = new fOtomasyon();
                return otomasyon.OgrenciEkle(ogrencino, ogrenciadi, ogrencisoyadi);
            }

            else
            {
                MessageBox.Show("İşlem İptal Edildi", "Öğrenci ekleme iptali");
                return 0;
            }


        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;

            OgrenciSil();
            loadOgrenci();
            ClearAllTextBox();
        }

        private void OgrenciSil()
        {
           
                int ogrencinosil = Convert.ToInt32(txtOgrenciNo.Text);

                DialogResult dialogresult = MessageBox.Show(string.Format("{0} Numaralı Öğrenci Silme İşlemi onaylansın mı ? ", ogrencinosil), "Ogrenci Ekleme Onayı", MessageBoxButtons.YesNo);

                if (dialogresult == System.Windows.Forms.DialogResult.Yes)
                {
                    fOtomasyon otomasyon = new fOtomasyon();
                    otomasyon.OgrenciSil(ogrencinosil);
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi", "Öğrenci silme iptali");

                }
            }
        
        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;
            if (m_InsertButtonPressed)
            {
                txtOgrenciNo.Text = string.Empty;
            }
            else
            {
                OgrenciGuncelle();
            }
                loadOgrenci();
                m_InsertButtonPressed = false;
            
        }

        private void OgrenciGuncelle()
        {
                int ogrencino = Convert.ToInt32(txtOgrenciNo.Text);
                string ogrenciadi = txtOgrenciAdi.Text;
                string ogrencisoyadi = txtOgrenciSoyadi.Text;

                DialogResult dialogResult = MessageBox.Show(string.Format("{0} öğrenci Güncelleme işlemi onaylansın mı ?", ogrencino), "Güncelleme Olayı", MessageBoxButtons.YesNo);

                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    fOtomasyon otomasyon = new fOtomasyon();
                    otomasyon.OgrenciGuncelle(ogrencino, ogrenciadi, ogrencisoyadi);
                }
                else
                {
                    MessageBox.Show("İşleminiz iptal edildi", "Güncelleme iptali.");
                }
            }

        public void ClearAllTextBox()
        {
            txtOgrenciAdi.Clear();
            txtOgrenciNo.Clear();
            txtOgrenciSoyadi.Clear();
            txtOgrenciNo.Select();
        }

        private void dataOgrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataOgrenci.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtOgrenciNo.Text = row.Cells[0].Value.ToString();
                txtOgrenciAdi.Text = row.Cells[1].Value.ToString();
                txtOgrenciSoyadi.Text = row.Cells[2].Value.ToString();

            }
        }

        private void txtOgrenciClear_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
            txtOgrenciNo.Select();
            ToolStripClear();
        }

        private bool Validate()
        {
            if (txtOgrenciNo == null || string.IsNullOrWhiteSpace(txtOgrenciNo.Text))
            {
                tslblOgrenciNo.Text = "ogrenci no girini";
                txtOgrenciNo.Focus();
                return false;
            }

            if (txtOgrenciAdi == null || string.IsNullOrWhiteSpace(txtOgrenciAdi.Text))
            {
                tslblOgrenciAdi.Text = "Ogrenci Adi Bilgisi Giriniz!";
                txtOgrenciAdi.Focus();
                return false;
            }
            if (tslblOgrenciSoyadi == null || string.IsNullOrWhiteSpace(txtOgrenciSoyadi.Text))
            {
                tslblOgrenciSoyadi.Text = "Ogrenci Soyadı Giriniz!";
                txtOgrenciNo.Focus();
                return false;
            }
            tslblOgrenciSoyadi.Text = string.Empty;
            return true;
        }
     
    }
}
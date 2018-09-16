using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OgrenciForm
{
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        private void MdiForm_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool durum = false;

            OgrenciForm ogrenci = new OgrenciForm();
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == ogrenci.Text)
                {
                    durum = true;
                    form.Activate();
                }
            }
            if (durum == false)
            {
                ogrenci.MdiParent = this;
                ogrenci.Show();
            }
        }

        private void dersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool durum = false;
            DersForm ders = new DersForm();
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == ders.Text)
                {
                    durum = true;
                    form.Activate();
                }
            }
            if (durum == false)
            {
                ders.MdiParent = this;
                ders.Show();
            }
            {
                
            }
        }

        private void notToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool durum = false;
            OgrenciDers ogrenciders = new OgrenciDers();
            foreach(Form  form in this.MdiChildren)
            {
                if (form.Text == ogrenciders.Text)
                {
                    durum = true;
                    form.Activate();
                }
            }
            if(durum==false)
            {
                ogrenciders.MdiParent = this;
                ogrenciders.Show();
            }
        }
    }
}
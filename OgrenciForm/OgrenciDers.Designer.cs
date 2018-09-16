namespace OgrenciForm
{
    partial class OgrenciDers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciDers));
            this.dataNot = new System.Windows.Forms.DataGridView();
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.lblDersId = new System.Windows.Forms.Label();
            this.lblVize = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblBasari = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtBasariNotu = new System.Windows.Forms.TextBox();
            this.txtDersDurumu = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsEkle = new System.Windows.Forms.ToolStripButton();
            this.tsKaydet = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsSil = new System.Windows.Forms.ToolStripButton();
            this.tsTemizle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolSOgrenciNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSDersId = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSVize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSFinal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolsBasari = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSDersDurumu = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tsLoad = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataNot)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataNot
            // 
            this.dataNot.AllowUserToAddRows = false;
            this.dataNot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataNot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNot.Location = new System.Drawing.Point(16, 228);
            this.dataNot.Name = "dataNot";
            this.dataNot.ReadOnly = true;
            this.dataNot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNot.Size = new System.Drawing.Size(698, 150);
            this.dataNot.TabIndex = 0;
            this.dataNot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNot_CellContentClick);
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.Location = new System.Drawing.Point(12, 35);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(62, 13);
            this.lblOgrenciNo.TabIndex = 1;
            this.lblOgrenciNo.Text = "Öğrenci Adı";
            // 
            // lblDersId
            // 
            this.lblDersId.AutoSize = true;
            this.lblDersId.Location = new System.Drawing.Point(13, 61);
            this.lblDersId.Name = "lblDersId";
            this.lblDersId.Size = new System.Drawing.Size(47, 13);
            this.lblDersId.TabIndex = 2;
            this.lblDersId.Text = "Ders Adı";
            // 
            // lblVize
            // 
            this.lblVize.AutoSize = true;
            this.lblVize.Location = new System.Drawing.Point(12, 87);
            this.lblVize.Name = "lblVize";
            this.lblVize.Size = new System.Drawing.Size(31, 13);
            this.lblVize.TabIndex = 3;
            this.lblVize.Text = "VİZE";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(13, 112);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(37, 13);
            this.lblFinal.TabIndex = 4;
            this.lblFinal.Text = "FİNAL";
            // 
            // lblBasari
            // 
            this.lblBasari.AutoSize = true;
            this.lblBasari.Location = new System.Drawing.Point(12, 137);
            this.lblBasari.Name = "lblBasari";
            this.lblBasari.Size = new System.Drawing.Size(80, 13);
            this.lblBasari.TabIndex = 5;
            this.lblBasari.Text = "BAŞARI NOTU";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(12, 164);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(69, 13);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.Text = "Ders Durumu";
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(104, 85);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(100, 20);
            this.txtVize.TabIndex = 9;
            this.txtVize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVize_KeyPress);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(104, 109);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 10;
            this.txtFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinal_KeyPress);
            // 
            // txtBasariNotu
            // 
            this.txtBasariNotu.Location = new System.Drawing.Point(104, 133);
            this.txtBasariNotu.Name = "txtBasariNotu";
            this.txtBasariNotu.ReadOnly = true;
            this.txtBasariNotu.Size = new System.Drawing.Size(100, 20);
            this.txtBasariNotu.TabIndex = 11;
            // 
            // txtDersDurumu
            // 
            this.txtDersDurumu.Location = new System.Drawing.Point(104, 159);
            this.txtDersDurumu.Name = "txtDersDurumu";
            this.txtDersDurumu.ReadOnly = true;
            this.txtDersDurumu.Size = new System.Drawing.Size(100, 20);
            this.txtDersDurumu.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEkle,
            this.tsKaydet,
            this.tsEdit,
            this.tsSil,
            this.tsTemizle,
            this.toolStripButton2,
            this.toolStripButton1,
            this.tsLoad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(733, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsEkle
            // 
            this.tsEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEkle.Image = ((System.Drawing.Image)(resources.GetObject("tsEkle.Image")));
            this.tsEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEkle.Name = "tsEkle";
            this.tsEkle.Size = new System.Drawing.Size(23, 22);
            this.tsEkle.Text = "Ekle";
            this.tsEkle.Click += new System.EventHandler(this.tsEkle_Click);
            // 
            // tsKaydet
            // 
            this.tsKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsKaydet.Image = ((System.Drawing.Image)(resources.GetObject("tsKaydet.Image")));
            this.tsKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKaydet.Name = "tsKaydet";
            this.tsKaydet.Size = new System.Drawing.Size(23, 22);
            this.tsKaydet.Text = "Kaydet";
            this.tsKaydet.Click += new System.EventHandler(this.tsKaydet_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsEdit.Image")));
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(23, 22);
            this.tsEdit.Text = "Düzenle";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsSil
            // 
            this.tsSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSil.Image = ((System.Drawing.Image)(resources.GetObject("tsSil.Image")));
            this.tsSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSil.Name = "tsSil";
            this.tsSil.Size = new System.Drawing.Size(23, 22);
            this.tsSil.Text = "Sil";
            this.tsSil.Click += new System.EventHandler(this.tsSil_Click);
            // 
            // tsTemizle
            // 
            this.tsTemizle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsTemizle.Image = ((System.Drawing.Image)(resources.GetObject("tsTemizle.Image")));
            this.tsTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTemizle.Name = "tsTemizle";
            this.tsTemizle.Size = new System.Drawing.Size(23, 22);
            this.tsTemizle.Text = "Temizle";
            this.tsTemizle.Click += new System.EventHandler(this.tsTemizle_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Öğrenciler";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Dersler";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(104, 186);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 23);
            this.btnHesapla.TabIndex = 14;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSOgrenciNo,
            this.toolSDersId,
            this.toolSVize,
            this.toolSFinal,
            this.toolsBasari,
            this.toolSDersDurumu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(733, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolSOgrenciNo
            // 
            this.toolSOgrenciNo.Name = "toolSOgrenciNo";
            this.toolSOgrenciNo.Size = new System.Drawing.Size(0, 17);
            // 
            // toolSDersId
            // 
            this.toolSDersId.Name = "toolSDersId";
            this.toolSDersId.Size = new System.Drawing.Size(0, 17);
            this.toolSDersId.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // toolSVize
            // 
            this.toolSVize.Name = "toolSVize";
            this.toolSVize.Size = new System.Drawing.Size(0, 17);
            // 
            // toolSFinal
            // 
            this.toolSFinal.Name = "toolSFinal";
            this.toolSFinal.Size = new System.Drawing.Size(0, 17);
            // 
            // toolsBasari
            // 
            this.toolsBasari.Name = "toolsBasari";
            this.toolsBasari.Size = new System.Drawing.Size(0, 17);
            // 
            // toolSDersDurumu
            // 
            this.toolSDersDurumu.Name = "toolSDersDurumu";
            this.toolSDersDurumu.Size = new System.Drawing.Size(0, 17);
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "DERSADI";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(345, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "DERSID";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "ÖĞRENCİ ADI";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "ÖĞRENCİNUMARASI";
            // 
            // tsLoad
            // 
            this.tsLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsLoad.Image")));
            this.tsLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLoad.Name = "tsLoad";
            this.tsLoad.Size = new System.Drawing.Size(23, 22);
            this.tsLoad.Text = "Yenile";
            // 
            // OgrenciDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 431);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtDersDurumu);
            this.Controls.Add(this.txtBasariNotu);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblBasari);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblVize);
            this.Controls.Add(this.lblDersId);
            this.Controls.Add(this.lblOgrenciNo);
            this.Controls.Add(this.dataNot);
            this.Name = "OgrenciDers";
            this.Text = "OgrenciDers";
            this.Load += new System.EventHandler(this.OgrenciDers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNot)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataNot;
        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.Label lblDersId;
        private System.Windows.Forms.Label lblVize;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblBasari;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtBasariNotu;
        private System.Windows.Forms.TextBox txtDersDurumu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsEkle;
        private System.Windows.Forms.ToolStripButton tsKaydet;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripButton tsSil;
        private System.Windows.Forms.ToolStripButton tsTemizle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolSOgrenciNo;
        private System.Windows.Forms.ToolStripStatusLabel toolSDersId;
        private System.Windows.Forms.ToolStripStatusLabel toolSVize;
        private System.Windows.Forms.ToolStripStatusLabel toolSFinal;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolsBasari;
        private System.Windows.Forms.ToolStripStatusLabel toolSDersDurumu;
        private System.Windows.Forms.ToolStripButton tsLoad;
    }
}
namespace OgrenciForm
{
    partial class DersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DersForm));
            this.dataders = new System.Windows.Forms.DataGridView();
            this.lblDersId = new System.Windows.Forms.Label();
            this.lblDersKodu = new System.Windows.Forms.Label();
            this.lblDersAdı = new System.Windows.Forms.Label();
            this.lblDersKredi = new System.Windows.Forms.Label();
            this.lblDersDonemi = new System.Windows.Forms.Label();
            this.cbDersDonemi = new System.Windows.Forms.ComboBox();
            this.txtDersId = new System.Windows.Forms.TextBox();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.txtDersAdı = new System.Windows.Forms.TextBox();
            this.txtDersKredi = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsDersEkle = new System.Windows.Forms.ToolStripButton();
            this.tsDersKaydet = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsDersSil = new System.Windows.Forms.ToolStripButton();
            this.tsDersTemizle = new System.Windows.Forms.ToolStripButton();
            this.tsOgrenciler = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsDersKodu = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDersAdı = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDersKredi = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDersNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblSınıf = new System.Windows.Forms.Label();
            this.cbSınıf = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataders)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataders
            // 
            this.dataders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataders.Location = new System.Drawing.Point(10, 280);
            this.dataders.Name = "dataders";
            this.dataders.ReadOnly = true;
            this.dataders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataders.Size = new System.Drawing.Size(375, 150);
            this.dataders.TabIndex = 0;
            this.dataders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDers_CellContentClick);
            // 
            // lblDersId
            // 
            this.lblDersId.AutoSize = true;
            this.lblDersId.Location = new System.Drawing.Point(12, 47);
            this.lblDersId.Name = "lblDersId";
            this.lblDersId.Size = new System.Drawing.Size(40, 13);
            this.lblDersId.TabIndex = 1;
            this.lblDersId.Text = "DersID";
            // 
            // lblDersKodu
            // 
            this.lblDersKodu.AutoSize = true;
            this.lblDersKodu.Location = new System.Drawing.Point(12, 75);
            this.lblDersKodu.Name = "lblDersKodu";
            this.lblDersKodu.Size = new System.Drawing.Size(54, 13);
            this.lblDersKodu.TabIndex = 2;
            this.lblDersKodu.Text = "DersKodu";
            // 
            // lblDersAdı
            // 
            this.lblDersAdı.AutoSize = true;
            this.lblDersAdı.Location = new System.Drawing.Point(12, 102);
            this.lblDersAdı.Name = "lblDersAdı";
            this.lblDersAdı.Size = new System.Drawing.Size(44, 13);
            this.lblDersAdı.TabIndex = 3;
            this.lblDersAdı.Text = "DersAdı";
            // 
            // lblDersKredi
            // 
            this.lblDersKredi.AutoSize = true;
            this.lblDersKredi.Location = new System.Drawing.Point(12, 129);
            this.lblDersKredi.Name = "lblDersKredi";
            this.lblDersKredi.Size = new System.Drawing.Size(53, 13);
            this.lblDersKredi.TabIndex = 4;
            this.lblDersKredi.Text = "DersKredi";
            // 
            // lblDersDonemi
            // 
            this.lblDersDonemi.AutoSize = true;
            this.lblDersDonemi.Location = new System.Drawing.Point(12, 199);
            this.lblDersDonemi.Name = "lblDersDonemi";
            this.lblDersDonemi.Size = new System.Drawing.Size(65, 13);
            this.lblDersDonemi.TabIndex = 5;
            this.lblDersDonemi.Text = "DersDonemi";
            // 
            // cbDersDonemi
            // 
            this.cbDersDonemi.FormattingEnabled = true;
            this.cbDersDonemi.Items.AddRange(new object[] {
            "Güz\t",
            "Bahar"});
            this.cbDersDonemi.Location = new System.Drawing.Point(145, 196);
            this.cbDersDonemi.Name = "cbDersDonemi";
            this.cbDersDonemi.Size = new System.Drawing.Size(121, 21);
            this.cbDersDonemi.TabIndex = 6;
            // 
            // txtDersId
            // 
            this.txtDersId.Location = new System.Drawing.Point(145, 47);
            this.txtDersId.Name = "txtDersId";
            this.txtDersId.ReadOnly = true;
            this.txtDersId.Size = new System.Drawing.Size(121, 20);
            this.txtDersId.TabIndex = 7;
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(145, 75);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(121, 20);
            this.txtDersKodu.TabIndex = 8;
            // 
            // txtDersAdı
            // 
            this.txtDersAdı.Location = new System.Drawing.Point(145, 102);
            this.txtDersAdı.Name = "txtDersAdı";
            this.txtDersAdı.Size = new System.Drawing.Size(121, 20);
            this.txtDersAdı.TabIndex = 9;
            // 
            // txtDersKredi
            // 
            this.txtDersKredi.Location = new System.Drawing.Point(145, 129);
            this.txtDersKredi.Name = "txtDersKredi";
            this.txtDersKredi.Size = new System.Drawing.Size(121, 20);
            this.txtDersKredi.TabIndex = 10;
            this.txtDersKredi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDersKredi_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDersEkle,
            this.tsDersKaydet,
            this.tsEdit,
            this.tsDersSil,
            this.tsDersTemizle,
            this.tsOgrenciler,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(399, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsDersEkle
            // 
            this.tsDersEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDersEkle.Image = ((System.Drawing.Image)(resources.GetObject("tsDersEkle.Image")));
            this.tsDersEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDersEkle.Name = "tsDersEkle";
            this.tsDersEkle.Size = new System.Drawing.Size(23, 22);
            this.tsDersEkle.Text = "Ekle";
            this.tsDersEkle.Click += new System.EventHandler(this.tsDersEkle_Click);
            // 
            // tsDersKaydet
            // 
            this.tsDersKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDersKaydet.Image = ((System.Drawing.Image)(resources.GetObject("tsDersKaydet.Image")));
            this.tsDersKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDersKaydet.Name = "tsDersKaydet";
            this.tsDersKaydet.Size = new System.Drawing.Size(23, 22);
            this.tsDersKaydet.Text = "DersKaydet";
            this.tsDersKaydet.Click += new System.EventHandler(this.tsDersKaydet_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsEdit.Image")));
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(23, 22);
            this.tsEdit.Text = "toolStripButton1";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsDersSil
            // 
            this.tsDersSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDersSil.Image = ((System.Drawing.Image)(resources.GetObject("tsDersSil.Image")));
            this.tsDersSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDersSil.Name = "tsDersSil";
            this.tsDersSil.Size = new System.Drawing.Size(23, 22);
            this.tsDersSil.Text = "DersSil";
            this.tsDersSil.Click += new System.EventHandler(this.tsDersSil_Click);
            // 
            // tsDersTemizle
            // 
            this.tsDersTemizle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDersTemizle.Image = ((System.Drawing.Image)(resources.GetObject("tsDersTemizle.Image")));
            this.tsDersTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDersTemizle.Name = "tsDersTemizle";
            this.tsDersTemizle.Size = new System.Drawing.Size(23, 22);
            this.tsDersTemizle.Text = "Temizle";
            this.tsDersTemizle.Click += new System.EventHandler(this.tsDersTemizle_Click);
            // 
            // tsOgrenciler
            // 
            this.tsOgrenciler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOgrenciler.Image = ((System.Drawing.Image)(resources.GetObject("tsOgrenciler.Image")));
            this.tsOgrenciler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOgrenciler.Name = "tsOgrenciler";
            this.tsOgrenciler.Size = new System.Drawing.Size(23, 22);
            this.tsOgrenciler.Text = "Öğrenciler";
            this.tsOgrenciler.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDersKodu,
            this.tsDersAdı,
            this.tsDersKredi,
            this.tsDersNo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 463);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(399, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsDersKodu
            // 
            this.tsDersKodu.Name = "tsDersKodu";
            this.tsDersKodu.Size = new System.Drawing.Size(0, 17);
            // 
            // tsDersAdı
            // 
            this.tsDersAdı.Name = "tsDersAdı";
            this.tsDersAdı.Size = new System.Drawing.Size(0, 17);
            // 
            // tsDersKredi
            // 
            this.tsDersKredi.Name = "tsDersKredi";
            this.tsDersKredi.Size = new System.Drawing.Size(0, 17);
            // 
            // tsDersNo
            // 
            this.tsDersNo.Name = "tsDersNo";
            this.tsDersNo.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lblSınıf
            // 
            this.lblSınıf.AutoSize = true;
            this.lblSınıf.Location = new System.Drawing.Point(12, 162);
            this.lblSınıf.Name = "lblSınıf";
            this.lblSınıf.Size = new System.Drawing.Size(34, 13);
            this.lblSınıf.TabIndex = 13;
            this.lblSınıf.Text = "SINIF";
            // 
            // cbSınıf
            // 
            this.cbSınıf.FormattingEnabled = true;
            this.cbSınıf.Items.AddRange(new object[] {
            "HAZIRLIK",
            "1.SINIF",
            "2.SINIF",
            "3.SINIF",
            "4:SINIF"});
            this.cbSınıf.Location = new System.Drawing.Point(145, 159);
            this.cbSınıf.Name = "cbSınıf";
            this.cbSınıf.Size = new System.Drawing.Size(121, 21);
            this.cbSınıf.TabIndex = 14;
            // 
            // DersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 485);
            this.Controls.Add(this.cbSınıf);
            this.Controls.Add(this.lblSınıf);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtDersKredi);
            this.Controls.Add(this.txtDersAdı);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.txtDersId);
            this.Controls.Add(this.cbDersDonemi);
            this.Controls.Add(this.lblDersDonemi);
            this.Controls.Add(this.lblDersKredi);
            this.Controls.Add(this.lblDersAdı);
            this.Controls.Add(this.lblDersKodu);
            this.Controls.Add(this.lblDersId);
            this.Controls.Add(this.dataders);
            this.Name = "DersForm";
            this.Text = "DersForm";
            this.Load += new System.EventHandler(this.DersForm_load);
            ((System.ComponentModel.ISupportInitialize)(this.dataders)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataders;
        private System.Windows.Forms.Label lblDersId;
        private System.Windows.Forms.Label lblDersKodu;
        private System.Windows.Forms.Label lblDersAdı;
        private System.Windows.Forms.Label lblDersKredi;
        private System.Windows.Forms.Label lblDersDonemi;
        private System.Windows.Forms.ComboBox cbDersDonemi;
        private System.Windows.Forms.TextBox txtDersId;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.TextBox txtDersAdı;
        private System.Windows.Forms.TextBox txtDersKredi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsDersEkle;
        private System.Windows.Forms.ToolStripButton tsDersKaydet;
        private System.Windows.Forms.ToolStripButton tsDersSil;
        private System.Windows.Forms.ToolStripButton tsDersTemizle;
        private System.Windows.Forms.ToolStripButton tsOgrenciler;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsDersKodu;
        private System.Windows.Forms.ToolStripStatusLabel tsDersAdı;
        private System.Windows.Forms.ToolStripStatusLabel tsDersKredi;
        private System.Windows.Forms.ToolStripStatusLabel tsDersNo;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label lblSınıf;
        private System.Windows.Forms.ComboBox cbSınıf;
    }
}
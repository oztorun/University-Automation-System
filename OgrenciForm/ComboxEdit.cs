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
    class Ogrenci
    {
        public string OgrenciAdi
        {
            set;
            get;
        }

        public string OgrenciSoyadi
        {
            get;
            set;
        }

        public string TamAdı
        {
            get
            {
                return OgrenciAdi + "," + OgrenciSoyadi;
            }
        }

        public Ogrenci(string _ogrenciadi,string _ogrencisoyadi)
        {
            OgrenciAdi=_ogrenciadi;
            OgrenciSoyadi=_ogrencisoyadi;
        }
    }

    
}

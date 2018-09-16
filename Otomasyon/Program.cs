using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fintek.App;
using Fintek.App.Data;
using Fintek.Common;
using Oracle.DataAccess.Client;
using Fintek.Facade.fOtomasyon;

namespace Otomasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            
            fOtomasyon f1 = new fOtomasyon();

            //object aaa = null;
            //object bbb = null;
            
            //if (aaa != null)
            //{
            //    string CCCC = "BEN C YİM";
                
            //    if (bbb != null)
            //    {
            //        //SELECT
            //    }
            //}
            //END

            //f1.OgrenciEkle(51315, "yDoozgur"," gCtorun");

            //f1.OgrenciEkle(77, "ozgur", "rrrr");

            //f1.OgrenciGuncelle(51315, "DENEME", "calıs");
            //f1.DersEkle(13, "MAdT101", "Mdatematik", 16, 1);
            //f1.DersSil(12);
            //f1.DersEkle("dasd1", "dsad", 3, "Güz");
           // f1.NotEkle(14, 8, 75, 80, 85, "GEÇTİ");
            //f1.NotGuncelle(14, 8, 70, 70, 70, "GEÇTİ");
           
            f1.NotEkle(15, 13, 55, 65, 60, "GEÇTİ");
        }
    }
}

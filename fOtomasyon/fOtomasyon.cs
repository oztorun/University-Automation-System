using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fintek.App;
using Fintek.App.Data;
using Fintek.Common;
using Oracle.DataAccess.Client;
using Fintek.Entity.eOtomasyon;
using System.Data;

namespace Fintek.Facade.fOtomasyon
{
    public class fOtomasyon
    {
        #region OgrenciIslemler
        public int OgrenciEkle(String ogrenciAdi, string ogrenciSoyadi)
        {
            DB db = new DB();
            int ogrenciNo;
            try
            {
                eOtomasyon otomasyonEntity = new eOtomasyon(db);
                db.BeginTran();

                ogrenciNo = otomasyonEntity.OgrenciEkle(ogrenciAdi, ogrenciSoyadi);

                db.CommitTran();
            }
            catch (AppException)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw new AppException(Hata.Parametrik, new string[] { "Ogrenci eklerken hata meydana geldi" });
            }
            catch (Exception ex)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw;
            }
            return ogrenciNo;
        }

        public int OgrenciGuncelle(int ogrenciNo, string ogrenciAdi, string ogrenciSoyadi)
        {
            DB db=new DB();
            try
            {
            eOtomasyon otomasyonEntity = new eOtomasyon(db); 
            db.BeginTran();
            ogrenciNo=otomasyonEntity.OgrenciGuncelle(ogrenciNo,ogrenciAdi,ogrenciSoyadi);
            db.CommitTran();
        }
            catch (AppException)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw;
            }
            catch (Exception ex)
            {

                if (db.InTransaction)
                    db.RollBackTran();

                throw new AppException(Hata.Parametrik, new string[] { "Ogrenci güncelleme islemi gerçekleştirilemedi" });
        }
            return ogrenciNo;
        }

        public int OgrenciSil(int ogrenciNo)
        {
            DB db = new DB();
            try
            {
                eOtomasyon otomasyonEntity = new eOtomasyon(db);
                db.BeginTran();
                otomasyonEntity.OgrenciSil(ogrenciNo);
                db.CommitTran();
            }

            catch (AppException)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw;
            }
            catch (Exception ex)
            {

                if (db.InTransaction)
                    db.RollBackTran();

                throw new AppException(Hata.Parametrik, new string[] { "Ogrenci silme islemi gerçekleştirilemedi" });
            }
            return ogrenciNo;
        
        }

        public void OgrenciGetir(int ogrenciNo)
        {
            DB db = new DB();

            try
            {
                eOtomasyon otomasyon = new eOtomasyon(db);
                otomasyon.OgrenciGetir(ogrenciNo);
            }
            catch (AppException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "Urun seçme işlemi sırasında hata meydana geldi." }, ex);

            }
        }

        public DataSet OgrenciAllGetir()
        {
            DB db = new DB();

            try
            {
                eOtomasyon OgrenciAllgetir = new eOtomasyon(db);
                return OgrenciAllgetir.OgrenciAllGetir();
            }

            catch(Exception ex)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw new AppException(Hata.Parametrik, new string[] { "Ogrenci getirme gerçekleştirilemedi" });
            }
        }

      


        #endregion

        #region Dersİslemleri
        public int DersEkle(string dersKodu, string dersAdi, int dersKredi,string Sınıf, string dersDonemi)
        {
            DB db = new DB();
            int dersId;
            try
            {
                eOtomasyon otomasyonentity = new eOtomasyon(db);
                db.BeginTran();

                dersId = otomasyonentity.DersEkle(dersKodu, dersAdi, dersKredi, Sınıf, dersDonemi);
                db.CommitTran();
            }
            catch (AppException)
            {
                if (db.InTransaction)
                    db.RollBackTran();

                throw new AppException(Hata.Parametrik, new string[] { "Ders Ekleme İşlemi Başarısız" });
            }
            catch (Exception ex)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw;
            }
            return dersId;
        }

        public int DersGuncelle(int dersId,string dersKodu,string dersAdi,int dersKredi,string Sınıf,string dersDonemi)
        {
            DB db=new DB();
        try 
	    {	        
		
            eOtomasyon otomasyonentity=new eOtomasyon(db);
            db.BeginTran();

            dersId=otomasyonentity.DersGuncelle(dersId,dersKodu,dersAdi,dersKredi,Sınıf,dersDonemi);
            db.CommitTran();
	}
	    catch (AppException)
	{
        if(db.InTransaction)
            db.RollBackTran();
		throw;
	}
    catch(Exception)
        {    
        if(db.InTransaction)
           db.RollBackTran();
        throw;
    }
    return dersId;            
        }

        public int DersSil(int dersId)
        {
            DB db = new DB();

            try
            {
                eOtomasyon otomasyonentity = new eOtomasyon(db);
                db.BeginTran();

                dersId = otomasyonentity.DersSil(dersId);
                db.CommitTran();
            }
            catch (AppException)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw;
            }
            catch (Exception)
            {
                if (db.InTransaction)
                    db.RollBackTran();
            }
            return dersId;
        }

        public DataSet DersAllGetir()
        {
            DB db = new DB();

            try
            {
                eOtomasyon DersAllGetir = new eOtomasyon(db);
                return DersAllGetir.DersAllGetir();
            }

            catch(Exception ex)
            {
                if (db.InTransaction)
                    db.RollBackTran();

                throw new AppException(Hata.Parametrik,new string[] {"Ders Getirme gerçekleşmedi"});
            }
        }
#endregion

        #region OGRENCIDerSİşlemleri

        public int NotEkle(int ogrenciNo, int dersId, int oVize, int oFinal, double oBasariNotu, string dersDurumu)
        {
            DB db = new DB();

            try
            {
                eOtomasyon otomasyon = new eOtomasyon(db);
                db.BeginTran();
                ogrenciNo = otomasyon.NotEkle(ogrenciNo,dersId, oVize, oFinal, oBasariNotu, dersDurumu);
                db.CommitTran();
            }
            catch (AppException)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw new AppException(Hata.Parametrik, new string[] { "Not Ekleme İşlemi Başarısız" });
            }
            catch (Exception ex)
            {
                if (db.InTransaction) ;
                db.RollBackTran();
                throw;
            }
            return ogrenciNo;
        }

        public int NotGuncelle(int ogrenciNo, int dersId, int oVize, int oFinal, double oBasariNotu, string dersDurumu)
        {
            DB db = new DB();

            try
            {
                eOtomasyon otomasyon = new eOtomasyon(db);
                db.BeginTran();
                ogrenciNo = otomasyon.NotGuncelle(ogrenciNo, dersId, oVize, oFinal, oBasariNotu, dersDurumu);
                db.CommitTran();
            }
            catch (AppException)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw;
            }
            catch (Exception)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw;
            }
            return ogrenciNo;
        }

        public int NotSil(int ogrenciNo,int dersId)
        {
            DB db = new DB();

            try
            {
                eOtomasyon otomasyon = new eOtomasyon(db);
                db.BeginTran();

                ogrenciNo = otomasyon.NotSil(ogrenciNo,dersId);
                db.CommitTran();
            }
            catch (AppException)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw;
            }
            catch (Exception)
            {
                if (db.InTransaction)
                    db.RollBackTran();
            }
           
            return ogrenciNo;
        }

        public DataSet NotAllGetir(int ogrenciNo,int dersId)
        {
            DB db = new DB();

            try
            {
                eOtomasyon NotAllGetir = new eOtomasyon(db);
                return NotAllGetir.NotAllGetir(ogrenciNo, dersId);
            }
            catch (Exception ex)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw new AppException(Hata.Parametrik,new string[]{"NOT Getirme İşlemi Başarısız ! "},ex);
            }
        }

        #endregion
       
        public DataSet HesapGetir(string KullaniciAdi)
        {
            DB db = new DB();

            try
            {
                eOtomasyon otomasyon = new eOtomasyon(db);
                return otomasyon.HesapGetir(KullaniciAdi);
            }
            catch (Exception ex)
            {
                if (db.InTransaction)
                    db.RollBackTran();
                throw new AppException(Hata.Parametrik, new string[] { "Hesap işlemi başarısız" }, ex);
            }
        }
    }
}

 

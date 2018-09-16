using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Fintek.App;
using Fintek.App.Data;
using Fintek.Common;
using Oracle.DataAccess.Client;

namespace Fintek.Entity.eOtomasyon
{
    public class eOtomasyon
    {
        private DB m_DataLayer;

        public eOtomasyon(DB db)
        {
            m_DataLayer = db;
        }

        #region OGRENCI
        //ÖĞRENCİ İŞLEMLERİ
        public int OgrenciEkle(string ogrenciAdi, string ogrenciSoyadi)
        {
            int OgrenciNoResult;
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("p_OgrenciNo", OracleDbType.Decimal, ParameterDirection.Output));
                parameterList.Add(new OracleParameter("p_OgrenciAdi", ogrenciAdi));
                parameterList.Add(new OracleParameter("p_OgrenciSoyadi", ogrenciSoyadi));
                m_DataLayer.ExecNonQuery("PLSQL_INS_OGRENCI_SP", parameterList.ToArray());
                OgrenciNoResult = Convert.ToInt32(parameterList[0].Value.ToString());
            }
            catch (DLException dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "Ogrenci ekleme işlemi sırasında hata meydana geldi" }, dlex);

            }
            return OgrenciNoResult;
        }

        public int OgrenciSil(int ogrenciNo)
        {
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("p_OgrenciNo", ogrenciNo));
                m_DataLayer.ExecNonQuery("PLSQL_DEL_OGRENCI_SP", parameterList.ToArray());

            }

            catch (DLException dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "ogrenci silme işlemi sırasında hata meydana geldi" }, dlex);
            }

            catch (Exception ex)
            {

            }
            return 0;
        }

        public int OgrenciGuncelle(int ogrenciNo, string ogrenciAdi, string ogrenciSoyadi)
        {
            try
            {

                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("p_OgrenciNo", ogrenciNo));
                parameterList.Add(new OracleParameter("p_OgrenciAdi", ogrenciAdi));
                parameterList.Add(new OracleParameter("p_OgrenciSoyadi", ogrenciSoyadi));



                m_DataLayer.ExecNonQuery("PLSQL_UPD_OTOMASYON_OGRENCI_SP", parameterList.ToArray());
            }
            catch (DLException dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "ogrenci guncelleme işlemi sırasında hata meydana geldi" }, dlex);
            }
            return 0;
        }

        public DataSet OgrenciGetir(int OgrenciNo)
        {
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("p_OgrenciNo", OgrenciNo));
                return m_DataLayer.ExecDataSet("PLSQL_SEL_OGRENCI_SP", parameterList.ToArray());
            }

            catch (Exception dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "ogrenci secme işlemi gerçekleştirilemedi" }, dlex);

            }

        }

        public DataSet OgrenciAllGetir()
        {
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("RC1", OracleDbType.RefCursor, ParameterDirection.InputOutput));
                return m_DataLayer.ExecDataSet("PLSQL_SEL_OGRENCIALL_SP", parameterList.ToArray());
            }
            catch (Exception dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "Öğrenciler yüklenemedi" }, dlex);
            }
        }

        #endregion

        #region DERS
        public int DersEkle(string dersKodu, string dersAdi, int dersKredi,string Sınıf, string dersDonemi)
        {
            int dersIdResult;
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("p_DersId", OracleDbType.Decimal, ParameterDirection.Output));
                parameterList.Add(new OracleParameter("p_DersKodu", dersKodu));
                parameterList.Add(new OracleParameter("p_DersAdi", dersAdi));
                parameterList.Add(new OracleParameter("p_DersKredi", dersKredi));
                parameterList.Add(new OracleParameter("p_Sınıf", Sınıf));
                parameterList.Add(new OracleParameter("p_DersDonemi", dersDonemi));
                m_DataLayer.ExecNonQuery("PLSQL_INS_DERS_SP", parameterList.ToArray());
                dersIdResult = Convert.ToInt32(parameterList[0].Value.ToString());
            }
            catch (DLException dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "Ders Ekleme İşlemi Başarısız" }, dlex);
            }
            return dersIdResult;
        }

        public int DersGuncelle(int dersId, string dersKodu, string dersAdi, int dersKredi,string Sınıf, string dersDonemi)
        {
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("p_DersId", dersId));
                parameterList.Add(new OracleParameter("p_DersKodu", dersKodu));
                parameterList.Add(new OracleParameter("p_DersAdi", dersAdi));
                parameterList.Add(new OracleParameter("p_DersKredi", dersKredi));
                parameterList.Add(new OracleParameter("p_Sınıf", Sınıf));
                parameterList.Add(new OracleParameter("p_DersDonemi", dersDonemi));
                m_DataLayer.ExecNonQuery("PLSQL_UPD_DERS_SP", parameterList.ToArray());
                return dersId;
            }
            catch (DLException dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "Ders Güncelleme İşlemi Başarısız" }, dlex);
            }
        }

        public int DersSil(int dersId)
        {
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("p_DersId", dersId));
                m_DataLayer.ExecNonQuery("PLSQL_DEL_DERS_SP", parameterList.ToArray());
                return dersId;
            }
            catch (DLException dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "Ders Silme İşlemi Başarısız" }, dlex);
            }
        }
        public DataSet DersAllGetir()
        {
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("RC1", OracleDbType.RefCursor, ParameterDirection.InputOutput));
                return m_DataLayer.ExecDataSet("PLSQL_SEL_DERSALL_SP", parameterList.ToArray());
            }
            catch (Exception dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "Dersler yüklenemedi" }, dlex);
            }
        }

        #endregion

        #region OGRENCİDERS
        public int NotEkle(int ogrenciNo, int dersId, int oVize, int oFinal, double oBasariNotu, string dersDurumu)
        {
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("p_OgrenciNo", ogrenciNo));
                parameterList.Add(new OracleParameter("p_DersId", dersId));
                parameterList.Add(new OracleParameter("p_OVize", oVize));
                parameterList.Add(new OracleParameter("p_OFinal", oFinal));
                parameterList.Add(new OracleParameter("p_OBasariNotu", oBasariNotu));
                parameterList.Add(new OracleParameter("p_ODersDurumu", dersDurumu));
                m_DataLayer.ExecNonQuery("PLSQL_INS_OGRENCIDERS_SP", parameterList.ToArray());
                return ogrenciNo;
            }
            catch (DLException dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "Not Ekleme İşlemi Başarısız" }, dlex);
            }
        }

        public int NotGuncelle(int ogrenciNo, int dersId, int oVize, int oFinal, double oBasariNotu, string dersDurumu)
        {
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("p_OgrenciNo", ogrenciNo));
                parameterList.Add(new OracleParameter("p_DersId", dersId));
                parameterList.Add(new OracleParameter("p_OVize", oVize));
                parameterList.Add(new OracleParameter("p_OFinal", oFinal));
                parameterList.Add(new OracleParameter("p_OBasariNotu", oBasariNotu));
                parameterList.Add(new OracleParameter("p_ODersDurumu", dersDurumu));
                m_DataLayer.ExecNonQuery("PLSQL_UPD_OGRENCIDERS_SP", parameterList.ToArray());
                return ogrenciNo;
            }
            catch (DLException dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "Not Güncelleme İşlemi Başarısız" }, dlex);
            }
        }

        public int NotSil(int ogrenciNo,int dersId)
        {
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("p_OgrenciNo", ogrenciNo));
                parameterList.Add(new OracleParameter("p_DersId", dersId));

                m_DataLayer.ExecNonQuery("PLSQL_DEL_OGRENCIDERS_SP", parameterList.ToArray());
                return ogrenciNo;

            }
            catch (DLException dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "Not Silme İşlemi Başarısız" }, dlex);
            }
        }

        public DataSet NotAllGetir(int ogrenciNo, int dersId)
        {
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("RC1", OracleDbType.RefCursor, ParameterDirection.InputOutput));
                parameterList.Add(new OracleParameter("p_ogrenciNo", ogrenciNo));
                parameterList.Add(new OracleParameter("p_DersID", dersId));
                return m_DataLayer.ExecDataSet("PLSQL_SEL_ALLOGRENCIDERS_SP", parameterList.ToArray());
            }
            catch (Exception dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "Notları Getirme İşlemi Başarısız" }, dlex);
            }
        }

        #endregion

        public DataSet HesapGetir(string KullaniciAdi)
        {
            try
            {
                List<OracleParameter> parameterList = new List<OracleParameter>();
                parameterList.Add(new OracleParameter("p_KullaniciAdi", KullaniciAdi));
                parameterList.Add(new OracleParameter("RC1", OracleDbType.RefCursor, ParameterDirection.InputOutput));
                return m_DataLayer.ExecDataSet("PLSQL_SEL_ACCOUNT_SP", parameterList.ToArray());
            }
            catch (DLException dlex)
            {
                throw new AppException(Hata.Parametrik, new string[] { "Kullanıcı Hesabı hatası" }, dlex);
            }

        }
    }
}


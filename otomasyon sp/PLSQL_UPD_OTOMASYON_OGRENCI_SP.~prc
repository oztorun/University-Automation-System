CREATE OR REPLACE PROCEDURE PLSQL_UPD_OTOMASYON_OGRENCI_SP
(
   p_OgrenciNo     IN plsql_ogrenci.ogrencino%TYPE,
   p_OgrenciAdi    IN plsql_ogrenci.ogrenciadi%TYPE,
   p_OgrenciSoyadi IN plsql_ogrenci.ogrencisoyadi%TYPE
)

 AS
BEGIN

   UPDATE plsql_ogrenci S
      SET S.OgrenciNo     = p_OgrenciNo,
          S.OgrenciAdi    = p_OgrenciAdi,
          S.OgrenciSoyadi = p_OgrenciSoyadi
   
    WHERE S.OgrenciNo = p_OgrenciNo;
END PLSQL_UPD_OTOMASYON_OGRENCI_SP;
/

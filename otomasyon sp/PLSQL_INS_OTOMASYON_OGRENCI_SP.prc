--ýnsert SP 

CREATE OR REPLACE PROCEDURE PLSQL_INS_OTOMASYON_OGRENCI_SP
(
   p_OgrenciNo     IN plsql_ogrenci.ogrencino%TYPE,
   p_OgrenciAdi    IN plsql_ogrenci.ogrenciadi%TYPE,
   p_OgrenciSoyadi IN plsql_ogrenci.ogrencisoyadi%TYPE
)

 AS
BEGIN

   INSERT INTO plsql_ogrenci
      (ogrencino,
       ogrenciadi,
       ogrencisoyadi)
   
   VALUES
      (p_OgrenciNo,
       p_OgrenciAdi,
       p_OgrenciSoyadi);

END PLSQL_INS_OTOMASYON_OGRENCI_SP;
/

CREATE OR REPLACE PROCEDURE PLSQL_INS_OGRENCI_SP
(
   p_OgrenciNo     OUT plsql_ogrenci.ogrencino%TYPE,
   p_OgrenciAdi    IN plsql_ogrenci.ogrenciadi%TYPE,
   p_OgrenciSoyadi IN plsql_ogrenci.ogrencisoyadi%TYPE
)

 IS
   v_OgrenciNo plsql_ogrenci.ogrencino%TYPE;

BEGIN
   SELECT PLSQL_OGRENCI_SEQ.nextval
     INTO v_OgrenciNo
     FROM dual;

   INSERT INTO plsql_ogrenci
      (ogrencino,
       ogrenciadi,
       ogrencisoyadi,
       statusind)
   
   VALUES
      (v_OgrenciNo,
       p_OgrenciAdi,
       p_OgrenciSoyadi,
       1);

   p_OgrenciNo := v_OgrenciNo;
END PLSQL_INS_OGRENCI_SP;
/

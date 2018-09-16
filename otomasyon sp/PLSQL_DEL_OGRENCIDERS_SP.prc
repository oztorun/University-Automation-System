CREATE OR REPLACE PROCEDURE PLSQL_DEL_OGRENCIDERS_SP
(
   p_OgrenciNo IN plsql_ogrenciders.ogrencino%TYPE,
   p_DersId    IN plsql_ogrenciders.dersid%TYPE
) IS
BEGIN

   UPDATE plsql_ogrenciders ss
      SET ss.dersid    = 0,
          ss.ogrencino = 0
    WHERE ss.dersid = p_DersId
      AND ss.ogrencino = p_OgrenciNo;

END PLSQL_DEL_OGRENCIDERS_SP;
/

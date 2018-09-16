CREATE OR REPLACE PROCEDURE PLSQL_UPD_OGRENCIDERS_SP
(
   p_OgrenciNo   IN plsql_ogrenciders.OgrenciNo%TYPE,
   p_DersId      IN plsql_ogrenciders.DersId%TYPE,
   p_OVize       IN plsql_ogrenciders.OVize%TYPE,
   p_OFinal      IN plsql_ogrenciders.OFinal%TYPE,
   p_OBasariNotu IN plsql_ogrenciders.OBasariNotu%TYPE,
   p_ODersDurumu IN plsql_ogrenciders.odersdurumu%TYPE
)

 AS
BEGIN

   UPDATE plsql_ogrenciders s
      SET s.ogrencino   = p_OgrenciNo,
          s.dersid      = p_DersId,
          s.ovize       = p_OVize,
          s.ofinal      = p_OFinal,
          S.obasarinotu = p_OBasariNotu,
          s.odersdurumu = p_ODersDurumu
   
    WHERE s.ogrencino = p_OgrenciNo
      AND s.dersid = p_DersId;

END PLSQL_UPD_OGRENCIDERS_SP;
/

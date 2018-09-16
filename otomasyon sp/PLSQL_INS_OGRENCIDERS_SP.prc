CREATE OR REPLACE PROCEDURE PLSQL_INS_OGRENCIDERS_SP
(
   p_OgrenciNo   IN plsql_ogrenciders.ogrencino%TYPE,
   p_DersId      IN plsql_ogrenciders.dersid%TYPE,
   p_OVize       IN plsql_ogrenciders.ovize%TYPE,
   p_OFinal      IN plsql_ogrenciders.ofinal%TYPE,
   p_OBasariNotu IN plsql_ogrenciders.obasarinotu%TYPE,
   p_ODersDurumu IN plsql_ogrenciders.odersdurumu%TYPE
)

 AS
BEGIN
   INSERT INTO plsql_ogrenciders
      (ogrencino,
       dersid,
       ovize,
       ofinal,
       obasarinotu,
       odersdurumu)
   
   VALUES
   
      (p_OgrenciNo,
       p_DersId,
       p_OVize,
       p_OFinal,
       p_OBasariNotu,
       p_ODersDurumu);

END PLSQL_INS_OGRENCIDERS_SP;
/

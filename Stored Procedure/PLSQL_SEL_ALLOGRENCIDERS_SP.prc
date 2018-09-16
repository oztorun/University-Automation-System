CREATE OR REPLACE PROCEDURE PLSQL_SEL_ALLOGRENCIDERS_SP
(
   p_OgrenciNo IN Plsql_Ogrenci.Ogrencino%TYPE,
   p_DersId    IN PLSQL_DERS.Dersid%TYPE,
   RC1         OUT SYS_REFCURSOR
) AS
BEGIN
   IF p_OgrenciNo IS NOT NULL AND p_DersId IS NOT NULL THEN
      OPEN RC1 FOR
         SELECT ogrenciders.ogrencino   "ÖÐRENCÝNO",
                ders.dersid             "DERSID",
                ogrenciders.ovize       "VÝZENOTU",
                ogrenciders.ofinal      "FÝNALNOTU",
                ogrenciders.obasarinotu "BASARINOTU",
                ogrenciders.odersdurumu "GECMEDURUMU"
           FROM PLSQL_OGRENCIDERS ogrenciders
          INNER JOIN PLSQL_OGRENCI ogrenci
             ON ogrenci.ogrencino = ogrenciders.ogrencino
          INNER JOIN PLSQL_DERS ders
             ON ders.dersid = ogrenciders.dersid
          WHERE ogrenciders.statusind = 1
            AND ogrenci.ogrencino = p_OgrenciNo
            AND ders.dersid = p_DersId;
   
   ELSE
      OPEN RC1 FOR
         SELECT ogrenciders.ogrencino,
                ogrenciders.ovize,
                ogrenciders.ofinal,
                ogrenciders.obasarinotu,
                ogrenciders.odersdurumu,
                ogrenci.ogrencino,
                ders.dersid
           FROM PLSQL_OGRENCIDERS ogrenciders
          INNER JOIN PLSQL_OGRENCI ogrenci
             ON ogrenci.ogrencino = ogrenciders.ogrencino
          INNER JOIN PLSQL_DERS ders
             ON ders.dersid = ogrenciders.dersid
          WHERE ogrenciders.statusind = 1;
   END IF;
END PLSQL_SEL_ALLOGRENCIDERS_SP;
/

CREATE OR REPLACE PROCEDURE PLSQL_UPD_DERS_SP
(
   p_DersId     IN plsql_ders.dersid%TYPE,
   p_DersKodu   IN plsql_ders.derskodu%TYPE,
   p_DersAdi    IN plsql_ders.dersadi%TYPE,
   p_DersKredi  IN plsql_ders.derskredi%TYPE,
   p_Sýnýf    IN plsql_ders.sinif%TYPE,
   p_DersDonemi IN plsql_ders.dersdonemi%TYPE
)

 AS
BEGIN

   UPDATE plsql_ders a
   
      SET a.derskodu   = p_DersKodu,
          a.dersadi    = p_DersAdi,
          a.derskredi  = p_DersKredi,
          a.sinif      = p_Sýnýf,
          a.dersdonemi = p_DersDonemi
   
    WHERE a.dersid = p_dersid;

END PLSQL_UPD_DERS_SP;
/

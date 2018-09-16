CREATE OR REPLACE PROCEDURE PLSQL_INS_DERS_SP
(
   p_DersId     OUT plsql_ders.dersid%TYPE,
   p_DersKodu   IN plsql_ders.derskodu%TYPE,
   p_DersAdi    IN plsql_ders.dersadi%TYPE,
   p_DersKredi  IN plsql_ders.derskredi%TYPE,
   p_DersDonemi IN plsql_ders.dersdonemi%TYPE
   
)

 IS
   v_DersId plsql_ders.dersid%TYPE;

BEGIN
   SELECT plsql_ders_seq.nextval
     INTO v_DersId
     FROM dual;

   INSERT INTO plsql_ders
      (dersid,
       derskodu,
       dersadi,
       derskredi,
       dersdonemi,
       statusind)
   
   VALUES
      (v_DersId,
       p_DersKodu,
       p_DersAdi,
       p_DersKredi,
       p_DersDonemi,
       1);

   p_DersId := v_DersId;

END PLSQL_INS_DERS_SP;
/

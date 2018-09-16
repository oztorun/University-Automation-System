CREATE OR REPLACE PROCEDURE PLSQL_DEL_DERS_SP(p_DersId IN plsql_ders.dersid%TYPE)

 IS
BEGIN
   UPDATE plsql_ders ss
      SET ss.dersid = 0
    WHERE ss.dersid = p_DersId;

END PLSQL_DEL_DERS_SP;
/

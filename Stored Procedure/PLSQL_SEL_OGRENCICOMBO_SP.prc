CREATE OR REPLACE PROCEDURE PLSQL_SEL_OGRENCICOMBO_SP
(
   p_OgrenciNo IN PLSQL_OGRENCI.OGRENCINO%TYPE,
   RC1         OUT SYS_REFCURSOR
) AS
BEGIN
   OPEN RC1 FOR
      SELECT o.OGRENCINO
        FROM PLSQL_OGRENCI o
       WHERE o.OGRENCINO = p_OgrenciNo
         AND o.statusind = 1;

END PLSQL_SEL_OGRENCICOMBO_SP;
/

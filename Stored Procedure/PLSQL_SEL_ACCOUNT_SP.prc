CREATE OR REPLACE PROCEDURE PLSQL_SEL_ACCOUNT_SP
(
   p_KullaniciAdi IN plsql_account.kullaniciadi%TYPE,
   RC1            OUT SYS_REFCURSOR
) AS
BEGIN
   OPEN RC1 FOR
      SELECT s.KULLANICIADI,
             s.PAROLA
        FROM PLSQL_ACCOUNT s
       WHERE s.KULLANICIADI = p_KullaniciAdi
         AND s.STATUSIND = 1;

END PLSQL_SEL_ACCOUNT_SP;
/

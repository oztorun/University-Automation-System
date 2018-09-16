CREATE OR REPLACE PROCEDURE PLSQL_INS_ACCOUNT_SP
(
   p_KullaniciAdi IN plsql_account.kullaniciadi%TYPE,
   p_Parola       IN plsql_account.parola%TYPE
) AS
BEGIN
   INSERT INTO plsql_account
      (kullaniciadi,
       parola)
   VALUES
      (p_KullaniciAdi,
       p_Parola);

END PLSQL_INS_ACCOUNT_SP;
/

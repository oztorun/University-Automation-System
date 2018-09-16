  CREATE OR REPLACE PROCEDURE PLSQL_DEL_OGRENCI_SP(p_OgrenciNo IN plsql_ogrenci.ogrencino%TYPE)
  
   IS
  BEGIN
     UPDATE plsql_ogrenci s
        SET s.statusind = 0
      WHERE s.ogrencino = p_OgrenciNo;
  
  END PLSQL_DEL_OGRENCI_SP;
/

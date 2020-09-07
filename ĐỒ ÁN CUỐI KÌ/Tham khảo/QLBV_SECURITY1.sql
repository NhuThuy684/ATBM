------------------ Tao user ---------------------
CREATE USER NV1512001 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512001;
CREATE USER NV1512002 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512002;
CREATE USER NV1512003 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512003;
CREATE USER NV1512004 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512004;
CREATE USER NV1512005 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512005;
CREATE USER NV1512006 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512006;
CREATE USER NV1512007 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512007;
CREATE USER NV1512008 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512008;
CREATE USER NV1512009 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512009;
CREATE USER NV1512010 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512010;
CREATE USER NV1512011 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512011;
CREATE USER NV1512012 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512012;
CREATE USER NV1512013 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512013;
CREATE USER NV1512014 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512014;
CREATE USER NV1512015 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512015;
CREATE USER NV1512016 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512016;
CREATE USER NV1512017 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512017;
CREATE USER NV1512018 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512018;
CREATE USER NV1512019 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512019;
CREATE USER NV1512020 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512020;
CREATE USER NV1512021 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512021;
CREATE USER NV1512022 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512022;
CREATE USER NV1512023 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512023;
CREATE USER NV1512024 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512024;
CREATE USER NV1512025 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512025;
CREATE USER NV1512026 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512026;
CREATE USER NV1512027 IDENTIFIED BY 123456;
GRANT CREATE SESSION TO NV1512027;
------------------ Tao role ---------------------
CREATE ROLE QLTAINGUYEN_NHANSU;
CREATE ROLE QLTAIVU;
CREATE ROLE QLCHUYENMON;
CREATE ROLE TIEPTAN;
CREATE ROLE NVTAIVU;
CREATE ROLE BACSI;
CREATE ROLE KYTHUATVIEN;
CREATE ROLE BANTHUOC;
CREATE ROLE KETOAN;
CREATE ROLE NHANVIEN; -- gán cho t?t c? user
-- quan ly --
GRANT NHANVIEN TO NV1512001;
GRANT QLTAINGUYEN_NHANSU TO NV1512001;
GRANT NHANVIEN TO NV1512002;
GRANT QLTAIVU TO NV1512002;
GRANT NHANVIEN TO NV1512003;
GRANT QLCHUYENMON TO NV1512003;
-- tiep tan --
GRANT NHANVIEN TO NV1512004;
GRANT NHANVIEN TO NV1512005;
GRANT NHANVIEN TO NV1512006;
GRANT NHANVIEN TO NV1512007;
GRANT NHANVIEN TO NV1512008;
GRANT TIEPTAN TO NV1512004, NV1512005, NV1512006, NV1512007, NV1512008;
-- NV tai vu --
GRANT NHANVIEN TO NV1512009;
GRANT NHANVIEN TO NV1512010;
GRANT NHANVIEN TO NV1512011;
GRANT NHANVIEN TO NV1512012;
GRANT NHANVIEN TO NV1512013;
GRANT NVTAIVU TO NV1512009, NV1512010, NV1512011, NV1512012, NV1512013;
-- bac si --
GRANT NHANVIEN TO NV1512014;
GRANT NHANVIEN TO NV1512015;
GRANT NHANVIEN TO NV1512016;
GRANT NHANVIEN TO NV1512017;
GRANT NHANVIEN TO NV1512018;
GRANT BACSI TO NV1512014, NV1512015, NV1512016, NV1512017, NV1512018;
--  ky thuat vien --
GRANT NHANVIEN TO NV1512019;
GRANT NHANVIEN TO NV1512020;
GRANT NHANVIEN TO NV1512021;
GRANT KYTHUATVIEN TO NV1512019, NV1512020, NV1512021;
-- ban thuoc --
GRANT NHANVIEN TO NV1512022;
GRANT NHANVIEN TO NV1512023;
GRANT NHANVIEN TO NV1512024;
GRANT BANTHUOC TO NV1512022, NV1512023, NV1512024;
-- ke toan --
GRANT NHANVIEN TO NV1512025;
GRANT NHANVIEN TO NV1512026;
GRANT NHANVIEN TO NV1512027;
GRANT KETOAN TO NV1512025, NV1512026, NV1512027;
-------------------- PHAN HE 1 ----------------------
--1.2 Xem danh sách các user
select  username from DBA_USERS where account_status = 'OPEN';
--1.3 Xem danh sách các table c?a user hi?n hành (QLBV), Xem danh sách các role
select  table_name  from all_tables  where  owner = 'QLBV';
select  role from  DBA_ROLES  where  common = 'NO';
-- 1.4 Thêm m?i ??i t??ng, role
CREATE USER NV1512003 IDENTIFIED BY 123456;
--GRANT CREATE SESSION TO NV1512001;
CREATE ROLE QLCHUYENMON;
-- 1.5 Phân/l?y quy?n c?a user
GRANT SELECT(TENTHUOC)  ON THUOC TO NV1512003;
REVOKE SELECT(TENTHUOC)  ON THUOC FROM NV1512003;
GRANT INSERT ON DICHVU TO NV1512003;
REVOKE  INSERT ON DICHVU FROM NV1512003;
GRANT SELECT ON DICHVU TO NV1512003 WITH GRANT OPTION;
-- Phân/l?y quy?n c?a role
GRANT SELECT ON THUOC TO QLCHUYENMON;
REVOKE SELECT ON THUOC FROM QLCHUYENMON;
GRANT SELECT(TENDV) ON DICHVU TO QLCHUYENMON;
REVOKE  SELECT(TENDV) ON DICHVU FROM QLCHUYENMON;
GRANT INSERT ON THUOC TO QLCHUYENMON WITH GRANT OPTION;
-------------------- PHAN HE 2 ----------------------
--------------------ROLE NHAN VIEN --------------------
-- nhân viên duoc truy xuat danh sách phòng ban, cham công
GRANT SELECT ON PHONGBAN TO NHANVIEN;
GRANT SELECT ON CHAMCONG TO NHANVIEN;
GRANT SELECT ON NHANVIEN TO NHANVIEN;
-- nhân viên (tru ke toan, quan ly tai nguyen & nhan su) duoc truy xuat danh sách nhân viên nhung chi duoc xem luong cua mình
CREATE OR REPLACE FUNCTION FUNCTION1(
p_schema varchar2,
p_obj varchar2 )
return varchar2
as
  user varchar2(100);
begin
  user := SYS_CONTEXT('userenv','session_user');
  if ( SYS_CONTEXT('userenv','ISDBA') = 'TRUE' ) then
    return '';
  else
   if (user = 'QLBV' or user = 'NV1512025' or user = 'NV1512026' or user = 'NV1512027' or user = 'NV1512001') then
      return '';
    else
      user := substr(user,3);
      return 'MANV = ''' || user || '''';
    end if;
  end if;
end;
SELECT FUNCTION1('QLBV','NHANVIEN') PREDICATE FROM DUAL;
BEGIN dbms_rls.add_policy (
  object_schema => 'QLBV',
  object_name => 'NHANVIEN',
  policy_name => 'policy1',
  function_schema => 'QLBV',
  policy_function => 'FUNCTION1',
  statement_types => 'select',
  sec_relevant_cols => 'luong,matkhau',
  sec_relevant_cols_opt => dbms_rls.ALL_ROWS);
END;
----------------- ROLE QLTAINGUYEN_NHANSU --------------------
GRANT SELECT ON THUOC TO NV1512003;
REVOKE SELECT ON THUOC FROM NV1512003;
GRANT SELECT(TENDV) ON DICHVU TO NV1512003;
REVOKE  SELECT(TENDV) ON DICHVU FROM NV1512003;
GRANT INSERT ON THUOC TO NV1512003 WITH GRANT OPTION;

GRANT SELECT ON THUOC TO QLCHUYENMON;
REVOKE SELECT ON THUOC FROM QLCHUYENMON;
GRANT SELECT(TENDV) ON DICHVU TO QLCHUYENMON;
REVOKE  SELECT(TENDV) ON DICHVU FROM QLCHUYENMON;
GRANT INSERT ON THUOC TO QLCHUYENMON WITH GRANT OPTION;

-- quan ly tai nguyen nhan su duoc xem, them, xoa, sua table phongban,chamcong
GRANT SELECT,INSERT,UPDATE,DELETE ON PHONGBAN TO QLTAINGUYEN_NHANSU;
GRANT SELECT,INSERT,UPDATE,DELETE ON CHAMCONG TO QLTAINGUYEN_NHANSU;
----------------- ROLE QLTAIVU --------------------
-- quan ly tai vu duoc insert, update c?t giá trong table dichvu va thuoc.
GRANT INSERT, UPDATE (GIADV) ON DICHVU TO QLTAIVU;
GRANT SELECT ON DICHVU TO QLTAIVU;
GRANT INSERT, UPDATE (GIATHUOC) ON THUOC TO QLTAIVU;
GRANT SELECT ON THUOC TO QLTAIVU;
----------------- ROLE QLCHUYENMON --------------------
-- quan ly chuyen mon duoc xem tat cac cac table
GRANT SELECT ON PHIEUKHAM TO QLCHUYENMON;
GRANT SELECT ON DICHVU TO QLCHUYENMON;
GRANT SELECT ON PK_DV TO QLCHUYENMON;
GRANT SELECT ON THUOC TO QLCHUYENMON;
GRANT SELECT ON PK_THUOC TO QLCHUYENMON;
----------------- ROLE TIEPTAN --------------------
-- tiep tan duoc select, insert, delete, update table benhnhan
GRANT SELECT,INSERT,UPDATE,DELETE ON BENHNHAN TO TIEPTAN;
-- tiep tan duoc tao phieu kham
GRANT INSERT ON PHIEUKHAM TO TIEPTAN;
-- tiep tan duoc select, update tren cot mapk, mabn, mabs, ngaykham cua table phieu kham
GRANT SELECT,UPDATE (MAPK,MABN,MABS,NGAYKHAM) ON PHIEUKHAM TO TIEPTAN;
----------------- ROLE NVTAIVU --------------------
-- nv tai vu duoc select dichvu, pk_dv, thuoc, pk_thuoc
GRANT SELECT ON DICHVU TO NVTAIVU;
GRANT SELECT ON PK_DV TO NVTAIVU;
GRANT SELECT ON THUOC TO NVTAIVU;
GRANT SELECT ON PK_THUOC TO NVTAIVU;
-- nv tai vu duoc update cot trangthai,vienphi cua table phieukham
GRANT UPDATE(TRANGTHAI,VIENPHI) ON PHIEUKHAM TO NVTAIVU;
GRANT UPDATE (name) ON salapati.xyz TO myrole;
----------------- ROLE BACSI --------------------
-- bác si duoc truy xuat danh sách thuoc
GRANT SELECT ON THUOC TO BACSI;
-- bác si duoc truy xuat danh sách dich vu
GRANT SELECT ON DICHVU TO BACSI;
-- bac si chi xem dc thong tin phieu kham cua minh dieu tri
grant SELECT ON PHIEUKHAM to BACSI
grant update(trieuchung,chuandoan,motathem) on phieukham to bacsi
CREATE OR REPLACE FUNCTION FUNCTION2(
p_schema varchar2,
p_obj varchar2 )
return varchar2
as
  user varchar2(100);
  temp varchar2(100);
begin
  user := SYS_CONTEXT('userenv','session_user');
  if ( SYS_CONTEXT('userenv','ISDBA') = 'TRUE' ) then
    return '';
  else
   if (user = 'QLBV' or user = 'NV1512004' or user = 'NV1512005' or user = 'NV1512006' or user = 'NV1512007' or user = 'NV1512008' or user = 'NV1512003') then
      return '';
    else
      user := substr(user,3);
      return 'MABS = ''' || user || '''';
    end if;
  end if;
end;
BEGIN dbms_rls.add_policy (
  object_schema => 'QLBV',
  object_name => 'PHIEUKHAM',
  policy_name => 'policy2',
  function_schema => 'QLBV',
  policy_function => 'FUNCTION2',
  statement_types => 'select');
END;
-- bac si chi duoc chinh sua cot trieuchung, chuandoan, motathem trong phieukham ma minh duoc phan cong
CREATE OR REPLACE FUNCTION FUNCTION4(
p_schema varchar2,
p_obj varchar2 )
return varchar2
as
  user varchar2(100);
begin
  user := SYS_CONTEXT('userenv','session_user');
  if ( SYS_CONTEXT('userenv','ISDBA') = 'TRUE' ) then
    return '';
  else
   if (user = 'QLBV' or user = 'NV1512009' or user = 'NV1512010' or user = 'NV1512011' or user = 'NV1512012' or user = 'NV1512013') then
      return '';
    else
      user := substr(user,3);
      return 'MABS = ''' || user || '''';
    end if;
  end if;
end;
BEGIN dbms_rls.add_policy (
  object_schema => 'QLBV',
  object_name => 'PHIEUKHAM',
  policy_name => 'policy4',
  function_schema => 'QLBV',
  policy_function => 'FUNCTION4',
  statement_types => 'update',
  update_check => true);
END;
-- bac si chi duoc xem thong tin benh nhan cua minh dieu tri
GRANT SELECT, UPDATE ON PHIEUKHAM TO BACSI
GRANT SELECT ON BENHNHAN TO BACSI
--
CREATE OR REPLACE FUNCTION FUNCTION3(
p_schema varchar2,
p_obj varchar2 )
return varchar2
as
  user varchar2(100);
  temp number;
begin
  user := SYS_CONTEXT('userenv','session_user');
  if ( SYS_CONTEXT('userenv','ISDBA') = 'TRUE' ) then
    return '';
  else
    if (user = 'QLBV' or user = 'NV1512004' or user = 'NV1512005' or user = 'NV1512006' or user = 'NV1512007' or user = 'NV1512008' ) then
      return '';
    else
      user := substr(user,3);
      return 'MABN IN (select MABN from PHIEUKHAM where MABS = ' || to_number(user)|| ')';
    end if;
  end if;
end;
BEGIN dbms_rls.add_policy (
  object_schema => 'QLBV',
  object_name => 'BENHNHAN',
  policy_name => 'policy3',
  function_schema => 'QLBV',
  policy_function => 'FUNCTION3',
  statement_types => 'select');
END;
-- bác si duoc them, sua, xóa thông tin pk_dv, pk_thuoc cua phieu kham mình thuc hien
GRANT SELECT,INSERT,UPDATE,DELETE ON PK_THUOC TO BACSI;
GRANT SELECT,INSERT,UPDATE,DELETE ON PK_DV TO BACSI;
CREATE OR REPLACE FUNCTION FUNCTION5(
p_schema varchar2,
p_obj varchar2 )
return varchar2
as
  user varchar2(100);
  temp number;
begin
  user := SYS_CONTEXT('userenv','session_user');
  if ( SYS_CONTEXT('userenv','ISDBA') = 'TRUE' ) then
    return '';
  else
    if (user = 'QLBV') then
      return '';
    else
      user := substr(user,3);
      return 'MAPK IN (select MAPK from PHIEUKHAM where MABS = ' || to_number(user)|| ')';
    end if;
  end if;
end;
BEGIN dbms_rls.add_policy (
  object_schema => 'QLBV',
  object_name => 'PK_THUOC',
  policy_name => 'policy5_1',
  function_schema => 'QLBV',
  policy_function => 'FUNCTION5',
  statement_types => 'insert,update,delete',
  update_check => true);
END;
BEGIN dbms_rls.add_policy (
  object_schema => 'QLBV',
  object_name => 'PK_DV',
  policy_name => 'policy5_2',
  function_schema => 'QLBV',
  policy_function => 'FUNCTION5',
  statement_types => 'insert,update,delete',
  update_check => true);
END;

CREATE OR REPLACE FUNCTION FUNCTION8(
p_schema varchar2,
p_obj varchar2 )
return varchar2
as
  user varchar2(100);
  temp number;
begin
  user := SYS_CONTEXT('userenv','session_user');
  if ( SYS_CONTEXT('userenv','ISDBA') = 'TRUE' ) then
    return '';
  else
    if (user = 'QLBV' or user = 'NV1512022' or user = 'NV1512023' or user = 'NV1512024' or user = 'NV1512003') then
      return '';
    else
      user := substr(user,3);
      return 'MAPK IN (select MAPK from PHIEUKHAM where MABS = ' || to_number(user)|| ')';
    end if;
  end if;
end;
BEGIN dbms_rls.add_policy (
  object_schema => 'QLBV',
  object_name => 'PK_THUOC',
  policy_name => 'policy8',
  function_schema => 'QLBV',
  policy_function => 'FUNCTION8',
  statement_types => 'select');
END;
----------------- ROLE KYTHUATVIEN --------------------
-- kY thuAt viên duoc truy xuat danh sách dich vu.
GRANT SELECT ON DICHVU TO KYTHUATVIEN;
-- ky thuat viên duoc xem thông tin pk_dv cua mình thuc hien
GRANT SELECT ON PK_DV TO KYTHUATVIEN;
CREATE OR REPLACE FUNCTION FUNCTION6(
p_schema varchar2,
p_obj varchar2 )
return varchar2
as
  user varchar2(100);
begin
  user := SYS_CONTEXT('userenv','session_user');
  if ( SYS_CONTEXT('userenv','ISDBA') = 'TRUE' ) then
    return '';
  else
   if (user = 'QLBV' or user = 'NV1512003') then
      return '';
    else
      user := substr(user,3);
      return 'MAKTV = ''' || user || '''' || 'or MAPK IN (select MAPK from PHIEUKHAM where MABS = ' || to_number(user)|| ')';
    end if;
  end if;
end;
BEGIN dbms_rls.add_policy (
  object_schema => 'QLBV',
  object_name => 'PK_DV',
  policy_name => 'policy6',
  function_schema => 'QLBV',
  policy_function => 'FUNCTION6',
  statement_types => 'select');
END;
----------------- ROLE BANTHUOC --------------------
-- nhân viên bán thuOc duoc xem danh sách thuc
GRANT SELECT ON THUOC TO BANTHUOC;
-- nhân viên bán thuoc duoc xem danh sách pk_thuoc cua mình thuc hien
GRANT SELECT ON PK_THUOC TO BANTHUOC;
----------------- ROLE KETOAN --------------------
-- nhân viên ke toán duoc xem luong cua moi nguoi -> dã cài dat o trên

------ OLS: xay dung va gan nhan cho mess
select * from THONGBAO;
grant select on THONGBAO to BACSI;
grant select on THONGBAO to KYTHUATVIEN;
GRANT SELECT ON THONGBAO TO NHANVIEN;
GRANT SELECT ON THONGBAO TO NVTAIVU;
grant select, insert, update, delete on THONGBAO to LBACSYS;
-- th?c hi?n b?ng user LBACSYS
------ ma hoa
-- dùng sys c?p quy?n grant execute on dbms_crypto to QLBV;
CREATE OR REPLACE PACKAGE CRYPT_PHIEUKHAM
IS 
  FUNCTION ENCRYPT(
    INPUT_DATA IN VARCHAR2,
    KEY_ID IN VARCHAR2)
    RETURN RAW DETERMINISTIC;
  FUNCTION DECRYPT(
    INPUT_DATA IN RAW,
    KEY_ID IN VARCHAR2)
    RETURN VARCHAR2 DETERMINISTIC;
END CRYPT_PHIEUKHAM;

CREATE OR REPLACE PACKAGE BODY CRYPT_PHIEUKHAM
IS
  ECRYPTION_TYPE PLS_INTEGER := DBMS_CRYPTO.ENCRYPT_AES192 + 
                                  DBMS_CRYPTO.CHAIN_CBC +
                                 DBMS_CRYPTO.PAD_PKCS5;
  PAD VARCHAR2(1) := ' ';
  PROCEDURE PADDING(KEY_PAD IN OUT VARCHAR2);
  FUNCTION ENCRYPT(
    INPUT_DATA IN VARCHAR2,
    KEY_ID IN VARCHAR2)
    RETURN RAW DETERMINISTIC
  IS
    KEY_PAD VARCHAR2(200) := KEY_ID;
    ENCRYPT_RAW RAW(2000) ;
  BEGIN
    PADDING(KEY_PAD);
        ENCRYPT_RAW := dbms_crypto.encrypt( src => UTL_I18N.STRING_TO_RAW (INPUT_DATA, 'AL32UTF8'),
                                        TYP => ECRYPTION_TYPE,
                                        KEY => UTL_I18N.STRING_TO_RAW(KEY_PAD,'AL32UTF8'));
    RETURN ENCRYPT_RAW;
  END ENCRYPT;
  FUNCTION DECRYPT(
    INPUT_DATA IN RAW,
    KEY_ID IN VARCHAR2)
    RETURN VARCHAR2 DETERMINISTIC
  IS
    DECRYPT_RAW RAW(2000);
    KEY_PAD VARCHAR2(200):= KEY_ID;
  BEGIN
    PADDING(KEY_PAD);
    DECRYPT_RAW := DBMS_CRYPTO.DECRYPT( SRC => INPUT_DATA,
                                        TYP => ECRYPTION_TYPE,
                                        KEY => UTL_I18N.STRING_TO_RAW (KEY_PAD, 'AL32UTF8'));
    RETURN UTL_I18N.RAW_TO_CHAR(DECRYPT_RAW,'AL32UTF8');
  END DECRYPT;
  PROCEDURE PADDING(KEY_PAD IN OUT VARCHAR2)
  IS
  BEGIN
    IF LENGTH(KEY_PAD) < 24 THEN
      KEY_PAD := RPAD(KEY_PAD,24,PAD);
    END IF;
  END;
END CRYPT_PHIEUKHAM;
--test crypt
update PHIEUKHAM
set CHUANDOAN = CRYPT_PHIEUKHAM.ENCRYPT(CHUANDOAN,TO_CHAR(MAPK));

update PHIEUKHAM
set CHUANDOAN = CRYPT_PHIEUKHAM.DECRYPT(CHUANDOAN,TO_CHAR(MAPK));

select * from PHIEUKHAM;
select CRYPT_PHIEUKHAM.DECRYPT(CHUANDOAN,TO_CHAR(MAPK)) FROM PHIEUKHAM;

create or replace view phieukham_view
as
select pk.mapk, pk.mabn,pk.mabs,pk.ngaykham,pk.trieuchung,CRYPT_PHIEUKHAM.DECRYPT(CHUANDOAN,TO_CHAR(MAPK)) as chuandoan, pk.motathem,pk.trangthai,pk.vienphi
from PHIEUKHAM pk;

select * from PHIEUKHAM;
select * from phieukham_view;
------- audit ---------
---Thiet lap audit voi tham so db,extended 
alter system set audit_trail=non scope=spfile; --enable audit
shutdown immediate;
startup
alter system set audit_trail=db,extended scope=spfile; -- disable audit
-- th?c hi?n audit
audit select,insert,delete on NHANVIEN by access;
audit select on THONGBAO by access;
audit update on PHIEUKHAM by access WHENEVER SUCCESSFUL;
audit update on PK_DV by access WHENEVER NOT SUCCESSFUL;
AUDIT EXECUTE ON QLBV.CRYPT_PHIEUKHAM;
-- danh sach user
select username from	DBA_USERS where account_status = 'OPEN'
select table_name from all_tables where owner = 'QLBV';
-- danh sach user/role và quy?n ???c c?p
select role from DBA_ROLES where common = 'NO';
-- dnah sách role
select role from DBA_ROLES where INHERITED = 'NO';
-- xem quy?n ???c c?p (connect các user ?? ki?m tra)
SELECT * FROM user_sys_privs;
select * from user_role_privs;
select * from user_col_privs;
SELECT distinct grantee,owner,table_name,grantor,grantable FROM dba_tab_privs where grantee = 'KETOAN';
SELECT  grantee,owner,table_name,column_name,grantor,privilege,grantable FROM dba_col_privs where grantee = 'KETOAN';
select * from THONGBAO;
select user_tab_privs.grantee,owner,table_name,grantor,privilege,grantable,granted_role,admin_option from user_tab_privs, dba_role_privs where user_tab_privs.grantee = dba_role_privs.grantee;


DROP TABLE CHINHANH
CASCADE CONSTRAINTS;

DROP TABLE THANHVIEN
CASCADE CONSTRAINTS;
DROP TABLE DONVI
CASCADE CONSTRAINTS;
DROP TABLE THONGBAO
CASCADE CONSTRAINTS;
DROP TABLE GIAMSAT 
CASCADE CONSTRAINTS;
DROP TABLE THEODOI
CASCADE CONSTRAINTS;
DROP TABLE UNGCUVIEN
CASCADE CONSTRAINTS;
DROP TABLE BTC
CASCADE CONSTRAINTS;
DROP TABLE PHIEUBAU
CASCADE CONSTRAINTS;
DROP TABLE TO_LAP
CASCADE CONSTRAINTS;

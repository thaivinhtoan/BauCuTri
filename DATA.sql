-->>lOGIN SYS V?I SID:XE

CREATE PLUGGABLE DATABASE "PDB" ADMIN USER "Admin" IDENTIFIED BY "admin"
  FILE_NAME_CONVERT=(
    'C:\Oracle18C\18.0.0\oradata\XE\pdbseed\SYSTEM01.DBF', 'C:\Oracle18C\18.0.0\oradata\XE\NEW_PDB\SYSTEM01.DBF',
    'C:\Oracle18C\18.0.0\oradata\XE\pdbseed\SYSAUX01.DBF', 'C:\Oracle18C\18.0.0\oradata\XE\NEW_PDB\SYSAUX01.DBF',
    'C:\Oracle18C\18.0.0\oradata\XE\pdbseed\UNDOTBS01.DBF', 'C:\Oracle18C\18.0.0\oradata\XE\NEW_PDB\UNDOTBS01.DBF',
    'C:\Oracle18C\18.0.0\oradata\XE\pdbseed\TEMP012020-08-29_07-14-33-622-AM.DBF', 'C:\Oracle18C\18.0.0\oradata\XE\NEW_PDB\TEMP012020-08-29_07-14-33-622-AM.DBF'
  )
  STORAGE UNLIMITED TEMPFILE REUSE;
/

-->> Login sys  sevicename: pbd --------------------------------------------------

--DROP TABLE THANHVIEN;
--DROP TABLE DONVI;
--DROP TABLE UNGVIEN;
--DROP TABLE BAUCHON;
--DROP TABLE LINHVUC;
alter SESSION set "_ORACLE_SCRIPT" = TRUE;
-- TAO USER DBA: QLBC 
CREATE USER QLBC IDENTIFIED BY QLBC;
ALTER USER QLBC QUOTA UNLIMITED ON SYSTEM; 

-- PHAN QUYEN CHO QLBC
grant restricted session, create session to QLBC with admin option;
GRANT DROP ANY ROLE TO QLBC;
GRANT CONNECT, RESOURCE, DBA TO QLBC ;--WITH ADMIN OPTION
GRANT ALTER SESSION, CREATE USER, DROP USER, CREATE ROLE,DROP ANY ROLE,
CREATE PROCEDURE, EXECUTE ANY PROCEDURE, ALTER ANY PROCEDURE, DROP ANY PROCEDURE, 
CREATE TRIGGER, DROP ANY TRIGGER TO QLBC ;--WITH ADMIN OPTION
GRANT SELECT ON SYS.dba_sys_privs TO QLBC WITH GRANT OPTION;
GRANT SELECT ON SYS.dba_role_privs TO QLBC WITH GRANT OPTION;
GRANT SELECT ON SYS.dba_roles TO QLBC WITH GRANT OPTION;
GRANT CREATE ANY TABLE, INSERT ANY TABLE, DELETE ANY TABLE, UPDATE ANY TABLE TO QLBC WITH ADMIN OPTION;


--> Login QLBC sevicename: pdb -----------------------------------------------------------------

--ALTER TABLE THANHVIEN DROP CONSTRAINT FK_TV_DV;
--ALTER TABLE THANHVIEN DROP CONSTRAINT FK_TV_LV;
--ALTER TABLE DONVI DROP CONSTRAINT FK_NVPT;
--ALTER TABLE BAUCHON DROP CONSTRAINT FK_BC_UV;
--ALTER TABLE BAUCHON DROP CONSTRAINT FK_BC_TV;
--DROP TABLE THANHVIEN;
--DROP TABLE LINHVUC;
--DROP TABLE DONVI;
--DROP TABLE UNGVIEN;
--DROP TABLE BAUCHON;


CREATE TABLE THANHVIEN
(
    MATV            INT NOT NULL,
    HOTEN           NVARCHAR2(100) NOT NULL,
    PHAI            NVARCHAR2(5) NOT NULL,
    QUEQUAN         NVARCHAR2(200)NOT NULL,
    NGAYSINH        DATE NOT NULL,
    QUOCTICH        NVARCHAR2(100) NOT NULL,
    DCTHUONGTRU     NVARCHAR2(200) NOT NULL,
    DCTAMTRU        NVARCHAR2(200) NOT NULL,
    VAITRO          NVARCHAR2(200) , -- VAI TRO GOM: "BAN TO CHUC", "TO LAP DANH SACH", "TO THEO GIOI KET QUA", "BO PHAN GIAM SAT", "UNG VIEN", "NGUOI DI BAU" HOAC NULL
    MADV            INT NOT NULL,
    VITRICONGTAC    NVARCHAR2(255) NOT NULL, -- PHAI CO "CONG TY"(VIET CO DAU) NHA CON LAI LA DIA DIEM NAO DO 
    NGHIPHEP        CHAR(1) NOT NULL, -- KO CO HAM BOOL NEN DUNG NAY THAY THE : TRA VE "Y", "N"
    LYDONGHIPHEP    NVARCHAR2(255) NOT NULL,
    USERNAME        NVARCHAR2(255) NOT NULL,
	MALV			INT NOT NULL,
    CONSTRAINT PK_TV PRIMARY KEY(MATV)
)
/
CREATE TABLE LINHVUC
(
	MALV INT NOT NULL,
	TENLV NVARCHAR2(200) NOT NULL, -- MIEN GIA TRI: [ FINANCIAL, IT]
	CONSTRAINT PK_LV PRIMARY KEY(MALV)
)
/
CREATE TABLE DONVI
(
    MADV        INT NOT NULL,
    TENDV       NVARCHAR2(200) NOT NULL, -- MIEN GIA TRI:[ A, B]
    NVPHUTRACH  INT NOT NULL,
    CONSTRAINT PK_DONVI PRIMARY KEY (MADV)
)
/
CREATE TABLE UNGVIEN
(
    MAUV            INT NOT NULL,
    HOTEN           NVARCHAR2(100) NOT NULL,
    PHAI            NVARCHAR2(5) NOT NULL,
    QUEQUAN         NVARCHAR2(200)NOT NULL,
    NGAYSINH        DATE NOT NULL,
    QUOCTICH        NVARCHAR2(100) NOT NULL,
    DCTHUONGTRU     NVARCHAR2(200) NOT NULL,
    CONSTRAINT PK_UV PRIMARY KEY (MAUV)
)
/
CREATE TABLE BAUCHON
(
    MATV INT NOT NULL,
    MAUV INT NOT NULL,
    CONSTRAINT PK_BC PRIMARY KEY (MATV,MAUV)
)
/
-- KHOA NGOAI
ALTER TABLE THANHVIEN ADD CONSTRAINT FK_TV_DV FOREIGN KEY (MADV) REFERENCES DONVI(MADV);
ALTER TABLE THANHVIEN ADD CONSTRAINT FK_TV_LV FOREIGN KEY (MALV) REFERENCES LINHVUC(MALV);
ALTER TABLE DONVI ADD CONSTRAINT FK_NVPT FOREIGN KEY (NVPHUTRACH) REFERENCES THANHVIEN(MATV);
ALTER TABLE BAUCHON ADD CONSTRAINT FK_BC_UV FOREIGN KEY (MAUV) REFERENCES UNGVIEN(MAUV);
ALTER TABLE BAUCHON ADD CONSTRAINT FK_BC_TV FOREIGN KEY (MATV) REFERENCES THANHVIEN(MATV);

/
--Du lieu bang THANHVIEN, 1 -> 3 ban to chuc(1: TRUONG BAN TO CHUC) , 
--4 -> 6 to lap danh sach, 
--7 -> 9 to theo doi ket qua, 
--10 -> 12 bo phan giam sat, 13 -> 27 nguoi di bau, 28-> 37 THANH VIEN (MIEN GIA TRI: NULL)
INSERT INTO "QLBC"."THANHVIEN" Values (1,'TO HOANG TRUNG','Nam','Khanh Hoa',TO_DATE('1999/11/25', 'yyyy/mm/dd'),'VN','Khanh Hoa','Phuong 3 - Quan 4','TRUONG BAN TO CHUC','1','CONG TY','N','N','trung',1);
INSERT INTO "QLBC"."THANHVIEN" Values (2,'NGUYEN BAO PHAT','Nam','Lao Cai',TO_DATE('1999/12/26', 'yyyy/mm/dd'),'VN','Lao Cai','Phuong 4 - Quan 1','BAN TO CHUC','1','CONG TY','N','N','phat',2);
INSERT INTO "QLBC"."THANHVIEN" Values (3,'VO MINH HIEN','Nam','An Giang',TO_DATE('1999/06/12', 'yyyy/mm/dd'),'VN','An Giang','Phuong 2 - Quan 6','BAN TO CHUC','1','CONG TY','N','N','hien',1);
--3 tv to lap danh sach quan ly lan luot 3 don vi 1, 2
INSERT INTO "QLBC"."THANHVIEN" Values (4,'NGUYEN DUY QUANG','Nam','Lao Cai',TO_DATE('1999/08/02', 'yyyy/mm/dd'),'VN','Lao Cai','Phuong 1 - Quan 12','TO LAP DANH SACH','1','CONG TY','N','N','quang',2);
INSERT INTO "QLBC"."THANHVIEN" Values (5,'NGUYEN PHUC MANH','Nam','Dak Nong',TO_DATE('1999/10/11', 'yyyy/mm/dd'),'VN','Dak Nong','Phuong 5 - Quan 1','TO LAP DANH SACH','2','CONG TY','N','N','manh',1);

INSERT INTO "QLBC"."THANHVIEN" Values (7,'NGUYEN MINH TRI','Nam','HCM',TO_DATE('1999/11/22', 'yyyy/mm/dd'),'VN','HCM','Phuong 6 - Quan 10','TO THEO DOI KET QUA','2','CONG TY','N','N','tri',1);
INSERT INTO "QLBC"."THANHVIEN" Values (8,'CHAU NGUYEN KHANH TRINH','Nam','Ca Mau',TO_DATE('1999/01/01', 'yyyy/mm/dd'),'VN','Ca Mau','Phuong 8 - Quan 10','TO THEO DOI KET QUA','2','CONG TY','N','N','trinh',2);
INSERT INTO "QLBC"."THANHVIEN" Values (9,'THAI VINH TOAN','Nam','Binh Duong',TO_DATE('1999/09/21', 'yyyy/mm/dd'),'VN','Binh Duong','Phuong 11 - Quan 2','TO THEO DOI KET QUA','2','CONG TY','N','N','toan',1);

INSERT INTO "QLBC"."THANHVIEN" Values (10,'HONG QUANG TU','Nam','HCM',TO_DATE('1999/11/11', 'yyyy/mm/dd'),'VN','HCM','Phuong 12 - Quan 1','BO PHAN GIAM SAT','2','CONG TY','N','N','tu',2);
INSERT INTO "QLBC"."THANHVIEN" Values (11,'VO NGUYEN HOAI LINH','Nam','Binh Phuoc',TO_DATE('1999/12/13', 'yyyy/mm/dd'),'VN','Binh Phuoc','Phuong 1 - Quan 1','BO PHAN GIAM SAT','2','CONG TY','N','N','linh1',1);
INSERT INTO "QLBC"."THANHVIEN" Values (12,'NGUYEN CHI TAI','Nam','Nam Dinh',TO_DATE('1999/12/01', 'yyyy/mm/dd'),'VN','Nam Dinh','Phuong 8 - Quan 12','BO PHAN GIAM SAT','2','CONG TY','N','N','tai',2);

INSERT INTO "QLBC"."THANHVIEN" Values (13,'NGUYEN VIET HUONG','Nu','HCM',TO_DATE('1999/10/11', 'yyyy/mm/dd'),'VN','HCM','Phuong 3 - Quan 4','NGUOI DI BAU','1','CONG TY','N','N','huong1',1);
INSERT INTO "QLBC"."THANHVIEN" Values (14,'TRAN THI THUY NGA','Nu','Lam Dong',TO_DATE('1999/01/02', 'yyyy/mm/dd'),'VN','Lam Dong','Phuong 1 - Quan 2','NGUOI DI BAU','2','CONG TY','N','N','nga',2);
INSERT INTO "QLBC"."THANHVIEN" Values (15,'NGUYEN KIEU OANH','Nu','Thanh Hoa',TO_DATE('1999/08/12', 'yyyy/mm/dd'),'VN','Thanh Hoa','Phuong 2 - Quan 3','NGUOI DI BAU','1','CONG TY','N','N','oanh',1);
INSERT INTO "QLBC"."THANHVIEN" Values (16,'HUYNH TRAN THANH','Nam','Long An',TO_DATE('1999/09/25', 'yyyy/mm/dd'),'VN','Long An','Phuong 3 - Quan 4','NGUOI DI BAU','2','CONG TY','N','N','thanh',2);
INSERT INTO "QLBC"."THANHVIEN" Values (17,'VO VU TRONG GIANG','Nam','Ca Mau',TO_DATE('1999/04/19', 'yyyy/mm/dd'),'VN','Ca Mau','Phuong 4 - Quan 5','NGUOI DI BAU','1','CONG TY','N','N','giang',1);

INSERT INTO "QLBC"."THANHVIEN" Values (18,'HONG VAN KHOA','Nam','Da Nang',TO_DATE('1999/12/30', 'yyyy/mm/dd'),'VN','Da Nang','Phuong 1 - Quan 2','NGUOI DI BAU','1','CONG TY','N','N','khoa',2);
INSERT INTO "QLBC"."THANHVIEN" Values (19,'LE THI NGOC','Nu','Tay Ninh',TO_DATE('1999/12/31', 'yyyy/mm/dd'),'VN','Tay Ninh','Phuong 2 - Quan 3','NGUOI DI BAU','2','CONG TY','N','N','ngoc',1);
INSERT INTO "QLBC"."THANHVIEN" Values (20,'LINH NGOC DAM','Nu','Kon Tum',TO_DATE('1999/11/29', 'yyyy/mm/dd'),'VN','Kon Tum','Phuong 3 - Quan 4','NGUOI DI BAU','1','CONG TY','N','N','dam',2);
INSERT INTO "QLBC"."THANHVIEN" Values (21,'NGUYEN TUONG VI','Nam','Binh Duong',TO_DATE('1999/01/01', 'yyyy/mm/dd'),'VN','Binh Duong','Phuong 5 - Quan 6','NGUOI DI BAU','2','CONG TY','N','N','vi',1);
INSERT INTO "QLBC"."THANHVIEN" Values (22,'PHONG THANH LE','Nam','Dien Bien',TO_DATE('1999/09/30', 'yyyy/mm/dd'),'VN','Dien Bien','Phuong 7 - Quan 8','NGUOI DI BAU','1','CONG TY','N','N','do',2);
INSERT INTO "QLBC"."THANHVIEN" Values (23,'NGUYEN LAN HUONG','Nu','Dong Nai',TO_DATE('1999/12/12', 'yyyy/mm/dd'),'VN','Dong Nai','Phuong 9 - Quan 10','NGUOI DI BAU','2','CONG TY','N','N','huong2',1);
INSERT INTO "QLBC"."THANHVIEN" Values (24,'LE NGOC MINH HUNG','Nu','Dong Thap',TO_DATE('1999/01/14', 'yyyy/mm/dd'),'VN','Dong Thap','Phuong 11 - Quan 12','NGUOI DI BAU','1','CONG TY','N','N','hung',2);
INSERT INTO "QLBC"."THANHVIEN" Values (25,'LE NGAN KHANH','Nu','Gia Lai',TO_DATE('1999/08/09', 'yyyy/mm/dd'),'VN','Gia Lai','Phuong 12 - Quan 1','NGUOI DI BAU','2','CONG TY','N','N','khanh',1);
INSERT INTO "QLBC"."THANHVIEN" Values (26,'DINH NGOC DIEP','Nu','Ha Giang',TO_DATE('1999/11/25', 'yyyy/mm/dd'),'VN','Ha Giang','Phuong 1 - Quan 2','NGUOI DI BAU','1','CONG TY','N','N','diep',2);
INSERT INTO "QLBC"."THANHVIEN" Values (27,'NGUYEN NGOC THUY TRANG','Nu','Ha Nam',TO_DATE('1999/09/10', 'yyyy/mm/dd'),'VN','Ha Nam','Phuong 2 - Quan 3','NGUOI DI BAU','2','CONG TY','N','N','trang',1);

INSERT INTO "QLBC"."THANHVIEN" Values (28,'NGUYEN JOHN','Nam','Ha Nam',TO_DATE('1999/09/10', 'yyyy/mm/dd'),'VN','Ha Nam','Phuong 2 - Quan 3',NULL,'2','ANH','N','N', 'john',1);
INSERT INTO "QLBC"."THANHVIEN" Values (29,'NGUYEN LUU LUY','Nu','Ha Nam',TO_DATE('1999/09/10', 'yyyy/mm/dd'),'VN','Ha Nam','Phuong 2 - Quan 3',NULL,'1','CONG TY','N','N', 'luy',1);
INSERT INTO "QLBC"."THANHVIEN" Values (30,'NGUYEN NGOC NHU','Nu','Ha Nam',TO_DATE('1999/09/10', 'yyyy/mm/dd'),'VN','Ha Nam','Phuong 2 - Quan 3',NULL,'1','MY','N','N', 'nhu',2);
INSERT INTO "QLBC"."THANHVIEN" Values (31,'NGUYEN MANH QUAN','Nam','Ha Nam',TO_DATE('1999/09/10', 'yyyy/mm/dd'),'VN','Ha Nam','Phuong 2 - Quan 3',NULL,'2','CONG TY','N','N', 'quan',1);
INSERT INTO "QLBC"."THANHVIEN" Values (32,'NGUYEN TRI VINH ','Nam','Ha Nam',TO_DATE('1999/09/10', 'yyyy/mm/dd'),'VN','Ha Nam','Phuong 2 - Quan 3',NULL,'2','CONG TY','N','N','vinh',2);
INSERT INTO "QLBC"."THANHVIEN" Values (33,'NGUYEN HOAI THUONG','Nu','Ha Nam',TO_DATE('1999/09/10', 'yyyy/mm/dd'),'VN','Ha Nam','Phuong 2 - Quan 3',NULL,'2','PHAP','N','N','thuong',2);
INSERT INTO "QLBC"."THANHVIEN" Values (34,'NGUYEN MINH KHANG','Nam','Ha Nam',TO_DATE('1999/09/10', 'yyyy/mm/dd'),'VN','Ha Nam','Phuong 2 - Quan 3',NULL,'1','DUC','N','N', 'khang',2);
INSERT INTO "QLBC"."THANHVIEN" Values (35,'NGUYEN THI HONG GAM','Nu','Ha Nam',TO_DATE('1999/09/10', 'yyyy/mm/dd'),'VN','Ha Nam','Phuong 2 - Quan 3',NULL,'1','SINGAPORE','N','N', 'gam',2);
INSERT INTO "QLBC"."THANHVIEN" Values (36,'NGUYEN TUYET NHUNG','Nu','Ha Nam',TO_DATE('1999/09/10', 'yyyy/mm/dd'),'VN','Ha Nam','Phuong 2 - Quan 3',NULL,'1','CONG TY','N','N', 'nhung',1);
INSERT INTO "QLBC"."THANHVIEN" Values (37,'NGUYEN THI THUY TRANG','Nu','Ha Nam',TO_DATE('1999/09/10', 'yyyy/mm/dd'),'VN','Ha Nam','Phuong 2 - Quan 3',NULL,'1','NHAT','N','N', 'trang1',2);



--Du lieu bang LINHVUC
INSERT INTO "QLBC"."LINHVUC" Values (1,'FINANCIAL');
INSERT INTO "QLBC"."LINHVUC" Values (2, 'IT');

--Du lieu bang DONVI, 2 nv phu trach la 2 nv trong to lap danh sach
INSERT INTO "QLBC"."DONVI" Values (1,'A',4);
INSERT INTO "QLBC"."DONVI" Values (2,'B',5);
--Du lieu bang UNGVIEN lay ra tu bang THANHVIEN
INSERT INTO "QLBC"."UNGVIEN" Values (1,'NGUYEN VIET HUONG','Nu','HCM',TO_DATE('1999/10/11', 'yyyy/mm/dd'),'VN','HCM');
INSERT INTO "QLBC"."UNGVIEN" Values (2,'TRAN THI THUY NGA','Nu','Lam Dong',TO_DATE('1999/01/02', 'yyyy/mm/dd'),'VN','Lam Dong');
INSERT INTO "QLBC"."UNGVIEN" Values (3,'NGUYEN KIEU OANH','Nu','Thanh Hoa',TO_DATE('1999/08/12', 'yyyy/mm/dd'),'VN','Thanh Hoa');
INSERT INTO "QLBC"."UNGVIEN" Values (4,'HUYNH TRAN THANH','Nam','Long An',TO_DATE('1999/09/25', 'yyyy/mm/dd'),'VN','Long An');
INSERT INTO "QLBC"."UNGVIEN" Values (5,'VO VU TRONG GIANG','Nam','Ca Mau',TO_DATE('1999/04/19', 'yyyy/mm/dd'),'VN','Ca Mau');

--Du lieu bang BAUCHON
INSERT INTO "QLBC"."BAUCHON" Values(18,1);
INSERT INTO "QLBC"."BAUCHON" Values(18,3);
INSERT INTO "QLBC"."BAUCHON" Values(18,5);
INSERT INTO "QLBC"."BAUCHON" Values(19,1);
INSERT INTO "QLBC"."BAUCHON" Values(19,2);
INSERT INTO "QLBC"."BAUCHON" Values(19,3);
INSERT INTO "QLBC"."BAUCHON" Values(20,3);
INSERT INTO "QLBC"."BAUCHON" Values(20,4);
INSERT INTO "QLBC"."BAUCHON" Values(20,5);
INSERT INTO "QLBC"."BAUCHON" Values(21,2);
INSERT INTO "QLBC"."BAUCHON" Values(21,4);
INSERT INTO "QLBC"."BAUCHON" Values(21,5);
INSERT INTO "QLBC"."BAUCHON" Values(22,1);
INSERT INTO "QLBC"."BAUCHON" Values(22,3);
INSERT INTO "QLBC"."BAUCHON" Values(22,4);
INSERT INTO "QLBC"."BAUCHON" Values(23,3);
INSERT INTO "QLBC"."BAUCHON" Values(23,4);
INSERT INTO "QLBC"."BAUCHON" Values(23,5);
INSERT INTO "QLBC"."BAUCHON" Values(24,1);
INSERT INTO "QLBC"."BAUCHON" Values(24,2);
INSERT INTO "QLBC"."BAUCHON" Values(24,5);
INSERT INTO "QLBC"."BAUCHON" Values(25,3);
INSERT INTO "QLBC"."BAUCHON" Values(25,4);
INSERT INTO "QLBC"."BAUCHON" Values(25,5);
INSERT INTO "QLBC"."BAUCHON" Values(26,1);
INSERT INTO "QLBC"."BAUCHON" Values(26,2);
INSERT INTO "QLBC"."BAUCHON" Values(26,5);
INSERT INTO "QLBC"."BAUCHON" Values(27,3);
INSERT INTO "QLBC"."BAUCHON" Values(27,4);
INSERT INTO "QLBC"."BAUCHON" Values(27,5);

/

CREATE TABLE TAIKHOAN
(
USERNAME NVARCHAR2(20) PRIMARY KEY,
USERTYPE NVARCHAR2(20) NOT NULL
);

INSERT INTO TAIKHOAN Values ( 'trung','TRUONG BAN TO CHUC');
INSERT INTO TAIKHOAN Values ( 'phat',' BAN TO CHUC');
INSERT INTO TAIKHOAN Values ( 'hien',' BAN TO CHUC');

INSERT INTO TAIKHOAN Values ( 'quang',' TO LAP DANH SACH');
INSERT INTO TAIKHOAN Values ( 'manh',' TO LAP DANH SACH');

INSERT INTO TAIKHOAN Values ( 'tri','TO THEO DOI KET QUA');
INSERT INTO TAIKHOAN Values ( 'trinh',' TO THEO DOI KET QUA');
INSERT INTO TAIKHOAN Values ( 'toan',' TO THEO DOI KET QUA ');

INSERT INTO TAIKHOAN Values ( 'tu',' BO PHAN GIAM SAT');
INSERT INTO TAIKHOAN Values ( 'linh1',' BO PHAN GIAM SAT ');
INSERT INTO TAIKHOAN Values ( 'tai',' BO PHAN GIAM SAT ');

INSERT INTO TAIKHOAN Values ( 'huong1',' UNG VIEN ');
INSERT INTO TAIKHOAN Values ( 'nga',' UNG VIEN ');
INSERT INTO TAIKHOAN Values ( 'oanh',' UNG VIEN ');
INSERT INTO TAIKHOAN Values ( 'thanh',' UNG VIEN ');
INSERT INTO TAIKHOAN Values ( 'giang',' UNG VIEN ');


INSERT INTO TAIKHOAN Values ( 'khoa',' NGUOI DI BAU ');
INSERT INTO TAIKHOAN Values ( 'ngoc',' NGUOI DI BAU  ');
INSERT INTO TAIKHOAN Values ( 'dam',' NGUOI DI BAU  ');
INSERT INTO TAIKHOAN Values ( 'vi',' NGUOI DI BAU  ');
INSERT INTO TAIKHOAN Values ( 'do',' NGUOI DI BAU  ');
INSERT INTO TAIKHOAN Values ( 'huong2',' NGUOI DI BAU  ');
INSERT INTO TAIKHOAN Values ( 'hung',' NGUOI DI BAU  ');
INSERT INTO TAIKHOAN Values ( 'khanh',' NGUOI DI BAU ');
INSERT INTO TAIKHOAN Values ( 'diep',' NGUOI DI BAU  ');
INSERT INTO TAIKHOAN Values ( 'trang',' NGUOI DI BAU  ');

ALTER TABLE THANHVIEN ADD CONSTRAINT FK_TV_DV FOREIGN KEY (MADV) REFERENCES DONVI(MADV);
ALTER TABLE THANHVIEN ADD CONSTRAINT FK_TV_LV FOREIGN KEY (MALV) REFERENCES LINHVUC(MALV);
ALTER TABLE DONVI ADD CONSTRAINT FK_NVPT FOREIGN KEY (NVPHUTRACH) REFERENCES THANHVIEN(MATV);
ALTER TABLE BAUCHON ADD CONSTRAINT FK_BC_UV FOREIGN KEY (MAUV) REFERENCES UNGVIEN(MAUV);
ALTER TABLE BAUCHON ADD CONSTRAINT FK_BC_TV FOREIGN KEY (MATV) REFERENCES THANHVIEN(MATV);


--TAO USER/ROLE
ALTER SESSION SET "_ORACLE_SCRIPT"= TRUE;
-- TAO ROLES
CREATE ROLE BANTOCHUC;
CREATE ROLE TOLAPDANHSACH;
CREATE ROLE TOTHEODOIKETQUA;
CREATE ROLE BOPHANGIAMSAT;
CREATE ROLE NGUOIDIBAU;
/
GRANT CREATE SESSION, restricted session TO BANTOCHUC, TOLAPDANHSACH, TOTHEODOIKETQUA, BOPHANGIAMSAT,NGUOIDIBAU;

----tao user thuoc vai tro ban to chuc
CREATE USER trung identified  by 1234;
CREATE USER phat identified  by 1234;
CREATE USER hien identified  by 1234;
GRANT BANTOCHUC TO trung, phat, hien;

----tao user thuoc vai tro to lap danh sach
ALTER SESSION SET "_ORACLE_SCRIPT"= TRUE;
CREATE USER quang identified  by 1234;

CREATE USER manh identified  by 1234;

GRANT TOLAPDANHSACH TO quang, manh;

----tao user thuoc vai tro to theo doi ket qua
ALTER SESSION SET "_ORACLE_SCRIPT"= TRUE;
/
CREATE USER tri identified  by 1234;

CREATE USER trinh identified  by 1234;

CREATE USER toan identified  by 1234;

GRANT TOTHEODOIKETQUA TO tri, trinh, toan;

-----tao user thuoc bo phan giam sat
ALTER SESSION SET "_ORACLE_SCRIPT"= true;
/
CREATE USER tu identified  by 1234;

CREATE USER linh1 identified  by 1234;

CREATE USER tai identified  by 1234;

GRANT BOPHANGIAMSAT TO tu, linh1, tai;


-----tao user thuoc vai tro nguoi di bau
ALTER SESSION SET "_ORACLE_SCRIPT"= TRUE;
/
CREATE USER huong1 identified  by 1234;

CREATE USER nga identified  by 1234;

CREATE USER oanh identified  by 1234;

CREATE USER thanh identified  by 1234;

CREATE USER giang identified  by 1234;

CREATE USER khoa identified  by 1234;

CREATE USER ngoc identified  by 1234;

CREATE USER dam identified  by 1234;

CREATE USER vi identified  by 1234;

CREATE USER do identified  by 1234;

CREATE USER huong2 identified  by 1234;

CREATE USER hung identified  by 1234;

CREATE USER khanh identified  by 1234;

CREATE USER diep identified  by 1234;

CREATE USER trang identified  by 1234;
grant create session to trang;
GRANT NGUOIDIBAU TO huong1,nga,oanh,thanh,giang,khoa,ngoc,dam,vi,do,huong2,hung,khanh,diep,trang;

-- tao user cho thanh vien co vai tro la null
CREATE USER john identified  by 1234;
grant create session to john;
CREATE USER luy identified  by 1234;
grant create session to luy;
CREATE USER nhu identified  by 1234;
grant create session to nhu;
CREATE USER quan identified  by 1234;
grant create session to quan;
CREATE USER vinh identified  by 1234;
grant create session to vinh;
CREATE USER thuong identified  by 1234;
grant create session to thuong;
CREATE USER khang identified  by 1234;
grant create session to khang;
CREATE USER gam identified  by 1234;
grant create session to gam;
CREATE USER nhung identified  by 1234;
grant create session to nhung;
CREATE USER trang1 identified  by 1234;
grant create session to trang1;

grant select on thanhvien to trung

select VAITRO from QLBC.THANHVIEN where USERNAME = 'trung'

-- Create a new database called 'GymManagement'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
	SELECT [name]
		FROM sys.databases
		WHERE [name] = N'GymManagement'
)
CREATE DATABASE GymManagement
GO

USE GymManagement
GO

-- Create a new table called '[TrangThietBi]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[TrangThietBi]', 'U') IS NOT NULL
DROP TABLE [dbo].[TrangThietBi]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[TrangThietBi]
(
	ten nvarchar(50),
	ma nvarchar(10),
	tinhTrang nvarchar(50),
	ngayMua date,
	giaThanh int,
	baoHanh int,
	ngayHetHanBaoHanh date,
	hangSanXuat nvarchar(50)
);
GO

-- Create a new table called '[NHANVIEN]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[NHANVIEN]', 'U') IS NOT NULL
DROP TABLE [dbo].[NHANVIEN]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[NHANVIEN]
(
    ID       NCHAR (32) NOT NULL,
    HoTen    NCHAR (32) NOT NULL,
    GioiTinh NCHAR (10) NOT NULL,
    Email    NCHAR (32) NOT NULL,
    SoDT    BIGINT     NOT NULL,
    DiaChi   NCHAR (50) NOT NULL,
    ChucVu   NCHAR (10) NOT NULL,
    Luong    MONEY      NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
GO

-- Create a new table called '[Member]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Member]', 'U') IS NOT NULL
DROP TABLE [dbo].[Member]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Member]
(
	ma char(10) primary key,
	ten nvarchar(50),
	tuoi INT, 
	gioiTinh	NCHAR (10),
	soDT BIGINT,
	ngayThamGia date,
	ngayKetThuc date,
);
GO

-- Create a new table called '[LogInData]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[LogInData]', 'U') IS NOT NULL
DROP TABLE [dbo].[LogInData]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[LogInData]
(
	maNV char(10) ,
	permissionLevel int,
	username nvarchar(30) primary key,
	passW nvarchar(30)
);
GO


-- Create a new table called '[PTSchedule]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[PTSchedule]', 'U') IS NOT NULL
DROP TABLE [dbo].[PTSchedule]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[PTSchedule]
(
	ID       NCHAR (32) NOT NULL,
    HoTen    NCHAR (32) NOT NULL,
	Thu	int,
	Buoi int
);

-- Create a new table called '[PTSchedule]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[GoiTap]', 'U') IS NOT NULL
DROP TABLE [dbo].[GoiTap]
GO
-- Create the table in the specified schema
create table GoiTap (
	ma		nvarchar(20),
	ten		nvarchar(30),
	thoiHan	int,
	moTa	nvarchar(50)
)

-- Create a new table called '[PTSchedule]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[MonthlyIncome]', 'U') IS NOT NULL
DROP TABLE [dbo].[MonthlyIncome]
GO
-- Create the table in the specified schema
Create table MonthlyIncome (
	maKH			char(10),
	maGoiTap		char(20),
	dateOfPay		date,
	PaymentPeriod	int, --pay for how long		
    price			int
)
GO


-- Create a new table called '[monthBucket]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[monthBucket]', 'U') IS NOT NULL
DROP TABLE [dbo].[monthBucket]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[monthBucket]
(
bucketName nvarchar(10),
bucketFirstDay date,
bucketLastDay date 
);
GO

-- Create a new table called '[Attendance]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Attendance]', 'U') IS NOT NULL
DROP TABLE [dbo].[Attendance]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Attendance]
(
	ma nvarchar(10), 
	thoigian DATETIME ,
	alias nvarchar(10),
);
GO

-- Create a new table called '[Feedback]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Feedback]', 'U') IS NOT NULL
DROP TABLE [dbo].[Feedback]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Feedback]
(
	maKH nvarchar(10), 
	thoigian date ,
	feedback nvarchar(2500),
);
GO

;WITH
  Pass0 as (select 1 as C union all select 1), --2 rows
  Pass1 as (select 1 as C from Pass0 as A, Pass0 as B),--4 rows
  Pass2 as (select 1 as C from Pass1 as A, Pass1 as B),--16 rows
  Pass3 as (select 1 as C from Pass2 as A, Pass2 as B),--256 rows
  Pass4 as (select 1 as C from Pass3 as A, Pass3 as B),--65536 rows
  Tally as (select row_number() over(order by C) as Number from Pass4)
INSERT monthBucket(bucketName, bucketFirstDay)
SELECT  
RIGHT('0000'+CONVERT(nvarchar(10), Y.Number),4) + '-'+ RIGHT('00'+CONVERT(nvarchar(10), M.Number),2),
CONVERT(date, convert(nvarchar(10), Y.Number)+'-'+convert(nvarchar(10),M.Number)+'-01')
FROM Tally as Y
CROSS JOIN Tally as M
WHERE Y.Number < 2100 AND y.Number >= 1980
AND M.Number <= 12

;UPDATE monthBucket SET bucketLastDay = EOMONTH(bucketFirstDay)


IF object_id('udf_GetNumeric', 'FN') IS NOT NULL
BEGIN
    DROP FUNCTION [dbo].[udf_GetNumeric]
END
GO
CREATE FUNCTION dbo.udf_GetNumeric
(
  @strAlphaNumeric VARCHAR(256)
)
RETURNS VARCHAR(256)
AS
BEGIN
  DECLARE @intAlpha INT
  SET @intAlpha = PATINDEX('%[^0-9]%', @strAlphaNumeric)
  BEGIN
    WHILE @intAlpha > 0
    BEGIN
      SET @strAlphaNumeric = STUFF(@strAlphaNumeric, @intAlpha, 1, '' )
      SET @intAlpha = PATINDEX('%[^0-9]%', @strAlphaNumeric )
    END
  END
  RETURN ISNULL(@strAlphaNumeric,0)
END
GO


--dummy Data--
SET DATEFORMAT dmy; 

truncate table TrangThietBi
insert into TrangThietBi (ten, ma, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat) 
values (N'Tạ tay','Ta-001',N'Còn tốt','04/05/2020',500,0,'04/05/2020',N'workoutNow') 

insert into TrangThietBi (ten, ma, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat)
values (N'Khung gánh tạ trợ lực','Ma-001',N'Còn tốt','15/07/2020',12000,6,'15/01/2021',N'workoutNow')

insert into TrangThietBi (ten, ma, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat)
values (N'Ghế tập tạ','Ta-002',N'Còn tốt','19/05/2020',800,6,'19/11/2020',N'workoutNow') 

insert into TrangThietBi (ten, ma, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat)
values (N'Máy tập ngực','Ma-002',N'Hỏng','20/05/2020',1000,12,'20/05/2021',N'workoutLater') 

insert into TrangThietBi (ten, ma, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat)
values (N'Máy tập đùi trong','Ma-003',N'Còn tốt','27/10/2020',13000,12,'27/10/2021',N'workoutNo') 

insert into TrangThietBi (ten, ma, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat) 
values (N'Máy tập đùi ngoài','Ma-004',N'Trong kho','27/05/2020',10000,12,'27/05/2021',N'workoutNo') 




truncate table NHANVIEN
INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'NV001', N'Phan Duy Đức', N'Nam', N'ducduypm0120@gmai.com', 376771465, N'KTX khu A', N'Admin', CAST(10000000.0000 AS Money))
INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'NV002', N'Hua Van Tuan Anh', N'Nam', N'tuananh123@gmail.com', 167645234, N'Thu Duc', N'Tiếp tân', CAST(10000000.0000 AS Money))
INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'NV003', N'Pham Xuan Vinh', N'Nam', N'vinhpham@gmail.com', 234567891, N'Thu Duc', N'Tiếp tân', CAST(10000000.0000 AS Money))
INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'NV004', N'Pham Viet Hoang', N'Nam', N'viethoangpm0120@gmai.com', 376771465, N'KTX khu A', N'PT', CAST(10000000.0000 AS Money))
INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'NV005', N'Phan Viet Duc', N'Nam', N'duc09@gmail.com', 167645234, N'Thu Duc', N'PT', CAST(10000000.0000 AS Money))
INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'NV006', N'Nguyen Viet My', N'Nam', N'mydep@gmail.com', 234567891, N'Thu Duc', N'PT', CAST(10000000.0000 AS Money))

truncate table LogInData
INSERT INTO LogInData (maNV, permissionLevel, username, passW) VALUES ('NV001',1,'duc','1234')
INSERT INTO LogInData (maNV, permissionLevel, username, passW) VALUES ('NV002',2,'anh','1234')
INSERT INTO LogInData (maNV, permissionLevel, username, passW) VALUES ('NV003',2,'vinh','1234')
INSERT INTO LogInData (maNV, permissionLevel, username, passW) VALUES ('NV004',3,'hoang','1234')
INSERT INTO LogInData (maNV, permissionLevel, username, passW) VALUES ('NV005',3,'vduc','1234')
INSERT INTO LogInData (maNV, permissionLevel, username, passW) VALUES ('NV006',3,'my','1234')

truncate table Member
insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH0001',N'Trương Nguyễn Tuấn Nam',22,N'Nam',0123456789,'12/02/2021')
insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH0002',N'Phan Duy',21,N'Nam',0123456789,'12/01/2021')
insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) --
values ('KH0003',N'Vinh',20,N'Nam',0123456789,'12/03/2021','12/07/2021')
insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH0004',N'Tuan Anh',22,N'Nu',0123456789,'12/05/2021')
insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH0005',N'Hoang Tuan Kiet',22,N'Nam',0123456789,'12/01/2021')
insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH0006',N'Someone',21,N'Nam',0123456789,'12/05/2021')
insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH0007',N'Someone Else',20,N'Nam',0123456789,'12/04/2021')
insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) --
values ('KH0008',N'Stranger',22,N'Nu',0123456789,'12/04/2021','12/10/2022')
insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH0009',N'ABC',21,N'Nam',0123456789,'12/03/2021')
insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH0010',N'XYZ Else',20,N'Nam',0123456789,'12/05/2021')
insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH0011',N'LMN',22,N'Nu',0123456789,'12/02/2021')


truncate table PTSchedule
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'4',N'Pham Viet Hoang',2,1)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'4',N'Pham Viet Hoang',2,2)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'4',N'Pham Viet Hoang',2,3)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'5',N'Phan Viet Duc',3,1)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'5',N'Phan Viet Duc',3,2)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'5',N'Phan Viet Duc',3,3)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'6',N'Nguyen Viet My',4,1)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'6',N'Nguyen Viet My',4,2)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'6',N'Nguyen Viet My',4,3)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'4',N'Pham Viet Hoang',5,1)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'4',N'Pham Viet Hoang',5,2)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'4',N'Pham Viet Hoang',5,3)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'5',N'Phan Viet Duc',6,1)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'5',N'Phan Viet Duc',6,2)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'5',N'Phan Viet Duc',6,3)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'6',N'Nguyen Viet My',7,1)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'6',N'Nguyen Viet My',7,2)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'6',N'Nguyen Viet My',7,3)

truncate table GoiTap
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'yoga1','Yoga 1 tháng',1,N'Gói tập Yoga 1 tháng') --300
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'yoga3','Yoga 3 tháng',3,N'Gói tập Yoga 3 tháng') --800
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'yoga-pt1','Yoga PT 1 tháng',1,N'Gói tập Yoga 1 tháng có PT kèm 1-1') --600
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'yoga-pt3','Yoga PT 3 tháng',3,N'Gói tập Yoga 3 tháng có PT kèm 1-1') --1200
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'fitness1','fitness 1 tháng',1,N'Gói tập fitness 1 tháng') --400
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'fitness3','fitness 3 tháng',3,N'Gói tập fitness 3 tháng') --1000
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'fitness-pt1','fitness PT 1 tháng',1,N'Gói tập fitness 1 tháng có PT kèm 1-1') --500
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'fitness-pt3','fitness PT 3 tháng',3,N'Gói tập fitness 3 tháng có PT kèm 1-1') --1200
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'gym1','gym 1 tháng',1,N'Gói tập gym 1 tháng') --500
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'gym3','gym 3 tháng',3,N'Gói tập gym 3 tháng') --1200
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'gym-pt1','gym PT 1 tháng',1,N'Gói tập gym 1 tháng có PT kèm 1-1') --700
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'gym-pt3','gym PT 3 tháng',3,N'Gói tập gym 3 tháng có PT kèm 1-1') --1900

truncate table MonthlyIncome
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0001','yoga1','12/02/2021',1,300000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0001','yoga1','12/03/2021',1,300000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0001','yoga1','12/04/2021',1,300000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0001','yoga1','12/05/2021',1,300000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0001','yoga1','12/06/2021',1,300000)

insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0002','gym-pt3','12/01/2021',3,1900000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0002','gym-pt3','12/02/2021',3,1900000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0002','gym-pt3','12/03/2021',3,1900000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0002','gym-pt3','12/04/2021',3,1900000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0002','gym-pt3','12/05/2021',3,1900000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0002','gym-pt3','12/06/2021',3,1900000)

insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0003','fitness-pt1','12/03/2021',1,500000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0003','fitness-pt1','12/04/2021',1,500000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0003','fitness-pt1','12/05/2021',1,500000)

insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0004','fitness1','12/05/2021',1,400000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0004','fitness1','12/06/2021',1,400000)

insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0005','yoga1','12/01/2021',1,300000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0005','yoga1','12/02/2021',1,300000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0005','yoga1','12/03/2021',1,300000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0005','yoga1','12/04/2021',1,300000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0005','yoga1','12/05/2021',1,300000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0005','yoga1','12/06/2021',1,300000)

insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0006','fitness-pt3','12/05/2021',3,1200000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0006','fitness-pt3','12/06/2021',3,1200000)

insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0007','fitness1','12/04/2021',1,400000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0007','fitness1','12/05/2021',1,400000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0007','fitness1','12/06/2021',1,400000)

insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0008','fitness-pt3','12/04/2021',3,1200000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0008','fitness-pt3','12/05/2021',3,1200000)

insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0009','fitness-pt3','12/03/2021',3,1200000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0009','fitness-pt3','12/04/2021',3,1200000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0009','fitness-pt3','12/05/2021',3,1200000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0009','fitness-pt3','12/06/2021',3,1200000)

insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0010','gym-pt3','12/05/2021',3,1900000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0010','gym-pt3','12/06/2021',3,1900000)

insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0011','fitness3','12/02/2021',3,1000000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0011','fitness3','12/03/2021',3,1000000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0011','fitness3','12/04/2021',3,1000000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0011','fitness3','12/05/2021',3,1000000)
insert into MonthlyIncome (maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values ('KH0011','fitness3','12/06/2021',3,1000000)

truncate table Attendance
insert into Attendance (ma,thoigian, alias) 
values ('KH0011',CONVERT(datetime, '2021-06-20 19:44:36.443', 120),N'Hội viên')
insert into Attendance (ma,thoigian,alias)
values ('KH0011',CONVERT(datetime, '2021-06-20 19:46:36.443', 120),N'Hội viên')
insert into Attendance (ma,thoigian,alias)
values ('KH0011',CONVERT(datetime, '2021-06-20 19:45:36.443', 120),N'Hội viên')
insert into Attendance (ma,thoigian,alias)
values ('KH0011',CONVERT(datetime, '2021-06-20 19:47:36.443', 120),N'Hội viên')
insert into Attendance (ma,thoigian,alias)
values ('KH0011',CONVERT(datetime, '2021-06-20 19:50:36.443', 120),N'Hội viên')

truncate table Feedback
insert into Feedback (maKH,thoigian,feedback) 
values ('KH0011','13/06/2021',N'Rất tốt')
insert into Feedback (maKH,thoigian,feedback) 
values ('KH0005','09/05/2021',N'Dịch vụ đầy đủ')
insert into Feedback (maKH,thoigian,feedback) 
values ('KH0010','25/07/2021',N'Nhân viên tận tình')
insert into Feedback (maKH,thoigian,feedback) 
values ('KH0007','29/09/2021',N'Cần trang bị thêm máy tập')
insert into Feedback (maKH,thoigian,feedback) 
values ('KH0009','30/04/2021',N'Phòng rộng rãi')






	

create database GymManagement

use GymManagement

create table TrangThietBi (
	ten nvarchar(50),
	ma nvarchar(10),
	tinhTrang nvarchar(50),
	ngayMua date,
	giaThanh int,
	baoHanh int,
	ngayHetHanBaoHanh date,
	hangSanXuat nvarchar(50)
)
CREATE TABLE NHANVIEN (
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
create table DanhSachHoiVien (
	ma char(10) primary key,
	ten nvarchar(50),
	tuoi INT, 
	gioiTinh	NCHAR (10),
	soDT BIGINT,
	ngayThamGia date,
	ngayKetThuc date,
);

drop table DanhSachHoiVien



CREATE TABLE monthBucket(
bucketName nvarchar(10),
bucketFirstDay date,
bucketLastDay date 
);


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

create table LogInData (
	dataID nvarchar(10),
	ma char(10) ,
	permissionLevel int,
	username nvarchar(30),
	passW nvarchar(30)
)

Create table PTSchedule (
	ID       NCHAR (32) NOT NULL,
    HoTen    NCHAR (32) NOT NULL,
	Thu	int,
	Buoi int
)



--dummy Data--
SET DATEFORMAT dmy; 

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





INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'1', N'Phan Duy Đức', N'Nam', N'ducduypm0120@gmai.com', 376771465, N'KTX khu A', N'Admin', CAST(10000000.0000 AS Money))
INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'2', N'Hua Van Tuan Anh', N'Nam', N'tuananh123@gmail.com', 167645234, N'Thu Duc', N'Admin', CAST(10000000.0000 AS Money))
INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'3', N'Pham Xuan Vinh', N'Nam', N'vinhpham@gmail.com', 234567891, N'Thu Duc', N'Admin', CAST(10000000.0000 AS Money))

INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'4', N'Phan Duy Đức', N'Nam', N'ducduypm0120@gmai.com', 376771465, N'KTX khu A', N'PT', CAST(10000000.0000 AS Money))
INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'5', N'Hua Van Tuan Anh', N'Nam', N'tuananh123@gmail.com', 167645234, N'Thu Duc', N'PT', CAST(10000000.0000 AS Money))
INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'6', N'Pham Xuan Vinh', N'Nam', N'vinhpham@gmail.com', 234567891, N'Thu Duc', N'PT', CAST(10000000.0000 AS Money))


delete from NHANVIEN

--drop table DanhSachHoiVien

insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
values ('KH001',N'Trương Nguyễn Tuấn Nam',22,N'Nam',0123456789,'12/02/2021','12/08/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
values ('KH002',N'Phan Duy',21,N'Nam',0123456789,'12/01/2021','12/08/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
values ('KH003',N'Vinh',20,N'Nam',0123456789,'12/03/2021','12/05/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
values ('KH004',N'Tuan Anh',22,N'Nu',0123456789,'12/05/2021','12/09/2022')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
values ('KH005',N'Hoang Tuan Kiet',22,N'Nam',0123456789,'12/01/2021','12/07/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
values ('KH006',N'Someone',21,N'Nam',0123456789,'12/05/2021','12/08/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
values ('KH007',N'Someone Else',20,N'Nam',0123456789,'12/04/2021','12/12/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
values ('KH008',N'Stranger',22,N'Nu',0123456789,'12/04/2021','12/10/2022')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
values ('KH009',N'ABC',21,N'Nam',0123456789,'12/03/2021','12/11/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
values ('KH010',N'XYZ Else',20,N'Nam',0123456789,'12/05/2021','12/09/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
values ('KH011',N'LMN',22,N'Nu',0123456789,'12/02/2021','12/11/2022')





INSERT INTO LogInData (dataID, ma, permissionLevel, username, passW) VALUES ('Log01','1',1,'duc','1234')
INSERT INTO LogInData (dataID, ma, permissionLevel, username, passW) VALUES ('Log02','2',1,'anh','1234')
INSERT INTO LogInData (dataID, ma, permissionLevel, username, passW) VALUES ('Log03','3',1,'vinh','1234')

select passW from LogInData where username = 'Duc'

SELECT CASE WHEN EXISTS ( SELECT * FROM LogInData WHERE username = 'duc' and passW = '1234') THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

Select NHANVIEN.ID 
from NHANVIEN inner join LogInData on NHANVIEN.ID = LogInData.ma
where LogInData.username = 'duc'

Select NHANVIEN.ID 
from NHANVIEN inner join LogInData on NHANVIEN.ID = LogInData.ma
where LogInData.username = 'duc'

Select LogInData.permissionLevel 
from NHANVIEN inner join LogInData on NHANVIEN.ID = LogInData.ma
where LogInData.username = 'duc'



INSERT INTO LogInData (dataID, ma, permissionLevel, username, passW) VALUES ('Log01','1',1,'duc','1234')
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'4',N'Phan Duy Đức',2,1)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'4',N'Phan Duy Đức',2,2)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'4',N'Phan Duy Đức',2,3)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'5',N'Hua Van Tuan Anh',3,1)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'5',N'Hua Van Tuan Anh',3,2)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'5',N'Hua Van Tuan Anh',3,3)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'6',N'Pham Xuan Vinh',4,1)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'6',N'Pham Xuan Vinh',4,2)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'6',N'Pham Xuan Vinh',4,3)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'4',N'Phan Duy Đức',5,1)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'4',N'Phan Duy Đức',5,2)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'4',N'Phan Duy Đức',5,3)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'5',N'Hua Van Tuan Anh',6,1)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'5',N'Hua Van Tuan Anh',6,2)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'5',N'Hua Van Tuan Anh',6,3)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'6',N'Pham Xuan Vinh',7,1)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'6',N'Pham Xuan Vinh',7,2)
insert into PTSchedule (ID, HoTen, Thu,Buoi) values (N'6',N'Pham Xuan Vinh',7,3)
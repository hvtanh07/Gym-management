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

create table GoiTap (
	ma		nvarchar(20),
	ten		nvarchar(30),
	thoiHan	int,
	moTa	nvarchar(50)
)

Create table MonthlyIncome (
	ID				char(10) primary key,
	maKH			char(10),
	maGoiTap		char(20),
	dateOfPay		date,
	PaymentPeriod	int, --pay for how long		
    price			int
)
drop table DanhSachHoiVien

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

--insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
--values ('KH001',N'Trương Nguyễn Tuấn Nam',22,N'Nam',0123456789,'12/02/2021','12/08/2021')
--insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
--values ('KH002',N'Phan Duy',21,N'Nam',0123456789,'12/01/2021','12/08/2021')
--insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
--values ('KH003',N'Vinh',20,N'Nam',0123456789,'12/03/2021','12/05/2021')
--insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
--values ('KH004',N'Tuan Anh',22,N'Nu',0123456789,'12/05/2021','12/09/2022')
--insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
--values ('KH005',N'Hoang Tuan Kiet',22,N'Nam',0123456789,'12/01/2021','12/07/2021')
--insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
--values ('KH006',N'Someone',21,N'Nam',0123456789,'12/05/2021','12/08/2021')
--insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
--values ('KH007',N'Someone Else',20,N'Nam',0123456789,'12/04/2021','12/12/2021')
--insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
--values ('KH008',N'Stranger',22,N'Nu',0123456789,'12/04/2021','12/10/2022')
--insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
--values ('KH009',N'ABC',21,N'Nam',0123456789,'12/03/2021','12/11/2021')
--insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
--values ('KH010',N'XYZ Else',20,N'Nam',0123456789,'12/05/2021','12/09/2021')
--insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) 
--values ('KH011',N'LMN',22,N'Nu',0123456789,'12/02/2021','12/11/2022')

insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH001',N'Trương Nguyễn Tuấn Nam',22,N'Nam',0123456789,'12/02/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH002',N'Phan Duy',21,N'Nam',0123456789,'12/01/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) --
values ('KH003',N'Vinh',20,N'Nam',0123456789,'12/03/2021','12/07/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH004',N'Tuan Anh',22,N'Nu',0123456789,'12/05/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH005',N'Hoang Tuan Kiet',22,N'Nam',0123456789,'12/01/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH006',N'Someone',21,N'Nam',0123456789,'12/05/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH007',N'Someone Else',20,N'Nam',0123456789,'12/04/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) --
values ('KH008',N'Stranger',22,N'Nu',0123456789,'12/04/2021','12/10/2022')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH009',N'ABC',21,N'Nam',0123456789,'12/03/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH010',N'XYZ Else',20,N'Nam',0123456789,'12/05/2021')
insert into DanhSachHoiVien (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) 
values ('KH011',N'LMN',22,N'Nu',0123456789,'12/02/2021')

INSERT INTO LogInData (dataID, ma, permissionLevel, username, passW) VALUES ('Log01','1',1,'duc','1234')
INSERT INTO LogInData (dataID, ma, permissionLevel, username, passW) VALUES ('Log02','2',1,'anh','1234')
INSERT INTO LogInData (dataID, ma, permissionLevel, username, passW) VALUES ('Log03','3',1,'vinh','1234')


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

drop table PTSchedule

insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'yoga1','Yoga 1 tháng',1,N'Gói tập Yoga 1 tháng') --300
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'yoga3','Yoga 3 tháng',1,N'Gói tập Yoga 3 tháng') --800
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'yoga-pt1','Yoga PT 1 tháng',1,N'Gói tập Yoga 1 tháng có PT kèm 1-1') --600
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'yoga-pt3','Yoga PT 3 tháng',1,N'Gói tập Yoga 3 tháng có PT kèm 1-1') --1200
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'fitness1','fitness 1 tháng',1,N'Gói tập fitness 1 tháng') --400
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'fitness3','fitness 3 tháng',1,N'Gói tập fitness 3 tháng') --1000
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'fitness-pt1','fitness PT 1 tháng',1,N'Gói tập fitness 1 tháng có PT kèm 1-1') --500
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'fitness-pt3','fitness PT 3 tháng',1,N'Gói tập fitness 3 tháng có PT kèm 1-1') --1200
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'gym1','gym 1 tháng',1,N'Gói tập gym 1 tháng') --500
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'gym3','gym 3 tháng',1,N'Gói tập gym 3 tháng') --1200
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'gym-pt1','gym PT 1 tháng',1,N'Gói tập gym 1 tháng có PT kèm 1-1') --700
insert into GoiTap (ma,ten,thoiHan,moTa) 
values (N'gym-pt3','gym PT 3 tháng',1,N'Gói tập gym 3 tháng có PT kèm 1-1') --1900

insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM001','KH001','yoga1','12/02/2021',1,300000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM012','KH001','yoga1','12/03/2021',1,300000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM013','KH001','yoga1','12/04/2021',1,300000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM014','KH001','yoga1','12/05/2021',1,300000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM015','KH001','yoga1','12/06/2021',1,300000)

insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM002','KH002','gym-pt3','12/01/2021',3,1900000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM017','KH002','gym-pt3','12/02/2021',3,1900000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM018','KH002','gym-pt3','12/03/2021',3,1900000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM019','KH002','gym-pt3','12/04/2021',3,1900000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM020','KH002','gym-pt3','12/05/2021',3,1900000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM021','KH002','gym-pt3','12/06/2021',3,1900000)

insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM003','KH003','fitness-pt1','12/03/2021',1,500000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM016','KH003','fitness-pt1','12/04/2021',1,500000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM022','KH003','fitness-pt1','12/05/2021',1,500000)

insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM004','KH004','fitness1','12/05/2021',1,400000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM023','KH004','fitness1','12/06/2021',1,400000)

insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM005','KH005','yoga1','12/01/2021',1,300000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM024','KH005','yoga1','12/02/2021',1,300000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM025','KH005','yoga1','12/03/2021',1,300000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM026','KH005','yoga1','12/04/2021',1,300000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM027','KH005','yoga1','12/05/2021',1,300000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM028','KH005','yoga1','12/06/2021',1,300000)

insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM006','KH006','fitness-pt3','12/05/2021',3,1200000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM029','KH006','fitness-pt3','12/06/2021',3,1200000)

insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM007','KH007','fitness1','12/04/2021',1,400000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM030','KH007','fitness1','12/05/2021',1,400000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM031','KH007','fitness1','12/06/2021',1,400000)

insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM008','KH008','fitness-pt3','12/04/2021',3,1200000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM032','KH008','fitness-pt3','12/05/2021',3,1200000)

insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM009','KH009','fitness-pt3','12/03/2021',3,1200000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM033','KH009','fitness-pt3','12/04/2021',3,1200000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM034','KH009','fitness-pt3','12/05/2021',3,1200000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM035','KH009','fitness-pt3','12/06/2021',3,1200000)

insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM010','KH010','gym-pt3','12/05/2021',3,1900000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM036','KH010','gym-pt3','12/06/2021',3,1900000)

insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM011','KH011','fitness3','12/02/2021',3,1000000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM037','KH011','fitness3','12/03/2021',3,1000000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM038','KH011','fitness3','12/04/2021',3,1000000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM039','KH011','fitness3','12/05/2021',3,1000000)
insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) 
values (N'PM040','KH011','fitness3','12/06/2021',3,1000000)


--Lay hoi vien và tình trạng thanh toán

--, DATEDIFF(day,getdate(),DATEADD(month,MonthlyIncome.PaymentPeriod,MonthlyIncome.dateOfPay)) as DayRemain
Select DanhSachHoiVien.ten as HoiVien, MonthlyIncome.dateOfPay,
trim(GoiTap.ma) + ' - ' + trim(GoiTap.ten) as Goi, MonthlyIncome.price
From MonthlyIncome inner join 
	 DanhSachHoiVien on DanhSachHoiVien.ma = MonthlyIncome.maKH inner join 
	 GoiTap			 on GoiTap.ma = MonthlyIncome.maGoiTap
Where DanhSachHoiVien.ma = 'KH004'

Delete from MonthlyIncome 
where maKH = 'Trương Nguyễn Tuấn Nam' AND year(dateOfPay) = '2021' and month(dateOfPay) = '7' and day(dateOfPay) = '15'


select ma from DanhSachHoiVien where ten = N'Trương Nguyễn Tuấn Nam'


	 




	

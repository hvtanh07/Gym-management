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
	ma char(10),
	ten nvarchar(50),
	ngayThamGia date,
	ngayKetThuc date
)
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


--drop table DanhSachHoiVien

insert into DanhSachHoiVien (ma, ten, ngayThamGia, ngayKetThuc) 
values (1,N'Trương Nguyễn Tuấn Nam','12/02/2021','12/08/2021')
insert into DanhSachHoiVien (ma, ten, ngayThamGia, ngayKetThuc) 
values (2,N'Nguyễn Tuấn Nam','12/03/2021','12/09/2021')
insert into DanhSachHoiVien (ma, ten, ngayThamGia, ngayKetThuc) 
values (3,N'Trương Nam','12/04/2021','12/10/2021')
insert into DanhSachHoiVien (ma, ten, ngayThamGia, ngayKetThuc) 
values (4,N'Nguyễn Tuấn','12/05/2021','12/11/2021')
insert into DanhSachHoiVien (ma, ten, ngayThamGia, ngayKetThuc) 
values (5,N'TrươngTuấn','12/06/2021','12/12/2021')
insert into DanhSachHoiVien (ma, ten, ngayThamGia, ngayKetThuc) 
values (6,N'Trương Hồ','13/06/2021','12/12/2021')


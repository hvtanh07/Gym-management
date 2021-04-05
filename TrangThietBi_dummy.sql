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

drop table TrangThietBi

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

INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'1', N'Phan Duy Đức', N'Nam', N'ducduypm0120@gmai.com', 376771465, N'KTX khu A', N'Admin', CAST(10000000.0000 AS Money))
INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'2', N'Hua Van Tuan Anh', N'Nam', N'tuananh123@gmail.com', 167645234, N'Thu Duc', N'Admin', CAST(10000000.0000 AS Money))
INSERT INTO NHANVIEN (ID, HoTen, GioiTinh, Email, SoDT, DiaChi, ChucVu, Luong) VALUES (N'3', N'Pham Xuan Vinh', N'Nam', N'vinhpham@gmail.com', 234567891, N'Thu Duc', N'Admin', CAST(10000000.0000 AS Money))


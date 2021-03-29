create database GymManagement

use GymManagement

create table TrangThietBi (
	ten nvarchar(50),
	ma nvarchar(10),
	soLuong int,
	tinhTrang nvarchar(50)
)

--dummy Data--

insert into TrangThietBi (ten, ma, soLuong, tinhTrang) values (N'Tạ tay','Ta-001',12,N'Còn tốt') 
insert into TrangThietBi (ten, ma, soLuong, tinhTrang) values (N'Khung gánh tạ trợ lực','Ma-001',5,N'Còn tốt') 
insert into TrangThietBi (ten, ma, soLuong, tinhTrang) values (N'Ghế tập tạ','Ta-002',2,N'Còn tốt') 
insert into TrangThietBi (ten, ma, soLuong, tinhTrang) values (N'Máy tập ngực','Ma-002',12,N'Hỏng') 
insert into TrangThietBi (ten, ma, soLuong, tinhTrang) values (N'Máy tập đùi trong','Ma-003',3,N'Còn tốt') 
insert into TrangThietBi (ten, ma, soLuong, tinhTrang) values (N'Máy tập đùi ngoài','Ma-004',1,N'Đang bảo trì') 

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


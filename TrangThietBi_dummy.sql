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

create table DanhSachHoiVien (
	ma char(10),
	ten nvarchar(50),
	ngayThamGia date,
)

insert into DanhSachHoiVien (ma, ten, ngayThamGia) 
values (1,N'Trương Nguyễn Tuấn Nam','12/02/2021')
insert into DanhSachHoiVien (ma, ten, ngayThamGia) 
values (2,N'Nguyễn Tuấn Nam','12/03/2021')
insert into DanhSachHoiVien (ma, ten, ngayThamGia) 
values (3,N'Trương Nam','12/04/2021')
insert into DanhSachHoiVien (ma, ten, ngayThamGia) 
values (4,N'Nguyễn Tuấn','12/05/2021')
insert into DanhSachHoiVien (ma, ten, ngayThamGia) 
values (5,N'TrươngTuấn','12/06/2021')
insert into DanhSachHoiVien (ma, ten, ngayThamGia) 
values (6,N'Trương Hồ','13/06/2021')

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

drop procedure GetTotalMembers

create procedure GetTotalMembers
as
	select month (ngayThamGia) as Month, count (ma) as Total
	from DanhSachHoiVien
	where ngayThamGia is not null
	group by month (ngayThamGia)
	order by month (ngayThamGia) asc
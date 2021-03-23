create database GymManagement

use GymManagement

create table TrangThietBi (
	ten nvarchar(50),
	ma nvarchar(10),
	soLuong int,
	tinhTrang nvarchar(50),
	ngayMua date,
	giaThanh int,
	baoHanh int,
	ngayHetHanBaoHanh date,
	hangSanXuat nvarchar(50)
)

--dummy Data--
SET DATEFORMAT dmy;  
insert into TrangThietBi (ten, ma, soLuong, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat) 
values (N'Tạ tay','Ta-001',12,N'Còn tốt','04/05/2020',500,0,'04/05/2020',N'workoutNow') 

insert into TrangThietBi (ten, ma, soLuong, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat)
values (N'Khung gánh tạ trợ lực','Ma-001',5,N'Còn tốt','15/07/2020',12000,6,'15/01/2021',N'workoutNow')

insert into TrangThietBi (ten, ma, soLuong, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat)
values (N'Ghế tập tạ','Ta-002',2,N'Còn tốt','19/05/2020',800,6,'19/11/2020',N'workoutNow') 

insert into TrangThietBi (ten, ma, soLuong, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat)
values (N'Máy tập ngực','Ma-002',12,N'Hỏng','20/05/2020',1000,12,'20/05/2021',N'workoutLater') 

insert into TrangThietBi (ten, ma, soLuong, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat)
values (N'Máy tập đùi trong','Ma-003',3,N'Còn tốt','27/10/2020',13000,12,'27/10/2021',N'workoutNo') 

insert into TrangThietBi (ten, ma, soLuong, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat) 
values (N'Máy tập đùi ngoài','Ma-004',1,N'Trong kho','27/05/2020',10000,12,'27/05/2021',N'workoutNo') 

drop table TrangThietBi
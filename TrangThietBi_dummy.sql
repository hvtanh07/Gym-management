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
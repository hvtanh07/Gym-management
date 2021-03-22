create database GymManagement

use GymManagement

create table TrangThietBi (
	ten nvarchar(50),
	ma nvarchar(10),
	soLuong int,
	tinhTrang nvarchar(50)
)

--dummy Data--

insert into TrangThietBi (ten, ma, soLuong, tinhTrang) values ('Tạ tay','Ta-001',12,'Còn tốt') 
insert into TrangThietBi (ten, ma, soLuong, tinhTrang) values ('Khung gánh tạ trợ lực','Ma-001',12,'Còn tốt') 
insert into TrangThietBi (ten, ma, soLuong, tinhTrang) values ('Ghế tập tạ','Ta-002',12,'Còn tốt') 
insert into TrangThietBi (ten, ma, soLuong, tinhTrang) values ('Máy tập ngực','Ma-002',12,'Hỏng') 
insert into TrangThietBi (ten, ma, soLuong, tinhTrang) values ('Máy tập đùi trong','Ma-003',12,'Còn tốt') 
insert into TrangThietBi (ten, ma, soLuong, tinhTrang) values ('Máy tập đùi ngoài','Ma-004',12,'Đang bảo trì') 

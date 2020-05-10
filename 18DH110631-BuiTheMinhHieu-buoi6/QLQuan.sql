create database QLQuan
use QLQuan
create table  ThucUong(
	MSHH nvarchar (10) constraint PK_ThucUong PRIMARY KEY,
	TenHang nvarchar (20),
	Gia INT NOT NULL,
	TinhTrang bit,
)
create table DatHang(
	MSDH nvarchar (10) CONSTRAINT PK_DatHang PRIMARY KEY,
	MSHH nvarchar (10),
	SoLuong int,
	TiLeGiam int
)

create table HoaDon(
	MSDH nvarchar (10),
	NgayDat datetime
)
alter table DatHang add constraint FK__DatHang_ThucUong foreign key (MSHH) REFERENCES ThucUong(MSHH)
alter table HoaDon add constraint FK_HoaDon_DatHang foreign key (MSDH) REFERENCES DatHang(MSDH)
create database BankingCardProcessor;

use BankingCardProcessor;

create table ThongTinKhachHang (
	UserId varchar(5),
	HoTenKH nvarchar(100),
	GioiTinh nvarchar(10),
	CMND varchar(20),
	NamSinhKH date,
	DiaChiKH nvarchar(100),
	SDT varchar(10),
	primary key (UserId)
);

create table ThongTinCard (
	UserId varchar(5),
	CardId varchar(20),
	MaPin varchar(6),
	SoDu int,
	primary key (CardId),
)

create table ThongTinGiaoDich (
	CardID varchar(20),
	MaGD varchar(5),
	LoaiGD nvarchar(50),
	ThoiGianGD date,
	SoTienGD varchar(15),
	primary key (MaGD)
)

create table ChiTietGiaoDich (
	MaGD varchar(5),
	TienVao int,
	TienRa int,
	NguoiNhan nvarchar(100),
	NguoiGui nvarchar(100),
	NoiDung nvarchar(200),
)

create table ThongTinServicePayment(
	LoaiService nvarchar(20),
	CardID varchar(20),
	KhuVuc nvarchar(20),
	SoTien varchar(15),
	TrangThai int
)
----------------------------------------------------------
insert into ThongTinKhachHang values ('001','Nguyen Quoc Trung','Nam','261626518','5/15/2001','Phu Quy','0708380170')
insert into ThongTinKhachHang values ('002','Nguyen Ngoc Hung','Nam','261626529','2/1/2001','Kien Giang','012990204')

insert into ThongTinCard values ('001','4815123456','123456','10000000')
insert into ThongTinCard values ('002','4815123457','123456','20000000')

--Electricity  --Dien luc TP HCM, Dien luc TP Ha Noi, Dien luc mien Bac, Dien luc mien Trung, Dien luc mien Nam
--Water        --Cong ty nuoc sach Ha Noi, Cap nuoc Cho Lon - TP.HCM, Cap nuoc Binh Thuan, Cap nuoc Kien Giang
--Internet     --VNPT, FPT Telecom, Viettel, CMC Telecom

insert into ThongTinServicePayment values ('Electricity','4815123456','Dien luc TP HCM','495000',0)
insert into ThongTinServicePayment values ('Water','4815123456','Cap nuoc Binh Thuan','278000',0)
insert into ThongTinServicePayment values ('Internet','4815123456','VNPT','165000',0)

insert into ThongTinServicePayment values ('Electricity','4815123457','Dien luc TP Ha Noi','495000',0)
insert into ThongTinServicePayment values ('Water','4815123457','Cap nuoc Kien Giang','278000',0)
insert into ThongTinServicePayment values ('Internet','4815123457','FPT Telecom','165000',0)
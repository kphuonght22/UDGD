create database	BakeryManager
go
use BakeryManager
go

create table Acccount
(
	userName nvarchar(100) primary key,
	displayName nvarchar(100) not null default N'Chưa có tên',
	passWord nvarchar(100) not null,
	type int default 0
)
go

create table Customer
(
	id int identity primary key,
	phoneNum int not null,
	name nvarchar(100) not null default N'Customer',
	point int default 0
)
go

create table FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa có tên',
)
go

create table Food
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa có tên',
	idCategory int not null,
	price float not null default 0,

	foreign key (idCategory) references FoodCategory(id)
)
go

create table Bill
(
	id int identity primary key,
	idCustomer int not null,
	timePay date not null default getdate(),

	foreign key (idCustomer) references Customer(id)
)
go

create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0,

	foreign key (idBill) references Bill(id),
	foreign key (idFood) references Food(id)
)
go
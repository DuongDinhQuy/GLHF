drop database GLHF
go

create database GLHF
go

use GLHF
go

create table Users
( Acc nvarchar(50) primary key
, Pass nvarchar(50)
, UserName nvarchar(50)
, Age int
, Gender nvarchar(50) 
)
go

insert into Users values ('1', '1', N'Admin', 100, 'Nam')
insert into Users values ('quy.dd210728', 'quydd', N'Dương Đình Quý', 21, 'Nam')
insert into Users values ('dat.nt210170', 'datnt', N'Nguyễn Tiến Đạt', 20, 'Nam')
insert into Users values ('giap.ph213893', 'giapph', N'Phan Hoàng Giáp', 30, 'Nam')
insert into Users values ('trang.ntt210850', 'trangntt', N'Nguyễn Thị Thu Trang', 10, N'Nữ')

create table Category
( ID int primary key identity(1, 1)
, CategoryName nvarchar(50) 
)
go

insert into Category values (N'Ăn uống')
insert into Category values (N'Học tập')
insert into Category values (N'Mua sắm')
insert into Category values (N'Vui chơi')
insert into Category values (N'Di chuyển')
insert into Category values (N'Cho vay')
insert into Category values (N'Thu nhập')
insert into Category values (N'Phụ cấp')
insert into Category values (N'Tiền thưởng')
insert into Category values (N'Thu nợ')

create table IncomeExpense
( ID int primary key identity(1, 1)
, UsersAcc nvarchar(50) foreign key references Users(Acc)
, Amount int
, CategoryId int foreign key references Category(ID)
, IEDate datetime
)
go
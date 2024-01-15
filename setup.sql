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

insert into IncomeExpense values (N'1', 1700000, 7, '2024-01-01 07:30:00')
insert into IncomeExpense values (N'1', -300000, 4, '2024-01-01 08:00:00')
insert into IncomeExpense values (N'1', -10000, 1, '2024-01-01 16:17:00')
insert into IncomeExpense values (N'1', -65000, 1, '2024-01-01 16:42:00')
insert into IncomeExpense values (N'1', -10000, 1, '2024-01-01 16:46:00')
insert into IncomeExpense values (N'1', -66000, 1, '2024-01-01 22:00:00')
insert into IncomeExpense values (N'1', -50000, 1, '2024-01-02 06:31:00')
insert into IncomeExpense values (N'1', -30000, 1, '2024-01-02 06:32:00')
insert into IncomeExpense values (N'1', -10000, 1, '2024-01-02 07:04:00')
insert into IncomeExpense values (N'1', -20000, 1, '2024-01-02 11:49:00')
insert into IncomeExpense values (N'1', -400000, 6, '2024-01-02 12:17:00')
insert into IncomeExpense values (N'1', -30000, 1, '2024-01-02 12:45:00')
insert into IncomeExpense values (N'1', -1000000, 3, '2024-01-02 12:46:00')
insert into IncomeExpense values (N'1', -127000, 4, '2024-01-02 15:14:00')
insert into IncomeExpense values (N'1', -140000, 3, '2024-01-02 15:25:00')
insert into IncomeExpense values (N'1', -42000, 1, '2024-01-02 15:34:00')
insert into IncomeExpense values (N'1', -70000, 5, '2024-01-02 17:57:00')
insert into IncomeExpense values (N'1', 600000, 8, '2024-01-03 10:37:00')
insert into IncomeExpense values (N'1', -10000, 1, '2024-01-03 17:30:00')
insert into IncomeExpense values (N'1', -245000, 1, '2024-01-04 10:32:00')
insert into IncomeExpense values (N'1', -35000, 1, '2024-01-04 12:44:00')
insert into IncomeExpense values (N'1', -95000, 4, '2024-01-04 15:11:00')
insert into IncomeExpense values (N'1', 50000, 10, '2024-01-04 15:23:00')
insert into IncomeExpense values (N'1', -20000, 1, '2024-01-04 17:12:00')
insert into IncomeExpense values (N'1', -15000, 1, '2024-01-05 07:02:00')
insert into IncomeExpense values (N'1', -36000, 1, '2024-01-05 08:36:00')
insert into IncomeExpense values (N'1', -500000, 6, '2024-01-05 13:31:00')
insert into IncomeExpense values (N'1', -108000, 3, '2024-01-05 17:28:00')
insert into IncomeExpense values (N'1', -270000, 4, '2024-01-05 17:39:00')
insert into IncomeExpense values (N'1', 67000, 10, '2024-01-05 21:07:00')

insert into IncomeExpense values (N'dat.nt210170', -70000, 1, '2024-01-10 19:48:00')
insert into IncomeExpense values (N'dat.nt210170', -125000, 1, '2024-01-15 11:48:15')
insert into IncomeExpense values (N'dat.nt210170', -60000, 1, '2024-01-15 20:00:00')
insert into IncomeExpense values (N'dat.nt210170', -567000, 3, '2024-01-14 02:00:00')
insert into IncomeExpense values (N'dat.nt210170', -500000, 4, '2024-01-13 15:00:00')
insert into IncomeExpense values (N'dat.nt210170', 4000000, 7, '2024-01-20 22:00:00')
insert into IncomeExpense values (N'dat.nt210170', 1500000, 9, '2023-05-06 20:20:20')
insert into IncomeExpense values (N'dat.nt210170', 100000, 10, '2023-05-06 22:20:20')

insert into IncomeExpense values (N'quy.dd210728', -240000, 1, '2024-01-20 22:00:00')
insert into IncomeExpense values (N'quy.dd210728', -120000, 3, '2024-01-02 11:20:00')
insert into IncomeExpense values (N'quy.dd210728', -20000, 4, '2024-01-03 19:47:32')
insert into IncomeExpense values (N'quy.dd210728', 5000000, 7, '2024-01-04 20:15:00')
insert into IncomeExpense values (N'quy.dd210728', 600000, 9, '2023-12-18 01:30:00')
insert into IncomeExpense values (N'quy.dd210728', 140000, 10, '2023-12-30 11:47:00')
insert into IncomeExpense values (N'quy.dd210728', -1400000, 6, '2023-1-10 11:00:00')

insert into IncomeExpense values (N'giap.ph213893', -60000, 1, '2024-01-15 20:11:15')
insert into IncomeExpense values (N'giap.ph213893', -35000, 1, '2024-01-15 20:50:00')
insert into IncomeExpense values (N'giap.ph213893', -35000, 1, '2024-01-13 11:48:15')
insert into IncomeExpense values (N'giap.ph213893', 250000, 8, '2023-11-10 14:21:39')
insert into IncomeExpense values (N'giap.ph213893', 800000, 9, '2023-12-25 23:59:50')
insert into IncomeExpense values (N'giap.ph213893', -250000, 5, '2023-12-30 14:21:39')
insert into IncomeExpense values (N'giap.ph213893', -25000, 3, '2023-12-30 08:21:39')

insert into IncomeExpense values (N'trang.ntt210850', -35000, 1, '2024-01-02 06:35:18')
insert into IncomeExpense values (N'trang.ntt210850', -60000, 2, '2024-01-03 11:30:49')
insert into IncomeExpense values (N'trang.ntt210850', -125000, 3, '2024-01-03 18:30:28')
insert into IncomeExpense values (N'trang.ntt210850', -180000, 4, '2024-01-03 21:15:28')
insert into IncomeExpense values (N'trang.ntt210850', -140000, 5, '2024-01-06 17:30:00')
insert into IncomeExpense values (N'trang.ntt210850', -300000, 6, '2024-01-06 20:04:28')
insert into IncomeExpense values (N'trang.ntt210850', 3000000, 7, '2024-01-10 08:15:39')
insert into IncomeExpense values (N'trang.ntt210850', -32000, 1, '2024-01-15 07:45:00')

--create view IncomeExpenseView as
--select IE.*, C.CategoryName as CategoryName
--from IncomeExpense IE
--join Category C on C.ID = IE.CategoryId

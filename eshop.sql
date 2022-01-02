create database eShopManagement;

use eShopManagement;


/* Create Tables*/
create table Employee
(
	ID varchar(20),
	nameEmployee nvarchar(100),
	uname varchar(50),
	pwd varchar(50),
	addresses nvarchar(100),
	primary key(ID)
);

create table wareHouse
(
	productID varchar(20),
	productName nvarchar(100),
	quantity int,
	priceIn int,
	priceOut int,
	categoryName nvarchar(100),
	employeeID varchar(20),
	primary key(productID)
);

create table Customer
(
	cusID varchar(20),
	username varchar(100),
	passwords varchar(100),
	nameCus nvarchar(100),
	addressCus nvarchar(100),
	primary key(cusID)
);

create table Category
(
	nameCate nvarchar(100),
	primary key(nameCate)
);

create table Product
(
	productID varchar(20),
	namePrd nvarchar(100),
	img varchar(200),
	nameCate nvarchar(100),
	price int,
	primary key(productID)
);

create table Bill
(
	billID varchar(20),
	empID varchar(20),
	cusID varchar(20),
	datePick date,
	primary key(billID)
);

create table BillDetail
(
	prdID varchar(20),
	quantity int,
	price int,
	billID varchar(20),
	primary key(prdID)
);



alter table wareHouse
add constraint FK_Ware_Emp
foreign key (employeeID) references Employee(ID);

alter table Product
add constraint FK_Prd_Cate 
foreign key (nameCate) references Category(nameCate);

alter table Bill
add constraint FK_Bill_Cus
foreign key (cusID) references Customer(cusID);

alter table Bill
add constraint FK_Bill_Emp
foreign key (empID) references Employee(ID);

alter table BillDetail
add constraint FK_BillDe_Bill
foreign key (billID) references Bill(billID);

alter table BillDetail
add constraint FK_BillDe_Prd
foreign key (prdID) references Product(productID);

/* Insert values */

-- Employee table
insert into Employee (ID, nameEmployee, uname, pwd, addresses) values ('001', 'Bach Tran Anh Duc', 'username001', '123456', 'Ho Chi Minh City');
insert into Employee (ID, nameEmployee, uname, pwd, addresses) values ('002', 'Hoang Tuan Anh', 'username002', '123456', 'Ho Chi Minh City');


insert into wareHouse (productID, productName, quantity, priceIn, priceOut, categoryName, employeeID) values ('001', 'CoCaaa', '3', '10', '12', 'water', '002');



select * from Employee;
select * from Product;
select * from wareHouse;
select * from Customer;
select * from Bill;
select * from BillDetail;
select * from Category;

drop table wareHouse;
drop table Product;
drop table Employee;

delete from wareHouse where productID = '123'

drop database eShopManager
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

create table Bill
(
	bilID varchar(20),
	productID varchar(20), 
	productName nvarchar(100),
	price int,
	quantity int,
	times date,
	employeeID varchar(20),
	primary key(bilID)
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

create table Product
(
	prdName nvarchar(100),
	prdID varchar(20),
	billID varchar(20),
	img varchar(200),
	primary key(prdID)
);


/* Insert values */

-- Employee table
insert into Employee (ID, nameEmployee, uname, pwd, addresses) values ('001', 'Bach Tran Anh Duc', 'username001', '123456', 'Ho Chi Minh City');
insert into Employee (ID, nameEmployee, uname, pwd, addresses) values ('002', 'Hoang Tuan Anh', 'username002', '123456', 'Ho Chi Minh City');


insert into wareHouse (productID, productName, quantity, priceIn, priceOut, categoryName, employeeID) values ('001', 'CoCaaa', '3', '10', '12', 'water', '002');



select * from Employee;
select * from Product;
select * from wareHouse;

drop table wareHouse;
drop table Product;
drop table Employee;

delete from wareHouse where productID = '001'

drop database eShopManager
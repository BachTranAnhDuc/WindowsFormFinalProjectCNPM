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

alter table wareHouse
add constraint FK_Ware_Prd
foreign key (productID) references Product(productID);

alter table wareHouse
add constraint FK_Ware_Cate
foreign key (categoryName) references Category(nameCate);

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
insert into Employee (ID, nameEmployee, uname, pwd, addresses) values ('003', 'Nguyen Huu Nam', 'username003', '123456', 'Ho Chi Minh City');
insert into Employee (ID, nameEmployee, uname, pwd, addresses) values ('004', 'Tran Thien Phong', 'username004', '123456', 'Ho Chi Minh City');


insert into wareHouse (productID, productName, quantity, priceIn, priceOut, categoryName, employeeID) values ('001', 'CoCaaa', '3', '10', '12', 'water', '002');


insert into Category (nameCate) values ('2x2');
insert into Category (nameCate) values ('3x3');
insert into Category (nameCate) values ('4x4');
insert into Category (nameCate) values ('5x5');
insert into Category (nameCate) values ('clock');
insert into Category (nameCate) values ('megaminx');
insert into Category (nameCate) values ('mirror');
insert into Category (nameCate) values ('pyraminx');
insert into Category (nameCate) values ('skew-b');
insert into Category (nameCate) values ('bluetooth');
insert into Category (nameCate) values ('YJ');
insert into Category (nameCate) values ('Twist');



insert into Product (productID, namePrd, img, nameCate, price) values ('prd001', 'Rubik 2x2 Gan', 'some text', '2x2', 29);
insert into Product (productID, namePrd, img, nameCate, price) values ('prd002', 'Rubik 3x3 Dayan', 'some text', '3x3', 34);
insert into Product (productID, namePrd, img, nameCate, price) values ('prd003', 'Rubik 3x3 Gan 11 M Pro Frosted Black', 'some text', '3x3', 89);
insert into Product (productID, namePrd, img, nameCate, price) values ('prd004', 'Rubik 4x4 Gan', 'some text', '4x4', 99);
insert into Product (productID, namePrd, img, nameCate, price) values ('prd005', 'Rubik 5x5 Valk', 'some text', '5x5', 105);
insert into Product (productID, namePrd, img, nameCate, price) values ('prd006', 'Rubik Clock', 'some text', 'clock', 20);
insert into Product (productID, namePrd, img, nameCate, price) values ('prd007', 'Rubik Megaminx Gan', 'some text', 'megaminx', 103);
insert into Product (productID, namePrd, img, nameCate, price) values ('prd008', 'Rubk Mirror', 'some text', 'mirror', 10);
insert into Product (productID, namePrd, img, nameCate, price) values ('prd009', 'Rubik Pyraminx Gan', 'some text', 'pyraminx', 19);
insert into Product (productID, namePrd, img, nameCate, price) values ('prd010', 'Rubik Skew-b Gan', 'some text', 'skew-b', 25);
insert into Product (productID, namePrd, img, nameCate, price) values ('prd011', 'GoCube Bluetooth', 'some text', 'bluetooth', 199);
insert into Product (productID, namePrd, img, nameCate, price) values ('prd012', 'CuberSpeed ​​YJ Axis V2', 'some text', 'YJ', 16);
insert into Product (productID, namePrd, img, nameCate, price) values ('prd013', 'CuberSpeed Twist 3x3 stickerelss', 'some text', 'Twist', 14);


insert into Customer (cusID, username, passwords, nameCus, addressCus) values ('cus001', 'usernamecustomer1', '123456789', 'Name Shop 001', 'Ho Chi Minh City');
insert into Customer (cusID, username, passwords, nameCus, addressCus) values ('cus002', 'usernamecustomer2', '123456789', 'Name Shop 002', 'Ho Chi Minh City');
insert into Customer (cusID, username, passwords, nameCus, addressCus) values ('cus003', 'usernamecustomer3', '123456789', 'Name Shop 003', 'Ho Chi Minh City');
insert into Customer (cusID, username, passwords, nameCus, addressCus) values ('cus004', 'usernamecustomer4', '123456789', 'Name Shop 004', 'Ho Chi Minh City');
insert into Customer (cusID, username, passwords, nameCus, addressCus) values ('cus005', 'usernamecustomer5', '123456789', 'Name Shop 005', 'Ho Chi Minh City');

insert into Bill (billID, empID, cusID, datePick) values ('bill001', '004', 'cus002', '03/04/2021');
insert into Bill (billID, empID, cusID, datePick) values ('bill002', '001', 'cus001', '03/04/2021');
insert into Bill (billID, empID, cusID, datePick) values ('bill003', '003', 'cus004', '03/04/2021');
insert into Bill (billID, empID, cusID, datePick) values ('bill004', '002', 'cus003', '03/04/2021');
insert into Bill (billID, empID, cusID, datePick) values ('bill005', '004', 'cus005', '03/04/2021');


insert into BillDetail (prdID, quantity, price, billID) values ('prd001', 1, 105, 'bill001');
insert into BillDetail (prdID, quantity, price, billID) values ('prd002', 1, 20, 'bill001');
insert into BillDetail (prdID, quantity, price, billID) values ('prd003', 1, 103, 'bill001');
insert into BillDetail (prdID, quantity, price, billID) values ('prd004', 1, 10, 'bill001');

insert into BillDetail (prdID, quantity, price, billID) values ('prd005', 1, 29, 'bill002');
insert into BillDetail (prdID, quantity, price, billID) values ('prd006', 1, 34, 'bill002');
insert into BillDetail (prdID, quantity, price, billID) values ('prd007', 1, 89, 'bill002');
insert into BillDetail (prdID, quantity, price, billID) values ('prd008', 1, 99, 'bill002');

insert into BillDetail (prdID, quantity, price, billID) values ('prd012', 2, 32, 'bill003');
insert into BillDetail (prdID, quantity, price, billID) values ('prd011', 3, 597, 'bill003');
insert into BillDetail (prdID, quantity, price, billID) values ('prd010', 4, 100, 'bill003');
insert into BillDetail (prdID, quantity, price, billID) values ('prd013', 3, 42, 'bill003');

insert into wareHouse (productID, productName, quantity, priceIn, priceOut, categoryName, employeeID) values ('prd001', 'Rubik 2x2 Gan', 20, '6000', '6200', '2x2', '001');
insert into wareHouse (productID, productName, quantity, priceIn, priceOut, categoryName, employeeID) values ('prd002', 'Rubik 3x3 Dayan', 30, '7000', '7300', '3x3', '002');
insert into wareHouse (productID, productName, quantity, priceIn, priceOut, categoryName, employeeID) values ('prd003', 'Rubik 3x3 Gan 11 M Pro Frosted Black', 20, '7500', '8000', '3x3', '001');
insert into wareHouse (productID, productName, quantity, priceIn, priceOut, categoryName, employeeID) values ('prd004', 'Rubik 4x4 Gan', 10, '4000', '4200', '4x4', '003');
insert into wareHouse (productID, productName, quantity, priceIn, priceOut, categoryName, employeeID) values ('prd005', 'Rubik 5x5 Valk', 10, '4500', '4700', '5x5', '001');
insert into wareHouse (productID, productName, quantity, priceIn, priceOut, categoryName, employeeID) values ('prd006', 'Rubik Clock', 15, '3500', '3700', 'clock', '002');
insert into wareHouse (productID, productName, quantity, priceIn, priceOut, categoryName, employeeID) values ('prd007', 'Rubik Megaminx Gan', 40, '8000', '8200', 'megaminx', '003');
insert into wareHouse (productID, productName, quantity, priceIn, priceOut, categoryName, employeeID) values ('prd008', 'Rubik Megaminx Gan', 40, '8000', '8200', 'megaminx', '003');



select * from Employee;
select * from Product;
select * from wareHouse;
select * from Customer;
select * from Bill;
select * from BillDetail;
select * from Category;


-- Query to caculate quantity of category
select sum(quantity) as 'Quantity' from wareHouse 
inner join Product 
on wareHouse.productID = Product.productID 
where Product.nameCate = '3x3'


-- Query to find detail category
select Product.productID, Product.namePrd, Product.nameCate, wareHouse.quantity from Product
inner join Category
on Product.nameCate = Category.nameCate
inner join wareHouse
on Product.productID = wareHouse.productID
where Product.nameCate = '3x3'

select Product.productID, Product.namePrd, Product.nameCate, wareHouse.quantity from Product inner join Category on Product.nameCate = Category.nameCate inner join wareHouse on Product.productID = wareHouse.productID where Product.nameCate = '3x3'


-- Query to find Customer's detail bill
select Customer.cusID, Customer.nameCus, Bill.billID, Bill.empID, Bill.datePick from Customer
inner join Bill
on Customer.cusID = Bill.cusID
where Customer.cusID = 'cus002'

select Customer.cusID, Customer.nameCus, Bill.billID, Bill.empID, Bill.datePick from Customer inner join Bill on Customer.cusID = Bill.cusID where Customer.cusID = 'cus002'


-- Query to find total priceIn from wareHouse
select productID, priceIn from wareHouse

select sum(priceIn) as 'Total' from wareHouse

select prdID, sum(price) as 'total' from BillDetail
group by prdID


select prdID, price from BillDetail

select categoryName, sum(priceIn) as 'total' from wareHouse group by categoryName

select Product.nameCate, sum(BillDetail.price) as 'total' from BillDetail
inner join Product
on BillDetail.prdID = Product.productID
group by Product.nameCate

select Product.nameCate, sum(BillDetail.price) as 'total' from BillDetail inner join Product on BillDetail.prdID = Product.productID group by Product.nameCate







drop table wareHouse;
drop table Product;
drop table Employee;

delete from wareHouse where productID = '123'
delete from BillDetail where quantity = 1

drop database eShopManager
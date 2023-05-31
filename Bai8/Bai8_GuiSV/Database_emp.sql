use master
go
if DB_ID('mydata') is not null
	drop database mydata
go
create database mydata
go
use mydata
go
create table tblDept(
deptid int primary key identity,
deptname nvarchar(25)
)
insert into tblDept values('Hanh chinh')
insert into tblDept values('Ke toan')
insert into tblDept values('Tong hop')
go
create table tblEmployee(
eid int primary key identity,
name nvarchar(30),
age int,
addr nvarchar(30),
salary int,
image nvarchar(50),
deptid int foreign key references tblDept(deptid))
go
insert into tblEmployee values('Lan Anh',32,'Ha noi',3500,'a01.jpg',1)
insert into tblEmployee values('Thi Huong',30,'Ha noi',5000,'a02.jpg',2)
insert into tblEmployee values('Van Ha',30,'Hai phong',4000,'a03.jpg',1)
insert into tblEmployee values('Hong Linh',35,'Thai binh',5500,'a04.jpg',3)
insert into tblEmployee values('Van Hung',32,'Hai phong',5000,'a05.jpg',1)
insert into tblEmployee values('Hai Yen',28,'Thai binh',3000,'a06.jpg',1)
insert into tblEmployee values('My Ha',26,'Hai phong',3000,'a07.jpg',2)
insert into tblEmployee values('Phuong Thuy',24,'Hai phong',2000,'a08.jpg',3)
insert into tblEmployee values('Phi Hung',24,'Ha noi',2500,'a09.jpg',2)
insert into tblEmployee values('Cong Tuan',40,'Thai binh',4500,'a10.jpg',2)
go
--drop table tblEmployee
-- select * from tblEmployee where addr='Hai phong' and salary>3000
select * from tblEmployee where deptid=1
select * from tblEmployee where deptid=2
select * from tblEmployee where deptid=3
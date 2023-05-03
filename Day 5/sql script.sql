create database employeeDB

use employeeDB

create table employeeInfo
(
	empNo int primary key,
	empName varchar(20),
	empDesignation varchar(20),
	empSalary int,
	empIsPermenant bit
)

insert into employeeInfo values(101,'Nikhil','Consultant',9000,1)
insert into employeeInfo values(102,'Kriti','HR',19000,1)
insert into employeeInfo values(103,'Sakshi','Consultant',1200,0)
insert into employeeInfo values(104,'Mohan','Sales',29000,1)
insert into employeeInfo values(105,'Rohan','Consultant',5500,0)
create database shoppingDB_repositoryP
use shoppingDB_repositoryP


create table productSQL
(
	pId int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit)

	insert into productSQL values(501,'SQL 1','Server Server',50,1)
	insert into productSQL values(502,'SQL 2','Server Server',50,1)
	insert into productSQL values(503,'SQL 3','Server Server',50,1)
	insert into productSQL values(504,'SQL 4','Server Server',50,1)
	insert into productSQL values(505,'SQL 5','Server Server',50,1)

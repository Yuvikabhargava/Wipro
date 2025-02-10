-- Aggregate functions
select count(*) as "No_ofEmployees" from employee;
select min(salary) as "MinimumSalary" from employee;
select max(salary) as "MaximumSalary" from employee;
select sum(salary) as "TotalSum" from employee;
select avg(salary) as "AverageSalary" from employee;

-- Group by
select city, count(*) from employee group by city;

-- having - filters the result of the group by clause
select deptid, count(*) from employee group by deptid having count(*) > 2;

select deptid, city, count(*) from employee group by deptid, city having count(*) > 1;

-- Function
-- System Functions
-- Date function
select getdate() as TodaysDate;
select SYSDATETIME() as CurrentDate;

-- Alter table: Add column
alter table employee add joiningdate date;

-- Select based on year, month and date functions
select * from employee where year(joiningdate) > 2020;
select * from employee where month(joiningdate) = 9;

select * from employee where joiningdate >= DateAdd(Day, -30, GetDate());

-- Calculate experience in years
select Empname, DateDiff(year, joiningdate, getdate()) as ExperienceinYears
from employee;

-- Insert data
insert into employee(empid, empname, deptid, joiningdate) 
values (19, 'Neha', 1, '2023-07-25');

insert into employee(empid, empname, deptid, joiningdate) 
values (20, 'Mahim', 3, getdate());

-- Math functions
select rand() as RandomNumber;
select cast(rand() * 50 as int) as RandomInteger;
select 10 % 3 as ModFunction;

-- Even employees
select * from employee where empid % 2 = 0;

-- User-defined functions
-- Scalar Valued function - returns single value
create or alter function GetCountEmployee()
returns int
as
begin
   declare @noofempl int; -- scalar variable
   select @noofempl = count(*) from employee;
   return @noofempl;
end;

-- Use the function
select dbo.GetCountEmployee();

-- Alter the function to include a parameter for city
create or alter function GetCountEmployee(@city varchar(20))
returns int
as
begin
   declare @noofempl int; -- scalar variable
   select @noofempl = count(*) from employee where city = @city;
   return @noofempl;
end;

-- Call the function with the city parameter
select dbo.GetCountEmployee('Pune');

-- Table-valued function
create or alter function GetEmployeeSal(@minsalary decimal(8, 2), @maxsalary decimal(8, 2))
returns table
as
return
(  
   select * from employee where salary between @minsalary and @maxsalary
);

-- Call the table-valued function
select * from dbo.GetEmployeeSal(55000, 70000);

-- Another example of a function to check east or west based on longitude
create or alter function eastorwest(@longitude decimal(9, 6))
returns char(4) 
as
begin
   declare @res char(4);
   set @res = 'Same';
   if (@longitude > 0.0)
     set @res = 'East';
   else
     set @res = 'West';
   return @res;
end;

-- Call the function with a longitude value
select dbo.eastorwest(-12);

-- Stored Procedure - query to be executed repeatedly
create or alter procedure sp_emp
as 
begin
  select * from employee;
end;

-- Execute stored procedure
exec sp_emp;

-- Stored Procedure with parameters
create or alter procedure sp_emp(@minsal decimal(8, 2), @maxsal decimal(8, 2))
as 
begin
  select * from dbo.GetEmployeeSal(@minsal, @maxsal);
end;

-- Execute stored procedure with parameters
exec sp_emp 60000, 80000;

-- Joins 
create table Student (
  Regno int not null,
  stname varchar(35),
  dept varchar(20),
  city varchar(25)
);

create table Fees (
  Regno int not null,
  dept varchar(20),
  FeesPaid decimal(10,2),
  Paidon date
);

-- Select data from Student and Fees tables
select * from student;
select * from Fees;

-- Inner Join - Common records
select S.Regno, S.stname, S.dept, F.FeesPaid, F.Paidon 
from Student S inner join Fees F
on S.Regno = F.Regno;

select S.Regno, S.stname, S.dept, F.FeesPaid, F.Paidon 
from Student S, Fees F
where S.Regno = F.Regno;

-- Outer Joins - Find unmatching records
-- Left Outer Join
select S.Regno, S.stname, S.dept, F.FeesPaid, F.Paidon 
from Student S left outer join Fees F
on S.Regno = F.Regno;

select e.empid, e.empname, d.deptname from employee e left join department d
on e.deptid = d.did;

-- Right Outer Join
select S.Regno, S.stname, S.dept, F.Regno, F.dept, F.FeesPaid, F.Paidon 
from Student S right outer join Fees F
on S.Regno = F.Regno;

-- Cross Join
select S.Regno, S.stname, S.dept, F.Regno, F.dept, F.FeesPaid, F.Paidon 
from Student S cross join Fees F;

-- Self Join - Join with the same table - alias name
alter table Employee add Managerid int;

-- Self join to find managers
select distinct e.empid, e.empname from employee e join employee e2
on e.empid = e2.managerid;

select e.empid, e.empname, e2.empname from employee e join employee e2
on e.empid = e2.managerid;

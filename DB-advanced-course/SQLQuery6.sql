use ITI
-------------------1------------------
/*

Create a scalar function that takes
date and returns Month name of that date.
*/
create function GetSname(@x date)
returns varchar(20)
	begin
	declare @month varchar(20)
	select @month = format(@x,'MMMM')
	return @month
	end
	select dbo.getSname('1/10/2021')

	---------------2------------------
	/*
	Create a multi-statements table-valued function that takes 2
	integers and returns the values between them.
	*/

	alter function getnumbers(@x int,@y int)
returns @t table(numbers int)
as
	begin
	declare @r int=@x
while  @r <=@y
	begin
		INSERT @t  VALUES (@r);
		set @r+=1;
	end 

		
		return 
	end

	select* from  dbo.getnumbers(1,10)

	----------3-----------------------

	/*
	Create inline function that takes
	Student No and returns Department
	Name with Student full name
	
	*/
	Create function depname(@did int)
returns table
	as
	return
	(
	 select D.Dept_Name,s.St_Fname+''+s.St_Lname Fullname
	 from Department D,Student s
	 where s.Dept_Id=D.Dept_Id
	)


	select * from depname(100)





	---------4----------------------

	/*
	4.	Create a scalar function that takes Student
	ID and returns a message to user 
a.	If first name and Last name are null then display
'First name & last name are null'
b.	If First name is null then display 'first name is null'
c.	If Last name is null then display 'last name is null'
d.	Else display 'First name & last name are not null'

	*/

	create function message (@stID int)
	returns varchar(20)
	begin
		declare @msg varchar(50)
		select 
		@msg=case
		when s.St_Fname is null then 'first name is null'
		when s.St_Lname is null then 'last name is null'
		when s.st_fname+' '+s.St_Lname is null then 'last name is null'
		else  s.St_Fname+' '+s.St_Lname 
				end

			from Student s
			where s.St_Id =@stID
			return @msg
	end


	select dbo.message(1)


	---------------5------------------------

	/*
	
	5.	Create inline function that takes
	integer which represents manager
	ID and displays department name, Manager Name and hiring date 
	*/

	alter function maneger (@Mid int)
	returns table
	as return(
	
	
	select d.Dept_Name,I.Ins_Name,d.Manager_hiredate
	from Department d,Instructor I
	where I.Ins_Id=d.Dept_Manager and @Mid=I.Ins_Id
	
	)
	select * from maneger(1)

	------------6---------------------

	/*
	6.Create multi-statements 
	table-valued function that takes a string
If string='first name' returns student first name
If string='last name' returns student last name 
If string='full name' returns Full Name from student table 
Note: Use “ISNULL” function

	*/
	create function names(@str varchar(20))
	returns @t table(name varchar(20))

	as
	begin
	if @str='first name'
	insert into @t  select Isnull(St_Fname,'')  from Student 


	else if @str='last name'
	insert into @t  select isnull(St_Lname,'')  from Student
	else if @str='full name'
	 insert into @t  select Isnull(St_Fname,'')+''+isnull(St_Lname,'')
	 from Student
	 return
	
	end

	select * from names('full name')

	------7---------------------


	/*
	7.	Write a query that returns
	the Student No and Student first name without the last char
	
	*/
	select s.St_Id,SUBSTRING(s.St_Fname,1,len(s.St_Fname)-1) 
	from Student s

	-----------------8-------------------

	/*
	
	8.	Wirte query to delete all grades for the 
	students Located in SD Department 
	
	
	*/

	delete from Stud_Course
where st_id in(select sc.Grade 
from Stud_Course sc, Department d, Student s
where s.St_Id = sc.St_Id and 
d.Dept_Id = s.Dept_Id and d.Dept_Name ='sd')

	----------------9-----------
	/*
	9.	Using Merge statement 
	between the following two tables
	[User ID, Transaction Amount]
	
	*/



create table dailyt(id int primary key, trans int)
create table lastt(id int primary key, trans int)
insert into dailyt values(1,1000),(2,2000),(3,1000)
insert into lastt values(1,4000),(4,2000),(2,10000)

merge into lastt as t
using dailyt as s
on t.id = s.id
when matched then
update
set t.trans = s.trans
when not matched then
insert 
values(s.id,s.trans);
---------------10-------------------------

create schema hr
alter schema hr transfer Student
alter schema hr transfer Course
create table hr.itistud(id int, name varchar(20))





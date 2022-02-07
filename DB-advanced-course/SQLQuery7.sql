use ITI

-----------------1-----------------------

/*
Create a view that displays student full name, 
course name if the student has a grade more than 50. 
*/
 create view S1
 as
select S.St_Fname+''+s.St_Lname full_Name ,c.Crs_Name
from Student s ,Stud_Course sc, Course c
where s.St_Id= sc.St_Id and c.Crs_Id=sc.Crs_Id and s.St_Id in(
select St_Id from Stud_Course where Grade>50

)
--------------2---------------------


/*
Create an
view that displays manager names and the topics they teach. 
*/
use ITI
create view v2
as
select i.Ins_Name,t.Top_Name
from Instructor i
,Course c, Ins_Course ic,Department d,Topic t
where i.Ins_Id=ic.Ins_Id and d.Dept_Manager =i.Ins_Id
and ic.Crs_Id=c.Crs_Id
and c.Top_Id=t.Top_Id





------------------3----------------------


/*
3.Create a view that will display Instructor Name,
Department Name for the ‘SD’ or ‘Java’ Department 

*/

Create view v3
as
select i.Ins_Name,d.Dept_Name
from Instructor i, Department d
where i.Ins_Id=d.Dept_Manager and d.Dept_Name in('SD','Java')


---------------------4-------------------------------
/*
Create a view “V1” that displays student data
for student who lives in Alex or Cairo. 
Note: Prevent the users to run the following query 
Update V1 set st_address=’tanta’
Where st_address=’alex’;
with check option
*/

Create view V1
as
select * from Student s where s.St_Address in
('Cairo','Alex')
with check option


----------------5-----------------------

/*
5.Create a view that will display the project name 
and the number of employees work on it. “Use Company DB”
*/

use Company_SD
create view E
as
select p.Pname, count(w.ESSn) as[number of employees]
from Project p ,Works_for w
where w.Pno=p.Pnumber
group by p.Pname


--------------------------6------------------

/*
6.	Create the following schema and transfer
the following tables to it 
a.	Company Schema 
i.	Department table (Programmatically)
ii.	Project table (by wizard)
b.	Human Resource Schema
i.	  Employee table (Programmatically)
*/

create schema Company 
alter schema Company transfer department

alter schema dbo transfer Company.department

create schema [Human Resource] 
alter schema [Human Resource] transfer Employee

----------------7-----------

/*
7.	Create index on column (manager_Hiredate)
that allow u to cluster 
the data in table Department. What will happen?  - Use ITI DB
*/


use iti
create clustered index i1
on department(manager_Hiredate)

-------------------------8-----------------

/*
8.	Create index that allow u to enter unique ages 
in student table. What will happen?  - Use ITI DB

*/
create unique index i2
on student(st_age)


----------------------9------------

/*
9.	Create a cursor for Employee table
that increases Employee salary by 10% if 
Salary <3000 and increases it by 20% 
if Salary >=3000. Use company DB

*/

declare cr1 cursor
for select salary from [Human Resource].Employee

for update 
declare @S int
open cr1
fetch cr1 into @s
while @@FETCH_STATUS=0

begin

if @S<3000
update [Human Resource].Employee
set salary =@S*.1
where current of cr1

else 
update [Human Resource].Employee
set salary =@S*.2
where current of cr1
fetch cr1 into @s
end
close cr1
deallocate cr1



-----------------------10--------------------

/*
10.	DisplayDepartment name with its manager name
using cursor. Use ITI DB

*/
use ITI
declare crrr cursor
for select d.Dept_Name,i.Ins_Name from Instructor i, department d
where i.Ins_Id=d.Dept_Manager


for read only 
declare @depname varchar(20),@insname varchar(20)

open crrr
fetch crrr into @depname, @insname

while @@FETCH_STATUS=0

begin

select @depname, @insname
fetch crrr into @depname, @insname

end
close crrr 
deallocate crrr


----------------------------11------------------------
/*
11.	Try to display all instructor names in 
one cell separated by comma. Using Cursor . Use ITI DB

*/

declare cr3 cursor
for select i.Ins_Name from Instructor i

for read only 
declare @insname varchar(20),@fullname varchar(20)

open cr3 
fetch cr3 into  @insname
while @@FETCH_STATUS =0
begin
set @fullname = CONCAT(@fullname,',',@insname)

fetch cr3 into  @insname

end
select @fullname
close cr3
deallocate cr3














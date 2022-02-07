-----1------------

/*
1.Create a stored procedure without parameters to show the
number of students per department name.[use ITI DB] 

*/

alter proc sp1 
as
select count(s.St_Id) 'number of students', d.Dept_Name
from Student s, Department d
where s.Dept_Id = d.Dept_Id
group by d.Dept_Name

sp1 



----------------------2-------------------------
/*
2.	Create a stored procedure that will check for the 
# of employees in the project p1 if they are more than 
3 print message to the user “'The number of employees in 
the project p1 is 3 or more'” if they are less display 
a message to the user “'The following employees work for 
the project p1'” in addition 
to the first name and last name of each one. [Company DB] 

*/

create proc numofEmp
as
select case
when COUNT(w.essn) > 3 then 'The number of employees in the project p1 is 3 or more'
else CONCAT ('The following employees work for the project p1', e.fname , e.lname)
end
from  Works_for w,employee e, Project p
where p.Pnumber= w.pno  and  e.ssn = w.ESSn and p.Pname = 'AL Solimaniah'
group by e.fname, e.lname 

numofEmp

/*
3.	Create a stored procedure that 
will be used in case there is an old employee
has left the project and a new one become instead of him. 
The procedure should take 3 parameters (old Emp. number, new Emp.
number and the project number) and
it will be used to update works_on table. [Company DB]

*/
create proc work @newemp_number int, @oldemp_number int, @pnumber int
as
update Works_for
set ESSn = @newemp_number
where pno = @pnumber and ESSn = @oldemp_number

work 512463,102672,100


/*
4.	add column budget in project table 
and insert any draft values in it then 
then Create an Audit table with the following structure 

This table will be used to audit the update trials on the Budget column (Project table, Company DB)
Example:
If a user updated the budget column then the project number, user name that made that update, the date of the modification and the value of the old and the new budget will be inserted into the Audit table
Note: This process will take place only if the user updated the budget column


*/
create table audit(projectno int, 
username varchar(50) default suser_name(), modi_date date default getdate(), b_old int, b_new int)
alter table company.project 
add budget int

create trigger upbudget
on company.project
instead of update
as
	if update(budget)
		begin
			declare @old_budget int,@new_budget int, @pno int
			select @old_budget = budget from deleted
			select @pno = pnumber from deleted
			select @new_budget = budget from inserted
			insert into audit
			values(@pno, suser_name(),getdate(), @old_budget, @new_budget)
		end
/*
5.	Create a trigger to prevent anyone 
from inserting a new record in the Department table [ITI DB]
“Print a message for user to tell him that he can’t
insert a new record in that table”

*/
use ITI
create trigger pre_in_dept
on department
instead of insert
as
	select 'you can’t insert a new record in that table'

insert into Department (Dept_Name) values('sd')

alter table department disable trigger pre_in_dept
alter table department enable trigger pre_in_dept


/*
6.Create a trigger that prevents the insertion 
Process for Employee table in March [Company DB].
*/
create trigger pre_in_mar
on employee
for insert
as
	begin
		if FORMAT(getdate(), 'MMMM') = 'march'
		rollback
	end


/*
7.	Create a trigger on student table after 
insert to add Row in Student Audit table (Server User Name ,
Date, Note) where note will be “[username] 
Insert New Row with Key=[Key Value] in table [table name]”

*/
create table stud_audit(server_username varchar(50), in_date date default getdate(), note varchar(100))
create trigger stdin 
on student
for insert
as
	begin
		declare @std_id int
		select @std_id = St_Id from inserted
		insert into stud_audit
		values(SUSER_NAME(),getdate() ,' Insert New Row with Key = '+convert( varchar(50),@std_id)+ 'in student' )
	end

/*
8-Create a trigger on student table
instead of delete to add Row in Student Audit 
table (Server User Name, Date, Note) where note will be“
try to delete Row with Key=[Key Value]”


*/

create trigger stdinstofin 
on student
instead of delete
as
	begin
		declare @std_id int
		select @std_id = St_Id from deleted
		insert into stud_audit
		values(SUSER_NAME(),getdate() ,'try to delete Row with Key'+convert( varchar(50),@std_id) )
	end

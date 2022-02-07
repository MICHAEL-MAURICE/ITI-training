
-----1
select D.Dependent_name,D.Sex
from Dependent D,Employee e
where  D.Sex='Female' and e.Sex ='Female' 
and e.SSN=D.ESSN
UNION
select D.Dependent_name,D.Sex
from Dependent D,Employee e
where  D.Sex='Male' and e.Sex ='Male' 
and e.SSN=D.ESSN

---2

select P.Pname,sum(w.Hours)
from Project p, Works_for w
where P.Pnumber=w.Pno
group by P.Pname




---3
/*
3.	Display the data of the department
which has the smallest employee ID over all employees' ID.

*/
select D.*
from Departments D,Employee e
 where e.Dno=D.Dnum and e.SSN in(select min(SSN)from Employee
 )


 ---4
 /*
 4.	For each department, retrieve the 
 department name and the maximum, 
 minimum and average salary of its employees.
 
 */
 select D.Dname,max(e.Salary),min(e.Salary),avg(e.Salary)
 from Departments D ,Employee e
 where e.Dno=D.Dnum
 group by D.Dname

 --5
 /*
 5.	List the full name of all managers who have no dependents
 */

 select e.Fname+' '+e.Lname as Fullname
 from Employee e,Departments d
 where e.SSN = d.MGRSSN and e.SSN not in(select ESSN
 from Dependent )
 
 ---6
 /*
 6.	For each department-- if its average salary 
 is less than the average salary of all employees-- 
 display its number,
 name and number of its employees
 
 */

 select D.Dnum,D.Dname,count(e.SSN)
 from Employee e ,Departments D
 where e.Dno=D.Dnum 
 group by D.Dname ,D.Dnum
 having avg(e.salary)<(select AVG(salary) from Employee)

 --7
 /*
 7.	Retrieve a list of employees names 
 and the projects names they are working on ordered by 
 department number and within each department, 
 ordered alphabetically by last name, first name.
 
 */

 select e.Fname+' '+ e.Lname Fullname,P.Pname
 from Employee e,Project P,Works_for d
 where e.SSN = d.ESSn and d.Pno =Pnumber
 order by e.Dno ,e.Lname,e.Fname

 --8
 /*
 8.	Try to get the max 2 salaries using subquery
 
 */

 select( select max(Salary) from Employee ),
 
 (select max(Salary) from Employee 
 where salary not in(select max(Salary)from Employee)
 )
 -----9
 /*
 
 9.	Get the full name of employees
 that is similar to any dependent name
 
 */
 select e.Fname+' '+e.Lname fullname
from Dependent D,Employee e
where   e.SSN=D.ESSN and d.Dependent_name in(
 select Fname+' '+Lname from Employee
)


----10
/*
10.	Display the employee number and name
if at least one of them have 
dependents (use exists keyword) self-study.
*/
select e.SSN,e.Fname
from Employee e
WHERE EXISTS 
(
select e.SSN
from Employee e,Dependent d
where e.SSN =d.ESSN

)




-----------------11
/*
11.	In the department table insert 
new department called "DEPT IT" ,
with id 100, employee with SSN = 112233 as
a manager for this department
. The start date for this manager is '1-11-2006'

*/
insert into Departments values(
'DEPT IT',100,112233,'1-11-2006'
)

----12
/*
12.	Do what is required if you know 
that : Mrs.Noha Mohamed(SSN=968574) ID
moved to be the manager of the new department (id = 100),
and they give you(your SSN =102672)
her position (Dept. 20 manager) 
a.	First try to update her record in the department table
b.	Update your record to be department 20 manager.

c.	Update the data of employee number=102660 
to be in your teamwork
(he will be supervised by you) 
(your SSN =102672)

*/

UPDATE Departments
SET MGRSSN=968574
where Dnum =100 

UPDATE Departments
SET MGRSSN=102672
where Dnum =20


UPDATE Employee
SET   Superssn = 102672
where  SSN=102660



/*
13.	Unfortunately the company ended the contract with
Mr. Kamel Mohamed (SSN=223344) so try to delete
his data from your database in case you know that you
will be temporarily in his position.
Hint: (Check if Mr. Kamel has dependents, 
works as a department manager, supervises any employees 
or works in any projects and handle these cases).


*/

delete from Dependent
	where essn=223344

	update Departments
	set MGRSSN=102672
	where MGRSSN=223344

	update Employee
	set Superssn=102672
	where Superssn=223344

	update Works_for
	set ESSn=102672
	where ESSn=223344
	
	delete from Employee
	where ssn=223344



/*
14.	Try to update all salaries of employees who work in Project
‘Al Rabwah’ by 30%




*/
update Employee 
set Salary+=Salary*0.3

 where SSN in
 (
 
 select e.SSN
 from Employee e,Project P,Works_for d
 where e.SSN = d.ESSn and d.Pno =Pnumber
 
 and p.Pname='Al Rabwah'
 
 )








use Company_SD
--1
select Dnum,Dname,MGRSSN,Fname+''+Lname as fullname
from Departments d ,Employee e
where d.MGRSSN = e.SSN
--2
select Dname,pname 
from Departments d,Project p
where p.Dnum =d.Dnum
--3
select d.*,Fname+''+Lname as fullname
from Employee e, Dependent d
where e.SSN= d.ESSN
--4
select Pnumber,Pname,Plocation
from Project
where Plocation in('Cairo','Alex')
--5
select P.*from Project P where Pname like 'a%'
--6
select e.* 
from Employee e
where e.Dno =30 and e.Salary between 1000 and 2000

--7

select e.Fname +''+e.Lname as fullname
from Employee e,Works_for w,Project P
where e.Dno =10 and w.ESSn =e.SSN and
p.Pname=w.Pno and Hours>=10 
and P.Pname='ALRabwah' 
--8
 select e.Fname+''+e.Lname
 from Employee e,Employee su
 where su.SSN =e.Superssn
 and su.Fname = 'Kamel'and su.Lname='Mohamed'

--9
select e.Fname +''+e.Lname as fullname,P.Pname
from Employee e, Project P ,Works_for w
where e.SSN = w.ESSn and w.Pno= P.Pnumber
order by P.Pname

--10
select P.Pnumber,D.Dname,e.Lname,e.Address,e.Bdate
from Employee e,Departments D,Project P
where P.Dnum = D.Dnum and e.SSN =D.MGRSSN 
and P.City = 'Cairo'

--11
select e.*,D.*
from Employee e,Departments D
where e.SSN =D.MGRSSN

--12 XXXX
select e.*,D.*
 from Employee e LEFT OUTER JOIN Dependent D
 on e.SSN=D.ESSN

--13
insert into Employee values(
'Michael',
'Maurice',102672,10-1-1998,'cairo','M',3000,112233,30
)
--14
insert into Employee values(
'Mohsen',
'Mah',102660,10-1-1998,'cairo','M',NULL,Null,30
)
--15
update Employee  set Salary +=Salary*0.2
where Employee.SSN =102672
use Company_SD
--1
select * from Employee
--2
select Fname,lname,salary,dno from Employee
--3
select pname, plocation,dnum from Project
--4
select Fname+' '+lname as Fullname,salary*12*0.1 as ANNUALCOMM from Employee   
--5
select SSN,Fname+' '+lname as Fullname from Employee where salary>1000;
--6
select SSN,Fname+' '+lname as Fullname from Employee where salary*12>10000;
--7
select Fname+' '+lname as Fullname ,salary from Employee where Sex ='female';
--8
select Dnum ,Dname from Departments where MGRSSN =968574
--9
select Pnumber ,Pname, Plocation from Project where Dnum=10
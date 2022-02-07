
use ITI

--1
/*
1.	Retrieve number of students who have a value in their age. 
*/

select count(St_Id) from Student where St_Age is not null

----2
/*
2.	Get all instructors Names without repetition

*/
select distinct Ins_Name from Instructor

----3
/*
3.	Display student with
the following Format (use isNull function)
Student ID	Student Full Name	Department name
*/
select isNULL(s.St_Id,' ') [Student ID], 
ISNULL(CONCAT(s.St_Fname,s.St_Lname),' ') [Student Full Name],
ISNULL(D.Dept_Name,'') [Department name]
from Student s,Department D
where s.Dept_Id=D.Dept_Id


-----4
/*
4.	Display instructor Name and Department Name 
Note: display all the instructors
if they are attached to a department or not

*/
select I.Ins_Name , D.Dept_Name from Department D 
right join Instructor I on D.Dept_Id=I.Dept_Id
------5
/*
5.	Display student full name and 
the name of the course he is taking
For only courses which have a grade  

*/

select s.St_Fname+' '+s.St_Lname[full Name], c.Crs_Name

from Student s , Course c,Stud_Course sc

where s.St_Id=sc.Crs_Id and c.Crs_Id=sc.Crs_Id 
and
sc.Grade is not null

----6
/*
6.Display number of courses for each topic name
*/

select count(c.Crs_Id) [NUMBER OF COURSES],c.Crs_Name
from Course c , Topic t
where c.Top_Id=t.Top_Id
group by c.Crs_Name

---7
/*
7.	Display max and min salary for instructors
*/

select max(I.Salary) [Max Salary],min(I.Salary)[Min Salary]

from Instructor I

------8
/*
8.	Display instructors who have salaries 
less than the average salary of all instructors.

*/
select I.Ins_Name
from Instructor I
where I.Salary<(select AVG(Salary)from Instructor)

---9
/*
9.	Display the Department name that contains
the instructor who receives the minimum salary

*/
select Dept_Name from Department where Dept_Id = (select top(1)
Dept_Id from Instructor  order by Salary )
----10

/*
Select max two salaries in instructor table. 

*/
select top(2) Salary from Instructor order by Salary desc
----11
/*
11.	 Select instructor name and his salary but
if there is no salary display instructor bonus keyword.
“use coalesce Function”

*/

select i.Ins_Name,
coalesce(Convert(varchar(20),i.Salary),'bonus') salary
from Instructor i

----12
/*
12.	Select Average Salary for instructors 
*/
select avg(salary) from Instructor

------13
/*
13.	Select Student first name and the data of his supervisor 
*/
select CONCAT(s1.St_Fname,' ',s1.St_Lname) ,s2.* 
from Student s1 
join Student s2 on s1.St_super =s2.St_Id;

---14
/*
14.	Write a query to select the highest two salaries in
Each Department for instructors who have salaries.
“using one of Ranking Functions”
*/

Select Salary , Dept_Id
From (select *,Dense_Rank() over
(partition by dept_id order by salary desc) as DR
	  from Instructor) as NewTable
where DR in(1,2) 

----15
/*
Write a query to select a random  student from each department.
“using one of Ranking Functions”

*/

Select *
From (select *,Dense_Rank() over(partition by Dept_Id
order by newid()) as DR
	  from Student  ) as NewTable 
	  where dr=1 

--------------------------------------------------------------








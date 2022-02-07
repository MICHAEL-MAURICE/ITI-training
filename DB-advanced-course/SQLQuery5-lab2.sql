 use AdventureWorks2012
---1
/*
1.Display the SalesOrderID, ShipDate of 
the SalesOrderHeader table (Sales schema) to
show SalesOrders that occurred 
within the period ‘7/28/2002’ and ‘7/29/2014’
*/
select s.SalesOrderID,s.ShipDate
from Sales.SalesOrderHeader s
where s.OrderDate between 28/7/2002 and 29/7/2014

---2
/*
2.	Display only Products(Production schema) with 
 a StandardCost below $110.00 (show ProductID, Name only)
*/
select ProductID,Name
from Production.Product
where StandardCost<110

-----3
/*
3.Display ProductID, Name if its weight is unknown
*/

select ProductID,Name
from Production.Product
where weight is null

----4
/*
Display all Products with a Silver, Black, or Red Color
*/

select *
from Production.Product p
where p.Color in('Silver', 'Black','Red')

------5
/*
Display any Product with a Name starting with the letter B
*/
select *
from Production.Product p
where p.Name like 'B%'

---6
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select Description
from Production.ProductDescription
where Description like '%[_]%'

-----7

/*

7.	Calculate sum of TotalDue for each OrderDate
in Sales.SalesOrderHeader table for 
the period between  '7/1/2001' and '7/31/2014'

*/
select sum(s.TotalDue) Sumation ,s.OrderDate

from Sales.SalesOrderHeader s
where DueDate between '7/1/2001' and '7/31/2014'
group by s.OrderDate
 
 ------8

/*
Display the Employees HireDate
(note no repeated values are allowed)

*/

select distinct HireDate
from HumanResources.Employee

----9

/*
9.	 Calculate the average of the unique
ListPrices in the Product table

*/
select  avg(distinct ListPrice)
from Production.Product


---10

/*
10.	Display the Product Name and its ListPrice
within the values of 100 and 120 
the list should has the following format
"The [product name] is only! [List price]" 
(the list will be sorted according to its ListPrice value)
*/
select 'The ['+Name+']  is only!'as Name,ListPrice
from [AdventureWorks2012].Production.Product
where ListPrice between 100 and 120
order by ListPrice

----11
/*
a)	Transfer the rowguid ,Name, 
SalesPersonID, Demographics from Sales.Store table
in a newly created table named [store_Archive]
701
*/
select rowguid ,Name, SalesPersonID,
Demographics into [store_Archive]
from [Sales].[Store]


/*
b)	Try the previous query but without transferring the data? 

*/
select rowguid ,Name, SalesPersonID,
Demographics into [store_Archive1]
from [Sales].[Store]
where 1=2


----12
/*

12.	Using union statement, retrieve the today’s date in 
different styles using convert or format funtion.
*/

select format(getdate(),'dd-MM-yyyy')
union
select format(getdate(),'dddd MMMM yyyy')
union
select format(getdate(),'ddd MMM yy')
union
select format(getdate(),'dddd')
union
select format(getdate(),'MMMM')
union
select format(getdate(),'hh:mm:ss')
union
select format(getdate(),'hh tt')
union
select format(getdate(),'HH')
union
select format(getdate(),'dd-MM-yyyy hh:mm:ss')
union
select format(getdate(),'dd-MM-yyyy hh:mm:ss tt')


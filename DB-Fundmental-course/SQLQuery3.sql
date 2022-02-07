create Table Course(
ID int primary key identity,
Cname varchar(20),
Dur int
constraint c1 unique(Dur)
)

create Table Lab(
LID int identity,
CID int ,
loc varchar(20),
capacity int,
constraint l1 primary key (LID,CID),
constraint l2 check (capacity<20),
constraint l3 foreign key(CID) references Course(ID)
on delete cascade on update cascade

)

create Table tech(
CID int  ,
ID int,
constraint t1 primary key (ID,CID),
constraint t2 foreign key(CID) references Course(ID)
on delete cascade on update cascade,
constraint t2 foreign key(ID) references Course(ID)
on delete cascade on update cascade
)

create Table instractor(
id  int primary key identity,
overtime int,
Birthday date,
hireddate date default getdate(),
salary int default 3000,

Fname varchar(20),
Lname varchar(20),
adress varchar(20),
Age as (year(getdate())-year(Birthday)),
netsalary as(isnull(salary,0)+isnull(overtime,0)) persisted
constraint i1 unique (overtime),

constraint i2 check (salary between 1000 and 5000),

constraint i3 check (adress in('alex','Cairo')),
)


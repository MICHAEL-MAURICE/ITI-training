
#region main

List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

//Q1 Display numbers sorted 

var q1 =numbers.OrderBy(x => x);
foreach (var x in q1)
{
    Console.WriteLine(x);
}
//Q2 using Query1  result and show each number and it’s multiplication
var q2 = numbers.OrderBy(x => x).Select(x => x * x);
foreach (var x in q2)
{
    Console.WriteLine(x);
}

//_______________________________________________________________________
string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

//Query1: Select names with length equal 3. 
var q3 =names.Where(x => x.Length ==3 ).Select(x => x);


//Query2: Select names that contains “a” letter then sort them by length 

var q4= names.Where(s => s.Contains("a") || s.Contains("A"));

foreach (var x in q4)
{
    Console.WriteLine(x);
}


var q5 = names.Take(2);
foreach (var x in q5)
{
    Console.WriteLine(x);
}

//------------------------------------------------------------------------------------------

List<student> students = new List<student>()
{
       new student(){ id=1, Fname="mohsen", Lname="Moh", 
           sub=new subject[]{ new subject(){ code=22,name="os"}, new subject(){ code=33,name="c#"}}},
       new student(){ id=2, Fname="Mona", Lname="Gala", 
           sub=new subject []{ new subject(){ code=22,name="EF"}, new subject (){ code=34,name="XML"}
           ,new subject (){ code=25, name="JS"}}},new student(){ id=3, Fname="Yara", Lname="Yousf", sub=new subject []{ new subject (){ code=22,name="EF"}, new subject (){ code=25,name="JS"}}},
       new student(){ id=1, Fname="Ali", Lname="Ali", sub=new subject []{  new subject (){ code=33,name="UML"}}},


};


//quary1
var s = students.Select(s => new { Fullname = s.Fname + " " + s.Lname, numofsubjects = s.sub.Count() });
foreach (var student in s)
{
    Console.WriteLine(student);
}


//quary2


var s2 = students.OrderByDescending(s => s.Fname).ThenBy(s => s.Lname).Select(s => new { Fullname = s.Fname + " " + s.Lname });

foreach (var student in s2)
{
    Console.WriteLine(student.Fullname);
}
class subject
{
    public int code { get; set; }
    public string name { get; set; }
    public subject()
    {

    }
    public subject(int code, string name)
    {
        this.code = code;
        this.name = name;
    }
}


class student
{
    public int id { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public subject[] sub { get; set; }

    public student()
    {

    }
    public student(int id, string Fname, string Lname, subject[] sub)
    {
        this.id = id;
        this.Fname = Fname;
        this.Lname = Lname;
        this.sub = sub;
    }

}







#endregion
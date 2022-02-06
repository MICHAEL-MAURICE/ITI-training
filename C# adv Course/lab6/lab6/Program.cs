using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{

    public delegate void mydel(Employee em);
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public int age { get; set; }

        public event mydel hireEmployee;
        public Employee(int id, string name, double salary, int age)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.age = age;
        }

        public void OnhireEmployee()
        {
            if (hireEmployee != null)
                hireEmployee(this);
        }
        public override string ToString()
        {
            string txt = $"Employee Id={id}\tName={name}\tSalary={salary}\tAge={age}";

            return txt;
        }
    }
    class socialinsurance
    {
        public int id { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        public socialinsurance(string name, int duration)
        {
            this.name = name;
            this.duration = duration;
        }
        public override string ToString()
        {
            return $"name={name},Duration={duration} years \n";
        }

        public void addinsurance(Employee emp)
        {

            Console.WriteLine(emp.ToString());
            Console.WriteLine("insurance with details:   " + this.ToString());
            Console.WriteLine($"added to new employee");
        }

    }
    class club
    {
        public string name { get; set; }
        public string loc { get; set; }
        public club(string name, string loc)
        {
            this.name = name;
            this.loc = loc;
        }
        public override string ToString()
        {
            return $"name={name},Location={loc}";
        }

        public void addclub(Employee emp)
        {
            Console.WriteLine("and club with details:   " + this.ToString());
            Console.WriteLine($"added to new employee");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee(100, "michael maurice", 7000, 23);
            socialinsurance s = new socialinsurance("social", 2);
            club c = new club("club for employees", "benha el velal ");

            em.hireEmployee += s.addinsurance;
            em.hireEmployee += c.addclub;


            em.OnhireEmployee();

            Console.ReadKey();
        }
    }
}

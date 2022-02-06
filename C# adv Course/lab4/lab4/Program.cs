using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public enum gender
    {
        male, female
    }


    [Flags]
   public  enum previlage : byte
    {
        guest = 1, Developer = 2, secretary = 4, DBA = 8
    }
    public class Hiredate://IComparable
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        public Hiredate(int day = 1, int month = 1, int year = 2022)
        {
            this.day = day;
            this.month = month;
            this.year = year;

        }

        //public int CompareTo(object obj)
        //{
        //    Hiredate otherDate = obj as Hiredate;
        //    if (otherDate.year == year)
        //    {
        //        if (otherDate.month == month)
        //        {
        //            if (otherDate.day == day) return 0;
        //            else if (otherDate.day > day) return -1;
        //            else return 1;
        //        }
        //        else if (otherDate.month > month) return -1;
        //        else return 1;
        //    }
        //    else if (otherDate.year > year) return -1;
        //    else return 1;
        //}

        public override string ToString()
        {
            return $"{day} / {month} / {year}";
        }


    }


    public class Employee: //IComparable
    {
       

        public int id { get; set; }

        public previlage securityLevel { get; set; }
        public int salary { get; set; }

        public Hiredate hireDate { get; set; }

        public gender gender { get; set; }

        public Employee(Hiredate hiredate, previlage securityLevel = previlage.guest, gender gen= gender.male,
            int id = 0,
             int salary = 2000

            )
        {
            this.id = id;
            this.securityLevel = securityLevel;
            this.salary = salary;
            this.gender = gender;
            this.hireDate = hiredate;




        }

        public override string ToString()
        {
            return $"Employee ID : {id} \n securityLevel : {securityLevel}\n Salary : {salary} \n Gender : {gender} \n Hire date : {hireDate}";
        }

        //public int CompareTo(object obj)
        //{
        //    Employee emp = obj as Employee;
        //    return hireDate.CompareTo(emp.hireDate);
            
        //}
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee[] emp = new Employee[3]
                {

                new Employee(new Hiredate(1,1,2020),previlage.DBA,gender.male,0,5000),
                new Employee(new Hiredate(2,2,2002),previlage.guest,gender.male,1,5000),
                new Employee(new Hiredate(3,3,2022),previlage.DBA ^ previlage.guest ^previlage.secretary ^previlage.Developer,gender.male,2,5000),

                };
                Array.Sort(emp);
                
                foreach (Employee emp2 in emp)
                {

                    Console.WriteLine(emp2);
                }
            }
            catch (Exception e)
            {

                //Write
                FileStream fWrite = new FileStream(@"D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\advanced_labs\lab4\Textfile.txt",
                     FileMode.Create, FileAccess.Write, FileShare.None);
                var text = e.Message;
                byte[] writeArr = Encoding.UTF8.GetBytes(text);
                fWrite.Write(writeArr, 0, text.Length);
                fWrite.Close();
                //Read
                FileStream fRead = new FileStream(@"D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\advanced_labs\lab4\Textfile.txt",
                       FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] readArr = new byte[text.Length];
                int count;
                while ((count = fRead.Read(readArr, 0, readArr.Length)) > 0)
                {
                    Console.WriteLine(Encoding.UTF8.GetString(readArr, 0, count));
                }
                fRead.Close();
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{

    struct student
    {
        int id;
        string name;    
        int age;
        public void set_Id(int _id)
        {
            if (_id > 0)
            {
                id = _id;
            }
            else
                Console.WriteLine(" Error ");
        }
        public void set_Age(int _age)
        {
            if (_age > 0)
            {
                age = _age;
            }
            else
                Console.WriteLine(" Error ");
        }
        public void set_Name(string _name)
        {
           name= _name;
        }
        public  int get_Id()
        {
            return id;
        }
        public int get_Age()
        {
            return age;
        }
        public string get_Name()
        {
            return name;
        }


        public void Print()
        {

            Console.WriteLine($"my name is : {name} \n My id is :{id} \n  iam: {age}  ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Please Enter number of studens :");

            int num= int.Parse(Console.ReadLine()); 
            int[] student_Ages = new int[num];
            int sum = 0;
            for (int i = 0; i < student_Ages.Length; i++)
            {
                student_Ages[i]=int.Parse(Console.ReadLine());
                sum += student_Ages[i];
            }
            Console.WriteLine($"Avg = {sum/num}");
            Array.Sort(student_Ages);
            Array.Reverse(student_Ages);

            #endregion

            #region task2 

            Console.WriteLine("Enter numbers of students : ");
            int num_of_Student= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter numbers of subjects : ");
            int num_of_Subjects = int.Parse(Console.ReadLine());
            int[,] sub = new int[num_of_Student, num_of_Subjects];

            for (int i = 0; i < num_of_Student; i++)

            {
                Console.WriteLine($"Student {i+1} : ");
                
                for (int j = 0; j < num_of_Subjects; j++)
                {
                    Console.WriteLine($"grade of Subject {j+1}");
                    sub[i,j]=int.Parse(Console.ReadLine());
                   


                }
                
            }


            for (int i = 0; i < num_of_Student; i++)

            {
                Console.WriteLine($"Student {i + 1} : ");
                int sum2 = 0;

                for (int j = 0; j < num_of_Subjects; j++)
                {
                    Console.WriteLine($"grade of Subject {j + 1} : {sub[i,j]}");

                    sum2 += sub[i, j];
                }
                Console.WriteLine($"sum of grades for Student {i + 1} = {sum2} ");
                Console.WriteLine("_______________________________________________________");

            }

            #endregion

            #region task 3 
            student s1 = new student();
            Console.WriteLine("Please Ener id: ");
            s1.set_Id(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please Ener Age: ");
            s1.set_Age(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please Ener name: ");
            s1.set_Name(Console.ReadLine());
             
            s1.Print();


            Console.WriteLine("Please Ener number of Array: ");
            int size_of_Array =int.Parse(Console.ReadLine());   
            student[] s2=new student[size_of_Array];
            for (int i = 0;i < size_of_Array; i++)
            {
                Console.WriteLine("Please Ener id: ");
                s2[i].set_Id(int.Parse(Console.ReadLine()));
                Console.WriteLine("Please Ener Age: ");
                s2[i].set_Age(int.Parse(Console.ReadLine()));
                Console.WriteLine("Please Ener name: ");
                s2[i].set_Name(Console.ReadLine());

            }





            #endregion


            Console.ReadKey();
        }
    }
}

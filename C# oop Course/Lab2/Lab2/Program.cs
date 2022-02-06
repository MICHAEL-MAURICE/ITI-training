using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region  task1
           Console.WriteLine("_____________Task 1______________");
            Console.WriteLine("Please Enter any char");
             char c = char.Parse(Console.ReadLine());
             int asci = (int)c;

             Console.WriteLine($"asci = {asci}");
             Console.WriteLine("Please Enter any Integer number");
             int numofasci = int.Parse(Console.ReadLine());
             char ch = (char)numofasci;
             Console.WriteLine($"char = {ch}");

             
            #endregion

            #region  task2
            Console.WriteLine("_____________Task 2______________");
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) { Console.WriteLine("Ths number is even"); }
            else Console.WriteLine("this number is odd");

            #endregion

            #region task3
            Console.WriteLine("_____________Task 3______________");
            Console.WriteLine("Enter number 1");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"sum = {num1+num2}");
            Console.WriteLine($"sub = {num1 - num2}");
            Console.WriteLine($"sub = {num1 * num2}");
            #endregion

            #region task4
            Console.WriteLine("_____________Task 4______________");
            Console.WriteLine("Please Enter your degree:");
            double degree = double.Parse(Console.ReadLine());

            if (degree < 50) Console.WriteLine("F");
            else if (degree >= 50 && degree < 60) Console.WriteLine("D");

            else if (degree >= 60 && degree < 70) Console.WriteLine("C");
            else if (degree >= 80 && degree < 90) Console.WriteLine("B");
            else  Console.WriteLine("A");
            #endregion


            #region task 5
            Console.WriteLine("_____________Task 5______________");
            for (int i = 1; i <= 12; i++)
            {
                for(int j = 1; j <= 12; j++)
                {
                    Console.WriteLine($"{i}*{j} = {i * j}");
                }

                Console.WriteLine("________________________________________________");
            }


            #endregion


            Console.ReadKey();
        }
    }
}

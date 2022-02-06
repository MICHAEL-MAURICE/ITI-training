using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
   class Complex
    {
        public int real { get; set; }
        public int img { get; set; }

        public Complex(int real, int img)
        {
            this.real = real;
            this.img = img;

        }
        public override string ToString()
        {
         
            return $"{real}+{img}i";
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
           
            return new Complex(c1.real -c2.real,c1.img - c2.img); ;
        }


        public static Complex operator *(Complex c1, Complex c2)
        {
           
            return new Complex(c1.real * c2.real, c1.img * c2.img);
        }

        public static Complex operator ++(Complex c1)
        {

            return new Complex(c1.real++, c1.img++);
          


        }
        

        public static bool operator >(Complex c1, Complex c2)
        {
            return (c1.real > c2.real && c1.img > c2.img);
        }
        public static bool operator <(Complex c1, Complex c2)
        {
            return (c1.real < c2.real && c1.img < c2.img);
        }
    }


    class calc
    {

       
        public static  int sum(int n1,int n2) { return n1 + n2; }
        public static int sub(int n1, int n2) { return n1 - n2; }
        public static int mul (int n1, int n2) { return n1 * n2; }
        public static int div(int n1, int n2) { return n1 / n2; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calc.sum(1,2));
            Console.WriteLine(calc.sub(2,1));
            Console.WriteLine(calc.mul(2,2));
            Console.WriteLine(calc.div(4,2));
            Complex c1 = new Complex(1,5);
            
            Console.WriteLine(++c1);
            Console.WriteLine(c1++);
            Console.ReadKey();  
        }
    }
}

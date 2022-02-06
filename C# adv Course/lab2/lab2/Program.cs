using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{

   public class three_d{

        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public three_d(int x,int y,int z)
        {
            this.x = x;
            this.y = y; 
            this.z = z; 
        }

        public override string ToString()
        {
            return $"-> point coordinates: ({x},{y},{z})";
        }
        public override bool Equals(object obj)
        {
            three_d p = (three_d)obj;   

            return (p.x==x && p.y==y && p.z==z);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            three_d p1=new three_d(1,5,6);
            Console.WriteLine(p1.ToString());
            three_d p2 = new three_d(1, 5, 6);
            Console.WriteLine(p1.Equals(p2));


            int res1,res2,res3;
            string myStr = null;
            res1 = Convert.ToInt32(myStr);
            Console.WriteLine("Convert: " + res1);
           // res2=int.Parse(myStr);
            //Console.WriteLine("int.parse " + res2);


            Console.WriteLine("int.parse " + int.TryParse(myStr, out res3));

            Console.WriteLine("int.tryparse " + res3);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a=new ArrayList();    
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            a.Add("ali");
            a.Add(2);
            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.ReadKey();
        }
    }
}

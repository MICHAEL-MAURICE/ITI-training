using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class queue<t>
    {

        private t[] arr { get; set; }
        private int tos { get; set; }

        public queue(int size = 10)
        {
            arr = new t[size];
            tos = 0;
        }


        public void push(t item)
        {
            if (tos < arr.Length)
                arr[tos++] = item;
            else
                throw new Exception();
        }

        public t popfront()
        {

           
                t popedItem = arr[0];
                for (int i = 0; i < tos-1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                tos--;
                return popedItem;

           
        }


        public override string ToString()
        {
            string res = "The res is : ";
            for (int i = 0; i < tos; i++)
            {
                res += arr[i].ToString()+" ";
            }

            return res;
        }
    }
    internal class Program
    {
        static void Main(string[] args)

        {


            try
            {

                queue<int> q = new queue<int>(5);
                
                q.push(1);
                q.push(2);
                q.push(3);
                q.push(4);
                q.push(5);

                q.push(4);
                q.push(5);
                q.push(4);
                q.push(5);
                q.push(4);
                q.push(5);

                Console.WriteLine( q.popfront());
                Console.WriteLine( q.ToString());
               
              

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}

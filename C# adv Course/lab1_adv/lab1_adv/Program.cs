using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_adv
{

    public static class mul
    {

        static void m

    }
    internal class Program
    {

       

        static void Main(string[] args)
        {
            
            #region task 1
            
            Console.WriteLine("Please enter size of array");
            int sizeofarr=int.Parse(Console.ReadLine());

            int []arr=new int[sizeofarr];

            int mx1 = 0;
            int mx = 0;
            int number = 0;
            int idx1 = 0,idx2=0;

            for(int i = 0; i < sizeofarr; i++)
            {

                arr[i]= int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < sizeofarr-1; i++)
            {
                for (int j = i+1; j < sizeofarr - 1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        mx = Math.Max(mx, (j - i + 1));
                        if (mx != mx1)
                        {
                            number=arr[i];
                            idx1 = i;
                            idx2 = j;
                        }
                        

                    }
                    mx1 = mx;

                }



            }


            Console.WriteLine($" the bigest number is {number}\nidx1 = {idx1} \nidx2={idx2}");

            #endregion
            
            
            #region task 2
        
            Console.WriteLine("Please enter your string");
            string s=Console.ReadLine();
            string[] arr2 =s.Split(' ') ;

            for(int i=arr2.Length-1;i>=0;i--)
                Console.Write(arr2[i]+" ");

            #endregion
            




            #region task 3
            int c = 0;
             void count_ones(int n)

            {
                
                while (n > 0)
                {
                    int p = n % 10;
                    if (p == 1) c++;
                    n /= 10;

                }

            }

            void count_ones2(string s)
            {
                for(int i=0; i<s.Length; i++)
                {
                    if(s[i] == '1')
                    c++;
                }


            }

            long o = 0;
            long countDigitOne(int n)
            {
                long countr = 0;
                for ( long i = 1; i <= n; i *= 10)
                {
                    long divider = i * 10;
                    countr += ((n / divider) * i + Math.Min(Math.Max(n % divider - i + 1, o), i));
                }
                return countr;
            }


            int[] arr = { 1,1, 20, 300, 4000, 50000, 600000, 7000000 };
            long ans = 0;
            long a = 1;
            int idx = 0;
            long count_ones3(int n)

            {

                if(n==0) return 0;
                while (n > 0)
                {
                    int p = n % 10;
                    if (p != 0) 
                    
                    {
                        ans += (idx<=1 ? 1+ p * arr[idx]:a+p*arr[idx]);
                        
                        idx++;
                        a *= 10;


                    }
                  
                    else
                    {
                       // a *= 10;
                        idx++;
                    }

                    n /= 10;

                }

                return ans;

            }

            long correct(int n)
            {
                if (n == 0) return 0;

                long b = 1;
                long sum = 0;

                while (b <= n)
                {
                    int cur = (int)(n / b % 10);
                    int left = (int)(n / b / 10);
                    int right = (int)(n % b);

                    if (cur > 1)
                    {
                        sum += (left + 1) * b;
                    }
                    else if (cur == 1)
                    {
                        sum += (left) * b;
                        sum += (right + 1);
                    }
                    else
                    {
                        sum += left * b;
                    }

                    b *= 10;
                }

                return sum;
            }


            Console.WriteLine("Please enter max number");

           int aa = int .Parse(Console.ReadLine());  
/*
            for(int i = 1; i <= a; i++)
            {
                count_ones2(i.ToString());


            }*/
           Console.WriteLine(correct(aa));
            Console.WriteLine(count_ones3(aa));



            #endregion
            System.Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _task_NADER_
{
    public class Program

    {

        /*
         notes 
        
         presentVolume  ====>   presentVolume
         presentPrice   ====>    presentPrice
         W              ====>    bagVolume  
         idx            ====>    index
         mony           ====>    budget
         c              ====>  counter to count peaple
         S              ====>  real num of  peaple


        if we can take any present for one time 
         int pick = solve(W - presentVolume[idx], idx-1, mony - presentPrice[idx], ++c);
       
        result = 7

        if we can take  any present for any time 
        int pick = solve(W - presentVolume[idx], idx, mony - presentPrice[idx], ++c);
        
        result = 14

          I solved this by using recursion because we have small constraines

         but if we have large we should use  dynamic programming
 
         */

        static void Main(string[] args)
        {

            const int N = 10000;
            const int M = 10000;
            float[] presentVolume = new float[N];
            float[] presentPrice = new float[M];
            int s = 0;
            int ans = 0;
            int solve(float W, int idx, float mony, int c)
            {
                if (W < 0) return -5000000;
                if (idx == -1) return 0;
                if (mony == 0) return 0;


                int pick = solve(W - presentVolume[idx], idx, mony - presentPrice[idx], ++c);

                int leave = solve(W, idx-1, mony, c);

                pick = c;
                if(s==c || c%s==0)
                    ans = Math.Max(pick, leave);
                
                return ans;

            }

            presentVolume[0] = 4.53f; ;
            presentPrice[0] = 12.23f;
            presentVolume[1] = 9.11f;
            presentPrice[1] = 45.03f;
            presentVolume[2] = 4.53f;
            presentPrice[2] = 12.23f;
            presentVolume[3] = 6.00f;
            presentPrice[3] = 32.93f;
            presentVolume[4] = 1.04f;
            presentPrice[4] = 6.99f;
            presentVolume[5] = 0.87f;
            presentPrice[5] = 0.46f;
            presentVolume[6] = 2.57f;
            presentPrice[6] = 7.34f;
            presentVolume[7] = 19.45f;
            presentPrice[7] = 65.98f;
            presentVolume[8] = 65.59f;
            presentPrice[8] = 152.13f;
            presentVolume[9] = 14.14f;
            presentPrice[9] = 7.23f;
            presentVolume[10] = 16.66f;
            presentPrice[10] = 10.00f;
            presentVolume[11] = 13.53f;
            presentPrice[11] = 25.25f;
            s = 7;
            Console.WriteLine("Result = "+solve(64.11f,11, 183.23f,0));


            Console.ReadKey();

        }
    }
}

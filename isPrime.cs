using System;
using System.Collections.Generic;

namespace giraffe
{
    //New Feature in C# 8
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a +ve Number till where Prime numbers is Needed.");
            int num = Convert.ToInt32(Console.ReadLine());
          for(int i=0;i<num;i++)
          {
            if(isPrime(i))
            {
                Console.WriteLine(i);

            }
            
          }
        // if(isPrime(127))
        //     {
        //         Console.WriteLine(127);

        //     }
        
            
         
        }
        public static bool isPrime(int n)
        {
            if(n==2)
            {
                return true;
            }
            if(n<2 || ((n%2)==0)){
                return false;
            }
            int ctr=0;
            //Console.Write("Counter--->");
            for(int i=3;i<Math.Sqrt(n);i++,i++)
            {
                ctr++;
                if(n%i == 0)
                {
                    return false;
                }

            }
            //Console.WriteLine(ctr);
            return true;
        }
        
    }


}

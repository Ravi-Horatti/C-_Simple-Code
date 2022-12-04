using System;
using System.Collections.Generic;

namespace giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter the base:");
          double num1 = Convert.ToDouble(Console.ReadLine());
       
          Console.WriteLine("Enter the power :");
          double num2 = Convert.ToDouble(Console.ReadLine());
          

         Console.WriteLine(getPow(num1,num2));
         }
         static double getPow(double basen, double pow)
         {
         	double result=1;
         	for(int i=0;i<= pow-1 ;i++)
         	{
         		result= result*basen;
         	}
//returning resut to calling method.
         	return result;
         }

    }
}

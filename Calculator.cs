using System;
using System.Collections.Generic;

namespace giraffe
{ 
    class Program
    {
        static void Main(string[] args)
        { 
          Console.WriteLine("Enter a Number:");
          double num1 = Convert.ToDouble(Console.ReadLine());
       
          Console.WriteLine("Enter 2nd Number :");
          double num2 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Enter Operator :");
          string op = Console.ReadLine();
          Console.Write("Result is : ");
          if(op == "+")
          {
            Console.WriteLine(num2+num1);
          }
          else if(op == "-")
          {
            Console.WriteLine(num1-num2);
          }
          else if(op == "*")
          {
            Console.WriteLine(num1*num2);
          }
          else if(op == "/")
          {
            Console.WriteLine(num1 / num2);
          }
          else 
          {
            Console.WriteLine("Invalid Operator: Please select correct oparator");
          }


          }
    }
}
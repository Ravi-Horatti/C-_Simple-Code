using System;
using System.Collections.Generic;

namespace giraffe
{ 
    class Program
    {
        static void Main(string[] args)
        { 
            //IF ELSE statements
           bool isMale = true;
           bool tall = false;
           if(isMale && tall)
           {
            Console.WriteLine( "Your are vey Tall Male!");
           }
           else if(isMale && !tall)
           {
            Console.WriteLine( "Your are short Male");
           }    
           else if(!isMale && tall)
           {
            Console.WriteLine( "Your are Tall but Not Male");
           }     
            else
            {
            Console.WriteLine( "Your are Not Male! or Not Tall or short non Male,??");

           }
            
            //Console.WriteLine( cube(3));
            //Console.ReadLine();

        }


      //   //Returrn Type Int
      // static int cube(int side)
      // {
      //   int result = side*side*side;
      //   return result;
      // }
    }
}
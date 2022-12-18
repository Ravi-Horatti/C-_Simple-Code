using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace giraffe
{
    //New Feature in C# 8
    class Program
    {
        static void Main(string[] args)
        {
           // Thread T1 = new Thread(new ThreadStart(fun1));
            
           // Task T1 = new Task(fun1); // 
           // Task T2 = new Task(fun1); //Built on top of Thread // Dosnt contain Thread Affinity. like Thread.
           
           // Thread T2 = new Thread(new ThreadStart(fun2));

            //T1.Start(); 
            //T2.Start();

            //After AYNC AND AWAIT
            
            //ASYNC :: Context Switching happens between methods
            //TASK &THread : Helps us to achiev Parallesism.

            fun1();
            fun2();
            Console.WriteLine("Helo World.");
            Console.ReadLine();

        }
        static  async void fun1()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Fuun 1 --:" + i);
            }

        }

        static async void fun2()
        {
            for (int i = 0; i < 1000; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Fuun 2 --:" + i);
            }

        }

    }


}

using System;
using System.Collections.Generic;
using System.Threading;

namespace giraffe
{
    //New Feature in C# 8
    class Program
    {
        static void Main(string[] args)
        {
           // Thread T1 = new Thread(new ThreadStart(fun1));
            Task T1 = new Task(fun1);
            Task T1 = new Task(fun1); //Built on top of Thread // Dosnt contain Thread Affinity. like Thread.
           // Thread T2 = new Thread(new ThreadStart(fun2));

            T1.Start();
            T2.Start();
            Console.WriteLine("Helo World.");
            Console.ReadLine();

        }
        static void fun1()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Fuun 1 --:" + i);
            }

        }

        static void fun2()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Fuun 2 --:" + i);
            }

        }

    }


}

using System;
using System.Collections.Generic;

namespace giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //// While & DO_While Loops.
            // int indexx = 6;
            // do
            // {
            //     Console.WriteLine("Hi");
            // } while (indexx <= 5);

            //----------------------------------------------------------
            // Guessing Word Game .
            string secreteWord = "giraffe";
            string guess = "";
            int limit = 5;
            int guess_count = 0;
            bool outofguuess = false;
            while (guess != secreteWord && !outofguuess)
            {
                if (guess_count < limit)
                {
                    Console.Write("Enter the Guess : ");
                    guess = Console.ReadLine();
                    guess_count++;
                }
                else
                {
                    outofguuess = true;
                }

            }
            if (!outofguuess)
            {
                Console.Write("You Win : ");

            }
            else if (outofguuess)
            {
                Console.Write("You Loose  ");

            }

            // Console.ReadLine();
        }

    }
}
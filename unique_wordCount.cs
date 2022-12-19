using System;
using System.Collections.Generic;

namespace giraffe
{
// 2nd round Prim_pokus
    class Program
    {
        static void Main(string[] args)
        {
            //
            int count = 1;
            string mystring = "ab abc ab abcd ab abc ab";
            string[] newstring = mystring.Split(" ");
            for (int j = 0; j < newstring - 2; j++)
            {
                int count = 1;
                int inde;
                if (newstring[j = "!"])
                {
                    continue;
                }
                else
                {
                    for (int i = 1; i < newstring - 1; i++)

                    {


                        if (newstring[j] == newstring[i])
                        {
                            inde = i;
                            count++;
                            newstring[j] = newstring[i] = "!";



                        }



                    }


                }

                Console.Write(newstring[inde]);
                Console.Write("Count " + count);

            }

        }
    }
}

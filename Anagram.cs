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
         anagram("qweidn11232#");

        }
         public static int anagram(string s)
    {
        //return -1 if string is uneven/odd
        if(((s.Length)%2) >0)
        {
            return -1;
        }
        else
        {
            //split string into 2 sub strings 
            var first = s.Substring(0, s.Length/2);
            var second = new List<char>(s.Substring(s.Length/2));
          
          // Remove all Common characters among both
           for(int i = 0; i < first.Length; ++i)
           {
                second.Remove(first[i]);
           }
               
             //return length  
            return second.Count();
        }

    }

    }


}

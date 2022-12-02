using System;
using System.Collections.Generic;

namespace giraffe
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Arrays.
            int[] luckynumbers = {3,4,5,66,7,8,12,9};
            //luckynumbers[0] = 111;
            string[] friends = new string[4];
            friends[0] = "John";
            friends[1] = "Mike";
            friends[2] = "Tom";
            friends[3] = "Jack";
            Console.WriteLine(friends[0]);

            Console.WriteLine(luckynumbers[0]);

//---------------------------------------------------------
            //METHOD
            greetings(friends[2]); //Calling Method here
            //iterating through array and calling method for all elements in it
            for(int i=0 ;i< friends.Length ; i++){
                greetings(friends[i]); 
            }



        }
        //new Method
        static void greetings( string name){
            Console.WriteLine("Hello "+name+" , Welcome to my Tuturial");
        }
    }
}
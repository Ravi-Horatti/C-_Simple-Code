using System;
using System.Collections.Generic;

namespace giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
           string mystring="asdfgjkjslfkjalkflja";
           char[] newchararray = mystring.toCharArray();
           bool value1= false;
           for(i=0;i<newchararray.Lenght;i++)
           {
           	for(j=i+1;j<newchararray.Lenght;j++)
           {
           	if (newchararray[i]==newchararray[j])
           	{
           		value1 = true

           	}
           }
           }


           //Use Value to check dublication:
        }
    }
}

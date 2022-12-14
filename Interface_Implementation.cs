using System;
using System.Collections.Generic;

namespace giraffe
{
    //New Feature in C# 8
    class Program
    {
        static void Main(string[] args)
        {
          
            Ivaccine vacc = new centre();
            vacc.Covaxin();//Calling a mehod in interface which has Implementation in It
            vacc.whichCenter();
         
        }
        public interface Ivaccine
        {
        	public void Covaxin(){
        		Console.WriteLine("Vaccinatin Done for Covaxin");
                //Implementing Logic in interface.
        	}
        }
        class centre : Ivaccine
        {
            public void whichCenter(){
        		Console.WriteLine("Centre is :  Bengaluru");
               
        	}

        }
    }


}

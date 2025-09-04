
using System;

Console.WriteLine("Top level Statement");

namespace C__day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //At a time only one is allowed in a c# file -- traditional or top level statement . 
            //Not allows us to use both in a single file. 
            // top level statements -- compiler also create a main method behind the seen. 
            // traditional way -- we manually write the main method
            // nd if both are used together in a sigle file then, it will cause error. 
            // because there will be two entry point in a sigle file 


        }
    }
}

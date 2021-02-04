using System;
using System.Runtime;
using ConsoleAppProject.App01;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Nick Day 04/02/2021
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine("Test output");
            //Console.Beep();
            Console.WriteLine();

            DistanceConverter converter = new DistanceConverter();
            converter.PrintHeading();

            char distanceUnit = 'M';

            switch (distanceUnit)
            {
                case (char)DistanceUnits.Feet: Console.WriteLine("Feet"); break;
                case (char)DistanceUnits.Miles: Console.WriteLine("Miles"); break;
                default : Console.WriteLine("No input"); break;
            }
        }
    }
}

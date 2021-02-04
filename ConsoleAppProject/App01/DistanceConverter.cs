using System;
using System.Runtime;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Nick Day version 0.1 - 04/02/21
    /// </author>
    public class DistanceConverter
    {
        public DistanceConverter()
        {
            PrintHeading();
            OutputResult(ConvertMilesToFeet(GetMiles()));
        }
        ///<summary>
        /// Output a heading
        ///</summary>
        private void PrintHeading()
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine("\tConvert Distances");
            Console.WriteLine("\tBy Nick Day");
            Console.WriteLine("------------------------");
        }

        private double GetMiles()
        {
            Console.WriteLine("Please enter the number of miles");
            return Convert.ToDouble(Console.ReadLine());
        }

        private double ConvertMilesToFeet(double miles)
        {
            return (miles * 5280);
        }

        private void OutputResult(double result)
        {
            Console.WriteLine(result.ToString("0.00") + " feet");
        }

    }
}

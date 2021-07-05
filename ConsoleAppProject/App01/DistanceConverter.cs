using System;
using System.Runtime;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Nick Day version 0.2 - 05/02/21
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;

        public const string FEET = "FEET";
        public const string MILES = "MILES";
        public const string METRES = "METRES";

        public string ToUnit { get; set; }
        public string FromUnit { get; set; }
        public double ToDistance { get; set; }
        public double FromDistance { get; set; }

        ///<summary>
        /// This is the constructor which intialises the class variables
        ///</summary>
        public DistanceConverter()
        {
            /*
            FromUnit = SelectUnit("Please choose a unit to convert FROM: ");
            ToUnit = SelectUnit("Please choose a unit to convert TO: ");
            InputFromDistance();
            ConvertDistance();
            PrintResult();
            */
        }

        ///<summary>
        /// This method gets the number of miles
        ///</summary>
        public void OutputChoices()
        {
            Console.WriteLine("1. " + FEET);
            Console.WriteLine("2. " + MILES);
            Console.WriteLine("3. " + METRES);
        }

        public string SelectUnit(string prompt)
        {
            Console.WriteLine("\n" + prompt);
            OutputChoices();
            Console.Write("\n > ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": return "FEET"; break;
                case "2": return "MILES"; break;
                case "3": return "METRES"; break;
            }
            return input.ToUpper();
        }

        public void InputFromDistance()
        {
            Console.WriteLine("Please enter the number of " + FromUnit);
            FromDistance = Convert.ToDouble(Console.ReadLine());
        }

        ///<summary>
        /// This method converts miles to feet
        ///</summary>
        public void ConvertDistance()
        {
            if(FromUnit == "MILES" && ToUnit == "FEET")
            {
                ToDistance = FromDistance * (double)FEET_IN_MILES;
            }
            if (FromUnit == "FEET" && ToUnit == "MILES")
            {
                ToDistance = FromDistance / (double)FEET_IN_MILES;
            }
        }

        ///<summary>
        /// This method prints the miles and feet
        ///</summary>
        public void PrintResult()
        {
            Console.WriteLine(FromDistance + " " + FromUnit + " is " + ToDistance + " " + ToUnit);
        }

    }
}

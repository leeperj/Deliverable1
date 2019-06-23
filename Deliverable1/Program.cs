using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputOne, userInputTwo, userInputThree;
            
            Console.WriteLine("Enter first number.");
            userInputOne = Console.ReadLine();
            Console.WriteLine("Enter second number.");
            userInputTwo = Console.ReadLine();
            Console.WriteLine("Enter third number.");
            userInputThree = Console.ReadLine();


            double inputOneParsed;
            double.TryParse(userInputOne, out inputOneParsed);
            double inputTwoParsed;
            double.TryParse(userInputTwo, out inputTwoParsed);
            double inputThreeParsed;
            double.TryParse(userInputThree, out inputThreeParsed);

            Console.WriteLine("You entered " + userInputOne +", " + userInputTwo + ", and " + userInputThree);

            double total = inputOneParsed + inputTwoParsed + inputThreeParsed;
            double average = inputOneParsed + inputTwoParsed + inputThreeParsed / 3;
            double highest = Math.Max(inputOneParsed, Math.Max(inputTwoParsed, inputThreeParsed));
            double lowest = Math.Min(inputOneParsed, Math.Min(inputTwoParsed, inputThreeParsed));


            var jpcur = total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
            var uscur = total.ToString("C2");
            var swcur = total.ToString("C2", CultureInfo.CreateSpecificCulture("sv-SE"));
            var thaicur = total.ToString("C", CultureInfo.CreateSpecificCulture("th-TH"));

            Console.WriteLine("The highest number is " + highest);
            Console.WriteLine("The lowest number is " + lowest);
            Console.WriteLine("The Total is " + total);
            Console.WriteLine("The average is " + average);
            Console.WriteLine("In US currency this is " + uscur);
            Console.WriteLine("In Swedish currency this is " + swcur);
            Console.WriteLine("In Japanese currency this is " + jpcur);
            Console.WriteLine("In Thai currency this is " + thaicur);
            Console.ReadLine();
        }

    }
}

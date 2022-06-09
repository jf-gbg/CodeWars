using System;

namespace Twice_As_Old
{
    internal class Program
    {
        //To get the age the father needs to be we need to multiply the sons age by 2
        //If the father is 30 years old and the son is 0 years old it was 30 years ago that the father was twice his sons age. (2 * 0 = 0, 30 - 30 = 0)
        //If the father is 30 years old and the son is 7 years old it was 16 years ago that the father was twice his sons age. (2 * 7 = 14, 30 - 16 = 14)
        //If the father is 45 years old and the son is 30 years old it will be 15 years until the father is twice his sons age. (2 * 30 = 60, 45 + 15 = 60)

        //create a solution that works when the father must be younger (subtracting from the fathers age)
        //dadYears - sonsAgeDoubled = years;
        public class TwiceAsOldSolution
        {
            public static int TwiceAsOld(int dadYears, int sonYears)
            {
                int sonsAgeDoubled = sonYears * 2;
                int years = dadYears - sonsAgeDoubled;

                return years;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine(TwiceAsOldSolution.TwiceAsOld(30, 10));
        }
    }
}

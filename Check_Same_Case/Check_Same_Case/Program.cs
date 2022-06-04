using System;
//if character a and character b are both letters check if they are lower case.
//if either is not a letter return -1
//if either one of the two letters is not lower case return 0

namespace Check_Same_Case
{
    public class Kata
    {

        //using built in C# methods (24.6ms in test)
        public static int SameCase(char a, char b)
        {
            if(!Char.IsLetter(a) || !Char.IsLetter(b))
            {
                return -1;
            }
            else if((Char.IsLower(a) && Char.IsLower(b)) || 
                (Char.IsUpper(a) && Char.IsUpper(b)))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //My own methods.(18.12ms in test)
        public static int SameCaseManual(char a, char b)
        {
            var resultA = CheckCase(a);
            var resultB = CheckCase(b);

            if (resultA == -1 || resultB == -1)
                return -1;
            else if (resultA == resultB)
                return 1;
            else
                return 0;
        }

        public static int CheckCase(char character)
        {
            int returnInt;

            if (character >= 97 && character <= 122)
                returnInt = 0;
            else if (character >= 65 && character <= 90)
                returnInt = 1;
            else
                returnInt = -1;

            return returnInt;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var returnValue = Kata.SameCase('7', 'b');
            Console.WriteLine(returnValue);
        }
    }
}
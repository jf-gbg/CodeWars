using System;

namespace Check_Same_Case
{
    public class Kata
    {
        public static int SameCase(char a, char b)
        {
            int letterA = (a);
            return letterA;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var returnValue = Kata.SameCase('a', 'b');
            Console.WriteLine(returnValue);
        }
    }
}
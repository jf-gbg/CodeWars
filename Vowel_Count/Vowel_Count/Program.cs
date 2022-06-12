using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        foreach(char letter in str)
        {
            switch (letter)
            {
                case 'a':
                    vowelCount += 1;
                    break;
                case 'e':
                    vowelCount += 1;
                    break;
                case 'i':
                    vowelCount += 1;
                    break;
                case 'o':
                    vowelCount += 1;
                    break;
                case 'u':
                    vowelCount += 1;
                    break;
            }
        }

        return vowelCount;
    }
}

namespace Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetVowelCount("abrakadabra"));
        }
    }
}


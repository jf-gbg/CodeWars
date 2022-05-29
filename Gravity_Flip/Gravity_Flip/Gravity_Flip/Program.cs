using System;

namespace Gravity_Flip
{

    //Restate
    //Sort an array of numbers either asscending or decending based on whether the method recieves L or R as a parameter.
    //Divide
    //Find the largest number in an array and return it. DONE
    //Find the largest number in an array and place it at the end of the return array. DONE
    //Sort an array of 2 numers and return it. DONE
    //Sort an array of 3 numbers and return it.

    public class Kata
    {
        public static int[] Flip(char dir, int[] arr)
        {
            int holdInt = 0;
            int num1 = 0;
            int num2 = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                Kata.WriteArray(arr);

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    num1 = arr[j];
                    num2 = arr[j + 1];

                    if (num1 > num2)
                    {
                        holdInt = num2;
                        arr[j + 1] = num1;
                        arr[j] = holdInt;
                    } 
                }
            } 

            return arr;
        }

        public static void WriteArray(int[] array)
        {
            foreach(int number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 3, 2, 1, 2 };
            Kata kata = new Kata();

            Kata.WriteArray(Kata.Flip('R', testArray));
        }
    }
}

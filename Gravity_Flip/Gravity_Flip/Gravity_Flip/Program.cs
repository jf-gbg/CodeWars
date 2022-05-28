using System;

namespace Gravity_Flip
{

    //Restate
    //Sort an array of numbers either asscending or decending based on whether the method recieves L or R as a parameter.
    //Divide
    //Find the largest number in an array and return it. DONE
    //Find the largest number in an array and place it at the front of the return array. 
    //Sort an array of 2 numers and return it. 
    //Sort an array of 3 numbers and return it.

    
    public class Kata
    {
        public static int[] Flip(char dir, int[] arr)
        {
            int[] returnArr = new int[arr.Length];
            int holdInt = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > holdInt)
                {
                    holdInt = arr[i];
                }

                if(i == arr.Length - 1)
                {
                    arr[i] = holdInt;
                }

            }

            return arr;
        }

        public static void WriteArray(int[] array)
        {
            foreach(int number in array)
            {
                Console.WriteLine(number);
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 4, 0, 2, 3 };
            Kata kata = new Kata();

            Console.WriteLine(Kata.Flip('R', testArray));

            Kata.WriteArray(Kata.Flip('R', testArray));
        }
    }
}

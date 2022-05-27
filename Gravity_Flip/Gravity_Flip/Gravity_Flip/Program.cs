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
        public static int Flip(char dir, int[] arr)
        {
            int returnInt = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(returnInt < arr[i])
                {
                    returnInt = arr[i];
                }
            }

            return returnInt;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 3, 22, 1, 5 };
            Kata kata = new Kata();

            Console.WriteLine(Kata.Flip('R', testArray));
        }
    }
}

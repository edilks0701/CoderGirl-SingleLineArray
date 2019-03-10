using System;

namespace SingleLineArray
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Initialize a single line an array with the following values: 1, 1, 2, 3, 5, 8. 

            int[] numbers = {1,1,2,3,5,8};
            
            numbers[0] = 1;
            numbers[1] = 1;
            numbers[2] = 2;
            numbers[3] = 3;
            numbers[4] = 5;
            numbers[5] = 8;

            foreach (int value in numbers)
            {
                   
                 Console.WriteLine(value);
            }


            // TODO: Loop through the array using foreach and print out each value on its own line.

            Console.ReadLine();
        }
    }
}

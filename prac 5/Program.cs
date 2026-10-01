using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int s = 1; s <= 5 - i; s++)
                Console.Write(" ");        // spaces

            for (int j = 1; j <= i; j++)
                Console.Write(j + " ");    // numbers

            Console.WriteLine();
        }
    }
}

/*
 * for (int i = 1; i<=5; i++){
 *     for (int s=1, s<=5-i; s++){
 *         Console.write(" ");
 *         for (int j=1, j<=i, j++){
 *             Console.write("* ");
 *         }
 *      }
 *      console.writeline();
 * }
*/

using System;

class Program
{
    static void Main()
    {
        for (int i = 5; i >= 1; i--)       // 5 to 1
        {
            for (int j = 1; j <= i; j++)
                Console.Write("* ");

            Console.WriteLine();
        }
    }
}

/*
 * static void main(){
 * for(int i = 5, i>=1, i--){
 *    for (int j = 1, j<=i, j++){
 *        Console.Write("* ");
 *    }
 *    console.writeline();
 * }
*/


using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)       // rows
        {
            for (int j = 1; j <= i; j++)  // numbers in each row
                Console.Write(j + " ");

            Console.WriteLine();           // next line
        }
    }
}

/*
 * using System;
 * class Program {
 *    public void main() {
 *        for (int i=1; i<=5, i++){
 *           for(int j=1; j<=i; j++) {
 *               Console.Write(j + " ")
 *            }
 *            console.WriteLine();
 *        }
 *    }
*/

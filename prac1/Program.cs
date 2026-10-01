using System;

class practical1
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        while (n > 0)
        {
            sum = sum + n % 10; // take last digit
            n = n / 10;         // remove last digit
        }

        Console.WriteLine("Sum = " + sum);
    }
}

/*
 * This program calculates the sum of digits of a given number.
 * using System,
 * class Program{
 *     public void main() {
 *           Console.Write("Enter number: ");
 *           int n = Convert.ToInt32(Console.Readline());
 *           
 *           int sum = 0;
 *           
 *           while(n>0){
 *              sum = sum + n%10;
 *              n = n/10;
 *           }
 *           
 *           Console.WriteLine("Sum = " + sum);
 *
 */

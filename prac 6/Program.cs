using System;

class Program
{
    static void Main()
    { // create 3*3 matrix with diagonal sum and border sum
        int[,] matrix = new int[3, 3];
        int diagonalSum = 0;
        int borderSum = 0;
        // Input matrix elements
        Console.WriteLine("Enter the elements of the 3x3 matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // Calculate diagonal and border sums
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j) // Primary diagonal
                    diagonalSum += matrix[i, j];
                if (i == 0 || i == 2 || j == 0 || j == 2) // Border elements
                    borderSum += matrix[i, j];
            }
        }
        // Output results
        Console.WriteLine($"Diagonal Sum: {diagonalSum}");
        Console.WriteLine($"Border Sum: {borderSum}");
    }
}
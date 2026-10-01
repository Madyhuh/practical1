// find maximum element in a pre defined matrix
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int max = matrix[0, 0];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (matrix[i, j] > max)
                    max = matrix[i, j];
            }
        }

        Console.WriteLine($"Maximum element in the matrix is: {max}");
    }
}

// find maximum element in a user defined matrix
/*
int[,] matrix = new int[3, 3];
int max = matrix[0, 0];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (matrix[i, j] > max)
            max = matrix[i, j];
    }
}

Console.WriteLine($"Maximum element in the matrix is: {max}");
*/

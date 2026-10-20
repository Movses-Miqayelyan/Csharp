using System.Numerics;

namespace ConsoleApp3;

class Program
{
    /*static void Main(string[] args)
    {
        Console.WriteLine("matrix.GetLength(0)");
        Console.WriteLine("matrix.GetLength(1)");
    }*/

    static int[] Above(int[,] matrix, int limit)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > limit)
                {
                    count++;
                }
            }
        }

        int[] arr = new int[count];
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > limit)
                {
                    arr[k] = matrix[i, j];
                    k++;
                }
            }
        }

        return arr;
    }
}
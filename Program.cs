using System;

namespace _4444444
{
    class Matrix
    {
        public static bool isToeplitzMatrix(int[,] matrix)
        {
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);
            if (x == 0|| y == 0)
            {
                return true;
            }
            for (int i = 1; i < x-1; i++)
            {
                for (int j = 1; j < y-1; j++)
                {
                    if (matrix[i,j] != matrix[i +1,j +1])
                    {
                        return false;
                    }
                }
            }
            return true;

        }
        public static void  Main(String[] args)
        {
            int[,] a = new int [,]{ { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };

            bool b = isToeplitzMatrix(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}

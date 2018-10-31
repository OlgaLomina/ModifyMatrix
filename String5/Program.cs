using System;
//Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column are set to 0.
namespace String5
{
    class Program
    {       
        static int[,] ModifyMatrix(int[,] matrix, int nrows, int ncolumns)
        {
            bool[] rows = new bool[nrows];
            bool[] columns = new bool[ncolumns];
            //по умолчанию в массивах все false
            //если наш элемент равен нулю, то ставим в массив true    //Array.Clear(rows, false, rows.Length);
            for (int i=0; i<nrows; i++)
            {
                for (int j=0; j<ncolumns; j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        rows[i] = true;
                        columns[j] = true;
                    }
                }
            }
            for (int i=0; i<nrows; i++)
            {
                for (int j=0; j<ncolumns; j++)
                {
                    if (rows[i] || columns[j])
                        matrix[i,j] = 0;                  
                }
            }
            return matrix;
        }

        static void Main(string[] args)
        {
            const int nrows = 3;
            const int ncolumns = 4;
            int[,] matrix = new int[nrows, ncolumns];

            //for (int i = 0; i < nrows; i++)
            //{
            //    for (int j = 0; j < ncolumns; j++)
            //    {
            //        Console.Write("Enter value for ({0},{1}): ", i, j);
            //        matrix[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            matrix[0, 0] = 1;
            matrix[0, 1] = 1;
            matrix[0, 2] = 0;
            matrix[0, 3] = 1;
            matrix[1, 0] = 1;
            matrix[1, 1] = 1;
            matrix[1, 2] = 1;
            matrix[1, 3] = 1;
            matrix[2, 0] = 1;
            matrix[2, 1] = 0;
            matrix[2, 2] = 1;
            matrix[2, 3] = 1;

            PrintMatrix(matrix, nrows, ncolumns);
            matrix = ModifyMatrix(matrix, nrows, ncolumns);
            Console.WriteLine();
            PrintMatrix(matrix, nrows, ncolumns);
        }

        static void PrintMatrix(int[,] matrix, int nrows, int ncolumns)
        {
            int i, j;
            for (i = 0; i < nrows; i++)
            {
                for (j = 0; j < ncolumns; j++)
                {
                    Console.Write("  " + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


    }
}

// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
int[,] matrix = new int[4, 7];

void InputMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void SortMatrix(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                {
                    if (matrix[i, k] < matrix[i, k + 1])
                    {
                        int sort = matrix[i, k + 1];
                        matrix[i, k + 1] = matrix[i, k];
                        matrix[i, k] = sort;
                    }
                }
                }
        }
}

void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[i, j]}\t");
                Console.WriteLine();
        }
    }
    InputMatrix(matrix);
    PrintMatrix(matrix);
    SortMatrix(matrix);
    Console.WriteLine();
    PrintMatrix(matrix);
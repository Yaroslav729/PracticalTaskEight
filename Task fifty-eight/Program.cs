// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
Console.Clear();

int[,] matrix = new int[2, 2];
int[,] secondMatrix = new int[2, 2];
int[,] resultMatrix = new int[2, 2];
InputMatrixRandom(matrix);
PrintMatrix(matrix);
Console.WriteLine();
InputMatrixRandom(secondMatrix);
PrintMatrix(secondMatrix);
Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            resultMatrix[j, i] = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                resultMatrix[j, i] += matrix[i, k] * secondMatrix[k, j];
            }
        }
    }

    PrintMatrix(resultMatrix);

void InputMatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 5);
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

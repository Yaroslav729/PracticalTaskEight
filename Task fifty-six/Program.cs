// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
int[,] matrix = new int[5, 3];
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
        int sumString = 0;
        int count = 0;

        for (int i = 0; i < matrix.GetLength(1); i++)
        sumString += matrix[0, 1];

        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum += matrix[i, j];   
            if (sum < sumString)  
            {
                sumString = sum;
                count = i;
            }      
        Console.Write($"{sum} ");
    }
     Console.WriteLine();
    Console.Write($"{count + 1} строка"); 
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
    Console.WriteLine();
    SortMatrix(matrix);
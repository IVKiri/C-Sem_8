// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер массива m x n. ");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();

int[,] newMatrix = new int[n, m];

for(int i = 0; i < newMatrix.GetLength(0); i++)
{
    for(int j = 0; j < newMatrix.GetLength(1); j++)
    {
        newMatrix[i,j] = matrix[j,i];
    }
    Console.WriteLine();
}
PrintMatrix(newMatrix);
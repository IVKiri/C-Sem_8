// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = new Random().Next(2, 7);
int n = new Random().Next(2, 7);
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();

// Первый вариант

for (int k = 0; k < 10; k++)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == k)
            {
                count++;
            }
        }
    }
    if (count != 0) Console.WriteLine($"Кол-во повторений для {k} = {count}");
}

//  Второй вариант

// int[] countArray = new int[10];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int index = matrix[i, j];
//         countArray[index]++;
//     }
// }

// for(int i = 0; i < countArray.Length; i++)
// {
//     if(countArray[i] !=0)
//     {
//         Console.WriteLine($"Кол-во повторений для {i} = {countArray[i]}");
//     }
// }



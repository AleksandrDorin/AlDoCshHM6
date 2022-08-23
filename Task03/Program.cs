// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] CreateMatrix(int length, int width, int min, int max)
{
    int[,] matrix = new int[length, width];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(min, max);
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }

}
void ChangeElement(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
                matrix[i, j] *= matrix[i, j];
    
}

int[,] matrix = CreateMatrix(3, 3, 1, 10);
PrintMatrix(matrix);
ChangeElement(matrix);
Console.WriteLine("");
PrintMatrix(matrix);
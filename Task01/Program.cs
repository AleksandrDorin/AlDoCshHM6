// Показать двумерный массив размером m×n заполненный вещественными числами
double[,] CreateMatrix(int lenght, int width)
{
    double[,] matrix = new double[lenght, width];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.NextDouble();
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine(" ");
    }

}
double[,] matrix = CreateMatrix(3, 3);
PrintMatrix(matrix);
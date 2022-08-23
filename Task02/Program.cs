// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] CreateMatrix(int length, int width)
{
    int[,] matrix = new int[length, width];
    Random random = new Random();
    for(int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            matrix[i,j] = i + j;
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
            Console.Write($"{matrix[i,j]} \t");
        Console.WriteLine();
    }
    
}
int[,] matrix = CreateMatrix(6,6);
PrintMatrix(matrix);
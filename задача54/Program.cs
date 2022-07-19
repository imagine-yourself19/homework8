int[,] Creatematrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //int x = Convert.ToInt32(Console.ReadLine());
            int x = new Random().Next(1, 10);
            matrix[i, j] = x;
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    return matrix;
}

int[,] SortVozrast(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
        {
            if (matrix[i, k] > matrix[i, k + 1])
            {
            int t = matrix[i, k];
            matrix[i, k] = matrix[i, k + 1];
            matrix[i, k + 1] = t;
            }
        }
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
}
return matrix;
}

int[,] matrix = new int[4, 4];
matrix = Creatematrix(matrix);
Console.WriteLine();
matrix = SortVozrast(matrix);
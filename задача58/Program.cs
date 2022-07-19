int[, ] CreateMatrix1(int[, ] matrix1)
{
for (int i = 0; i < matrix1.GetLength(0); i++)
{
for (int j = 0; j < matrix1.GetLength(1); j++)
{
int x = new Random().Next(1, 10);
matrix1[i , j] = x;
}
}
for (int i = 0; i < matrix1.GetLength(0); i++)
{
for (int j = 0; j < matrix1.GetLength(1); j++)
{
Console.Write(matrix1[i, j] + "\t");
}
Console.WriteLine();
}

return matrix1;
}

int[, ] CreateMatrix2(int[, ] matrix2)
{
for (int i = 0; i < matrix2.GetLength(0); i++)
{
for (int j = 0; j < matrix2.GetLength(1); j++)
{
int x = new Random().Next(1, 10);
matrix2[i , j] = x;
}
}
for (int i = 0; i < matrix2.GetLength(0); i++)
{
for (int j = 0; j < matrix2.GetLength(1); j++)
{
Console.Write(matrix2[i, j] + "\t");
}
Console.WriteLine();
}

return matrix2;
}

void MatrixMultiplication(int[, ]matrix1, int[, ]matrix2)
{
Console.WriteLine();
for (int i = 0; i < matrix1.GetLength(0); i++)
{
for (int j = 0; j < matrix1.GetLength(1); j++)
{
    
    matrix1[i, j] = matrix1[i, j] * matrix2[i, j];
}
}

for (int i = 0; i < matrix1.GetLength(0); i++)
{
for (int j = 0; j < matrix1.GetLength(1); j++)
{
Console.Write(matrix1[i, j] + "\t");
}
Console.WriteLine();
}

}

int[, ] matrix1 = new int[3, 3];
int[, ] matrix2 = new int[3, 3];
matrix1 = CreateMatrix1(matrix1);
Console.WriteLine();
matrix2 = CreateMatrix2(matrix2);
MatrixMultiplication(matrix1, matrix2);
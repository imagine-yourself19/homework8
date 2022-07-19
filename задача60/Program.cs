int[,, ] CreateMatrix(int[,, ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
for (int k = 0; k < matrix.GetLength(2); k++)
{
int x = new Random().Next(10, 100);
matrix[i, j, k] = x;
}
}
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
for (int k = 0; k < matrix.GetLength(2); k++)
{
Console.Write(matrix[i, j, k] + "\t");
// $"Элемент с индексом [{i, j, k}] : "+matrix... - думала получится вывести индекс так, но "ошибка сборки"
}
}
Console.WriteLine();
}

return matrix;
}

int[,, ] matrix = new int[3, 3, 3];
matrix = CreateMatrix(matrix);
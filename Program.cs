// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] matrix = new int[2, 2];
// void FillArray(int[,]matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 5);

        // FillArray(matrix);
        // Print Array(int[,]matrix);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.Write($"Вторая матрица ");
Console.WriteLine();
int[,] matrix2 = new int[2, 2];
// void FillArray(int[,]matrix);
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = new Random().Next(1, 5);

        // FillArray(matrix);
        // Print Array(int[,]matrix);
        Console.Write($"{matrix2[i, j]} ");
    }
    Console.WriteLine();
}
Console.Write($"Результирующая матрица ");
Console.WriteLine();
int[,] matrixresult = new int[2,2];
for (int i = 0; i < matrixresult.GetLength(0); i++)
{
    for (int j = 0; j < matrixresult.GetLength(1); j++)
    {
        matrixresult[i, j] = matrix[i, j] * matrix2[i, j];
    
    Console.Write($"{matrixresult[i,j]} ");
}
Console.WriteLine();
}
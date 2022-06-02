// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SortRowMaxToMinArray(int[,] matr, int row)
{
    int jMin = 0;
    int matrMin = 0;
    int tmp = 0;
    int length = matr.GetLength(1);
    while (length > 0)
    {
        matrMin = matr[row, 0];
        jMin = 0;
        for (int j = 0; j < length; j++)
        {
            if (matr[row, j] < matrMin)
            {
                jMin = j;
                matrMin = matr[row, j];
            }

        }
        tmp = matr[row, length - 1];
        matr[row, length - 1] = matr[row, jMin];
        matr[row, jMin] = tmp;
        length--;
    }
}
Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во столбцов: ");
int k = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] matrix = new int[n, k];
FillArray(matrix);
Console.WriteLine("Начальный полученный массив: ");
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
for (int i = 0; i < n; i++)
    SortRowMaxToMinArray(matrix, i);
Console.WriteLine("Массив после сортировки по убыванию каждой строки: ");
Console.WriteLine();
PrintArray(matrix);
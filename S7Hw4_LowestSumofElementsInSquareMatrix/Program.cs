// В прямоугольной матрице найти строку с наименьшей суммой элементов.
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
int FindRowWithLowestSumOfElements(int[,] matr)
{
    int length = matr.GetLength(0);
    int[] sums = new int[length];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            sums[i] = sums[i] + matr[i, j];
        }
    }
    int iMax = 0;
    int max = sums[0];
    for (int i = 1; i < length; i++)
        if (sums[i] < max)
        {
            max = sums[i];
            iMax = i;
        }
    return iMax + 1;
}
Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] matrix = new int[n, n];
FillArray(matrix);
Console.WriteLine("Полученный массив: ");
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine($"Номер строки с минимальной суммой элементов: {FindRowWithLowestSumOfElements(matrix)}");
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//         array[i,j] = new Random().Next(min, max+1);
//     }
//     }
//     return array;
// }
// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength (0); i++)
//     {
//         for (int j = 0; j < array.GetLength (1); j++)
//     {
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine ();
// }
// }
// Console.WriteLine("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите минимальное число: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите максимальное число: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandomArray(rows, columns, min, max);
// ShowArray(myArray);

double[,] CreateRandomArray(int m, int n)
{
    double[,] array = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        array[i,j] = new Random().NextDouble();
    }
    }
    return array;
}
void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength (0); i++)
    {
        for (int j = 0; j < array.GetLength (1); j++)
    {
        Console.Write("{0;f2}",array[i,j] + " ");
    }
    Console.WriteLine ();
}
}
Console.WriteLine("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandomArray(rows, columns);
ShowArray(myArray);
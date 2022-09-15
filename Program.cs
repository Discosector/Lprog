// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

int[,] CreateRandomArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(rows, columns, min, max);
ShowArray(myArray);



double[] AvgColumns(int[,] array)
{
    double[] Avg = new double[array.GetLength(0)];
    
    for(int i=0; i<array.GetLength(0); i++)
    {
        double Sum=0;
        for(int j=0; j<array.GetLength(1); j++)
        {
            Sum+=array[i,j];
        }
        Avg[i]=Sum/array.GetLength(1);
        Console.Write($"{Avg[i]} ");
    }
    Console.WriteLine();
    return(Avg);
}
 AvgColumns(myArray);
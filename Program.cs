// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] CreateRandomArray(int m, int n, int min, int max)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        array[i,j] = new Random().Next(min, max+1);
    }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength (0); i++)
    {
        for (int j = 0; j < array.GetLength (1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine ();
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

int[,] myArray1 = CreateRandomArray(rows, columns, min, max);
ShowArray(myArray1);
Console.WriteLine ();
int[,] myArray2 = CreateRandomArray(rows, columns, min, max);
ShowArray(myArray2);

int[,] ProdArray(int[,]array1,int[,]array2 )
{
    int[,] ArrayNew = new int[rows, columns];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {

            for (int k = 0; k < array2.GetLength(0); k++)
            {
                for (int l = 0; l < array2.GetLength(1); l++)
                {
                    ArrayNew[i,j]= array1[i,j]+array2[k,l];

                }
            }
        }
    }

    return ArrayNew;
}       
Console.WriteLine ();
int [,]matrix = ProdArray (myArray1,myArray2);
ShowArray(matrix);

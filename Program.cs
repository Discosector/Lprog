// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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
// void SortRows(int[,] array)
// {


//     for (int i= 0; i < array.GetLength(0); i++)
//     {
//     int buf = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
                
//                 if (array[i,k] > array[i, j])
//                 {

//                     buf = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i,k] = buf;
//                 }

//             }
//         }
//     }
//     Console.WriteLine();
// }
// SortRows (myArray);
// ShowArray (myArray);


// #56

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



 int[] SumRows(int[,] array)
{
    int[] Sum = new int[array.GetLength(1)];
    
    for(int i=0; i<array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j=0; j<array.GetLength(1); j++)
        {
           sum+=array[i,j];
        }
        
       Console.Write($"{sum} ");
        
    }
    Console.WriteLine();
    return(Sum);
}
 int[]arrayOne = SumRows(myArray);


int MinNumber(int[]Array)
{
 int min = Array[0];

    for (int i = 0; i < Array.Length; i++)
{
    if (Array[i]<min)
        { 
            min = Array[i];
        }
}
return min;

}

bool Exam(int rows, int columns)
{
    if (rows== columns)
    {
        return false;
    
    }
    else
    {
        return true;
    }
}

if (Exam(rows, columns) == false)
{
    Console.WriteLine("Введите разные значения строк и столбцов");
    
}
else SumRows(myArray);

Console.WriteLine ();
Console.WriteLine (MinNumber(arrayOne));
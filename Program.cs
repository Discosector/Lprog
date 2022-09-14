// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

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

// void Number(int[,] array, int a, int b)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == a && j == b)
//             {
//                 Console.Write(array[i, j] + " ");
//             }

//         }
//     }
// }
// Console.WriteLine("Введите индексы элемента: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());

// bool Exam(int x1, int y1)
// {
//     if (x1 > rows || y1 > columns)
//     {
//         return false;
//     }
//     else
//     {
//         return true;
//     }
// }

// if (Exam(x, y) == false)
// {
//     Console.WriteLine("Элемента не существует");
// }
// else Number(myArray, x, y);
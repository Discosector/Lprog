// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

// int[] CreArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1,100);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// int[] myArray = CreArray(10);
// ShowArray(myArray);

// int sum = 0;
// for (int i = 0; i < myArray.Length; i++)
// { if (i % 2 == 1)
//     sum += myArray [i];
// }
// Console.Write($"сумма элементов, стоящих на нечётных позициях: {sum}");
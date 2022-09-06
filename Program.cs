// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве


// int[] CreArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
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

// int count = 0;
// for (int i = 0; i < myArray.Length; i++)
// { if (myArray [i] % 2 == 0)
//     count += 1;
// }
// Console.Write($"количество четных чисел: {count}");
// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

// // 1й вариант

// int Multi (int a, int b)
// {
// int Pow = 1;
// int num = 0;
// while (num<b)
// {
//     Pow = Pow * a;
//     num ++;
// }
// return Pow;
// }
// Console.WriteLine("введите два числа: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Multi(num1, num2));

// // // 2й вариант

// int Multi (int a, int b)
// {
// int Pow = Math.Pow(a,b);
// return Pow;
// }
// Console.WriteLine("введите два числа: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Multi(num1, num2));

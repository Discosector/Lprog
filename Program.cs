Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2  > max)
    max = num2;
if (num3 > max)
    max = num3;
Console.WriteLine(num1+", " + num2+ ", "+ num3+ " -> " +max);
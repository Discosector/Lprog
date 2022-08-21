int current = 1;
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + num);
while (current <= num)
    if (current % 2 == 0)
        Console.Write(current + "");
    current++;
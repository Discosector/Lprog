int Sec(int Number){
    int n = Number/10%10;
    return n;}
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int a = Sec(num);
Console.WriteLine(num + " -> " + a);
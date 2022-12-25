Console.Write("Программа, которая принимает на вход трёхзначное 23");
System.Console.WriteLine("число и на выходе показывает вторую цифру этого числа");
Console.WriteLine("Введите трёхзначное число: ");

int x = Convert.ToInt32(Console.ReadLine());

while (x <= 100 || x > 999)
{
    Console.WriteLine("Это не трёхзначное число, попробуйте ещё раз: ");
    x = Convert.ToInt32(Console.ReadLine());
}

x = x / 10 % 10;
Console.WriteLine($"Вторая цифра введённого числа: {x}");
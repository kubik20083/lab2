System.Console.WriteLine("Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");  

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
string numberStr = Convert.ToString(number);
int numberDigit = numberStr.Length;

if (numberDigit > 2) 
Console.WriteLine($"Третья цифра введённого числа: {numberStr[2]}");

else Console.WriteLine("Третьей цифры нет");

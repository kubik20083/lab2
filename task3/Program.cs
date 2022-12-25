Console.Write("Введите число для недели от 1 до 7: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1 || x > 7)
System.Console.WriteLine("Дней недели всего 7, введите число от 1 до 7");
else if (x > 5)
System.Console.WriteLine("Выходной день");

else
System.Console.WriteLine("Рабочий день");


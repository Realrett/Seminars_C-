// Сравниваем 3 числа
Console.WriteLine("Сравним 3 числа и найдем большее. Введите первое число");
string numberA = Console.ReadLine();
int number1 = int.Parse(numberA);

Console.WriteLine("Введите второе число");
string numberB = Console.ReadLine();
int number2 = int.Parse(numberB);

Console.WriteLine("Введите третье число");
string numberС = Console.ReadLine();
int number3 = int.Parse(numberС);

int max = number1;

if (max >= number2)
{
if (max >= number3)
{
 Console.WriteLine($"Наибольшее число {max}");
}
else
{
    int max3 = number3;
    Console.WriteLine($"Наибольшее число {max3}");
}
}
else
{
    int max2 = number2;
    if (max2 >= number3)
{
 Console.WriteLine($"Наибольшее число {max2}");
}
else
{
int max4 = number3;
 Console.WriteLine($"Наибольшее число {max4}");
}
}
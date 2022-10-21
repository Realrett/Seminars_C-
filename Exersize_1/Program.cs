// Сравниваем 2 числа
Console.WriteLine("Введите первое число");
string numberA = Console.ReadLine();
int number1 = int.Parse(numberA);

Console.WriteLine("Введите второе число");
string numberB = Console.ReadLine();
int number2 = int.Parse(numberB);

if (number1 > number2)
{
    Console.WriteLine("Первое число большее из двух");
}
else
{
    Console.WriteLine("Второе число большее из двух");
}
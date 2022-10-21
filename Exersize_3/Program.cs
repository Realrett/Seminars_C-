// Проверить делится ли число без остатка на 2
Console.WriteLine("Проверим является ли число чётным? Введите число:");
string numberA = Console.ReadLine();
int number1 = int.Parse(numberA);
if (number1 % 2 ==0)
{
    Console.WriteLine("Число чётное");
}
else
{
  Console.WriteLine("Число нечётное");  
}
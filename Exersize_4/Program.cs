// вводим число N и показываем все четные значения от 1 до N
Console.WriteLine("Введите число N:");
string numberA = Console.ReadLine();
int number1 = int.Parse(numberA);
int number2 = 1;
if(number1 > 0)
{
for(int i = number1-1; i > number2; i--)
{
    if(i % 2 ==0)
    {
    Console.WriteLine($"Чётные числа, находящиеся в промежутке {i}");
    }
}
}
else
{
  for(int i = number1+1; i < number2; i++)
{
    if(i % 2 ==0)
    {
    Console.WriteLine($"Чётные числа, находящиеся в промежутке {i}");
    }
}  
}  




Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());


if (numberA * numberA == numberB)
{
    Console.WriteLine("Да!");
}
else 
{
    Console.WriteLine("Нет!");
}
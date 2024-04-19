//на вход принимает два числа и выводит, какое число большее, а какое меньшее.
Console.WriteLine("Введите Первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine("первое число больше");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine("второе число больше");
}
else
{
    Console.WriteLine("числа равны");
}

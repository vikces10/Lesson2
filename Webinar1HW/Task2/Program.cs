// Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите Первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Третье число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine(max);

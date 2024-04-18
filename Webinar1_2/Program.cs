﻿// Напишите  программу,  которая  принимает  на  вход трёхзначное целое число и на выходе показывает 
// сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

using Internal;

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;

    int result = firstDigit + lastDigit;

    Console.WriteLine($"Сумма первой и последней цифры =  {result}");
}
else
{
    Console.WriteLine("Ошибка! Число не трехзначное.");
}

// 
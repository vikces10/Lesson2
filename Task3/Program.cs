int a1 = 100;
int b1 = 30;

if (a1 > b1)
{
    Console.WriteLine(a1);
}
else
{
    Console.WriteLine(b1);
}


// Задача, найти самую тяжелую гирю из 5
int a = 6;
int b = 7;
int c = 9;
int d = 10;
int e = 4;

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}
Console.WriteLine(max);

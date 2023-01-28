
Console.WriteLine("Введите положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 0)
{
    Console.WriteLine("Внимание, вы ввели НОЛЬ!!!");
}

if (2 > a)
{
    Console.WriteLine("Внимание, четных чисел нет!!!");
}

for (int i = 2; i <= a; i += 2)
{
    Console.Write($"{i} ");
}

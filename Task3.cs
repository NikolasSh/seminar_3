
Console.WriteLine("Введите число: ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (a % 2 == 1)
{
    Console.WriteLine("Введенное число является нечетным!");
}
else if (a == 0)
{
    Console.WriteLine("Внимание, вы ввели НОЛЬ!!!");
}
else 
{
    Console.WriteLine("Введенное число является четным!");
}

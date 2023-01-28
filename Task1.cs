Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В:");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max > b)
{
    Console.WriteLine("Число А больше числа Б и равно:");
    Console.WriteLine(max);
}
else 
{
    Console.WriteLine("Число Б больше числа А и равно:");
    Console.WriteLine(b);
}
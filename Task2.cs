Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C:");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max >= b && max >= c)
{    
    Console.Write("Число А больше числа Б и больше числа С и равно:");
    Console.WriteLine(max);       
}
else if (c > max && c > b )
{    
    max = c;
    Console.Write("Число C больше числа A и больше числа B и равно: ");
    Console.WriteLine(max);     
}
else
{
    max = b;
    Console.Write("Число B больше числа А и больше числа С и равно: ");
    Console.WriteLine(b);
}

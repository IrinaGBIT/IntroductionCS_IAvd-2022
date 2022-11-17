// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a;
Console.WriteLine("Введите 1-ое число: ");
a=Convert.ToInt32(Console.ReadLine());
int b;
Console.WriteLine("Введите 2-ое число: ");
b=Convert.ToInt32(Console.ReadLine());
int c;
Console.WriteLine("Введите 3-е число: ");
c=Convert.ToInt32(Console.ReadLine());
int max=a;
if (b>max) max=b;
if (c>max) max=c;
{
    Console.WriteLine("Max is "+max);
}

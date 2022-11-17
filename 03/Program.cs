// 03. С клавиатуры вводятся два числа a и b. Найти максимальное из них

int a;
Console.WriteLine("Введите 1-ое число: ");
a=Convert.ToInt32(Console.ReadLine());
int b;
Console.WriteLine("Введите 2-ое число: ");
b=Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("Max is "+a);
}
else
{
    Console.WriteLine("Max is "+b);
}
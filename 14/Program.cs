// See https://aka.ms/new-console-template for more information

int a;
Console.WriteLine("Введите 1-ое число: ");
a=Convert.ToInt32(Console.ReadLine());
int b;
Console.WriteLine("Введите 2-ое число: ");
b=Convert.ToInt32(Console.ReadLine());
int max=a;
if (a%b==0) 
{
    Console.WriteLine($"{a} кратно {b}");
}
else
{
    Console.WriteLine($"остаток от деления = {a%b}");
}
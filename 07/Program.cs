// 7. Выяснить является ли число чётным.

int a;
System.Console.WriteLine("Введите число: ");
a=Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("НеЧетное число");
}

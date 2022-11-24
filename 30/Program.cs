// 30. Написать программу вычисления произведения чисел от 1 до N

int A=Convert.ToInt32(Console.ReadLine());
int multi=1;

for (int i=1; i<=A; i++)
{
    multi=multi*i;
}
Console.WriteLine($"Произведение чисел = {multi}");

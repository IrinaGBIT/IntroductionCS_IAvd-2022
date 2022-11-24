/// 26. Найти сумму чисел от 1 до A

int A=Convert.ToInt32(Console.ReadLine());
int sum=0;

for (int i=0; i<=A; i++)
{
    sum=sum+i;
}
Console.WriteLine($"Сумма чисел = {sum}");

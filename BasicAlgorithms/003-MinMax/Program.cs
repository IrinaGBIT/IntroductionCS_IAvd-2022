// Найти минимальное (Min) число в последовательности натуральных чисел, оканчивающееся на 4
// (сначала вводится количество чисел в последовательности, потом сами числа)

int n=Convert.ToInt32(Console.ReadLine());
int min=30000;
for(int i=0;i<n;i++)
{
    int a=Convert.ToInt32(Console.ReadLine());
    if (a<min && a%10==4) min=a;
}
System.Console.WriteLine(min);

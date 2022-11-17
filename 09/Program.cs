// 9. Вывести на экран четные числа от 1 до N

int N=Convert.ToInt32(Console.ReadLine());
int i=2;
while (i<=N)
{
   System.Console.Write($"{i} "); 
   i=i+2;
}
System.Console.WriteLine();
for(int j=2;j<=N; j=j+2)
{
    System.Console.Write($"{j} "); 
}
System.Console.WriteLine();
for(int k=1;k<=N; k=k+1)
{
    if (k%2==0)
   {
        System.Console.Write($"{k} "); 
    }   
}
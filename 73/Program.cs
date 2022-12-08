// 73.	Найти сумму элементов от M до N, N и M заданы.

// See https://aka.ms/new-console-template for more information - Materials should be reviewed!

int Sum(int m,int n)
{
    if (m==n) return m;
    else
     return Sum(m+1,n)+m;
}

System.Console.WriteLine(Sum(2,4));
System.Console.WriteLine((2+4)*3/2);
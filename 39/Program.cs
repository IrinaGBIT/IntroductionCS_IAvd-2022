// 39. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1); // max+1 - т.е. число в массиве не превышает 101, может быть 100
    return a;
}

int SumOddPositions(int[] a) // поиск числа на нечетной позиции и их сумма:
{
    int s=0;
    // поиск чисел на нечетной позиции в массиве:
    for(int i=1;i<a.Length;i=i+2) // или так можно написать последний параметр: ;i+=2)
    // сумма чисел на нечетной позиции массива:
         s=s+a[i];
    return s;
}

void Print(int[] a) // для вывода массива
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray(5,0,10);// заданы параметры массива для вывода на печать
Print(a); // печать массива
System.Console.WriteLine();
System.Console.WriteLine(SumOddPositions(a)); // печать суммы чисел на нечетной позиции


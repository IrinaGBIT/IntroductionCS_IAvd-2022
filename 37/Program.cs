// 37.	Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

int[] RandomIntArray(int size=10,int min=100,int max=999)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}
int EvenNumbers(int[] a)
{
    int count=0;
    foreach(int el in a)
        if (el%2==0) count=count+1;
    return count;
}
int OddNumbers(int[] a)
{
    int countNeg=0;
    foreach(int el in a)
        if (el%2!=0) countNeg++;
    return countNeg;
}
void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray(10,100,999);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных {EvenNumbers(a)}");
System.Console.WriteLine($"Количество нечетных {OddNumbers(a)}");


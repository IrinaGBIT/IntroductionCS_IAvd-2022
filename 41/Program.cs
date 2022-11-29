// 41. В Указанном массиве вещественных чисел найдите разницу 
// между максимальным и минимальным элементом

int[] RandomIntArray(int size=10,int min=0,int max=100) // задаем массив случайных чисел
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1); // здесь max+1 - число в массиве не может быть больше max+1
        // т.е. в данном случае максимальное случайное число в массиве может быть равно 100
    return a;
}

int Max(int[] a) // поиск max числа в массиве
{
    int m=a[0];
    for(int i=1;i<a.Length;i++)
         if (a[i]>m) m=a[i];
    return m;
}

int Min(int[] a) // поиск min числа в массиве
{
    int m=a[0];
    for(int i=1;i<a.Length;i++)
         if (a[i]<m) m=a[i];
    return m;
}

void Print(int[] a) // для вывода массива на печать
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray(5,0,10); // задали параметры массива для вывода на печать
Print(a); // вывод массива на печать
System.Console.WriteLine(); // следующий результат программы с новой строки
System.Console.WriteLine(Max(a)-Min(a)); // вывод разницы между max and min на печать 

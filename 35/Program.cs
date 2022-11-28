// 35. Написать программу замены элементов массива на противоположные

int[] RandomIntArray(int size=8,int min=0,int max=100) // задаем массив случайных чисел (оригинальный)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1); // здесь max+1 - число в массиве не может быть больше 101,
        // т.е. в данном случае максимальное случайное число в массиве может быть равно 100.
    return a;
}

void Print(int[] a) // для вывода оригинального массива на печать
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

void PrintRev(int[] a) // для вывода противоположного массива на печать
{
    for(int i = a.Length - 1; i >= 0; i--)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray(9,0,10); // задали параметры оригинального массива для вывода на печать
Print(a); // вывод оригинального массива на печать
System.Console.WriteLine(); // с новой строки следующий результат
PrintRev(a); // вывод противоположного массива на печать






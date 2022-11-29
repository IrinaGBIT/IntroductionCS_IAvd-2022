// 32.	Задать массив из 8 целых элементов и вывести их на экран

int[] RandomIntArray(int size=8,int min=0,int max=100) // задаем массив из 8 случайных чисел
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1); // здесь max+1 - число в массиве не может быть больше max+1
        // т.е. в данном случае максимальное случайное число в массиве может быть равно 100
    return a;
}
void Print(int[] a) // для вывода массива на печать
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}"); // 5 - "знакоместо"
}

int[] a=RandomIntArray(8,0,10); // задали параметры массива для вывода на печать
Print(a); // вывод массива на печать

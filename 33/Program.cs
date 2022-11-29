// 33. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] RandomIntArray(int size=8,int min=0,int max=1) // задаем массив из 8 случайных чисел из 0 и 1.
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1); // здесь max+1 - число в массиве не может быть больше 2,
        // т.е. в данном случае максимальное случайное число в массиве - это 1 (единица)
    return a;
}
void Print(int[] a) // для вывода массива на печать
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}"); // знак 5 - "знакоместо"
}

int[] a=RandomIntArray(8,0,1); // задали параметры массива для вывода на печать
Print(a); // вывод массива на печать



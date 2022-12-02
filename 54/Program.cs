// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
//Принять первые числа равными 0 и 1

int[] Fibonacci(int n)
{
    int[] result = new int[n];
    for (int i = 0; i < n; i++)
        if (i < 2) result[i] = i;
        else result[i] = result[i - 1] + result[i - 2];
    return result;
}

{
    Console.WriteLine("Ввести число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] numbers = Fibonacci(n);
    for (int i = 0; i < numbers.Length; i++)
        Console.Write($"{numbers[i]} ");
}

// Вариант преподавателя
/*
int n=10;
int[] a=new int[n];
a[0]=0;
a[1]=1;
for(int i=2;i<n;i++)
  a[i]=a[i-1]+a[i-2];//рекурентная формула (следующее значение за счет использования предыдущих)
for(int i=0;i<n;i++)
    System.Console.Write($"{a[i]} ");
*/
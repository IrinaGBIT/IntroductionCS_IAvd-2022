// 56.	Написать программу копирования массива

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

int[] Copy(int[] arr)
{
    int length = arr.Length;
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
        result[i] = arr[i];
    return result;
}

{
    Random random = new Random();
    Console.WriteLine("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] array1 = new int[n];
    for (int i = 0; i < n; i++)
        array1[i] = random.Next(0, 100);
    Console.Write("Массив случайных чисел: ");
    Print(array1);

    int[] array2 = Copy(array1);
    Console.Write("Копия массива: ");
    Print(array2);
}

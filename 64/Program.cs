// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

// 64 vers 1 - with given variable values

void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],8}");
        System.Console.WriteLine();
    }
}
void Modified2DArr(int[,] a, int[,] b)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0) {b[i, j] = a[i, j]*a[i, j];} else b[i, j] = a[i, j]; 
        }
    }
}
    int n = 5;
    int k = 5;
    int min = -5;
    int max = 10;

    int[,] Random2DArray = new int[n, k];
    int[,] New2DArray = new int[n, k];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            Random2DArray[i, j] = random.Next(min, max);
        }
    }
    Console.WriteLine("Исходный массив");
    Print2DArray(Random2DArray);
    Modified2DArr(Random2DArray, New2DArray);
    Console.WriteLine("Изменённый массив");
    Print2DArray(New2DArray);

/*
// 64 vers 2 - manual input value
void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],8}");
        System.Console.WriteLine();
    }
}
void Modified2DArr(int[,] a, int[,] b)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
             if (i%2==0 && j%2==0) {b[i, j] = a[i, j]*a[i, j];} else b[i, j] = a[i, j]; 
        }
    }
}
Console.WriteLine("Введите количество строк массива, n=");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива, k=");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число начала диапазона случайных чисел, min =");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число окончания диапазона случайных чисел, max =");
int max = int.Parse(Console.ReadLine());

int[,] Random2DArray = new int[n, k];
int[,] New2DArray = new int[n, k];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < k; j++)
    {
        Random2DArray[i, j] = random.Next(min, max);
    }
}
Console.WriteLine("Исходный массив");
Print2DArray(Random2DArray);
Modified2DArr(Random2DArray, New2DArray);
Console.WriteLine("Изменённый массив");
Print2DArray(New2DArray);
*/

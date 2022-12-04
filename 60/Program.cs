// 60.	Показать двумерный массив размером m×n заполненный целыми случайными числами.
/*
// 60 vers 0 - с предварительно заданными параметрами 
int[,] Random2DArray = new int [5, 8];
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 8; j++)
    {
        Random2DArray[i, j] = random.Next(10);
        Console.Write($"{Random2DArray[i, j],4}");
    }
    Console.WriteLine();
}
*/

/*
// 60 vers 1 - мое ДЗ, для одной переменной 2 строки кода 
// почему использование (int.Parse) привело к предупреждению?
// лучше использовать vers 2 (ниже)?

Console.WriteLine("Введите количество строк массива, n=");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива, m=");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число начала диапазона случайных чисел, min =");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число окончания диапазона случайных чисел, max =");
int max = int.Parse(Console.ReadLine());

int[,] Random2DArray = new int [n, m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Random2DArray[i, j] = random.Next(min,max+1);
        Console.Write($"{Random2DArray[i, j],4}");
    }
    Console.WriteLine();
}
*/

// 60 vers 2 - мое ДЗ, with Convert - для одной переменной 3 строки 
int n;
Console.WriteLine("Введите количество строк массива, n=");
n=Convert.ToInt32(Console.ReadLine());
int m;
Console.WriteLine("Введите количество столбцов массива, m=");
m=Convert.ToInt32(Console.ReadLine());
int min;
Console.WriteLine("Введите число начала диапазона случайных чисел, min =");
min=Convert.ToInt32(Console.ReadLine());
int max;
Console.WriteLine("Введите число окончания диапазона случайных чисел, max =");
max=Convert.ToInt32(Console.ReadLine());

int[,] Random2DArray = new int [n, m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Random2DArray[i, j] = random.Next(min,max+1);
        Console.Write($"{Random2DArray[i, j],4}");
    }
    Console.WriteLine();
}


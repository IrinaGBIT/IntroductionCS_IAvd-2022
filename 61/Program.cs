// 61.	Показать двумерный массив размером m×n заполненный вещественными случайными числами
/*
// 61 vers 1 (with Parse) 
//- работает, но появилось предупреждение, лучше использовать vers 2 ниже?

Console.WriteLine("Введите количество строк массива, n=");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива, m=");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число начала диапазона случайных чисел, min =");
double min = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число окончания диапазона случайных чисел, max =");
double max = double.Parse(Console.ReadLine());
double range = max-min;

double[,] Random2DArray = new double [n, m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Random2DArray[i, j] = Math.Round(min+range*random.NextDouble(), 2);
        Console.Write($"{Random2DArray[i, j],8}  ");
    }
    Console.WriteLine();
}
*/


// 61 vers 2  (with Convert)

int n;
Console.WriteLine("Введите количество строк массива, n=");
n=Convert.ToInt32(Console.ReadLine());
int m;
Console.WriteLine("Введите количество столбцов массива, m=");
m=Convert.ToInt32(Console.ReadLine());
double min;
Console.WriteLine("Введите число начала диапазона случайных чисел, min =");
min=Convert.ToDouble(Console.ReadLine());
double max;
Console.WriteLine("Введите число окончания диапазона случайных чисел, max =");
max=Convert.ToDouble(Console.ReadLine());
double range = max-min;

double[,] Random2DArray = new double [n, m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Random2DArray[i, j] = Math.Round(min+range*random.NextDouble(), 2);
        Console.Write($"{Random2DArray[i, j],8}");
    }
    Console.WriteLine();
}


/*
// 61 vers 3 - (with given variable values)
int n = 5;
int m = 6;
double min = -3.33;
double max = 5.6;
double range = max - min;

double[,] Random2DArray = new double[n, m];
Random random = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Random2DArray[i, j] = Math.Round(min + range * random.NextDouble(), 2);
        Console.Write($"{Random2DArray[i, j],8}  ");
    }
    Console.WriteLine();
}
*/
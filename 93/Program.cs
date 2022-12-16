// 93.	Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
int[,] Arr1 = new int [4, 5];
Random random1 = new Random();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Arr1[i, j] = random1.Next(10);
        Console.Write($"{Arr1[i, j],4}");
    }
    Console.WriteLine();
}
System.Console.WriteLine();

int[,] Arr2 = new int [4, 5];
Random random2 = new Random();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Arr2[i, j] = random2.Next(10);
        Console.Write($"{Arr2[i, j],4}");
    }
    Console.WriteLine();
}
System.Console.WriteLine();

int[,] CreatedArr = new int [4, 5];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        CreatedArr[i, j] = Arr1[i, j]*Arr2[i, j];
        Console.Write($"{CreatedArr[i, j],4}");
    }
    Console.WriteLine();
}
System.Console.WriteLine();

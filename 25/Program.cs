// 25. Вывести на экран кубы чисел от 1 до N

/*
// Case 1
for (int i=0; i<=N; i++)
{
    Console.WriteLine($"куб числа {i} = {i*i*i}");
}
*/

/*
// Case 2
for (int i=0; i<=N; i++)
{
    Console.WriteLine($"{i}^3 = " + Math.Pow(i, 3));
}
*/

for (int i=1; i<=5; i++)
{
    Console.WriteLine($"{i}^3 = " + Math.Pow(i, 3));
}

// 70.	Показать натуральные числа от 1 до N, N задано.
// Этот случай описан в BasicAlgorithms

void Loop(int N, int i)
{
    if (i<=N)
    {
        System.Console.Write($"{i} ");
        Loop(N,i+1);
    }
}
Loop(10,1);

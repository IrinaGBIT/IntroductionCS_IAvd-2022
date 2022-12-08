// 71.	Показать натуральные числа от N до 1, N задано.
/*
void Loop(int N, int i)
{
    if (i<=N)
    {
        System.Console.Write($"{N} ");
        Loop(N-1,i++);
    }
}
Loop(15,1);
*/


void Task71(int N, int i)
{
    if (i<=N)
    {
        System.Console.Write($"{N} ");
        Task71(N-1,i++);
    }
}
Task71(15,1);


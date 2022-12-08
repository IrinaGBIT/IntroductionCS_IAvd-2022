// 030-Loop with recursion (Цикл с помощью рекурсии)

// Вывести числа от 1 до N без использования цикла.
/*
int i=1;
int N=10;
metka:
    System.Console.WriteLine(i);
    i++;
if (i<=N) goto metka;
*/

// Вывести числа от 1 до N через РЕКУРСИЮ..
void Loop(int N,int i)
{
    if (i<=N)
    {
        System.Console.Write($"{i} ");
        Loop(N,i+1);
    }    
}
//int i=1;
//int N=10;
//Loop(N,i);
Loop(8,1);

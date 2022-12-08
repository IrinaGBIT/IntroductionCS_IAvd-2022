// 75.	Написать программу вычисления функции Аккермана.
// Для решение использовала Реализацию в псевдокоде из ресурса Википедия. Функция Аккермана:
///https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0
//В псевдокоде функция Аккермана реализуется по определению:
//функция ack(n, m)
//если n = 0
//вернуть m + 1
//иначе, если m = 0
//вернуть ack (n - 1, 1)
//еще
//вернуть ack(n - 1, ack (n, m - 1))

int Ack(int n, int m)
{
    if (n == 0)
    {
        return (m + 1);
    }
    else if (m == 0)
    {
        return Ack(n - 1, 1);
    }
    else
    {
        return Ack(n - 1, Ack(n, m - 1));
    }
}

{
    Console.WriteLine("Enter n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int a = Ack(n, m);
    Console.WriteLine($"Ack(n,m) = {a}");
}

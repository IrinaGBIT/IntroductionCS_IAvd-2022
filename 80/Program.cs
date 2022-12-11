// 80. Вывести на экран кодировку символов по ASCII(с 32 до 122).

// 80 vers1
//using System.Linq;
int b;
for (b = 32; b <= 122;)
{
    System.Console.WriteLine($"Dec {b}: {(char)b} ");
    b++;
}

/*
// 80 vers2 - in table ASCII : Dec 32 = Hex 20; Dec 122 = Hex 7A.

char c;
for (c ='\x20'; c <= '\x7A';) // or for (c ='\u0020'; c <= '\u007A';) 
{
    System.Console.Write($"{c} ");
    c++;
} 
*/

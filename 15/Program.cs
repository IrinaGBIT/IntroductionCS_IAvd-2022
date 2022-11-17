// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет 
// (Вывести: NO)

int n=Convert.ToInt32(Console.ReadLine());
n=System.Math.Abs(n);

// Case 1 (simple- third from the end)
if (n<100) System.Console.WriteLine("NO");
else System.Console.WriteLine(n/100%10);

// Case 2 (third from the beginin)
if (n>99)
{
    while (n>1000)
    {
        n=n/10;
    }
    System.Console.WriteLine(n%10);
}
else
{
    System.Console.WriteLine("NO");
}

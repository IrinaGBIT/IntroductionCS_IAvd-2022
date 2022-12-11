//84. Определить являются ли введенные с клавиатуры символы правильной записью целого числа. 
// Вычислить сумму цифр введенного числа. 
// Задача РЕШЕНА ПРЕПОДАВАТЕЛЕМ на уроке 9 (09.12.2022).

int SumDigits(int n)
{
    int sum=0;
    n=Math.Abs(n);
    while(n!=0)
    {
        sum=sum+n%10;
        n=n/10;
    }
    return sum;
}

string s=Console.ReadLine();
int n;
bool flag=int.TryParse(s,out n);
if (flag)
{
    // foreach(char c in s)
    //   if (char.IsDigit(c))
    //   //sum=sum+(int)char.GetNumericValue(c);
    //   sum=sum+(c-'0');
    System.Console.WriteLine($"Сумма цифр числа {n} = {SumDigits(n)}");
} 
else System.Console.WriteLine("Wrong number");

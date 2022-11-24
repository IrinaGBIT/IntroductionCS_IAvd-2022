// 27. Возведите число А в натуральную степень B, используя цикл

double A=Convert.ToDouble(Console.ReadLine()); // основание степени может быть любым числом
int B=Convert.ToInt32(Console.ReadLine()); // натуральная степень
double powA=1;
int i=1;

//Вариант1 - с циклом
for(i=1; i<=B; i++ )
{
    powA=powA*A;
}
Console.WriteLine($"{A}^{B} = {powA}");

/* Вариант2 - простой
{
    Console.WriteLine($"{A}^{B} = " + Math.Pow(A,B));
}
*/




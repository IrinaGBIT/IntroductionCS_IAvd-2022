// 27. Возведите число А в натуральную степень B используя цикл

double A=Convert.ToDouble(Console.ReadLine()); // основание степени может быть любым числом
int B=Convert.ToInt32(Console.ReadLine()); // натуральная степень
{
    Console.WriteLine($"{A}^{B} = " + Math.Pow(A,B));
}





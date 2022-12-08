// 76.	Написать программу возведения числа А в целую положительную степень B.
// С помощью РЕКУРСИИ !

double Power(int a,int b)
{
    if (b>0) return Power(a,b-1)*a;
        else
            if (b<0) return Power(a,b+1)*1/a;
                else return 1;
}

System.Console.WriteLine(Power(2,-3)); // negative power of a number (Отрицательная степеь числа).
/*
System.Console.WriteLine(Power(2,3)); // positive power of a number (Положительная степень числа).
*/

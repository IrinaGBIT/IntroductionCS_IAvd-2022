// 29. Подсчитать сумму цифр в числе. Сделать подпрограмму.

//Основная программа

int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumDigits(N));

//Подпрограмма

int SumDigits(int Number)
{
Number=Math.Abs(Number);
int sumDig=0;
if (Number==0) sumDig=0;
while (Number>0)
{
sumDig=sumDig+Number%10;
Number=Number/10;
}
return sumDig;
}


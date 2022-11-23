// 22. Программа проверяет пятизначное число на палиндромом.

System.Console.WriteLine("Введите пятизначное число: ");

int originNumb=Convert.ToInt32(Console.ReadLine());
int temp=Convert.ToInt32(Console.ReadLine());
double newNumb=Convert.ToDouble(Console.ReadLine());
int i=0;
temp=originNumb;
newNumb=0;
i=0;
while(i<=5)
{
    newNumb[i]=temp%10*10000+temp/10;
    i=i+1;
}
System.Console.WriteLine($"{newNumb}");
{
if(newNumb==originNumb) System.Console.WriteLine($"{originNumb} является палидромом");
else System.Console.WriteLine($"{originNumb} НЕ является палидромом");
}


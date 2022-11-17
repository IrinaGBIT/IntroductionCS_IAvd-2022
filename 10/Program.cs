// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры.

int a;
System.Console.WriteLine("Введите число");
a=Convert.ToInt32(Console.ReadLine());
int d=a%10;
System.Console.WriteLine(d);

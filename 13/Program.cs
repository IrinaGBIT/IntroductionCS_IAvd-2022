// 13. Удалить вторую цифру целого числа введенного с клавиатуры.

int a=Convert.ToInt32(Console.ReadLine());
//456
//98765
int b=a/100*10+a%10;
System.Console.WriteLine(b);
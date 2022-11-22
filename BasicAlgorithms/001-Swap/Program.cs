// Обмен значениями двух переменных

// Классический способ
/* int a=5;
int b=7;
int temp;
temp=a;
a=b;
b=temp;
*/

// Без использования 3-ей переменной
/* int a=5;
int b=7;
a=a+b;
b=a-b;
a=a-b;
*/
// 3-ий способ
int a=5;
int b=7;
a=a^b;
b=a^b;
a=a^b;
System.Console.WriteLine($"a={a} b={b}");


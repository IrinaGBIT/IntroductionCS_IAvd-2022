// Задача 20.2 ГИА
/*

*/

/* // Вариан 1 with Parse: почему-то выдает ПРЕДУПРЕЖДЕНИЕ
int n=int.Parse(Console.ReadLine()); // количество учеников
int k=0; // Счетчик (количество двоечников)
bool flag=false; // Флаг
for(int i=0; i<n; i++)
{
    int a=int.Parse(Console.ReadLine()); // Количество решенных задач
    if (a<5) k++;
    if (a==10) flag=true;
}
System.Console.WriteLine(k); // Количество двоечников
if (flag==true)
System.Console.WriteLine("YES"); // Кол-во учеников, решивших все 10 задач
else
System.Console.WriteLine("NO"); // Нет учеников, решивших все 10 задач
*/

// Вариант 2
int n=Convert.ToInt32(Console.ReadLine()); // количество учеников
int k=0; // Счетчик (количество двоечников)
bool flag=false; // Флаг
for(int i=0; i<n; i++)
{
    int a=Convert.ToInt32(Console.ReadLine()); // Количество решенных задач
    if (a<5) k++;
    if (a==10) flag=true;
}
System.Console.WriteLine(k); // Количество двоечников
if (flag==true)
System.Console.WriteLine("YES"); // Кол-во учеников, решивших все 10 задач
else
System.Console.WriteLine("NO"); // Нет учеников, решивших все 10 задач

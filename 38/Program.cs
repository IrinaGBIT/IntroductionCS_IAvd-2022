// 38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

/*
// Вариат 1
// Создание массива
int N=8; // можно ввести размер массива с клавиатуры int N = Console.Readline();
int[]a = new int [N];
// Заполнение массива
Random random = new Random();
for(int i=0; i<a.Length; i++)
    a[i]=random.Next(0,200);

// Вывод массива на печать
for(int i=0; i<a.Length; i++)
System.Console.Write($"{a[i],5}");

// Обработка массива
// case 1

int count =0;
for(int i=0; i<a.Length; i++)
    if(a[i]>10 && a[i]<=99)
        count++;

// case 1.1 - внутри for можем менять массив / коллекцию
/*
int count =0;
for(int i=0; i<a.Length; i++)
{
    if(a[i]>10 && a[i]<=99)
        count++;
    a[i]=4;
}
 */  
 /* 
// case 2 с оператором foreach - есть ограничение, не можем менять элемент el:
count =0;
foreach(int el in a)
    if(el>10 && el<=99)
        count++;

// первый способ вывода на печать через строчку:
System.Console.WriteLine();
System.Console.WriteLine(count);

// второй способ вывода на печать через строчку:
System.Console.Write("\n");
System.Console.WriteLine(count);

// третий способ вывода на печать через строчку:
System.Console.WriteLine($"\n{count}");
*/

// case 3 с подпрограммой:

int[] RandomIntArray(int N, int min, int max)
{
    int[] a = new int [N];
// Заполнение массива
    Random random = new Random();
    for(int i=0; i<a.Length; i++)
    a[i]=random.Next(0,200);
    return a;
}
void PrintArray(int[] a)
{
  for(int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i],5}"); 
}

int Solve(int[] a)
{
//foreach способ:
    int count=0;
    foreach(int el in a)
    {
        if (el>=10 && el<=99)
            count++;       
    }
    return count;
}

// Создание массива

int M=12;
int[] a=RandomIntArray(M,0,200);
PrintArray(a);
//Обработка массива
System.Console.WriteLine($"\n{Solve(a)}");



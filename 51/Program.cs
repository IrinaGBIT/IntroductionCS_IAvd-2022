// 51.	С клавиатуры вводится число N. Затем вводятся N чисел. 
// Определить сколько чисел больше 0 введено с клавиатуры

int result = 0;
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
    Console.WriteLine($"Введите число {i} из {n}: ");
    int input = Convert.ToInt32(Console.ReadLine());
    
        if (input > 0)
        result++;
    }
Console.WriteLine($"{result} чисел из {n} больше нуля");

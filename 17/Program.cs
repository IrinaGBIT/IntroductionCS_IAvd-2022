// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.Write("Введите число, соответствующее номеру дня недели (от 1 до 7): ");
int n=Convert.ToInt32(Console.ReadLine());
if(n>=6)
{
    System.Console.WriteLine("Ура, Выходной!");
}
else
{
     System.Console.WriteLine("Пилите, Шура, пилите… (Золотой теленок. Ильф и Петров)");
}

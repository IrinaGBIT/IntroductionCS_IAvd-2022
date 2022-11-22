// 20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, 
// причем X ≠ 0 и Y ≠ 0

/*
// Case1
double x=Convert.ToDouble(Console.ReadLine());
double y=Convert.ToDouble(Console.ReadLine());
int part=0;
if (x>0 && y>0) part=1;
if (x<0 && y>0) part=2;
if (x<0 && y<0) part=3;
if (x>0 && y<0) part=4;
System.Console.WriteLine("PART: "+ part);
*/

//Case2
double x=Convert.ToDouble(Console.ReadLine());
double y=Convert.ToDouble(Console.ReadLine());
Part(x,y);
System.Console.WriteLine("PART: "+ Part(x,y));
/*
Pause();
*/
// подпрограмма
int Part(double x, double y)
{
   // тело подпрограммы
    int part=0;
    if (x>0 && y>0) part=1; // or: return 1;
    if (x<0 && y>0) part=2; // or: return 2;
    if (x<0 && y<0) part=3; // or: return 3;
    if (x>0 && y<0) part=4; // or: return 4;
    return part; // or: return=0;
}
/*
void Pause();
{
    System.Console.WriteLine("press any key");
    Console.ReadKey();
}
*/
// 23. Найти расстояние между точками в пространстве 2D
double x1,x2,y1,y2,distance;
x1=Convert.ToUInt32(Console.ReadLine());
y1=Convert.ToUInt32(Console.ReadLine());
x2=Convert.ToUInt32(Console.ReadLine());
y2=Convert.ToUInt32(Console.ReadLine());

distance=Math.Sqrt((x2-x1)*(x2-x1)+Math.Pow(y2-y1,2));
System.Console.WriteLine(distance);

//23. Найти расстояние между точками в пространстве 2D

double x1,y1,x2,y2,distance;
x1=Convert.ToDouble(Console.ReadLine());
y1=Convert.ToDouble(Console.ReadLine());
x2=Convert.ToDouble(Console.ReadLine());
y2=Convert.ToDouble(Console.ReadLine());

distance=Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2));
System.Console.WriteLine(distance);

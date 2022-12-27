Console.Clear();

Console.WriteLine("Введите координату Х1: ");
double x1 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите координату Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());  
double X = (x2-x1)*(x2-x1);
double Y = (y2-y1)*(y2-y1);
double Z = (z2-y1)*(z2-y1);
double S = Math.Sqrt(X + Y + Z);
Console.WriteLine(S);


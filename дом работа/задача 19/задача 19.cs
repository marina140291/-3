Console.Clear();

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x < 10000 || x > 99999)
{
 Console.WriteLine("вы ошиблись, введите число");
 x = Convert.ToInt32(Console.ReadLine());
 } 
int a = x / 10000;
int b = (x / 1000) % 10;
int c = (x / 10) % 10;
int d = x % 10;

if (a == d && b == c)
Console.WriteLine("да");
else 
Console.WriteLine("нет");


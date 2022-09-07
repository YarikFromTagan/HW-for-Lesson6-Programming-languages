/*
Задача 43: Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями
y = k1 * x + b1,
y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
Example:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
Console.WriteLine("Для прямой, заданной уравнением y = k1 * x + b1");
Console.Write("введите b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Для прямой, заданной уравнением y = k2 * x + b2");
Console.Write("введите b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(b1 == b2 && k1 == k2)
{
    Console.WriteLine("Заданные Вами прямые совпадают");
    Console.WriteLine();
    System.Environment.Exit(0);
}
if(k1 == k2)
{
    Console.WriteLine("Заданные Вами прямые не имеют точки пересечения, т.е. они параллельны!!!");
    Console.WriteLine();
}
else
{
double Xresult = (b2 - b1) / (k1 - k2);
double Yresult = k1 * Xresult + b1;

Console.WriteLine($"Координаты точки пересечения заданных Вами прямых A({Xresult}; {Yresult})");
Console.WriteLine();
}
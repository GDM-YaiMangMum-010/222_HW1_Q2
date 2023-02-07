using System;
class Program
{
    static void Main (string[] args)
    {
        double C0X = 0, C0Y = 0, C0P0X = 0, C0P0Y = 0, n = 0;
        C0X = double.Parse(Console.ReadLine());
        C0Y = double.Parse(Console.ReadLine());
        C0P0X = double.Parse(Console.ReadLine());
        C0P0Y = double.Parse(Console.ReadLine());
        n = double.Parse(Console.ReadLine());
    }
    static double Diameter (double cx, double cy, double px, double py)
    {
        return Math.Sqrt(Math.Pow((cx-px),2)+Math.Pow((cy-py),2));
    }
}
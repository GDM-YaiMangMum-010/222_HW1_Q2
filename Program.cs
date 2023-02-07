using System;
class Program
{
    static void Main (string[] args)
    {
        double C0X = 0, C0Y = 0, C0P0X = 0, C0P0Y = 0, endcx = 0, endcy = 0, endpx = 0 ,endpy = 0;
        int n = 0;
        C0X = double.Parse(Console.ReadLine());
        C0Y = double.Parse(Console.ReadLine());
        C0P0X = double.Parse(Console.ReadLine());
        C0P0Y = double.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        for(int i = n;i > n;i++)
        {
            
        }
        Console.WriteLine(endcx);
        Console.WriteLine(endcy);
        Console.WriteLine(endpx);
        Console.WriteLine(endpy);
    }
    static double Diameter (double cx, double cy, double px, double py)
    {
        return Math.Sqrt(Math.Pow((cx-px),2)+Math.Pow((cy-py),2));
    }
    static double Theta (double x,double y)
    {
        return Math.Pow(Math.Tan(y/x),-1);
    }
    static double NewX (double x, double y,double r,double t)
    {
        return r*Math.Cos(90+t);
    }
    static double NewY (double x, double y,double r,double t)
    {
        return r*Math.Sin(90+t);
    }
}
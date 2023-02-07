using System;
class Program
{
    static void Main (string[] args)
    {
        double C0X = 0, C0Y = 0, C0P0X = 0, C0P0Y = 0, endcx = 0, endcy = 0, endpx = 0 ,endpy = 0;
        int n = 0;
        double d,d2,thetap,newpx,newpy,newcx,newcy;
        C0X = double.Parse(Console.ReadLine());
        C0Y = double.Parse(Console.ReadLine());
        C0P0X = double.Parse(Console.ReadLine());
        C0P0Y = double.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        for(int i = n;i > n;i++)
        {
            d = Diameter(C0X,C0Y,C0P0X,C0P0Y);
            d2 = d/2;
            thetap = Theta(C0P0X,C0P0Y);
            newpx = NewX(d,thetap);
            newpy = NewY(d,thetap);
            C0P0X = newpx;
            C0P0Y = newpy;
            newcx = NewX(d2,thetap);
            newcy = NewY(d2,thetap);
            C0P0X = newcx;
            C0P0Y = newcy;
        }
        endcx = C0X; endcy = C0Y; endpx = C0P0X; endpy = C0P0Y;
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
    static double Midpoint (double x,double y)
    {
        return Math.Pow(Math.Tan(y/x),-1);
    }
    static double NewX (double r,double t)
    {
        return r*Math.Cos(90+t);
    }
    static double NewY (double r,double t)
    {
        return r*Math.Sin(90+t);
    }
}
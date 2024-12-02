using System;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        string fract1 = f1.GetFractionString();
        Console.WriteLine(fract1);
        double fract1d = f1.GetDecimalValue();
        Console.WriteLine(fract1d);
        Fraction f2 = new Fraction(5, 1);
        string fract2 = f2.GetFractionString();
        Console.WriteLine(fract2);
        double fract2d = f2.GetDecimalValue();
        Console.WriteLine(fract2d);
        Fraction f3 = new Fraction(3, 4);
        string fract3 = f3.GetFractionString();
        Console.WriteLine(fract3);
        double fract3d = f3.GetDecimalValue();
        Console.WriteLine(fract3d);
        Fraction f4 = new Fraction(1, 3);
        string fract4 = f4.GetFractionString();
        Console.WriteLine(fract4);
        double fract4d = f4.GetDecimalValue();
        Console.WriteLine(fract4d);
    }
}
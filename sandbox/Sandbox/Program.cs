using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Blind kitchen = new Blind(12, 18, "Black");
        double totalMaterialsNeededK = kitchen.GetArea();
        Console.WriteLine($"{totalMaterialsNeededK} materials");

        Blind livingRoom = new Blind(18, 36, "white");
        double totalMaterialsNeededL = livingRoom.GetArea();
        Console.WriteLine($"{totalMaterialsNeededL} materials");
    }

    
}
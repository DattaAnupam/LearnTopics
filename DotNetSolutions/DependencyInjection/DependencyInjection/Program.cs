using DependencyInjection;
using static DependencyInjection.ClassA;


internal class Program {
    public static void Main(string[] args)
    {
        var objA = new ClassA();
        var objB = new ClassB();

        objB.UsePrintDeligate(objA.PrintID);

        objB.UseGetIDDeligate(objA.GetID);

        Console.ReadKey();
    }
}
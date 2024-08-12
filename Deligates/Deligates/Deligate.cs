namespace Deligates
{
    public class ClassA
    {
        public static void MethodA(string message) => Console.WriteLine(message);
        public static void MethodB(MyDelegate del) => del("Delegate passed as parameter");

        public static int MethodC(int num1, int num2) => num1 + num2;
    }
}

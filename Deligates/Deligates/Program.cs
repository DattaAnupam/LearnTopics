namespace Deligates
{
    // Diclare delegate
    public delegate void MyDelegate(string msg);
    public class Program
    {
        public static void Main(string[] args)
        {
            MyDelegate delA = ClassA.MethodA;
            delA("Calling MethodA() using Deligate");
        }
    }
}
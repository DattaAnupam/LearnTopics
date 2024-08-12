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

            // Deligate with Lamda function
            // Assigning lamda function to the delegate
            delA = (string msg) => { Console.WriteLine(msg); };
            delA("This delegate holds reference to the lamda function");

            // Pass deligate as argument
            ClassA.MethodB(delA);
        }
    }
}
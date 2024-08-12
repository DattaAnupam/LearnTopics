namespace Deligates
{
    // Diclare delegate
    public delegate void MyDelegate(string msg);
    public delegate int MyDelegate2(int num1, int num2);
    public class Program
    {
        public static void Main(string[] args)
        {
            MyDelegate delA = ClassA.MethodA;
            delA("Calling MethodA() using Deligate");

            // Delegate with returning value
            MyDelegate2 delB = ClassA.MethodC;
            Console.WriteLine($"Sum of two number using delegate: {delB(3, 4)}");

            // Deligate with Lamda function
            // Assigning lamda function to the delegate
            delA = (string msg) => { Console.WriteLine(msg); };
            delA("This delegate holds reference to the lamda function");

            // Pass deligate as argument
            ClassA.MethodB(delA);

            #region Multi cast Delegate
            
            #endregion
        }
    }
}
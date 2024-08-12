namespace Deligates
{
    #region Declare delegates
    public delegate void MyDelegate(string msg);
    public delegate int MyDelegate2(int num1, int num2);
    public delegate void MyDelegate3<T>(T obj);
    #endregion

    public class Program
    {
        public static void Main(string[] args)
        {
            #region Simple delegate
            MyDelegate delA = ClassA.MethodA;
            delA("Calling MethodA() using Deligate");
            #endregion

            #region Delegate with returning value
            MyDelegate2 delB = ClassA.MethodC;
            Console.WriteLine($"Sum of two number using delegate: {delB(3, 4)}");
            #endregion

            #region Deligate with Lamda function
            // Assigning lamda function to the delegate
            delA = (string msg) => { Console.WriteLine(msg); };
            delA("This delegate holds reference to the lamda function");
            #endregion

            #region Pass deligate as argument
            ClassA.MethodB(delA);
            #endregion

            #region Multi cast Delegate
            MyDelegate delC = ClassA.MethodA;
            MyDelegate delD = delA + delC;
            delD("Multi cast delegate: Adding two delegate");
            delD -=delC;
            delD("Multi cast delegat: Substituting delegate");
            #endregion

            #region Generic Delegate
            MyDelegate3<int> delE = ClassA.MethodD;
            delE(5);
            MyDelegate3<string> delF = ClassA.MethodD;
            delF("test");
            #endregion
        }
    }
}

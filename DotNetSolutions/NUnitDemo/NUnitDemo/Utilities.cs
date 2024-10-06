using NUnitDemo.Interfaces;

namespace NUnitDemo
{
    public class Utilities : IUtilities
    {
        public Utilities()
        {
            
        }

        public int GetGreater(int num1, int num2) =>  num1 > num2? num1 : num2;
    }
}

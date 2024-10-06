using NUnitDemo.Interfaces;

namespace NUnitDemo
{
    public class Calculator : ICalculator
    {
        private readonly IUtilities _Utilities;
        public Calculator(IUtilities utilities)
        {
            _Utilities = utilities;
        }

        public int GetSum(int num1, int num2) 
        {
            int larger = _Utilities.GetGreater(num1, num2);
            Console.WriteLine("larger is : {0}", larger);
            return num1 + num2;
        }
    }
}

namespace NUnitDemo.Interfaces
{
    public interface ICalculator
    {
        /// <summary>
        /// Returns sum of two whole numbers.
        /// </summary>
        /// <param name="num1">First whole number</param>
        /// <param name="num2">Second whole number.</param>
        /// <returns>Sum of two whole numbers</returns>
        int GetSum(int num1, int num2);
    }
}

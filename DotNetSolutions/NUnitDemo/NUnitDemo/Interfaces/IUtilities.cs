namespace NUnitDemo.Interfaces
{
    public interface IUtilities
    {
        /// <summary>
        /// Gives the larger one among the two numbers.
        /// </summary>
        /// <param name="num1">First whole number</param>
        /// <param name="num2">Second whole number</param>
        /// <returns>the largest one.</returns>
        int GetGreater(int num1, int num2);
    }
}

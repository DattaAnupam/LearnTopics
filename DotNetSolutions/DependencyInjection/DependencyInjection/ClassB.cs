using static DependencyInjection.ClassA;

namespace DependencyInjection
{
    public class ClassB
    {
        public void UsePrintDeligate(PrintDeligate printDeligate)
        {
            Console.WriteLine("This method uses deligate passed through the arugument");

            printDeligate();
        }

        public void UseGetIDDeligate(GetIDDeligate getIDDeligate) {

            Console.WriteLine("This method uses get ID deligate passed through the arugument");

            getIDDeligate();
        }
    }
}

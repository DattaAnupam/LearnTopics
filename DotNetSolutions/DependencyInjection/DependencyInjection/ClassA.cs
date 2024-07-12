namespace DependencyInjection
{
    public class ClassA
    {
        public delegate void PrintDeligate();
        public delegate string GetIDDeligate();

        public void PrintID()
        {
            Console.WriteLine($"New ID : {Guid.NewGuid()}");
        }

        public string GetID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}

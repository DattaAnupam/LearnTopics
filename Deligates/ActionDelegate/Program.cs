static void Greet(string name) => Console.WriteLine($"Hello {name}!!!");

#region Simple Action delegate
Action<string> greetAction = Greet;

greetAction("Anupam");
#endregion

#region Action with Lamda Function
Action<int, int> PrintTwoNumber = (int num1, int num2) =>
{
    Console.WriteLine($"Num1: {num1}");
    Console.WriteLine($"Num1: {num2}");
};

Console.WriteLine("Action with Lamda expression");
PrintTwoNumber(45, 30);
#endregion

static void Greet(string name) => Console.WriteLine($"Hello {name}!!!");

#region Simple Func delegate
Action<string> greetAction = Greet;

greetAction("Anupam");
#endregion


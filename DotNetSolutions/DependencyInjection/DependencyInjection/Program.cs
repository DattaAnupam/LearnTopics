List<int> integerList = new List<int>()
{
    1,2, 3, 4, 5, 6, 7, 8, 9, 10,
};

// Find all the number which are > 5

// Query Syntax
var numbers = from n in integerList where n > 5 select n;

foreach(var number in numbers)
{
    Console.WriteLine(number);
}

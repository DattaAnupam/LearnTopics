List<int> integerList = new List<int>()
{
    1,2, 3, 4, 5, 6, 7, 8, 9, 10,
};

// Method Syntax
var numbers_method = integerList.Where(n => n > 5).GroupBy(n => n%2 ==0);

foreach(IGrouping<bool, int> group in numbers_method)
{
    Console.WriteLine($"{group.Key} : {group.Count()}");
    foreach(int number in group)
    {
        Console.WriteLine(number);
    }
}


List<int> integerList = new List<int>()
{
    1,2, 3, 4, 5, 6, 7, 8, 9, 10,
};

// Find all the number which are > 5
// Query Syntax
var numbers_query = from n in integerList where n > 5 select n;
foreach (var number in numbers_query)
{
    Console.Write(number);
}
Console.WriteLine();


// Method Syntax
var numbers_method = integerList.Where(n => n > 5).AsQueryable();

foreach(var number in numbers_method)
{
    Console.Write(number);
}

// Mixed Syntax = Query Syntax + Fluent/Method Syntax
// Query: Find the some of numbers > 5 in the above list
var sum = (from n in integerList where n > 5 select n).Sum();
Console.WriteLine($"\nSum: {sum}");

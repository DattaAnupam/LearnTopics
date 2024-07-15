using DependencyInjection;

// Get all the students
// Find the average of Their age
Students students = new Students();

var ageAverage = students.GetStudents().Average(s => s.Age);

Console.WriteLine($"Average Age: {ageAverage}");


Console.ReadKey();

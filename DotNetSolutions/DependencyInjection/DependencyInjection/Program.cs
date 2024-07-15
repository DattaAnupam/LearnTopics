using DependencyInjection;
using DependencyInjection.Models;


// Get all the students
// group them by their cities
Students students = new Students();
IEnumerable<IGrouping<string, Student>> studentGroups = students.GetStudents().GroupBy(s => s.City);

// Print students based on their group
foreach(IGrouping<string, Student> group in studentGroups)
{
    // Display each city
    Console.WriteLine($"City: {group.Key}");

    // show studets of above group
    foreach(Student student in group)
    {
        Console.WriteLine($"ID: {student.ID}, Name: {student.StudentName}, Age: {student.Age}, City: {student.City}");
    }
}

Console.ReadKey();

using DependencyInjection;
using DependencyInjection.Models;

// Print the details of Eldest Student
Students students = new Students();

int maxAge = students.GetStudents().Max(s => s.Age);
Student eldestStudent = students.GetStudents().Where(s => s.Age == maxAge).FirstOrDefault();

students.PrintStudent(eldestStudent);

// Print the details of Youngest Student
// if found more than one, then print the first one
int minAge = students.GetStudents().Min<Student>(s => s.Age);
Student youngestStudent = students.GetStudents().Where<Student>(s => s.Age == minAge).First();

students.PrintStudent(youngestStudent);

Console.ReadKey();

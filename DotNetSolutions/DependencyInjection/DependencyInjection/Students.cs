using DependencyInjection.Models;

namespace DependencyInjection
{
    public class Students
    {
        public IList<Student> GetStudents()
        {
            IList<Student> students = new List<Student>()
            {
                new Student() {ID = 1, Age = 18, City = "Siliguri", StudentName = "First Student",},
                new Student() {ID = 2, Age = 19, City = "Jalpaiguri", StudentName = "Second Student",},
                new Student() {ID = 3, Age = 18, City = "Coochbihar", StudentName = "Third Student",},
                new Student() {ID = 4, Age = 17, City = "Siliguri", StudentName = "Fourth Student",},
                new Student() {ID = 5, Age = 19, City = "Jalpaiguri", StudentName = "Fifth Student",},
                new Student() {ID = 6, Age = 18, City = "Alipurduar", StudentName = "Sixth Student",},
            };

            return students;
        }
    }
}

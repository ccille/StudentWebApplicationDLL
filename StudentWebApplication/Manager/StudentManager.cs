using StudentLibrary;

namespace StudentWebApplication.Manager
{
    public class StudentManager :IStudent
    {
        private static List<Student> liste = new List<Student>()
        {
            new Student("cecilie", "zealand"),
            new Student("Olga", "zealand næstved")
        };

        public Student Create(Student newstudent)
        {
            liste.Add(newstudent);
            return newstudent;
        }

        public List<Student> GetAll()
        {
            return liste;
        }
    }
}

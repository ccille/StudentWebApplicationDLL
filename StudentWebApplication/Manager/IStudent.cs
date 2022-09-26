using StudentLibrary;

namespace StudentWebApplication.Manager
{
    public interface IStudent
    {
        Student Create(Student newstudent);

        List<Student> GetAll();
    }
}

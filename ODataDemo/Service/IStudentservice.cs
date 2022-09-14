using ODataDemo.Model;

namespace ODataDemo.Service
{
    public interface IStudentService
    {
        IQueryable<student> RetrieveAllStudents();
    }
}

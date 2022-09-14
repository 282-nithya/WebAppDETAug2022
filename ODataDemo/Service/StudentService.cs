using ODataDemo.Model;
using ODataDemo.Model;

namespace ODataDemo.Service
{
    public class StudentService : IStudentService
    {
        public IQueryable<student> RetrieveAllStudents()
        {
            return new List<student>
            {
                new student
                {
                    Id = Guid.NewGuid(),
                    Name = "cherry",
                    score = 200,
                },
                 new student
                {
                    Id = Guid.NewGuid(),
                    Name = "moni",
                    score = 160,
                },
                new student
                {
                    Id = Guid.NewGuid(),
                    Name = "chintu",
                    score = 170,
                },
            }.AsQueryable();
        }
    }
}

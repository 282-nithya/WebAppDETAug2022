using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ODataDemo.Model;
using ODataDemo.Service;

namespace ODataDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public  StudentController(IStudentService studentService) =>
            this.studentService = studentService;
        [HttpGet]

        public ActionResult<IQueryable<student>> GetAllStudents()
        {
            IQueryable<student> retrievedStudents = 
                this.studentService.RetrieveAllStudents();

            return Ok(retrievedStudents);
        }
    }
}

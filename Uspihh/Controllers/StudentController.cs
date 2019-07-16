using System.Web.Http;
using Uspihh.Models.DTOModels;
using Uspihh.Models.EntityModels;
using Uspihh.Models.Mappers;
using Uspihh.Services.Services;

namespace Uspihh.Controllers
{
    [Authorize]
    public class StudentController : ApiController
    {
        private readonly IStudentService studentService;
        private readonly IMapper<StudentEntity, StudentDTO> studentMapper;

        public StudentController(IStudentService studentService,
            IMapper<StudentEntity, StudentDTO> studentMapper)
        {
            this.studentService = studentService;
            this.studentMapper = studentMapper;
        }

        public IHttpActionResult CreateStudent([FromBody]StudentDTO student)
        {
            var studentEntity = studentMapper.Map(student);
            studentService.CreateStudent(studentEntity);
            return Ok();
        }

        public IHttpActionResult GetStudentById([FromUri]long studentId)
        {
            var student = studentService.GetStudentById(studentId);
            var studentDTO = studentMapper.Map(student);
            return Ok(studentDTO);
        }
    }
}

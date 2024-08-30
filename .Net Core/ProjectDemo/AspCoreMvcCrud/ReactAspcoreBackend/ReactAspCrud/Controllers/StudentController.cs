using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactAspCrud.Models;

namespace ReactAspCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
      private readonly StudentDbContext _context;

        public StudentController(StudentDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetStudent")]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        [HttpPost]
        [Route("AddStudent")]
        public async Task<Student> AddStudent(Student objStudent)
        {
            _context.Students.Add(objStudent);//adding REcord in db
            await _context.SaveChangesAsync();  //saving that data in db
            return objStudent;
        }
        [HttpPatch]
        [Route("UpdateStudent/{id}")]

        public async Task<Student> UpdateStudent(Student objStudent)
        {
            _context.Entry(objStudent).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return objStudent;
        }
        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public bool DeleteStudent(int id)
        {
            bool a = false;
            var student = _context.Students.Find(id);
            if (student != null)
            {
                a = true;
                _context.Entry(student).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            else
            {
                a=false;
            }
            return a;
        }
    }
}

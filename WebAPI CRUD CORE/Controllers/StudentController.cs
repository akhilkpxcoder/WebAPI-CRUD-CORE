using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_CRUD_CORE.Models;

namespace WebAPI_CRUD_CORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentContext _dbContext;

        public StudentController(StudentContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudent()
        {
            if(_dbContext.Students == null) 
            { 
                return NotFound();
            }
            return await _dbContext.Students.ToListAsync();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudent(int id)
        {
            if (_dbContext.Students == null)
            {
                return NotFound();
            }
            return await _dbContext.Students.ToListAsync();
        }
    }
}

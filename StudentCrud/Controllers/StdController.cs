using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentCrud.Models;

namespace StudentCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StdController : ControllerBase
    {
        private readonly MydbContext context;

        public StdController(MydbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var data = await context.Students.ToListAsync();
            return Ok(data);
        }
    }
}

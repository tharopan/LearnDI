using LearnDI.Services.Employee;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LearnDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(
            IEmployeeService employeeService
            )
        {
            this._employeeService = employeeService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            return await _employeeService.GetAsync(id);
        }
    }
}

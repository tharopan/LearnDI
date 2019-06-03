using System.Threading.Tasks;

namespace LearnDI.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        public async Task<string> GetAsync(int id)
        {
            return $"Employee {id}";
        }
    }
}

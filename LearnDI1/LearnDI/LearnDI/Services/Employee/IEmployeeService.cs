using System.Threading.Tasks;

namespace LearnDI.Services.Employee
{
    public interface IEmployeeService
    {
        Task<string> GetAsync(int id);
    }
}

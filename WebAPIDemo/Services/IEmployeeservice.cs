using WebAPIDemo.Model;

namespace WebAPIDemo.Services
{
    public interface IEmployeeservice
    {
        IEnumerable<Employee> GetAll();

        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employee);

        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int id);
    }
}

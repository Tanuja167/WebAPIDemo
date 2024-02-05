using WebAPIDemo.Model;

namespace WebAPIDemo.Repository
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> GetAll();

        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employee);

        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int id);
    }
}

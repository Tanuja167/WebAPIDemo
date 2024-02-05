using WebAPIDemo.Model;
using WebAPIDemo.Repository;

namespace WebAPIDemo.Services
{
    public class EmployeeService : IEmployeeservice
    {
        private readonly IEmployeeRepo repo;

        public EmployeeService(IEmployeeRepo repo)
        {
            this.repo = repo;
        }

        public int AddEmployee(Employee employee)
        {
            return repo.AddEmployee(employee);
        }

        public int DeleteEmployee(int id)
        {
            return repo.DeleteEmployee(id);
        }

        public IEnumerable<Employee> GetAll()
        {
           return repo.GetAll();
        }

        public Employee GetEmployeeById(int id)
        {
            return repo.GetEmployeeById(id);
        }

        public int UpdateEmployee(Employee employee)
        {
            return repo.UpdateEmployee(employee);   
        }
    }
}

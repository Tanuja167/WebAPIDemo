using WebAPIDemo.Data;
using WebAPIDemo.Model;

namespace WebAPIDemo.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly ApplicationDbContext db;

        public EmployeeRepo(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddEmployee(Employee employee)
        {
          db.Add(employee);
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int id)
        {
            int res = 0;
            var result = db.emp.Where(x => x.Id == id).FirstOrDefault();
            if(result != null)
            {
                db.emp.Remove(result);
                res = db.SaveChanges();
            }
            return res;

        }

        public IEnumerable<Employee> GetAll()
        {
           var result = db.emp.ToList();
            return result;
        }

        public Employee GetEmployeeById(int id)
        {
            var result = db.emp.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }

        public int UpdateEmployee(Employee employee)
        {
            int result = 0;
            var res = db.emp.Where(x => x.Id ==  employee.Id).FirstOrDefault();
            if(res != null)
            {
                res.Name = employee.Name;
                res.Department = employee.Department;
                res.Salary = employee.Salary;
                result = db.SaveChanges();
            }
            return result;
        }
    }
}

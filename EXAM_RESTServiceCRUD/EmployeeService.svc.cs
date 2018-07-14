using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EXAM_RESTServiceCRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        static IEmployeeRepository repository = new EmployeeRepository();

        public string AddEmployee(Employee employee, string id)
        {
            Employee newEmployee = repository.AddNewEmployee(employee);
            return "id=" + newEmployee.EmployeeId;
        }

        public void DoWork()
        {
        }

        public Employee GetEmployeeByDepartment(string department)
        {
            return repository.GetEmployeeByDepartment(department);
        }

        public List<Employee> GetEmployeeList()
        {
            return repository.GetAllEmployee();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EXAM_RESTServiceCRUD
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmployeeId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal Salary { get; set; }

        [DataMember]
        public string Department { get; set; }
    }

    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployee();
        Employee GetEmployeeByDepartment(string department);
        Employee AddNewEmployee(Employee item);
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();
        private int counter = 1;

        public EmployeeRepository()
        {
            AddNewEmployee(new Employee { EmployeeId = 1, Name = "Hung", Salary = 100000000, Department = "kinhdoanh"});
            AddNewEmployee(new Employee { EmployeeId = 2, Name = "Tung", Salary = 100000000, Department = "laptrinh"});
            AddNewEmployee(new Employee { EmployeeId = 3, Name = "Danh", Salary = 100000000, Department = "ketoan"});

        }

        public Employee AddNewEmployee(Employee newEmployee)
        {
            if (newEmployee == null)
                throw new ArgumentNullException("newEmployee");
            newEmployee.EmployeeId = counter++;
            employees.Add(newEmployee);
            return newEmployee;
        }

        public List<Employee> GetAllEmployee()
        {
            return employees;
        }

        public Employee GetEmployeeByDepartment(string department)
        {
            return employees.Find(b => b.Department == department);
        }
    }
}
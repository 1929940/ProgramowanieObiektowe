using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Models
{
    public class EmployeesFactory
    {
        public static Employee CreateEmployee(string firstName, string lastName) => new Employee(firstName, lastName);
        public static Employees CreateEmployees(List<Employee> employeesArg)
        {
            Employees employees = new Employees();
            employeesArg.ForEach(x => employees.AddEmployee(x));
            return employees;
        } 
    }
}

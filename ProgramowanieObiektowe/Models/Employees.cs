using System.Collections.Generic;
using System.Linq;

namespace ProgramowanieObiektowe.Models
{
    public class Employees
    {
        private List<Employee> EmployeesList { get; set; }

        public Employee this[int i]
        {
            get => EmployeesList[i];
            set => EmployeesList[i] = value;
        }

        public Employee this[string firstName, string lastName] => EmployeesList.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

        public void AddEmployee(Employee employee)
        {
            if (!EmployeesList.Contains(employee))
                EmployeesList.Add(employee);
        }
        public void RemoveEmployee(Employee employee) => EmployeesList.Remove(employee); //Walidacja juz jest zaimplementowana w metodzie Remove, jak obiekt nie istnieje, to go nie usunie
    }
}


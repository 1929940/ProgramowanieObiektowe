using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Models
{
    public class Employee : Person
    {
        public List<Operation> Operations { get; set; }
        public ContractType Contract { get; set; }
        public decimal Salary { get; set; }

        public Employee(string firstName, string lastName) : base(firstName, lastName) 
            => Operations = new List<Operation>();

        public void PrintOperations() => Operations.ForEach(x => Console.WriteLine(x));
        public void AddOperation(decimal value) => 
            Operations.Add(new Operation() { Value = value, Date = DateTime.Now });
        public decimal GetOperationSum() => Operations.Sum(x => x.Value);
        public IEnumerable<Operation> GetOperations(DateTime from, DateTime to) 
            => Operations.Where(x => x.Date >= from && x.Date <= to);

        public Operation this[int i]
        {
            get => Operations[i]; 
            set => Operations[i] = value; 
        }

        public static bool operator >(Employee one, Employee two) => one.Salary > two.Salary;
        public static bool operator <(Employee one, Employee two) => one.Salary < two.Salary;

        public static decimal operator +(Employee employee, decimal value) => employee.Salary + value;

        //Zglupialem tutaj...

        public delegate void PrintMsg(Employee employee);

        public void ChangeNameWithDelegate(string firstName, string lastName, PrintMsg generateMessage)
        {
            FirstName = firstName;
            LastName = LastName;
            generateMessage(this);
        }

        public Func<Employee, string> OnNameChanged { get; set; }

        public void ChangeNameWithEvent(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine(OnNameChanged?.Invoke(this));
        }
    }
}
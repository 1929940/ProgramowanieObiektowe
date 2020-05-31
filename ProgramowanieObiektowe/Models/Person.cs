
namespace ProgramowanieObiektowe.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString() => string.Format("{0} {1}", FirstName, LastName);
    }
}

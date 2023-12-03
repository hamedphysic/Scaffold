namespace Scaffold.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullInfo { get { return $"{FirstName},{LastName}"; } }

    }
}

namespace MarwinTask.Core.Entities
{
    public class Company
    {
        public string Iin { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
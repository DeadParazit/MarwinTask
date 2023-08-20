using MarwinTask.Core.Entities;

namespace MarwinTask.Service.DTO
{
    public class EmployeeDTO
    {
        public string Iin { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }

        public string CompanyIin { get; set; }
    }
}

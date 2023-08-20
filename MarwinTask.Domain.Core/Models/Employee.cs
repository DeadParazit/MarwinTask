using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwinTask.Core.Entities
{
    public class Employee
    {
        public string Iin { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }

        public string CompanyIin { get; set; }
        public Company Company { get; set; }
    }
}

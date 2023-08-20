using MarwinTask.Core.Entities;
using MarwinTask.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwinTask.Service.Extensions
{
    public static class EmployeeExtensions
    {
        public static List<Employee> ConvertToEmployee(this List<EmployeeDTO> employeesDto)
        {
            return employeesDto.Select(s => new Employee
            {
                Iin = s.Iin,
                Surname = s.Surname,
                Firstname = s.Firstname, 
                Lastname = s.Lastname,
                CompanyIin = s.CompanyIin
            }).ToList();
        }

        public static List<EmployeeDTO> ConvertToEmployeeDTO(this List<Employee> employees)
        {
            return employees.Select(s => new EmployeeDTO
            {
                Iin = s.Iin,
                Surname = s.Surname,
                Firstname = s.Firstname,
                Lastname = s.Lastname,
                CompanyIin = s.CompanyIin
            }).ToList();
        }
    }
}

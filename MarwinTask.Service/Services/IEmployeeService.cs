using MarwinTask.Core.Entities;
using MarwinTask.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwinTask.Service.Services
{
    public interface IEmployeeService
    {
        public Task UpdateEmployees(List<EmployeeDTO> employeeDTOs);
        public Task<List<EmployeeDTO>> GetEmployees();
    }
}

using MarwinTask.Repository.Repositories;
using MarwinTask.Service.DTO;
using MarwinTask.Service.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwinTask.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<EmployeeDTO>> GetEmployees()
        {
            var eployeeDTOs = await _employeeRepository.GetEmployees();
            return eployeeDTOs.ConvertToEmployeeDTO();
        }

        public async Task UpdateEmployees(List<EmployeeDTO> employeesToUpdate) => await _employeeRepository.UpdateEmployeesAsync(employeesToUpdate.ConvertToEmployee());
    }
}

using MarwinTask.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwinTask.Repository.Repositories
{
    public interface IEmployeeRepository
    {
        Task UpdateEmployeesAsync(List<Employee> employeesToUpdate);
        Task<List<Employee>> GetEmployees();
    }
}

using MarwinTask.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwinTask.Repository.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MarwinDbContext _context;

        public EmployeeRepository(MarwinDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task UpdateEmployeesAsync(List<Employee> employeesToUpdate)
        {
            var currentEmployees = _context.Employees.ToList();

            foreach (var employee in currentEmployees)
            {
                var sameEmployee = employeesToUpdate.FirstOrDefault(e => e.Iin == employee.Iin);

                if (sameEmployee is not null)
                {
                    _context.Entry(sameEmployee).CurrentValues.SetValues(employee);

                    employeesToUpdate.Remove(sameEmployee);
                }
                else
                {
                    _context.Remove(employee);
                }
            }

            await _context.AddRangeAsync(employeesToUpdate);

            await _context.SaveChangesAsync();
        }
    }
}

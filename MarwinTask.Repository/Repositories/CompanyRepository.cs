using MarwinTask.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwinTask.Repository.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly MarwinDbContext _context;

        public CompanyRepository(MarwinDbContext context)
        {
            _context = context;
        }

        public async Task<List<Company>> GetCompanyListAsync() => await _context.Companies.Include(c => c.Employees).ToListAsync();
    }
}

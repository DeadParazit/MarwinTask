using MarwinTask.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwinTask.Repository.Repositories
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetCompanyListAsync();
    }
}

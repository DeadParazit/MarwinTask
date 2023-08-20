using MarwinTask.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwinTask.Service.Services
{
    public interface ICompanyService
    {
        public Task<List<Company>> GetCompanies();
    }
}

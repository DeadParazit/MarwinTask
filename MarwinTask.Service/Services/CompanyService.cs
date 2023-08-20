using MarwinTask.Core.Entities;
using MarwinTask.Repository.Repositories;

namespace MarwinTask.Service.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _repository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _repository = companyRepository;
        }

        public async Task<List<Company>> GetCompanies() => await _repository.GetCompanyListAsync();
    }
}
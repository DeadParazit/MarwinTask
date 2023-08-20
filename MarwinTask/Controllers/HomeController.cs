using CsvHelper;
using CsvHelper.Configuration;
using MarwinTask.Core.Entities;
using MarwinTask.Models;
using MarwinTask.Service.DTO;
using MarwinTask.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Globalization;

namespace MarwinTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICompanyService _companyService;
        private readonly IEmployeeService _employeeService;

        public HomeController(ILogger<HomeController> logger,
            ICompanyService companyService,
            IEmployeeService employeeService)
        {
            _logger = logger;
            _companyService = companyService;
            _employeeService = employeeService;
        }

        public async Task<IActionResult> Index()
        {
            var companyViewModel = new CompanyViewModel();
            companyViewModel.Companies = await _companyService.GetCompanies();

            return View(companyViewModel);
        }

        public async Task<IActionResult> Import(IFormFile file)
        {
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    var records = csv.GetRecords<EmployeeDTO>().ToList();

                    await _employeeService.UpdateEmployees(records);
                }
            }

            return RedirectToAction(actionName: "Index");
        }

        [HttpGet]
        public async Task<IActionResult> Export()
        {
            var employees = await _employeeService.GetEmployees();

            var stream = new MemoryStream();
            using (var writeFile = new StreamWriter(stream, leaveOpen: true))
            {
                using (var csv = new CsvWriter(writeFile, CultureInfo.InvariantCulture, true))
                {                
                    csv.WriteRecords(employees);
                }
                    
            }
            stream.Position = 0; //reset stream
            return File(stream, "application/octet-stream", "Employees.csv");
        }
    }
}
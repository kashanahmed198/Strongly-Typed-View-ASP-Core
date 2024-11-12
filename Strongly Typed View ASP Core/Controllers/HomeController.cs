using Microsoft.AspNetCore.Mvc;
using Strongly_Typed_View_ASP_Core.Models;
using System.Diagnostics;

namespace Strongly_Typed_View_ASP_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Employee obj = new Employee()
            //{
            //    EmpID = 101,
            //    EmpName = "Affan",
            //    Designation = "Manaaer",
            //    Salary = 55000,
            //};

            var myEmployees = new List<Employee>
            {
                new Employee { EmpId = 101, EmpName = "Kashan", Designation = "Developer", Salary = 50000},
                new Employee { EmpId = 102, EmpName = "Ahmed", Designation = "Developer", Salary = 40000},
                new Employee { EmpId = 103, EmpName = "Ahtasham", Designation = "Developer", Salary = 55000},
                new Employee { EmpId = 104, EmpName = "Umair", Designation = "Developer", Salary = 35000},
                new Employee { EmpId = 105, EmpName = "Noman", Designation = "Developer", Salary = 45000}
            };
            return View(myEmployees);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

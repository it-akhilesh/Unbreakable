using Microsoft.AspNetCore.Mvc;
using Unbreakable.Data;
using Unbreakable.Models;

namespace Unbreakable.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
                
        }
        public IActionResult Index()
        {
            List<Employee> objEmployeelist = _db.employees.ToList();
            return View(objEmployeelist);
        }
    }
}
